/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2021 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under Ultimate Liberty license
  * SLA0044, the "License"; You may not use this file except in compliance with
  * the License. You may obtain a copy of the License at:
  *                             www.st.com/SLA0044
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "usb_device.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include "usbd_cdc_if.h"
#include "canbridge.h"
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */
typedef struct
{
	uint32_t mailbox;
	CAN_TxHeaderTypeDef hdr;
	uint8_t payload[8];
} CAN_TxPacketTypeDef;

typedef struct
{
	CAN_RxHeaderTypeDef hdr;
	uint8_t payload[8];
} CAN_RxPacketTypeDef;

/// CAN过滤器寄存器位宽类型定义
typedef union
{
    __IO uint32_t value;
    struct
    {
        uint8_t REV : 1;			///< [0]    ：未使用
        uint8_t RTR : 1;			///< [1]    : RTR（数据帧或远程帧标志位）
        uint8_t IDE : 1;			///< [2]    : IDE（标准帧或扩展帧标志位）
        uint32_t EXID : 18;			///< [21:3] : 存放扩展帧ID
        uint16_t STID : 11;			///< [31:22]: 存放标准帧ID
    } Sub;
} CAN_FilterRegTypeDef;

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
#define CAN_BASE_ID 0						///< CAN标准ID，最�?11位，也就�?0x7FF
#define CAN_FILTER_MODE_MASK_ENABLE 1		///< CAN过滤器模式�?�择�?=0：列表模�?  =1：屏蔽模�?
#define CAN_ID_TYPE_STD_ENABLE      1       ///< CAN过滤ID类型选择�?=1：标准ID�?=0：扩展ID
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
CAN_HandleTypeDef hcan;

/* USER CODE BEGIN PV */

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_CAN_Init(void);
/* USER CODE BEGIN PFP */
void CAN_Filter_Config(void);
uint8_t CAN_Transmit(CAN_TxPacketTypeDef* packet);
void HAL_CAN_RxFifo0MsgPendingCallback(CAN_HandleTypeDef *canHandle);

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */
  char buf[1024];
  CanBridge_Pkt_Response pktResponse;
  CanBridge_Pkt_Packet pktPacket;
  CanBridge_Pkt_Config pktConfig;
  CanBridge_Pkt_Config_Response pktConfigRsp;
  CanBridge_Pkt_Get_Can pktGetCan;
  CanBridge_Pkt_Get_Can_Response pktGetCanRsp;
  CanBridge_Pkt_Send_Packet pktSendPacket;

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_CAN_Init();
  MX_USB_DEVICE_Init();
  /* USER CODE BEGIN 2 */

  CAN_Filter_Config();
  HAL_CAN_Start(&hcan);
  HAL_CAN_ActivateNotification(&hcan, CAN_IT_RX_FIFO0_MSG_PENDING);					// 使能CAN接收中断

  pktPacket.can_idx = 0;
  pktPacket.header = CANBRIDGE_HEADER;
  pktPacket.pkt_type = CANBRIDGE_PKT_TYPE_PACKET;
  pktPacket.len = sizeof(pktPacket) - 3 ;
  pktPacket.hdr.StdId = 0x583;
  pktPacket.hdr.ExtId = 0x345;
  pktPacket.hdr.IDE = 1;
  pktPacket.hdr.RTR = 0;
  pktPacket.hdr.DLC = 8;
  pktPacket.hdr.FilterMatchIndex = 0;
  pktPacket.hdr.Timestamp = 0x234345;
  for (int i=0;i<8;i++) {
	  pktPacket.payload[i] = i;
  }
  CalcCRC16((unsigned char*)&pktPacket);

  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
    HAL_Delay(500);
    //sprintf(buf, "response=%d\tpacket=%d\tconfig=%d\tconfigresponse=%d\tgetcan=%d\tgetcanresponse=%d\tsendpacket=%d\r\nrx=%d\ttx=%d\r\n", sizeof(pktResponse), sizeof(pktPacket), sizeof(pktConfig), sizeof(pktConfigRsp), sizeof(pktGetCan), sizeof(pktGetCanRsp), sizeof(pktSendPacket), sizeof(CAN_RxHeaderTypeDef), sizeof(CAN_TxHeaderTypeDef));
    //CDC_Transmit_FS((uint8_t*)buf, strlen(buf));
    //pktPacket.hdr.StdId++;
    //CalcCRC16((unsigned char*)&pktPacket);
    //CDC_Transmit_FS((uint8_t*)&pktPacket, sizeof(pktPacket));
  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};
  RCC_PeriphCLKInitTypeDef PeriphClkInit = {0};

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.HSEPredivValue = RCC_HSE_PREDIV_DIV1;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLMUL = RCC_PLL_MUL9;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_2) != HAL_OK)
  {
    Error_Handler();
  }
  PeriphClkInit.PeriphClockSelection = RCC_PERIPHCLK_USB;
  PeriphClkInit.USBClockSelection = RCC_USBCLKSOURCE_PLL_DIV1_5;
  if (HAL_RCCEx_PeriphCLKConfig(&PeriphClkInit) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief CAN Initialization Function
  * @param None
  * @retval None
  */
static void MX_CAN_Init(void)
{

  /* USER CODE BEGIN CAN_Init 0 */

  /* USER CODE END CAN_Init 0 */

  /* USER CODE BEGIN CAN_Init 1 */

  /* USER CODE END CAN_Init 1 */
  hcan.Instance = CAN;
  hcan.Init.Prescaler = 9;
  hcan.Init.Mode = CAN_MODE_NORMAL;
  hcan.Init.SyncJumpWidth = CAN_SJW_1TQ;
  hcan.Init.TimeSeg1 = CAN_BS1_5TQ;
  hcan.Init.TimeSeg2 = CAN_BS2_2TQ;
  hcan.Init.TimeTriggeredMode = DISABLE;
  hcan.Init.AutoBusOff = DISABLE;
  hcan.Init.AutoWakeUp = DISABLE;
  hcan.Init.AutoRetransmission = DISABLE;
  hcan.Init.ReceiveFifoLocked = DISABLE;
  hcan.Init.TransmitFifoPriority = DISABLE;
  if (HAL_CAN_Init(&hcan) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN CAN_Init 2 */

  /* USER CODE END CAN_Init 2 */

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{
  GPIO_InitTypeDef GPIO_InitStruct = {0};

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOF_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(LED_GPIO_Port, LED_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin : LED_Pin */
  GPIO_InitStruct.Pin = LED_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_OD;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(LED_GPIO_Port, &GPIO_InitStruct);

}

/* USER CODE BEGIN 4 */
void CAN_Filter_Config(void)
{
    CAN_FilterTypeDef sFilterConfig;
    CAN_FilterRegTypeDef IDH = {0};
    CAN_FilterRegTypeDef IDL = {0};

#if CAN_ID_TYPE_STD_ENABLE
    IDH.Sub.STID = (CAN_BASE_ID >> 16) & 0xFFFF;		// 标准ID�?16�?
    IDL.Sub.STID = (CAN_BASE_ID & 0xFFFF);				// 标准ID�?16�?
#else
    IDH.Sub.EXID = (CAN_BASE_ID >> 16) & 0xFFFF;		// 扩展ID�?16�?
    IDL.Sub.EXID = (CAN_BASE_ID & 0xFFFF);				// 扩展ID�?16�?
    IDL.Sub.IDE  = 1;									// 扩展帧标志位置位
#endif
    sFilterConfig.FilterBank           = 0;												// 设置过滤器组编号
#if CAN_FILTER_MODE_MASK_ENABLE
    sFilterConfig.FilterMode           = CAN_FILTERMODE_IDMASK;							// 屏蔽位模�?
#else
    sFilterConfig.FilterMode           = CAN_FILTERMODE_IDLIST;							// 列表模式
#endif
    sFilterConfig.FilterScale          = CAN_FILTERSCALE_32BIT;							// 32位宽
//    sFilterConfig.FilterIdHigh         = IDH.value;										// 标识符寄存器�?ID高十六位，放入扩展帧�?
//    sFilterConfig.FilterIdLow          = IDL.value;										// 标识符寄存器�?ID低十六位，放入扩展帧�?
//    sFilterConfig.FilterMaskIdHigh     = IDH.value;										// 标识符寄存器二ID高十六位，放入扩展帧�?
//    sFilterConfig.FilterMaskIdLow      = IDL.value;										// 标识符寄存器二ID低十六位，放入扩展帧�?
    sFilterConfig.FilterIdHigh         = 0x0000;										// 标识符寄存器�?ID高十六位，放入扩展帧�?
    sFilterConfig.FilterIdLow          = 0x0000;										// 标识符寄存器�?ID低十六位，放入扩展帧�?
    sFilterConfig.FilterMaskIdHigh     = 0x0000;										// 标识符寄存器二ID高十六位，放入扩展帧�?
    sFilterConfig.FilterMaskIdLow      = 0x0000;										// 标识符寄存器二ID低十六位，放入扩展帧�?
    sFilterConfig.FilterFIFOAssignment = CAN_RX_FIFO0;									// 过滤器组关联到FIFO0
    sFilterConfig.FilterActivation     = ENABLE;										// �?活过滤器
    sFilterConfig.SlaveStartFilterBank = 14;											// 设置从CAN的起始过滤器编号，本单片机只有一个CAN，顾此参数无�?
    if (HAL_CAN_ConfigFilter(&hcan, &sFilterConfig) != HAL_OK)
    {
        Error_Handler();
    }
}

uint8_t CAN_Transmit(CAN_TxPacketTypeDef * packet)
{
	if(HAL_CAN_AddTxMessage(&hcan, &packet->hdr, packet->payload, &packet->mailbox) != HAL_OK)
		return 1;
	return 0;
}

//void CAN_Init(void)
//{
//    MX_CAN_Init();
//    CAN_Filter_Config();
//    HAL_CAN_Start(&hcan);
//    HAL_CAN_ActivateNotification(&hcan, CAN_IT_RX_FIFO0_MSG_PENDING);					// 使能CAN接收中断
//}

void HAL_CAN_RxFifo0MsgPendingCallback(CAN_HandleTypeDef *canHandle)
{
	static CAN_RxPacketTypeDef packet;
	CanBridge_Pkt_Packet pktPacket;

    // CAN数据接收
    if (canHandle->Instance == hcan.Instance)
    {
        if (HAL_CAN_GetRxMessage(canHandle, CAN_RX_FIFO0, &packet.hdr, packet.payload) == HAL_OK)		// 获得接收到的数据头和数据
        {
//			printf("\r\n\r\n\r\n################### CAN RECV ###################\r\n");
//			printf("STID:0x%X\r\n",packet.hdr.StdId);
//			printf("EXID:0x%X\r\n",packet.hdr.ExtId);
//			printf("DLC :%d\r\n", packet.hdr.DLC);
//			printf("DATA:");
//			for(int i = 0; i < packet.hdr.DLC; i++)
//			{
//				printf("0x%02X ", packet.payload[i]);
//			}

            pktPacket.header = CANBRIDGE_HEADER;
            pktPacket.len = sizeof(pktPacket) - 3 ;
            pktPacket.pkt_type = CANBRIDGE_PKT_TYPE_PACKET;
            pktPacket.can_idx = 0;
            memcpy(&pktPacket.hdr, &packet.hdr, sizeof(packet.hdr));
            memcpy(pktPacket.payload, packet.payload, 8);
            CalcCRC16((unsigned char*)&pktPacket);
            CDC_Transmit_FS((uint8_t*)&pktPacket, sizeof(pktPacket));

        	HAL_CAN_ActivateNotification(canHandle, CAN_IT_RX_FIFO0_MSG_PENDING);						// 再次使能FIFO0接收中断
        }
    }
}

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
