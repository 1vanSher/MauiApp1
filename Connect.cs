using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Platforms.Android
{
    public class Connect : Application
    {
        private static dbconn db;

        public static dbconn Db
        {
            get
            {
                if (db == null)
                {
                    db = new dbconn(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "radio.db"));
                }
                return db;
            }
        }
    }
}
