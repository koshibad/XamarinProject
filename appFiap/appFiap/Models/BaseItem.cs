using System;
using SQLite;

namespace appFiap
{
	public class BaseItem
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }

		public BaseItem()
		{
		}
	}
}
