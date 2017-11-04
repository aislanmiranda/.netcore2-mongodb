using System;
using System.Collections.Generic;
using System.Text;

namespace a82.Data
{
    public static class Settings
    {
        public static string MongoConnection { get { return "mongodb://localhost:9000"; }  }

        public static string Database { get { return "DBTeste"; } }

    }
}
