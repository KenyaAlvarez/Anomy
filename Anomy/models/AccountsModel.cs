using SQLite;

namespace Anomy.Models
{
    public class AccountsModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string SocialMedia { get; set; }
        public string imagesource { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
