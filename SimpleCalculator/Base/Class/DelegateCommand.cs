using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleCalculator.Base.Class
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();

            if (DoCanExecute != null)
            {
                return DoCanExecute.Invoke(parameter);
            }

            return false;

        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();

            if (DoExecute != null)
            {
                DoExecute.Invoke(parameter);
            }
        }

        public Func<object, bool> DoCanExecute { get; set; }

        public Action<object> DoExecute { get; set; }
    }
}
