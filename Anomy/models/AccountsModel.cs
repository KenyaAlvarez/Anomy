using SQLite;

namespace Anomy.models
{
    public class AccountsModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string SocialMedia { get; set; }
        public ImageSource imagesource { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
