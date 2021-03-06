﻿using JT808.Protocol.Extensions;
using JT808.Protocol.Formatters;
using JT808.Protocol.Interfaces;
using JT808.Protocol.MessagePack;
using System.Text.Json;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 扩展车辆信号状态位
    /// </summary>
    public class JT808_0x0200_0x25 : JT808_0x0200_BodyBase, IJT808MessagePackFormatter<JT808_0x0200_0x25>, IJT808Analyze
    {
        /// <summary>
        /// 扩展车辆信号状态位
        /// </summary>
        public int CarSignalStatus { get; set; }
        /// <summary>
        /// JT808_0x0200_0x25
        /// </summary>
        public override byte AttachInfoId { get; set; } = JT808Constants.JT808_0x0200_0x25;
        /// <summary>
        /// 4 byte
        /// </summary>
        public override byte AttachInfoLength { get; set; } = 4;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="writer"></param>
        /// <param name="config"></param>
        public void Analyze(ref JT808MessagePackReader reader, Utf8JsonWriter writer, IJT808Config config)
        {
            JT808_0x0200_0x25 value = new JT808_0x0200_0x25();
            value.AttachInfoId = reader.ReadByte();
            writer.WriteNumber($"[{value.AttachInfoId.ReadNumber()}]附加信息Id", value.AttachInfoId);
            value.AttachInfoLength = reader.ReadByte();
            writer.WriteNumber($"[{value.AttachInfoLength.ReadNumber()}]附加信息长度", value.AttachInfoLength);
            value.CarSignalStatus = reader.ReadInt32();
            writer.WriteNumber($"[{value.CarSignalStatus.ReadNumber()}]扩展车辆信号状态位", value.CarSignalStatus);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public JT808_0x0200_0x25 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x0200_0x25 value = new JT808_0x0200_0x25();
            value.AttachInfoId = reader.ReadByte();
            value.AttachInfoLength = reader.ReadByte();
            value.CarSignalStatus = reader.ReadInt32();
            return value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="config"></param>
        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x0200_0x25 value, IJT808Config config)
        {
            writer.WriteByte(value.AttachInfoId);
            writer.WriteByte(value.AttachInfoLength);
            writer.WriteInt32(value.CarSignalStatus);
        }
    }
}
