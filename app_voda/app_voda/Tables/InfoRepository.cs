using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace app_voda.Tables
{
    public class InfoRepository
    {
        SQLiteConnection database;
        public InfoRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<InfoList>();
        }
        public IEnumerable<InfoList> GetItems()
        {
            return database.Table<InfoList>().ToList();
        }
        public InfoList GetItem(int num)
        {
            return database.Get<InfoList>(num);
        }
        public int DeleteItem(int num)
        {
            return database.Delete<InfoList>(num);
        }
        public int SaveItem(InfoList item)
        {
            if (item.Number != 0)
            {
                database.Update(item);
                return item.Number;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
