using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnightTime.Core.DataLayer.SQLite;

using KnightTime.Core.BusinessLayer.Contracts;

namespace KnightTime.Core.BusinessLayer
{
    public class Run: IBusinessEntity
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeSpan HoursSlept
        {
            get
            {
                return EndTime - StartTime;
            }
        }
    }
}
