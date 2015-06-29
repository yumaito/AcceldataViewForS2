﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accelerometer
{
    /// <summary>
    /// センサの設定情報を管理するクラス
    /// </summary>
    public class SensorConfig
    {
        #region メンバ変数
        private Dictionary<dataType, int> requiredDataNum;
        private Dictionary<dataType, byte[]> fixedData;
        private Endian endian;
        private SensorVer version;
        #endregion

        #region プロパティ
        /// <summary>
        /// データを形成するのに必要なバイト配列の要素数
        /// </summary>
        public Dictionary<dataType, int> RequiredDataNum
        {
            get
            {
                return this.requiredDataNum;
            }
        }
        /// <summary>
        /// データの先頭部分の固定された情報
        /// </summary>
        public Dictionary<dataType, byte[]> FixedData
        {
            get
            {
                return this.fixedData;
            }
        }
        /// <summary>
        /// 送られる情報のエンディアン
        /// </summary>
        public Endian Endian
        {
            get
            {
                return this.endian;
            }
        }
        /// <summary>
        /// センサの型番
        /// </summary>
        public SensorVer Version
        {
            get
            {
                return this.version;
            }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// センサの設定情報を管理するクラス
        /// </summary>
        /// <param name="version"></param>
        public SensorConfig(SensorVer version)
        {
            this.version = version;
            this.SetEndian(version);
            this.SetFixedData(version);
            this.SetRequiredNum(version);
        }
        #endregion

        #region メソッド
        private void SetEndian(SensorVer v)
        {
            switch(v)
            {
                case SensorVer.WAA010:
                    this.endian = accelerometer.Endian.Big;
                    break;
                case SensorVer.TSND121:
                    this.endian = accelerometer.Endian.Little;
                    break;
                default:
                    break;
            }
        }
        private void SetFixedData(SensorVer v)
        {
            this.requiredDataNum = new Dictionary<dataType, int>();
            switch(v)
            {
                case SensorVer.WAA010:
                    this.requiredDataNum.Add(dataType.both, 20);
                    this.requiredDataNum.Add(dataType.accel, 15);
                    this.requiredDataNum.Add(dataType.gyro, 15);
                    break;
                case SensorVer.TSND121:
                    break;
                default:
                    break;
            }
        }
        private void SetRequiredNum(SensorVer v)
        {
            this.fixedData = new Dictionary<dataType, byte[]>();
            switch(v)
            {
                case SensorVer.WAA010:
                    byte[] agb = SensorData.Encoding.GetBytes("agb");
                    byte[] senb = SensorData.Encoding.GetBytes("senb");
                    byte[] gyb = SensorData.Encoding.GetBytes("gyb");
                    this.fixedData.Add(dataType.both, agb);
                    this.fixedData.Add(dataType.accel, senb);
                    this.fixedData.Add(dataType.gyro, gyb);
                    break;
                case SensorVer.TSND121:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 静的メソッド
        private static byte[] Reverse(byte[] bytes, Endian endian)
        {

            if (BitConverter.IsLittleEndian ^ endian == Endian.Little)
            {
                //IsLittleEndianとendianの排他的論理和
                //リトルエンディアンなら配列を反転
                return bytes.Reverse().ToArray();
            }
            else
            {
                //ビッグエンディアンならそのまま
                return bytes;
            }
        }
        private static byte[] GetSubArray(byte[] src, int startIndex, int count)
        {
            byte[] dst = new byte[count];
            Array.Copy(src, startIndex, dst, 0, src.Length);
            return dst;
        }
        public static int ToInt32(byte[] value, Endian endian)
        {
            switch(endian)
            {
                case Endian.Big:
                    short temp = (short)(value[0] << 8 | value[1]);
                    return (int)(temp);
                case Endian.Little:
                    short temp2 = (short)(value[1] << 8 | value[0]);
                    return (int)(temp2);
                default:
                    return 0;
            }
            //byte[] sub = GetSubArray(value, startIndex, sizeof(int));
            //byte[] resultArray = SensorConfig.Reverse(sub, endian);
            //return BitConverter.ToInt32(resultArray, 0);
        }
        #endregion
    }
}