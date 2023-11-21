using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_distruttore
{
    class Esempio : IDisposable
    {
        // Attributi
        private string stringa;
        private int numero;

        // Costruttore senza parametri
        public Esempio()
        {
            Console.WriteLine("Costruttore senza parametri chiamato.");
            stringa = "Casa di Jotroop";
            numero = 0;
        }

        // Costruttore con parametri
        public Esempio(string inputStringa, int inputNumero)
        {
            Console.WriteLine("Costruttore con parametri chiamato.");
            stringa = inputStringa;
            numero = inputNumero;
        }

        // Metodi accessor
        public string GetStringa()
        {
            return stringa;
        }

        public int GetNumero()
        {
            return numero;
        }

        // Distruttore
        ~Esempio()
        {
            Console.WriteLine("Distruttore chiamato. Pulizia delle risorse non gestite.");
        }

        // Implementazione dell'interfaccia IDisposable
        public void Dispose()
        {
            Console.WriteLine("Dispose chiamato. Pulizia delle risorse gestite.");
            GC.SuppressFinalize(this); // Impedisce al GC di chiamare il distruttore dopo il Dispose
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Creazione dell'istanza di esempio.");
            using (Esempio esempio = new Esempio("Hello", 42))
            {
                Console.WriteLine($"Stringa: {esempio.GetStringa()}, Numero: {esempio.GetNumero()}");
            }

            Console.WriteLine("L'oggetto esempio è stato distrutto o eliminato.");
            Console.ReadLine();
        }
    }
}
