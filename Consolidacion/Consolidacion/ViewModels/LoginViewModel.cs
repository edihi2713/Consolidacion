using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Consolidacion.ViewModels
{
    using System.Windows.Input;

    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsRunning { get; set; }
        public bool IsRemembered { get; set; }




        #region Commands

        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructores

        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
  
        #endregion




    }
}
