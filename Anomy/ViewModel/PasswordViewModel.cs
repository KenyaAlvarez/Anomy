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
        public async Task nextpage()
        {
            await Navigation.PushAsync(new InfoPage());
        }
        //public void accounts()
        //{
            
        //}
        #endregion
        #region Comandos
        public ICommand nextpagecommand => new Command(async () => await nextpage());
        //public ICommand ProcesoSimplecommand => new Command(accounts);
        #endregion 
    }

}

