using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using KnightTime.Core.BusinessLayer.Contracts;
using KnightTime.Core.DataAccessLayer;

namespace KnightTime.Core.BusinessLayer
{
    //TODO
    public class Monitor: IMonitorLoop
    {
        bool isRunning;
        private KnightTimePollRepository _repository;
        public Monitor()
        {
            isRunning = false;
           
        }

        private Task<bool> task;

        public void Start(Action wristPoll, Action maskPoll, Action baseStationPoll)
        {
            int count = 20;
            isRunning = true;

            while (isRunning)
            {
                //If there is a Wrist Periphral, then Poll
                if (wristPoll != null)
                {
                    
                    //TODO Wait until the peripheral replies.
                    Random rand = new Random();
                    //KnightTimeRepository.SavePoll(new Poll() { Temperature = (double)rand.Next(0, 40) });
                    if (count-- == 0)
                    {
                        var polls = KnightTimePollRepository.GetPolls();
                        wristPoll();
                    }
                }
                //If there is a Mask Periphral, then Poll
                if (maskPoll != null)
                {
                    maskPoll();
                    //TODO Wait until the peripheral replies.
                }
                //If there is a Base Station, then Poll
                if (baseStationPoll != null)
                {
                    baseStationPoll();
                    //TODO Wait until the peripheral replies.
                }
            }
        }
        public void Stop()
        {
            isRunning = false;
        }
    }
}
