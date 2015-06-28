using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accelerometer
{
    /// <summary>
    /// 加速度データとジャイロデータを持つクラス
    /// </summary>
    public class AccelData

    {
        #region メンバ変数
        private int time;
        private XYZData accel;
        private XYZData gyro;
        private dataType d;
        //private byte[] databuffer;
        //private int index;
        #endregion

        #region プロパティ
        /// <summary>
        /// 時刻（int型）
        /// </summary>
        public int Time
        {
            get
            {
                return this.time;
            }
        }
        /// <summary>
        /// 加速度
        /// </summary>
        public XYZData Accel
        {
            get
            {
                return accel;
            }
        }
        /// <summary>
        /// ジャイロ
        /// </summary>
        public XYZData Gyro
        {
            get
            {
                return gyro;
            }
        }
        public dataType D
        {
            get
            {
                return d;
            }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// 加速度データのインスタンス生成
        /// </summary>
        /// <param name="time">時間</param>
        /// <param name="accel">加速度</param>
        /// <param name="gyro">角速度</param>
        public AccelData(short time, XYZData accel, XYZData gyro)
        {
            this.time = time;
            this.accel = accel;
            this.gyro = gyro;
        }
        /// <summary>
        /// 加速度データのインスタンス生成
        /// </summary>
        /// <param name="byteData">20個の要素からなるバイト型配列</param>
        public AccelData(byte[] byteData, dataType d, SensorVer sensor)
        {
            switch(sensor)
            {
                case SensorVer.WAA010:
                    this.CreateDataFor010(d, byteData);
                    break;
                case SensorVer.TSND121:
                    this.CreateDataFor121(d, byteData);
                    break;
            }

            if (d == dataType.both)
            {
                if (byteData.Length != 25)
                {
                    throw new ArgumentException("byteData型配列の要素数は20個でなければなりません。");
                }
                //時間を作成
                this.time = (short)(byteData[3] << 24 | byteData[4] << 16 | byteData[5] << 8 | byteData[6]);
                //byteData配列から7～12の要素を抽出-----
                byte[] data = new byte[6];
                int typeSize = System.Runtime.InteropServices.Marshal.SizeOf(byteData.GetType().GetElementType());
                Buffer.BlockCopy(byteData, 7 * typeSize, data, 0, 6 * typeSize);
                //--------
                //自クラスのメソッド呼び出し--------
                this.accel = this.ReturnData(data);
                //13～18の要素を抽出-----
                data = new byte[6];//初期化
                typeSize = System.Runtime.InteropServices.Marshal.SizeOf(byteData.GetType().GetElementType());
                Buffer.BlockCopy(byteData, 13 * typeSize, data, 0, 6 * typeSize);
                //-------
                //自クラスのメソッド呼び出し
                this.gyro = this.ReturnData(data);
            }
            else if (d == dataType.accel)
            {
                if (byteData.Length != 25)
                {
                    throw new ArgumentException("byteData型配列の要素数は20個でなければなりません。");
                }
                //
                this.time = (short)(byteData[4] << 24 | byteData[5] << 16 | byteData[6] << 8 | byteData[7]);
                byte[] data = new byte[6];
                int typeSize = System.Runtime.InteropServices.Marshal.SizeOf(byteData.GetType().GetElementType());
                Buffer.BlockCopy(byteData, 8 * typeSize, data, 0, 6 * typeSize);
                //
                this.accel = this.ReturnData(data);

            }
            else
            {

            }

        }
        
        #endregion

        #region メソッド
        /// <summary>
        /// 各値を番号で指定できるようにするメソッド
        /// </summary>
        /// <param name="num">0～2なら加速度の値、3～5なら角速度の値</param>
        /// <returns></returns>
        public int ReturnByNumber(int num)
        {
            if (num < 3)
            {
                return this.accel.ReturnByNumber(num);
            }
            else if (num < 6)
            {
                return this.gyro.ReturnByNumber(num - 3);
            }
            else
            {
                return this.accel.X;
            }
        }
        private void CreateDataFor010(dataType d, byte[] data)
        {
            //リストに変換（抽出がやりやすいので）
            List<byte> temp = data.ToList();
            switch(d)
            {
                case dataType.both:
                    this.CreateTime(temp.GetRange(3, 4).ToArray());
                    this.accel = this.ReturnData(temp.GetRange(7, 6).ToArray());
                    this.gyro = this.ReturnData(temp.GetRange(13, 6).ToArray());
                    break;
                case dataType.accel:
                    this.CreateTime(temp.GetRange(4, 4).ToArray());
                    this.accel = this.ReturnData(temp.GetRange(8, 6).ToArray());
                    break;
                case dataType.gyro:
                    this.CreateTime(temp.GetRange(3, 4).ToArray());
                    this.gyro = this.ReturnData(temp.GetRange(7, 6).ToArray());
                    break;
            }
        }
        private void CreateDataFor121(dataType d, byte[] data)
        {

        }
        /// <summary>
        /// 時刻を生成する
        /// </summary>
        /// <param name="data"></param>
        private void CreateTime(byte[] data)
        {
            this.time = (int)(data[0] << 24 | data[1] << 16 | data[2] << 8 | data[3]);
        }
        /// <summary>
        /// byte型の配列からXYZData型のインスタンスを返すメソッド
        /// </summary>
        /// <param name="data">byte型の配列（6要素必要）</param>
        /// <returns></returns>
        private XYZData ReturnData(byte[] data)
        {
            int x = (int)(data[0] << 8 | data[1]);
            int y = (int)(data[2] << 8 | data[3]);
            int z = (int)(data[4] << 8 | data[5]);
            return new XYZData(x, y, z);
        }
        /// <summary>
        /// デバッグ時に見やすい用
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "time=" + this.time + ": accel=" + this.accel.ToString() + ",gyro=" + this.gyro.ToString();
            //return base.ToString();
        }
        /// <summary>
        /// CSV出力するとき用
        /// </summary>
        /// <returns></returns>
        public string CSVFormat(dataType d)
        {
            if (d == dataType.both)
            {
                return this.time + "," + this.accel.CSVFormat() + "," + this.gyro.CSVFormat();
            }
            else
            {
                return this.time + "," + this.accel.CSVFormat();
            }

        }
        #endregion
    }
}
