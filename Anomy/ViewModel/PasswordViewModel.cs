using Anomy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Anomy.ViewModel
{
   public class PasswordViewModel : BaseViewModel
    {
        #region Variables
        string _Texto;
        #endregion
        #region Constructor
        public PasswordViewModel(INavigation navigation)
        {
            Navigation = navigation;
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
        public async Task returnpage()
        {
            await Navigation.PushAsync(new Accounts());
        }
        //public void accounts()
        //{
            
        //}
        #endregion
        #region Comandos
        public ICommand returnpagecommand => new Command(async () => await returnpage());
        //public ICommand ProcesoSimplecommand => new Command(accounts);
        #endregion 
    }

}

