using SQLite;


namespace MauiApp1.Platforms.Android
{
    public class dbconn
    {
        private readonly SQLiteConnection conn;

        public dbconn(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<radiotable>();
        }

        public List<radiotable> GetAll()
        {
            return conn.Table<radiotable>().ToList();
        }

        public int Save(radiotable item)
        {
            return conn.Insert(item);
        }

        public int Delete(radiotable item)
        {
            return conn.Delete(item);
        }
        public int Update(radiotable item)
        {
            return conn.Update(item);
        }

    }
}
