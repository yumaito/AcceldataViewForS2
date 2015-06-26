using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accelview_classes
{
    public class XYZData
    {
        #region メンバ変数
        private int x;//x軸
        private int y;//y軸
        private int z;//z軸
        #endregion

        #region プロパティ
        /// <summary>
        /// X軸データ
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }
        }
        /// <summary>
        /// Y軸データ
        /// </summary>
        public int Y
        {
            get
            {
                return y;
            }
        }
        /// <summary>
        /// Z軸データ
        /// </summary>
        public int Z
        {
            get
            {
                return z;
            }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// x、y、zの値を持つクラスのインスタンスを生成
        /// </summary>
        public XYZData()
            : this(0, 0, 0)
        {

        }
        /// <summary>
        /// x,y,zの値をもつクラスのインスタンスを生成
        /// </summary>
        /// <param name="x">x軸</param>
        /// <param name="y">y軸</param>
        /// <param name="z">z軸</param>
        public XYZData(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        #endregion

        #region メソッド
        /// <summary>
        /// 各値を番号で指定できるようにするメソッド
        /// </summary>
        /// <param name="num">0ならx軸、1ならy軸、2ならz軸の値</param>
        /// <returns></returns>
        public int ReturnByNumber(int num)
        {
            switch (num)
            {
                case 0:
                    return this.x;
                    //break;
                case 1:
                    return this.y;
                    //break;
                case 2:
                    return this.z;
                    //break;
                default:
                    return this.x;
                    //break;
            }
        }
        /// <summary>
        /// ベクトルの大きさを返すメソッド（適当に作ってみた）
        /// </summary>
        /// <returns></returns>
        public double Size()
        {
            return Math.Sqrt(Math.Pow((double)x, 2) + Math.Pow((double)y, 2) + Math.Pow((double)z, 2));
        }
        /// <summary>
        /// デバッグ時に見やすい用
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "(" + this.x.ToString() + "," + this.y.ToString() + "," + this.z.ToString() + ")";
            //return base.ToString();
        }
        /// <summary>
        /// CSV出力するとき用
        /// </summary>
        /// <returns></returns>
        public string CSVFormat()
        {
            return this.x + "," + this.y + "," + this.z;
        }
        #endregion
    }
}
