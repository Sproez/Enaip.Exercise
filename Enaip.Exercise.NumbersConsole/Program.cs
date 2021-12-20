using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enaip.Exercise.Common;



namespace Enaip.Exercise.NumbersConsole
{
    class Program
    {
        static void Main(string[] args)

        {
            CalculatorHelper helper = new CalculatorHelper();
            Console.WriteLine("Calculator Console in C#"); //opzionale 

            bool endApp = false;

            //masimo 10 interazioni



            for (var i = 0; i < 9 || endApp == true; i++);
            {

                while (!endApp)

                {
                    
                    Console.WriteLine();

                    // dichiaro variabili 
                    double numero1 = 0;
                    double numero2 = 0;
                    double risultato = 0;
                    string numInput1 = "";
                    string numInput2 = "";
                    string operationInput = "";

                    //richiesta all'utente del primo numero
                    Console.Write("Inserisci un numero e premi invio: ");
                    //lettura
                    numInput1 = Console.ReadLine();
                    while (!double.TryParse(numInput1, out numero1))
                    {
                        Console.Write("Carattere non valido. Inserisci caratteri numerici: ");
                        numInput1 = Console.ReadLine();
                    }

                    //richiesta all'utente del secondo numero
                    Console.Write("Inserisci un altro numero e premi invio: ");
                    //lettura
                    numInput2 = Console.ReadLine();
                    while (!double.TryParse(numInput2, out numero2))
                    {
                        Console.Write("Carattere non valido. Inserisci caratteri numerici: ");
                        numInput2 = Console.ReadLine();
                    }

                    //richiesta tipo operazione (quali sono disponibili)
                    Console.WriteLine("Scegli un operatore dalla seguente lista:");
                    Console.WriteLine("\ta - Aggiungi");
                    Console.WriteLine("\ts - Sottrai");
                    Console.WriteLine("\tm - Moltiplica");
                    Console.WriteLine("\td - Dividi");
                    Console.Write("Digita opzione scelta e premi invio: ");
                    operationInput = Console.ReadLine();

                    

                    risultato = CalculatorHelper.DoOperation(numero1, numero2, operationInput);

                    //output risultato
                    if (double.IsNaN(risultato))
                    {
                        Console.WriteLine("Operatore non riconosciuto o operazione in errore.");
                    }
                    else
                    {
                        Console.WriteLine("Risultato: {0:0.##}", risultato);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Premi 'u' per uscire altrimenti premi un qualsiasi tasto e invio per continuare");

                    if (Console.ReadLine() == "u")
                        endApp = true;

                }



            }
           

        }

      
    
    }
}
