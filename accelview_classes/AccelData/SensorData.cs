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
        private dataType currentType;
        private List<AccelData> allData;
        private List<byte> dataBuffer;
        private int bufferindex;
        private const int maximumData = 1000;
        #region 静的変数
        private static Dictionary<dataType, int> requiredDataNum =
            new Dictionary<dataType, int>(){
                {dataType.accel,15},
                {dataType.gyro,15},
                {dataType.both,20}
            };
        private static Dictionary<dataType, byte[]> fixedData =
            new Dictionary<dataType, byte[]>(){
                {dataType.both,
                new byte[]{0x73,0x65,0x6E,0x62}},
                {dataType.accel,
                new byte[]{0x61,0x67,0x62}}
            };
        #endregion
        #endregion

        #region プロパティ
        #region 静的変数
        /// <summary>
        /// 得るデータと受け取るデータの先頭固定バイト
        /// </summary>
        public static Dictionary<dataType, byte[]> FixedData
        {
            get
            {
                return SensorData.fixedData;
            }
        }
        /// <summary>
        /// 得るデータと配列の個数の関係
        /// </summary>
        public static Dictionary<dataType,int> RequiredDataNum
        {
            get
            {
                return SensorData.requiredDataNum;
            }
        }
        #endregion
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
        public SensorData(dataType type)
        {
            this.currentType = type;
            //allDataの初期化（必ず必要）
            this.allData = new List<AccelData>();
            //bufferの初期化
            this.dataBuffer = new List<byte>();
        }
        #endregion

        #region メソッド
        #region public
        /// <summary>
        /// シリアルポートからのデータを受け取りデータバッファに溜める
        /// もし加速度データに変更できるだけの量が溜まれば加速度データに変換後、該当データは破棄
        /// </summary>
        /// <param name="data"></param>
        public void pushDataBuffer(byte data)
        {
            this.dataBuffer.Add(data);
        }
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
        //public bool checkData(List<byte> data)
        //{
        //    //データ数が一定個以下ならfalseを返す
        //    if (data.Count <= SensorData.requiredDataNum[this.currentType])
        //    {
        //        return false;
        //    }
        //    else
        //    {

        //    }
        //}
        #endregion
        #endregion
    }
}
