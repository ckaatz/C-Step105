using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step105
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Division = new List<int> { 10, 20, 50 };
                Console.WriteLine("Pick a number to divide the list by:");
                int Num1 = Convert.ToInt32(Console.ReadLine());

                foreach (int Div in Division)
                {
                    Console.WriteLine("No errors occurred!");
                    Console.WriteLine(Div / Num1);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by 0.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
