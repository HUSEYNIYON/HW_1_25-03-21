using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace HW_1_25_03_21.Repositories
{
    public abstract class DbWorker<T> : IReadAllFromDB<T>
    {
        public List<T> ReadAll()
        {
			try
			{
				using (IDbConnection db = new SqlConnection(ConString.path))
				{
					return db.Query<T>($"SELECT * FROM {typeof(T).Name}").ToList();
				}
			}
			catch (Exception)
			{
				return null;
			}
        }
    }
}
