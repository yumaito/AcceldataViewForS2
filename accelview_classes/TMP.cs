using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accelview_classes
{
    public class TMP : ICloneable
    {
        #region メンバ変数
        private int time;
        private int rtime;
        private double nose;
        private double body;
        private double env;

        #endregion

        #region プロパティ
        /// <summary>
        /// 時間（ms）
        /// </summary>
        public int Time
        {
            get
            {
                return time;
            }
        }
        /// <summary>
        /// 累積時間（ms）
        /// </summary>
        public int Rtime
        {
            get
            {
                return rtime;
            }
        }
        /// <summary>
        /// 鼻の温度（摂氏）
        /// </summary>
        public double Nose
        {
            get
            {
                return nose;
            }
        }
        /// <summary>
        /// 体幹温度（摂氏）
        /// </summary>
        public double Body
        {
            get
            {
                return body;
            }
        }
        /// <summary>
        /// 周囲の温度（摂氏）
        /// </summary>
        public double Env
        {
            get
            {
                return env;
            }
        }
        #endregion

        #region コンストラクタ
        public TMP(int time, int rtime, double nose, double body, double env)
        {
            this.time = time;
            this.rtime = rtime;
            this.nose = nose;
            this.body = body;
            this.env = env;
        }
        #endregion
        #region メンバ関数
        public object Clone()
        {
            return new TMP(this.time, this.rtime, this.nose, this.body, this.env);
        }
        public TMP ReturnSelf()
        {
            return new TMP(this.time, this.rtime, this.nose, this.body, this.env);
        }
        #endregion

    }
}
