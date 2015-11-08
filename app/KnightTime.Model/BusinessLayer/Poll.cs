using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnightTime.Core.DataLayer.SQLite;
using KnightTime.Core.BusinessLayer.Contracts;

namespace KnightTime.Core.BusinessLayer
{
    public class Poll: IBusinessEntity
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }

        /// <summary>
        /// The id of the run that this poll belongs to.
        /// </summary>
        public int RID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string Gender { get; set; }

        public string DateTime { get; set; }

        /* Wrist - Peripheral 0 */
        public string Motion_Acc_X { get; set; }
        public string Motion_Acc_Y { get; set; }
        public string Motion_Acc_Z { get; set; }

        public string Motion_Jerk_Mag { get; set; }
        public string Motion_Jerk_Mag_MovingAvg { get; set; }

        public string Motion_Gyr_X { get; set; }
        public string Motion_Gyr_Y { get; set; }
        public string Motion_Gyr_Z { get; set; }

        public string Motion_Gyro_Mag { get; set; }

        /* Mask - Peripheral 1 */
        public string HeartRate { get; set; }
        public string Temperature { get; set; }
        public string EEG { get; set; }
        
        /* Base Station - Peripheral 2 */
        public string AmbientLight { get; set; }
        public string AmbientHumidity { get; set; }
        public string AmbientNoise { get; set; }
        public string AmbientTemp { get; set; }
        

        public IEnumerable<string> ToArray()
        {
            List<string> ret = new List<string>();

            ret.Add(RID.ToString());

            if (DateTime != null) ret.Add(DateTime.ToString());
            else ret.Add("NULL");

            if (Motion_Acc_X != null) ret.Add(Motion_Acc_X.ToString());
            else ret.Add("NULL");
            if (Motion_Acc_Y != null) ret.Add(Motion_Acc_Y.ToString());
            else ret.Add("NULL");
            if (Motion_Acc_Z != null) ret.Add(Motion_Acc_Z.ToString());
            else ret.Add("NULL");

            if (Motion_Gyr_X != null) ret.Add(Motion_Gyr_X.ToString());
            else ret.Add("NULL");
            if (Motion_Gyr_Y != null) ret.Add(Motion_Gyr_Y.ToString());
            else ret.Add("NULL");
            if (Motion_Gyr_Z != null) ret.Add(Motion_Gyr_Z.ToString());
            else ret.Add("NULL"); 

            if (HeartRate != null) ret.Add(HeartRate.ToString());
            else ret.Add("NULL");
            if (Temperature != null) ret.Add(Temperature.ToString());
            else ret.Add("NULL");
            if (EEG != null) ret.Add(EEG.ToString());
            else ret.Add("NULL");
            
            if (AmbientLight != null) ret.Add(AmbientLight.ToString());
            else ret.Add("NULL");
            if (AmbientHumidity != null) ret.Add(AmbientHumidity.ToString());
            else ret.Add("NULL");
            if (AmbientNoise != null) ret.Add(AmbientNoise.ToString());
            else ret.Add("NULL");
            if (AmbientTemp != null) ret.Add(AmbientTemp.ToString());
            else ret.Add("NULL");

            if (Motion_Jerk_Mag != null) ret.Add(Motion_Jerk_Mag.ToString());
            else ret.Add("NULL");
            if (Motion_Gyro_Mag != null) ret.Add(Motion_Gyro_Mag.ToString());
            else ret.Add("NULL");
            if (Motion_Jerk_Mag_MovingAvg != null) ret.Add(Motion_Jerk_Mag_MovingAvg.ToString());
            else ret.Add("NULL");
            return ret;
        }
    }
}
