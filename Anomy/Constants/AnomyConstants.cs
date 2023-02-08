﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anomy.Constants
{
    public static class AnomyConstants
    {
        public const string DataBaseFileName = "AnomyDb";

        public const SQLite.SQLiteOpenFlags Flags = SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DataBaseFileName);
            }
        }
    }
}
