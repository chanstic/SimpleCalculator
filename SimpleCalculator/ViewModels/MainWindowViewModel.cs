using SimpleCalculator.Base.Class;
using SimpleCalculator.Models;
using SimpleCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {
        //计算器三个属性
        private double _firstNumber;

        public double FirstNumber
        {
            get { return _firstNumber; }
            set 
            { 
                _firstNumber = value;
                RaisePropertyChanged(nameof(FirstNumber));
            }
        }

        private double _secondNumber;

        public double SeconeNumber
        {
            get { return _secondNumber; }
            set 
            { 
                _secondNumber = value;
                RaisePropertyChanged(nameof(SeconeNumber));
            }
        }

        private double _result;

        public double Result
        {
            get { return _result; }
            set 
            { 
                _result = value;
                RaisePropertyChanged(nameof(Result));
            }
        }

        //计算器的加法方法
        public DelegateCommand SumDelegateCommand { get; set; }

        //计算器从数据源获取数据的方法
        public DelegateCommand GetNumbersDelegateCommand { get; set; }


        //初始化计算器的View Model
        public MainWindowViewModel()
        {
            //初始化加法方法
            SumDelegateCommand = new DelegateCommand();
            SumDelegateCommand.DoCanExecute = new Func<object, bool>(o => true);
            SumDelegateCommand.DoExecute = new Action<object>(o => { Result = FirstNumber + SeconeNumber; });

            //初始化获取数据方法
            GetNumbersDelegateCommand = new DelegateCommand();
            GetNumbersDelegateCommand.DoCanExecute = new Func<object, bool>(o => true);
            GetNumbersDelegateCommand.DoExecute = new Action<object>(o =>
              {
                  GetNumbersAction getNumbersAction = new GetNumbersAction();
                  CalculatorModel calculatorModel = getNumbersAction.GetNumbers();
                  FirstNumber = calculatorModel.FirstNumber;
                  SeconeNumber = calculatorModel.SecondNumber;
              });
        }




    }
}
