using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DistribuidoraAriel.Services
{
    public class ServicesDistribuidora
    {
        private SQLiteAsyncConnection ConBD;

        public ServicesDistribuidora(string PathCon)
        {
            ConBD = new SQLiteAsyncConnection(PathCon);

        }
    }
}
