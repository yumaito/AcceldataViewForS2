using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accelview_classes
{
    public class Data
    {
        #region メンバ変数
        private List<TMP> d;
        #endregion

        #region プロパティ
        /// <summary>
        /// 蓄積された全てのデータ
        /// </summary>
        public List<TMP> D
        {
            get
            {
                return d;
            }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// リストの初期化
        /// </summary>
        public Data()
        {
            this.d = new List<TMP>();
        }
        #endregion

        #region メンバ関数
        public void PushData(TMP data)
        {
            this.d.Add(data);
        }
        public List<TMP> ExtractData(int head, int tail)
        {
            List<TMP> result = new List<TMP>();
            for (int i = head; i < tail + 1; i++)
            {
                result.Add(this.d[i]);
            }
            return result;
        }
        public Type[] ReturnMenmberArray<Type>(int n)
        {
            Type[] result = new Type[this.d.Count];
            return result;
        }
        #endregion
    }
}
