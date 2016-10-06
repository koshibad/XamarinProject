using System;
using System.IO;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(appFiap.iOS.SQLiteService))]
namespace appFiap.iOS
{
	public class SQLiteService : ISQLiteService
	{
		string GetPath(string databaseName)
		{
			if (string.IsNullOrWhiteSpace(databaseName))
				throw new ArgumentException("Invalid database", nameof(databaseName));

			var sqLIteFileName = $"{databaseName}.db3";
			var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine(documentPath, "..", "Library");
			var path = Path.Combine(libraryPath, sqLIteFileName);

			return path;
		}

		public SQLiteConnection GetConnection(string databaseName)
		{
			return new SQLiteConnection(GetPath(databaseName));
		}

		public long GetSize(string databaseName)
		{
			var fileInfo = new FileInfo(GetPath(databaseName));
			return fileInfo != null ? fileInfo.Length : 0;
		}

		public SQLiteService()
		{
		}
	}
}
