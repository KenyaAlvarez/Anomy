using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anomy.models
{
    public class AccountsModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string SocialMedia { get; set; }
        public string imagesource { get; set; }
    }
}
