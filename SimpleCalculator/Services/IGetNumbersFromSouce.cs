using SimpleCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
    interface IGetNumbersFromSouce
    {
        CalculatorModel GetNumbers();
    }
}
