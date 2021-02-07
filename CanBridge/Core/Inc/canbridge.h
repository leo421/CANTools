/*
 * canbridge.h
 *
 *  Created on: 2021年2月6日
 *      Author: WangXu
 */

#ifndef INC_CANBRIDGE_H_
#define INC_CANBRIDGE_H_

typedef enum {
	CANBRIDGE_HEADER	=0xAA55
} CanBridge_Pkt_Header;

//数据包类型
typedef enum
{
	CANBRIDGE_PKT_TYPE_RESPONSE			=1,
	CANBRIDGE_PKT_TYPE_PACKET			=2,
	CANBRIDGE_PKT_TYPE_CONFIG			=3,
	CANBRIDGE_PKT_TYPE_CONFIG_RESPONSE	=4,
	CANBRIDGE_PKT_TYPE_GET_CAN			=5,
	CANBRIDGE_PKT_TYPE_GET_CAN_RESPONSE	=6,
	CANBRIDGE_PKT_TYPE_SEND_PACKET		=7
} CanBridge_Pkt_Type;
//#define CANBRIDGE_PKT_TYPE_RESPONSE			1
//#define CANBRIDGE_PKT_TYPE_PACKET			2
//#define CANBRIDGE_PKT_TYPE_CONFIG			3
//#define CANBRIDGE_PKT_TYPE_CONFIG_RESPONSE	4
//#define CANBRIDGE_PKT_TYPE_GET_CAN			5
//#define CANBRIDGE_PKT_TYPE_GET_CAN_RESPONSE	6
//#define CANBRIDGE_PKT_TYPE_SEND_PACKET		7

//响应数据包 pkt_type=CANBRIDGE_PKT_TYPE_RESPONSE
typedef struct {
	CanBridge_Pkt_Header	header;			//固定帧头
	uint8_t					len;			//数据长度，不包括header和len
	CanBridge_Pkt_Type		pkt_type;		//数据包类型
	uint16_t				errno;			//错误码
	uint16_t				crc16;			//校验数据
}__attribute__((packed)) CanBridge_Pkt_Response;

//接收到的can数据包 pkt_type=CANBRIDGE_PKT_TYPE_PACKET
typedef struct {
	CanBridge_Pkt_Header	header;			//固定帧头
	uint8_t					len;			//数据长度，不包括header和len
	CanBridge_Pkt_Type		pkt_type;		//数据包类型
	uint8_t					can_idx;		//can接口索引
	CAN_RxHeaderTypeDef		hdr;			//can数据包头
	uint8_t					payload[8];	//can数据
	uint16_t				crc16;			//校验数据
}__attribute__((packed)) CanBridge_Pkt_Packet;

//设置数据包 pkt_type=CANBRIDGE_PKT_TYPE_CONFIG
typedef struct {
	CanBridge_Pkt_Header	header;			//固定帧头
	uint8_t					len;			//数据长度，不包括header和len
	CanBridge_Pkt_Type		pkt_type;		//数据包类型
	uint8_t					can_idx;		//can接口索引
	uint32_t				bitrate;		//接口速率
	uint16_t				crc16;			//校验数据
}__attribute__((packed)) CanBridge_Pkt_Config;

//设置数据包响应 pkt_type=CANBRIDGE_PKT_TYPE_CONFIG_RESPONSE
typedef struct {
	CanBridge_Pkt_Header	header;			//固定帧头
	uint8_t					len;			//数据长度，不包括header和len
	CanBridge_Pkt_Type		pkt_type;		//数据包类型
	uint8_t					can_idx;		//can接口索引
	uint16_t				errno;			//接口速率设置结果，成功为0
	uint16_t				crc16;			//校验数据
}__attribute__((packed)) CanBridge_Pkt_Config_Response;

//查询接口数量 pkt_type=CANBRIDGE_PKT_TYPE_GET_CAN
typedef struct {
	CanBridge_Pkt_Header	header;			//固定帧头
	uint8_t					len;			//数据长度，不包括header和len
	CanBridge_Pkt_Type		pkt_type;		//数据包类型
	uint16_t				crc16;			//校验数据
}__attribute__((packed)) CanBridge_Pkt_Get_Can;

//查询接口数量响应 pkt_type=CANBRIDGE_PKT_TYPE_GET_CAN_RESPONSE
typedef struct {
	CanBridge_Pkt_Header	header;			//固定帧头
	uint8_t					len;			//数据长度，不包括header和len
	CanBridge_Pkt_Type		pkt_type;		//数据包类型
	uint8_t					count;			//接口数量
	uint16_t				crc16;			//校验数据
}__attribute__((packed)) CanBridge_Pkt_Get_Can_Response;

//发送数据包 pkt_type=CANBRIDGE_PKT_TYPE_SEND_PACKET
typedef struct {
	CanBridge_Pkt_Header	header;			//固定帧头
	uint8_t					len;			//数据长度，不包括header和len
	CanBridge_Pkt_Type		pkt_type;		//数据包类型
	uint8_t					can_idx;		//can接口索引
	uint32_t				mailbox;		//can发送邮箱，指为1、2、4，可组合。也可以不指定
	CAN_TxHeaderTypeDef		hdr;			//can数据包头
	uint8_t					payload[8];	//can数据
	uint16_t				crc16;			//校验数据
}__attribute__((packed)) CanBridge_Pkt_Send_Packet;


void CalcCRC16(unsigned char *aStr);
unsigned char CheckCRC16(unsigned char *aStr);

#endif /* INC_CANBRIDGE_H_ */
