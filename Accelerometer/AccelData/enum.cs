using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace accelerometer
{
    /// <summary>
    /// 取得するデータのタイプ
    /// </summary>
    public enum dataType
    {
        /// <summary>
        /// 加速度データのみ
        /// </summary>
        accel,
        /// <summary>
        /// 角速度データのみ
        /// </summary>
        gyro,
        /// <summary>
        /// 加速度と角速度データの両方
        /// </summary>
        both
    }
    /// <summary>
    /// センサの型番
    /// </summary>
    public enum SensorVer
    {
        [Description("WAA-010")]
        WAA010,
        [Description("TSND121")]
        TSND121
    }
    /// <summary>
    /// エンディアン
    /// </summary>
    public enum Endian
    {
        /// <summary>
        /// リトルエンディアン
        /// </summary>
        Little,
        /// <summary>
        /// ビッグエンディアン
        /// </summary>
        Big
    }
}
