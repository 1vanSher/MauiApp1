using SQLite;

namespace MauiApp1.Platforms.Android
{
    public class radiotable
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string songer { get; set; }

        public string song { get; set; }

        public string time { get; set; }
    }
}
