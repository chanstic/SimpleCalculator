using SimpleCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleCalculator.Services
{
    public class GetNumbersAction : IGetNumbersFromSouce
    {
        public CalculatorModel GetNumbers()
        {
            //throw new NotImplementedException();

            CalculatorModel calculator = new CalculatorModel();

            string xmlFileName = System.IO.Path.Combine(Environment.CurrentDirectory, "Assets/Data/Numbers.xml");
            XDocument xDoc = XDocument.Load(xmlFileName);
            XElement number = xDoc.Root.Element("Numbers");

            calculator.FirstNumber = double.Parse(number.Element("FirstNumber").Value);
            calculator.SecondNumber = double.Parse(number.Element("SecondNumber").Value);

            return calculator;
        }
    }
}
