﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KnightTime.Core.BusinessLayer;
using KnightTime.Core.DataLayer;

namespace KnightTime.Core.DataAccessLayer
{
    internal class KnightTimeRunRepository
    {
        KnightTime.Core.DataLayer.KnightTimeRunDatabase db = null;
        protected static string dbLocation;
        protected static KnightTimeRunRepository me;

        static KnightTimeRunRepository()
        {
            me = new KnightTimeRunRepository();
        }

        protected KnightTimeRunRepository()
        {
            // set the db location
            dbLocation = DatabaseFilePath;

            // instantiate the database	
            db = new KnightTime.Core.DataLayer.KnightTimeRunDatabase(dbLocation);
        }

        internal static string DatabaseFilePath
        {
            get
            {
                var sqliteFilename = "KnightTimeRunDB.db3";

#if NETFX_CORE
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, sqliteFilename);
#else

#if SILVERLIGHT
			// Windows Phone expects a local path, not absolute
	        var path = sqliteFilename;
#else

#if __ANDROID__
			// Just use whatever directory SpecialFolder.Personal returns
	        string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); ;
#else
                // we need to put in /Library/ on iOS5.1 to meet Apple's iCloud terms
                // (they don't want non-user-generated data in Documents)
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
                string libraryPath = Path.Combine(documentsPath, "../Library/"); // Library folder
#endif
                var path = Path.Combine(libraryPath, sqliteFilename);
#endif

#endif
                return path;
            }
        }
        
        internal static Run GetRun(int id)
        {
            return me.db.GetItem<Run>(id);
        }

        internal static IEnumerable<Run> GetRuns()
        {
            return me.db.GetItems<Run>();
        }

        internal static int SaveRun(Run item)
        {
            return me.db.SaveItem<Run>(item);
        }

        internal static int DeleteRun(int id)
        {
            return me.db.DeleteItem<Run>(id);
        }
    }
}
