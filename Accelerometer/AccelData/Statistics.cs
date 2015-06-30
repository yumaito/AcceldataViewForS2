using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
using System.Drawing;


namespace accelerometer
{
    /// <summary>
    /// 統計計算をする静的クラス
    /// </summary>
    public static class Statistics
    {
        #region
        /// <summary>
        /// 算術平均の計算
        /// </summary>
        /// <param name="data">AccelDataのリスト
        /// </param>
        /// <returns>0～2は加速度のX,Y,Z,3～5は角速度のX,Y,Z</returns>
        public static double[] Mean(List<AccelData> data)
        {
            double[] result = new double[6] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            foreach (AccelData ad in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    result[i] += ad.ReturnByNumber(i);
                    
                }
            }
            for (int i = 0; i < 6; i++)
            {
                result[i] = result[i] / data.Count;
            }
            return result;
        }
        /// <summary>
        /// enum型のDescriptionを取得する関数
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetDescription(object enumValue)
        {
            FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
            if (null != fi)
            {
                object[] attrs = fi.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return "";
        }
        #endregion
    }
}
