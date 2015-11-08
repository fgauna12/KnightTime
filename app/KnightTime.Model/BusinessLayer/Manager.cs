using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnightTime.Core.DataAccessLayer;

namespace KnightTime.Core.BusinessLayer
{
    //TODO
    public static class Manager
    {
        /// <summary>
        /// Get the run from a specific day
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static IEnumerable<Run> GetRunFrom(DateTime dateTime)
        {
            return KnightTimeRunRepository.GetRuns().Where(d => d.StartTime.ToShortDateString() == dateTime.ToShortDateString());
        }

        /// <summary>
        /// Get the lastest run in the db.
        /// </summary>
        /// <returns></returns>
        public static Run GetLatestRun()
        {
            var runs = KnightTimeRunRepository.GetRuns();
            return (runs.Count() > 0) ? runs.Aggregate((r1, r2) => r1.ID > r2.ID ? r1 : r2) : null;
        }

        /// <summary>
        /// Get the polls from the latest run executed. 
        /// <remarks>This is typically called by the summary page</remarks>
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Poll> GetPollsFromLatestRun()
        {
            var iLatestRun = GetLatestRun();
            return (iLatestRun != null) ? KnightTimePollRepository.GetPolls().Where(p => p.RID == iLatestRun.ID) : null;
        }

        /// <summary>
        /// Get the latest poll in the database.
        /// </summary>
        /// <returns></returns>
        public static Poll GetLatestPoll()
        {
            var poll = KnightTimePollRepository.GetPolls();
            if (poll == null || poll.Count() == 0) return null;
            return (poll.Count() > 0) ? poll.Aggregate((r1, r2) => r1.ID > r2.ID ? r1 : r2) : null;
        }

        /// <summary>
        /// Get the latest jerk magnitude stored.
        /// </summary>
        /// <returns></returns>
        public static double GetLatestJerkMagnitude()
        {
            var latestPoll = GetLatestPoll();
            if (latestPoll != null)
                return double.Parse(latestPoll.Motion_Jerk_Mag);
            else return -1.0;
        }
        
        /// <summary>
        /// Get the polls from the specified run.
        /// </summary>
        /// <param name="run"></param>
        /// <returns></returns>
        public static IEnumerable<Poll> GetPollsFromRun(Run run)
        {
            return KnightTimePollRepository.GetPolls().Where(p => p.RID == run.ID);
        }

        /// <summary>
        /// Get the polls from the specified run id
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public static IEnumerable<Poll> GetPollsFromRID(int rid)
        {
            return KnightTimePollRepository.GetPolls().Where(p => p.RID == rid);
        }

        public static IEnumerable<Run> GetRuns()
        {
            return KnightTimeRunRepository.GetRuns();
        }
    }
}
