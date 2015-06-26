using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace accelview_classes
{
    public enum dataType
    {
        accel,gyro,both
    }
    public enum SensorVer
    {
        [Description("WAA-010")]
        WAA010,
        //[Description("TSND121")]
        //TSND121
    }
}
