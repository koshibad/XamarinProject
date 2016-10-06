using System;
using SQLite;

namespace appFiap
{
	public interface ISQLiteService
	{
		SQLiteConnection GetConnection(string databaseName);
		long GetSize(string databaseName);
	}
}
