using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accelview_classes
{
    /// <summary>
    /// AccelDataをリストとして保持するクラス
    /// </summary>
    public class SensorData
    {
        #region メンバ変数
        List<AccelData> allData;
        private const int maximumData = 1000;
        #endregion

        #region プロパティ
        public List<AccelData> AllData
        {
            get
            {
                return allData;
            }
        }
        /// <summary>
        /// リストに保持されている最後のデータを返す
        /// </summary>
        public AccelData LastData
        {
            get
            {
                return this.allData.Last();
            }
        }
        #endregion


        #region コンストラクタ
        public SensorData()
        {
            //allDataの初期化（必ず必要）
            this.allData = new List<AccelData>();
        }
        #endregion

        #region メソッド
        #region public
        /// <summary>
        /// SensorDataにAccelDataを追加するメソッド
        /// </summary>
        /// <param name="input">AccelData</param>
        public void pushData(AccelData input)
        {
            this.allData.Add(input);
            //もしデータの個数がmaximumDataを超えたら、リストの最初の値を削除
            if (this.allData.Count > maximumData)
            {
                this.allData.RemoveAt(0);
            }
        }
        /// <summary>
        /// 指定した番号から番号までのデータを返すメソッド
        /// </summary>
        /// <param name="head">頭の番号</param>
        /// <param name="tail">終わりの番号</param>
        /// <returns></returns>
        public List<AccelData> ExtractData(int head,int tail)
        {
            //例外処理
            if (head > tail)
            {
                throw new ArgumentException("head>tailとなる数値が入力されました");
            }
            if (head > this.allData.Count - 1)
            {
                throw new ArgumentOutOfRangeException("head", "蓄積されているデータ数より大きな番号が指定されました。");
            }
            if (tail > this.allData.Count - 1)
            {
                throw new ArgumentOutOfRangeException("tail", "蓄積されているデータ数より大きな番号が指定されました。");
            }
            //
            List<AccelData> result = new List<AccelData>();
            //Console.WriteLine("Extracting");
            //Console.WriteLine("(" + head + "," + tail + ")");
            for (int i = head; i < tail + 1; i++)
            {
                result.Add(this.allData[i]);
            }
            return result;
        }
        /// <summary>
        /// 後ろから指定した数分のデータを返すメソッド
        /// </summary>
        /// <param name="num">指定する数</param>
        /// <returns></returns>
        public List<AccelData> ExtractData(int num)
        {
            int tail = this.allData.Count - 1;
            
            if (this.allData.Count >= num)
            {
                //抽出したい数よりも蓄積されているデータの方が多い場合
                int head = this.allData.Count - num;
                return this.ExtractData(head, tail);
            }
            else
            {
                if (this.allData.Count == 0)
                {
                    //データが一つもないとき
                    return this.allData;
                }
                else
                {
                    //Console.WriteLine("exrtact Data");
                    return this.ExtractData(0, tail);
                }
            }
        }
        #endregion
        #region private
        
        #endregion
        #endregion
    }
}
