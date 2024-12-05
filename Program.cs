using System;

//PRE: rep 3 números
namespace ProjecteProva2
{
    public class Program
    {
        public static int WriteValue()
        {
            const string FormatError = "Format del valor incorrecte";
            const string Error = "Error";
            try
            {
                return Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(FormatError);
                return -1;
            }
            catch (Exception)
            {
                Console.WriteLine(Error);
                return -1;
            }
        }
        public static bool IsInRange(int num, int min, int max)
        {
            return num >= min && num <= max;
        }
        public static int FindNumberOdDaysInAMonth(int month, int year)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else
            {
                if (month == 2)
                {
                    if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                else
                {
                    return 30;
                }
            }
        }
        public static void Main()
        {
            const string WriteDay = "Introdueix el dia";
            const string WriteMonth = "Introdueix el mes";
            const string WriteYear = "Introdueix el any";
            const string RigthDate = "Data correcta";
            const string WrongDate = "Data incorrecta";
            int dia;
            int mes;
            int any;
            int totalDaysMonth;
            bool validat;

            Console.WriteLine(WriteDay);
            dia = WriteValue();
            Console.WriteLine(WriteMonth);
            mes = WriteValue();
            Console.WriteLine(WriteYear);
            any = WriteValue();
            if (dia == -1 || mes == -1 || any == -1)
            {
                validat = false;
            }
            else
            {
                validat = IsInRange(mes, 1, 12);
                if (validat)
                {
                    totalDaysMonth = FindNumberOdDaysInAMonth(mes, any);
                    validat = IsInRange(dia, 1, totalDaysMonth);
                }

            }
            if (validat)
            {
                Console.WriteLine(RigthDate);
            }
            else
            {
                Console.WriteLine(WrongDate);
            }
        }
    }
}
//POST: retorna si els números (dd, mm, yyyy) estan dins del rang de data corresponent