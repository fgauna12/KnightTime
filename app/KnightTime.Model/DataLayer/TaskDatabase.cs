using System;
using System.Linq;
using System.Collections.Generic;
using KnightTime.Core.DataLayer.SQLite;
using KnightTime.Core.BusinessLayer;

namespace KightTime.Core.DataLayer
{
	/// <summary>
	/// TaskDatabase builds on SQLite.Net and represents a specific database, in our case, the Task DB.
	/// It contains methods for retrieval and persistance as well as db creation, all based on the 
	/// underlying ORM.
	/// </summary>
	public class KnightTimeDatabase : SQLiteConnection
	{
		static object locker = new object ();

		/// <summary>
		/// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
		/// if the database doesn't exist, it will create the database and all the tables.
		/// </summary>
		/// <param name='path'>
		/// Path.
		/// </param>
		public KnightTimeDatabase (string path) : base (path)
		{
			// create the tables
			CreateTable<Poll> ();
		}
		
		public IEnumerable<T> GetItems<T> () where T : KnightTime.Core.BusinessLayer.Contracts.IBusinessEntity, new ()
		{
            lock (locker) {
                return (from i in Table<T> () select i).ToList ();
            }
		}

        public T GetItem<T>(int id) where T : KnightTime.Core.BusinessLayer.Contracts.IBusinessEntity, new()
		{
            lock (locker) {
                return Table<T>().FirstOrDefault(x => x.ID == id);
                // Following throws NotSupportedException - thanks aliegeni
                //return (from i in Table<T> ()
                //        where i.ID == id
                //        select i).FirstOrDefault ();
            }
		}

        public int SaveItem<T>(T item) where T : KnightTime.Core.BusinessLayer.Contracts.IBusinessEntity
		{
            lock (locker) {
                if (item.ID != 0) {
                    Update (item);
                    return item.ID;
                } else {
                    return Insert (item);
                }
            }
		}

        public int DeleteItem<T>(int id) where T : KnightTime.Core.BusinessLayer.Contracts.IBusinessEntity, new()
		{
            lock (locker) {
#if NETFX_CORE
                return Delete(new T() { ID = id });
#else
                return Delete<T> (new T () { ID = id });
#endif
            }
		}
	}
}