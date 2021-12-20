using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Enaip.Exercise.Common
{
    public class CalculatorHelper
    {
        public CalculatorHelper()
        {
            var streamWriter = File.CreateText("CalculatorHelper.Log");
            streamWriter.WriteLine("Testo da Loggare");
            Trace.Listeners.Add(new TextWriterTraceListener(streamWriter));
            Trace.AutoFlush = true;
            Trace.WriteLine("CalculatorHelper Inizializzato");
            Trace.WriteLine($"Partenza ore {DateTime.Now}");
        }

        public double DoOperation(double num1, double num2, string op)
        {

            Trace.WriteLine("Sono entrato in DoOperation");


            /*
            op è l'operazione da eseguire:
		        - a è aggiungere
		        - s è sottrarre
		        - m è moltiplicare
		        - d è dividere (se il secondo numero è diverso da 0)
		        - altrimenti gli passiamo double.NaN (valore di default)
            */

            double result = double.NaN; // Default value "not-a-number" 

            #region alternativa on if-else
            /*
             * 
             * questa è un'alternativa
             * 
             * 
            if (op == "a")
            {
                result = num1 + num2;
            }
            else if (op == "s")
            { 
                result = num1 - num2;
            }
            else if (op == "m")
            {
                result = num1 * num2;
            }
            else if (op == "d")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
            }

            return result;
*/
            #endregion alternativa

            switch (op.ToLower())
            {
                case "a":
                    result = num1 + num2;
                    Trace.WriteLine($"{ num1} + { num2} = { result}");
                    break;
                case "s":
                    result = num1 - num2;
                    Trace.WriteLine(String.Format("{0} - {1} = {2}", num1 , num2));
                    break;
                case "m":
                    result = num1 * num2;
                    Trace.WriteLine($"{ num1} * { num2} = { result}");
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Trace.WriteLine($"{ num1} / { num2} = { result}");
                    }
                    break;
                default:
                    Trace.WriteLine($"Nessuna operazione");
                    break;
            }
            return result;
        }
    }
}
