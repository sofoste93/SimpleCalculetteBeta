using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculetteBeta
{
	class Program
	{
		public static double num1, num2;
		public static double addi, subt, mult, divi, mod;

		public static string errMsgOverFlow = "\n\t>> ERROR Over Flow! <<\n\n\t - The input value is too long.";
		public static string errMsgNull = "\n\t>> ERROR EMPTY! <<\n\n\t - The input cannot be empty.";
		public static string errMsg = "" +
			"\n\t>> FORMAT ERROR! POSSIBLE CAUSE: <<\n\n\t - Make sure your input has the correct format " +
			"\n\t - For decimal number please use ','(a comma) instead of '.'(a dot)\n" +
			"\n\t - There is no operator or invalid operator \n";
		static void Main(string[] args)
		{
			string programName = "\t\t\tMINI CALCULATOR";

			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine("\n\t--------------------------------------------------");
			Console.WriteLine(programName);
			Console.WriteLine("\tNote for this version: Select operand unavailable.");
			Console.WriteLine("\t--------------------------------------------------\n");

			char op; 

			Console.WriteLine("\n\t===============[ Your Input ]===============\n");
			try
			{
				Console.Write("\tEnter first number: ");
				num1 = Convert.ToDouble(Console.ReadLine());
				
				Console.Write("\tEnter the arithmetic operator: ");
				op = Convert.ToChar(Console.ReadLine());
				
				Console.Write("\tEnter second number: ");
				num2 = Convert.ToDouble(Console.ReadLine());

				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\n\t===============[ Result Out ]===============\n");
				
				switch (op)
				{

					case '+':
						addi = add(num1, num2);
						Console.WriteLine(addi);
						break;
					case '-':
						subt = subtract(num1, num2);
						Console.WriteLine(subt);
						break;
					case '*':
					case 'x':
						mult = multiply(num1, num2);
						Console.WriteLine(mult);
						break;
					case '/':
					case ':':
						divi = divide(num1, num2);
						Console.WriteLine(divi);
						break;
					case '%':
						mod = modulo(num1, num2);
						Console.WriteLine(mod);
						break;
					default:
						Console.WriteLine("ERROR ON OPERATOR!\n");
						break;
				}

			}
			catch (FormatException)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(errMsg + "\n");
			}
			catch (ArgumentNullException)

			{
				Console.WriteLine(errMsgNull);
			}
			catch (OverflowException)
			{
				Console.WriteLine(errMsgOverFlow);
			}
			finally
			{

				Console.ForegroundColor = ConsoleColor.Red;
			}

			Console.WriteLine("\n\t===============[ Terminated ]===============\n");
			Console.WriteLine("\n\tPress any key to quit..");
			Console.ReadKey();

		}

		// method add
		public static double add(double x, double y)
		{
			double result = x + y;
			Console.Write("\t" + "Sum = ");
			return result;
		}
		// method subtract
		public static double subtract(double x, double y)
		{
			double result = x - y;
			Console.Write("\t" + "Difference = ");
			return result;
		}
		// method multiply
		public static double multiply(double x, double y)
		{
			double result = x * y;
			Console.Write("\t" + "Product = ");
			return result;
		}
		// method divide
		public static double divide(double x, double y)
		{
			double result = x / y;
			Console.Write("\t" + "Quotient = ");
			return result;
		}
		// method modulo => rest of division
		public static double modulo(double x, double y)
		{
			double result = x % y;
			Console.Write("\t" + "Rest of division = ");
			return result;
		}

	}
}
