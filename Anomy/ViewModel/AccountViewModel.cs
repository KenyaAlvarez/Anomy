using Anomy.models;
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
        public async Task Volver()
        {
            await Navigation.PopAsync();
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
                    imagesource = "inatagram.png"
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
            };
        }
        #endregion
        #region Comandos
        public ICommand ProcesoAsynccommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimplecommand => new Command(accounts);
        #endregion 
    }
}
