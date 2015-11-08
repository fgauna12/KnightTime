using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightTime.Core.BusinessLayer
{
    public static class SensorData
    {
        public struct Temperature
        {
            public double Celcius { get; set; }
            public Temperature(double celcius)
            {
                Celcius = celcius;
            }
        }

        public struct Motion
        {
            public struct Acceleration 
            {
                public int X { get; set; }
                public int Y { get; set; }
                public int Z { get; set; }

                public Acceleration(int x, int y, int z)
                {
                    X = x;
                    Y = y;
                    Z = z;
                }
            }
            /// <summary>
            /// Acceleration in the x, y, z directions
            /// </summary>
            public Acceleration Acc { get; private set; }

            public Motion(int ax, int ay, int az)
            {
                Acc = new Acceleration(ax, ay, az);
            }            
        }

        public struct HeartRate
        {
            int BPM { get; set; }
            public HeartRate(int BPM)
            {
                this.BPM = BPM;
            }
        }

    }
}
