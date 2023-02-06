using Anomy.models;
using Anomy.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Anomy.ViewModel
{
    public class AccountViewModel : BaseViewModel
    {
        #region Variables
        string _Texto;
        public List<AccountsModel> Accountslist { get; set; }
        #endregion
        #region Constructor
        public AccountViewModel(INavigation navigation)
        {
            Navigation = navigation;
            accounts();
        }
        #endregion
        #region Objetos
        public string Texto
        {
            get { return _Texto; } 
            set { _Texto = value; }
        }
        #endregion
        #region Procesos
        public async Task addCommand()
        {
            await Navigation.PushAsync(new PasswordPage());
        }
        public void accounts()
        {
            Accountslist = new List<AccountsModel>
            { 
                new AccountsModel
                {
                    SocialMedia = "Facebook",
                    imagesource = "facebook.png"
                },
                new AccountsModel
                {
                    SocialMedia = "Github",
                    imagesource = "github.png"
                },
                new AccountsModel
                {
                    SocialMedia = "Instagram",
                    imagesource = "instagram.png"
                },
                new AccountsModel
                {
                    SocialMedia = "Dropbox",
                    imagesource = "dropbox.png"
                },
                new AccountsModel
                {
                    SocialMedia = "Amazon",
                    imagesource = "amazon.png"
                },
                 new AccountsModel
                {
                    SocialMedia = "BVVA",
                    imagesource = "bvva.png"
                },
                    new AccountsModel
                {
                    SocialMedia = "Discord",
                    imagesource = "discord.png"
                },
                    new AccountsModel
                {
                    SocialMedia = "App store",
                    imagesource = "appstore.png"
                },
            };
        }
        #endregion
        #region Comandos
        public ICommand addcommand => new Command(async () => await addCommand());
        //public ICommand ProcesoSimplecommand => new Command(accounts);
        #endregion 
    }
}
