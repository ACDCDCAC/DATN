

#include "stm32f1_rc522_spi2.h"

/*
 * Ten ham:Write_MFRC5200
 * Chuc nang: wait 1 byte is stored in register MFRC522
 * Input:addr-> I just wrote down, val-> Value to record
 * Check: No
 */
uint8_t RC522_SPI_Transfer_2(uint8_t data)
{
	uint8_t rx_data;
	HAL_SPI_TransmitReceive(&hspi2,&data,&rx_data,1,100);
	
	/*while(SPI_I2S_GetFlagStatus(MFRC522_SPI, SPI_I2S_FLAG_TXE)==RESET);
	SPI_I2S_SendData(MFRC522_SPI,data);

	while(SPI_I2S_GetFlagStatus(MFRC522_SPI, SPI_I2S_FLAG_RXNE)==RESET);
	return SPI_I2S_ReceiveData(MFRC522_SPI);*/
	return rx_data;
}

/*
 * Ten ham:Write_MFRC5200
 * Note: wait 1 byte is stored in register MFRC522
 * Input: addr-> DIa write only, val-> Value to write
 * Check: No
 */
void Write_MFRC522_2(uint8_t addr, uint8_t val)
{
	/* CS LOW */
	//GPIO_ResetBits(MFRC522_CS_GPIO, MFRC522_CS_PIN);
  HAL_GPIO_WritePin(GPIOB,GPIO_PIN_12,GPIO_PIN_RESET);
	//The address is located:0XXXXXX0
	RC522_SPI_Transfer_2((addr<<1)&0x7E);	
	RC522_SPI_Transfer_2(val);
	
	/* CS HIGH */
	//GPIO_SetBits(MFRC522_CS_GPIO, MFRC522_CS_PIN);
	HAL_GPIO_WritePin(GPIOB,GPIO_PIN_12,GPIO_PIN_SET);
}


/*
 * Ten ham:Read_MFRC522_2
 * Note: A 1-byte doc is stored from a register MFRC522
 * Input: addr-> address doc
 * Look up: Value in the read register
 */
uint8_t Read_MFRC522_2(uint8_t addr)
{
	uint8_t val;

	/* CS LOW */
	//GPIO_ResetBits(MFRC522_CS_GPIO, MFRC522_CS_PIN);
	HAL_GPIO_WritePin(GPIOB,GPIO_PIN_12,GPIO_PIN_RESET);

	//The address is located:1XXXXXX0
	RC522_SPI_Transfer_2(((addr<<1)&0x7E) | 0x80);	
	val = RC522_SPI_Transfer_2(0x00);
	
	/* CS HIGH */
	//GPIO_SetBits(MFRC522_CS_GPIO, MFRC522_CS_PIN);
	HAL_GPIO_WritePin(GPIOB,GPIO_PIN_12,GPIO_PIN_SET);
	return val;	
	
}


/*
 * Ten ham:SetBitMask_2
 * Note: Set bits in an MFRC522 register
 * Input: reg - Registers settings; mask - value set
 * Check: No
 */
void SetBitMask_2(uint8_t reg, uint8_t mask)  
{
    uint8_t tmp;
    tmp = Read_MFRC522_2(reg);
    Write_MFRC522_2(reg, tmp | mask);  // set bit mask
}


/*
 * Ten ham:ClearBitMask_2
 * Note: Reset bit in register MFRC522
 * Input: reg - Dia register; mask - Value bit can clear
 * Check: No
 */
void ClearBitMask_2(uint8_t reg, uint8_t mask)  
{
    uint8_t tmp;
    tmp = Read_MFRC522_2(reg);
    Write_MFRC522_2(reg, tmp & (~mask));  // clear bit mask
} 


/*
 * Ten Ham:AntennaOn_2
 * Chuc Nang: Mo antenna, should have at least 1 ms
 * Input: no
 * Check: no
 */
void AntennaOn_2(void)
{
	

Read_MFRC522_2(TxControlReg);
//	if (!(temp & 0x03))
//	{
//		SetBitMask_2(TxControlReg, 0x03);
//	}
	SetBitMask_2(TxControlReg, 0x03);
}


/*
 * Ten ham:AntennaOff_2
 * Dong Anten, should have at least 1 ms
 * Input: no
 * Check: no
 */
void AntennaOff_2(void)
{
	ClearBitMask_2(TxControlReg, 0x03);
}


/*
 * Ten ham:ResetMFRC522
 * Look: Restart RC522
 * Input: No.
 * Return: No.
 */
void MFRC522_Reset_2(void)
{
    Write_MFRC522_2(CommandReg, PCD_RESETPHASE);
}

/*
 * Ten ham:MFRC522_SPI_Init
 * Wish: Start SPI
 * Input: No.
 * Tra va: No.
 */
/*void MFRC522_SPI_Init(void)
{
	GPIO_InitTypeDef GPIO_InitStruct;
	SPI_InitTypeDef SPI_InitStruct;
	
	RCC_APB2PeriphClockCmd(MFRC522_SPI_GPIO_RCC | RCC_APB2Periph_AFIO,ENABLE);		// Enable clock GPIO
	
	if(MFRC522_SPI==SPI1)
	{
		RCC_APB2PeriphClockCmd(MFRC522_SPI_RCC,ENABLE);																// Enable clock SPI1
	}
	else
	{
		RCC_APB1PeriphClockCmd(MFRC522_SPI_RCC,ENABLE);																// Enable clock SPI2 or SPI3
	}
	
	GPIO_InitStruct.GPIO_Pin = MFRC522_SCK_PIN | MFRC522_MISO_PIN | MFRC522_MOSI_PIN;	// SCK, MISO, MOSI
	GPIO_InitStruct.GPIO_Mode = GPIO_Mode_AF_PP;
	GPIO_InitStruct.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(MFRC522_SPI_GPIO, &GPIO_InitStruct);																	// init GPIO SPI

	SPI_InitStruct.SPI_BaudRatePrescaler = SPI_BaudRatePrescaler_8;
	SPI_InitStruct.SPI_Direction= SPI_Direction_2Lines_FullDuplex;
	SPI_InitStruct.SPI_Mode = SPI_Mode_Master;
	SPI_InitStruct.SPI_DataSize = SPI_DataSize_8b;
	SPI_InitStruct.SPI_CPOL = SPI_CPOL_Low;
	SPI_InitStruct.SPI_CPHA = SPI_CPHA_1Edge;
	SPI_InitStruct.SPI_NSS = SPI_NSS_Soft;
	SPI_InitStruct.SPI_FirstBit = SPI_FirstBit_MSB;
	SPI_InitStruct.SPI_CRCPolynomial = 7;
	SPI_Init(MFRC522_SPI, &SPI_InitStruct);

	SPI_Cmd(MFRC522_SPI, ENABLE);
}
*/
/*
 * Ten ham:InitMFRC522
 * Start RC522
 * Input:  No.
 * Look up:  No.
 */
void MFRC522_Init_2(void)
{

	//GPIO_SetBits(MFRC522_CS_GPIO,MFRC522_CS_PIN);						// Activate the RFID reader
	HAL_GPIO_WritePin(GPIOB,GPIO_PIN_12,GPIO_PIN_SET);
	//HAL_GPIO_WritePin(GPIOB,GPIO_PIN_0,GPIO_PIN_SET);
	//GPIO_SetBits(MFRC522_RST_GPIO,MFRC522_RST_PIN);					// not reset

		// spi config
	//MFRC522_SPI_Init();
	
	MFRC522_Reset_2();
	 	
	//Timer: TPrescaler*TreloadVal/6.78MHz = 24ms
	Write_MFRC522_2(TModeReg, 0x8D);		//auto=1; f(Timer) = 6.78MHz/TPreScaler
	Write_MFRC522_2(TPrescalerReg, 0x3E);	//TModeReg[3..0] + TPrescalerReg
	Write_MFRC522_2(TReloadRegL, 30);           
	Write_MFRC522_2(TReloadRegH, 0);
	
	Write_MFRC522_2(TxAutoReg, 0x40);		//100%ASK
	Write_MFRC522_2(ModeReg, 0x3D);		//CRC Original value 0x6363	???

	//ClearBitMask_2(Status2Reg, 0x08);		//MFCrypto1On=0
	//Write_MFRC522_2(RxSelReg, 0x86);		//RxWait = RxSelReg[5..0]
	//Write_MFRC522_2(RFCfgReg, 0x7F);   		//RxGain = 48dB

	AntennaOn_2();		//Mo Anten
}

/*
 * Ten ham:MFRC522_ToCard_2
 * Highlights: information between RC522 and ISO14443
 * Input: command - send to MF522,
 *			 sendData - Remittance sent to the state MFRC522, 
 *			 sendLen - Send the message number
 *			 backData - BackData is returned
 *			 backLen - Retrieve the data number
 * Check: CARD_VALID if successful
 */
uint8_t MFRC522_ToCard_2(uint8_t command, uint8_t *sendData, uint8_t sendLen, uint8_t *backData, uint *backLen)
{
    uint8_t status = ERR0R_DETECT;
    uint8_t irqEn = 0x00;
    uint8_t waitIRq = 0x00;
    uint8_t lastBits;
    uint8_t n;
    uint i;

    switch (command)
    {
        case PCD_AUTHENT:		//Acknowledging the liver
		{
			irqEn = 0x12;
			waitIRq = 0x10;
			break;
		}
		case PCD_TRANSCEIVE:	// FIFO data collection
		{
			irqEn = 0x77;
			waitIRq = 0x30;
			break;
		}
		default:
			break;
    }
   
    Write_MFRC522_2(CommIEnReg, irqEn|0x80);	//Yeu cau ngat
    ClearBitMask_2(CommIrqReg, 0x80);			//Clear all the bits
    SetBitMask_2(FIFOLevelReg, 0x80);			//FlushBuffer=1, FIFO
    
	Write_MFRC522_2(CommandReg, PCD_IDLE);	//NO action; Huy bo lenh hien hanh	???

	// Record in FIFO
    for (i=0; i<sendLen; i++)
    {   
		Write_MFRC522_2(FIFODataReg, sendData[i]);    
	}

	//chay
	Write_MFRC522_2(CommandReg, command);
    if (command == PCD_TRANSCEIVE)
    {    
		SetBitMask_2(BitFramingReg, 0x80);		//StartSend=1,transmission of data starts  
	}   
    
	//The team is allowed to be stored
	i = 2000;	//i tuy thuoc tan so thach anh, thoi gian toi da cho the M1 la 25ms
    do 
    {
		//CommIrqReg[7..0]
		//Set1 TxIRq RxIRq IdleIRq HiAlerIRq LoAlertIRq ErrIRq TimerIRq
        n = Read_MFRC522_2(CommIrqReg);
        i--;
    }
    while ((i!=0) && !(n&0x01) && !(n&waitIRq));

    ClearBitMask_2(BitFramingReg, 0x80);			//StartSend=0
	
    if (i != 0)
    {    
        if(!(Read_MFRC522_2(ErrorReg) & 0x1B))	//BufferOvfl Collerr CRCErr ProtecolErr
        {
            status = CARD_VALID;
            if (n & irqEn & 0x01)
            {   
				status = NO_CARD_TAGERR;			//??   
			}

            if (command == PCD_TRANSCEIVE)
            {
               	n = Read_MFRC522_2(FIFOLevelReg);
              	lastBits = Read_MFRC522_2(ControlReg) & 0x07;
                if (lastBits)
                {   
					*backLen = (n-1)*8 + lastBits;   
				}
                else
                {   
					*backLen = n*8;   
				}

                if (n == 0)
                {   
					n = 1;    
				}
                if (n > MAX_LEN)
                {   
					n = MAX_LEN;   
				}
				
				//FIFO doc in the received data
                for (i=0; i<n; i++)
                {   
					backData[i] = Read_MFRC522_2(FIFODataReg);    
				}
            }
        }
        else
        {   
			status = ERR0R_DETECT;  
		}
        
    }
	
    //SetBitMask_2(ControlReg,0x80);           //timer stops
    //Write_MFRC522_2(CommandReg, PCD_IDLE); 

    return status;
}

/*
 * Ten ham:MFRC522_Request_2
 * Show it, read it
 * Input: reqMode - Phat is able,
 *			 TagType - Type of check
 *			 	0x4400 = Mifare_UltraLight
 *				0x0400 = Mifare_One(S50)
 *				0x0200 = Mifare_One(S70)
 *				0x0800 = Mifare_Pro(X)
 *				0x4403 = Mifare_DESFire
 * Return: CARD_VALID if the bar is curved
 */
uint8_t MFRC522_Request_2(uint8_t reqMode, uint8_t *TagType)
{
	uint8_t status;  
	uint backBits;			//The bits are manipulated

	Write_MFRC522_2(BitFramingReg, 0x07);		//TxLastBists = BitFramingReg[2..0]	???
	
	TagType[0] = reqMode;
	status = MFRC522_ToCard_2(PCD_TRANSCEIVE, TagType, 1, TagType, &backBits);

	if ((status != CARD_VALID) || (backBits != 0x10))
	{    
		status = ERR0R_DETECT;
	}
   
	return status;
}


/*
 * Ten ham:MFRC522_Anticoll_2
 * Detect the collision, select and read the serial number
 * Input: serNum - Look up the serial the 4 byte, byte 5 is the ma checksum
 * Check: CARD_VALID if successful
 */
uint8_t MFRC522_Anticoll_2(uint8_t *serNum)
{
    uint8_t status;
    uint8_t i;
	uint8_t serNumCheck=0;
    uint unLen;
    

    //ClearBitMask_2(Status2Reg, 0x08);		//TempSensclear
    //ClearBitMask_2(CollReg,0x80);			//ValuesAfterColl
	Write_MFRC522_2(BitFramingReg, 0x00);		//TxLastBists = BitFramingReg[2..0]
 
    serNum[0] = PICC_ANTICOLL;
    serNum[1] = 0x20;
    status = MFRC522_ToCard_2(PCD_TRANSCEIVE, serNum, 2, serNum, &unLen);

    if (status == CARD_VALID)
	{
		//Check the serial number
		for (i=0; i<4; i++)
		{   
		 	serNumCheck ^= serNum[i];
		}
		if (serNumCheck != serNum[i])
		{   
			status = ERR0R_DETECT;    
		}
    }

    //SetBitMask_2(CollReg, 0x80);		//ValuesAfterColl=1

    return status;
} 


/*
 * Ten Ham:CalulateCRC_2
 * MFRC522 is a formula of RC522
 * Input: pIndata - Data CRC into calculator, wool - Data data, pOutData - CRC calculation
 * Check: No
 */
void CalulateCRC_2(uint8_t *pIndata, uint8_t len, uint8_t *pOutData)
{
    uint8_t i, n;

    ClearBitMask_2(DivIrqReg, 0x04);			//CRCIrq = 0
    SetBitMask_2(FIFOLevelReg, 0x80);			//Con tro FIFO
    //Write_MFRC522_2(CommandReg, PCD_IDLE);

	//Record in FIFO
    for (i=0; i<len; i++)
    {   
		Write_MFRC522_2(FIFODataReg, *(pIndata+i));   
	}
    Write_MFRC522_2(CommandReg, PCD_CALCCRC);

	// Let the CRC computer complete
    i = 0xFF;
    do 
    {
        n = Read_MFRC522_2(DivIrqReg);
        i--;
    }
    while ((i!=0) && !(n&0x04));			//CRCIrq = 1

	//Doc results in CRC calculation
    pOutData[0] = Read_MFRC522_2(CRCResultRegL);
    pOutData[1] = Read_MFRC522_2(CRCResultRegM);
}


/*
 * Ten ham:MFRC522_SelectTag_2
 * read the right way
 * Input:serNum--So serial the
 * Check: Use the same amount of inspection
 */
uint8_t MFRC522_SelectTag_2(uint8_t *serNum)
{
	uint8_t i;
	uint8_t status;
	uint8_t size;
	uint recvBits;
	uint8_t buffer[9]; 

	//ClearBitMask_2(Status2Reg, 0x08);			//MFCrypto1On=0

    buffer[0] = PICC_SElECTTAG;
    buffer[1] = 0x70;
    for (i=0; i<5; i++)
    {
    	buffer[i+2] = *(serNum+i);
    }
	CalulateCRC_2(buffer, 7, &buffer[7]);		//??
    status = MFRC522_ToCard_2(PCD_TRANSCEIVE, buffer, 9, buffer, &recvBits);
    
    if ((status == CARD_VALID) && (recvBits == 0x18))
    {   
		size = buffer[0]; 
	}
    else
    {   
		size = 0;    
	}

    return size;
}


/*
 * Ten Ham:MFRC522_Auth_2
 * Identify the bad face
 * Input: authMode - Check your password
                 0x60 = Film confirmation A
                 0x61 = Film confirmation B
             BlockAddr - Addresses
             Sectorkey - The shadow area
             serNum - So serial the, 4 bytes
 * Check: CARD_VALID if successful
 */
uint8_t MFRC522_Auth_2(uint8_t authMode, uint8_t BlockAddr, uint8_t *Sectorkey, uint8_t *serNum)
{
    uint8_t status;
    uint recvBits;
    uint8_t i;
	uint8_t buff[12]; 

	//Confirmation + Address + password + quick number
    buff[0] = authMode;
    buff[1] = BlockAddr;
    for (i=0; i<6; i++)
    {    
		buff[i+2] = *(Sectorkey+i);   
	}
    for (i=0; i<4; i++)
    {    
		buff[i+8] = *(serNum+i);   
	}
    status = MFRC522_ToCard_2(PCD_AUTHENT, buff, 12, buff, &recvBits);

    if ((status != CARD_VALID) || (!(Read_MFRC522_2(Status2Reg) & 0x08)))
    {   
		status = ERR0R_DETECT;   
	}
    
    return status;
}


/*
 * Ten ham:MFRC522_Read_2
 * Doc with data
 * Input: blockAddr - Address location; recvData - Retrieve document output
 * Check: CARD_VALID if successful
 */
uint8_t MFRC522_Read_2(uint8_t blockAddr, uint8_t *recvData)
{
    uint8_t status;
    uint unLen;

    recvData[0] = PICC_READ;
    recvData[1] = blockAddr;
    CalulateCRC_2(recvData,2, &recvData[2]);
    status = MFRC522_ToCard_2(PCD_TRANSCEIVE, recvData, 4, recvData, &unLen);

    if ((status != CARD_VALID) || (unLen != 0x90))
    {
        status = ERR0R_DETECT;
    }
    
    return status;
}


/*
 * Ten ham:MFRC522_Write_2
 * wait repeats data
 * Input: blockAddr - locations; writeData - write data
 * Check: CARD_VALID if successful
 */
uint8_t MFRC522_Write_2(uint8_t blockAddr, uint8_t *writeData)
{
    uint8_t status;
    uint recvBits;
    uint8_t i;
	uint8_t buff[18]; 
    
    buff[0] = PICC_WRITE;
    buff[1] = blockAddr;
    CalulateCRC_2(buff, 2, &buff[2]);
    status = MFRC522_ToCard_2(PCD_TRANSCEIVE, buff, 4, buff, &recvBits);

    if ((status != CARD_VALID) || (recvBits != 4) || ((buff[0] & 0x0F) != 0x0A))
    {   
		status = ERR0R_DETECT;   
	}
        
    if (status == CARD_VALID)
    {
        for (i=0; i<16; i++)		//16 FIFO bytes recorded
        {    
        	buff[i] = *(writeData+i);   
        }
        CalulateCRC_2(buff, 16, &buff[16]);
        status = MFRC522_ToCard_2(PCD_TRANSCEIVE, buff, 18, buff, &recvBits);
        
		if ((status != CARD_VALID) || (recvBits != 4) || ((buff[0] & 0x0F) != 0x0A))
        {   
			status = ERR0R_DETECT;   
		}
    }
    
    return status;
}


/*
 * Ten ham:MFRC522_Halt_2
 * CHuc nang: Dua the vao ngu dong
 * Input: NO.
 * Look up: NO.
 */
void MFRC522_Halt_2(void)
{
	uint unLen;
	uint8_t buff[4]; 

	buff[0] = PICC_HALT;
	buff[1] = 0;
	CalulateCRC_2(buff, 2, &buff[2]);
 
	MFRC522_ToCard_2(PCD_TRANSCEIVE, buff, 4, buff,&unLen);
}
