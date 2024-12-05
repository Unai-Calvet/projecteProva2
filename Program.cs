using System;
using Prova;
// S'ordena amb el Merge Sort, perquè és més ràpid que el quick sort si l'ordre dels números a ordenar no s'asembla a la combinació ordenada.

namespace ProjecteProva2 {
    public class Program {
        public static void Main() {
            const string FromatError = "Format incorrecte.";
            const string Error = "Error";
            const string WriteNumberToSearch = "Indrodueix un numero enter: ";
            const string NumberIn = "El número és a l'interval.";
            const string NumberNotIn = "El número no és a l'interval.";
            int[] array = new int [] { 10, -4, 6, 4, 8, 13, 2, -4 };
            Console.WriteLine(WriteNumberToSearch);
            try
            {
                int numberToSearch = Convert.ToInt32(Console.ReadLine());
                if (SearchClass.BinarySearch(FirstSort.Order(array, array[0], array[array.Length - 1]), -4, 13, numberToSearch) == numberToSearch)
                {
                    Console.WriteLine(NumberIn);
                }
                else {
                    Console.WriteLine(NumberNotIn);
                }
            }
            catch (FormatException) {
                Console.WriteLine(FromatError);
            }
            catch (Exception) {
                Console.WriteLine(Error);
            }
        }
    }
}