namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to enter a decimal number
            Console.Write("Enter a decimal number: ");

            //convert the given string to an integer
            int decimalNumber = Convert.ToInt32((Console.ReadLine()));

            //convert the decimal number to binary with using a while loop
            int[] binaryDigits = new int[32]; // max 32-bit binary number
            int i = 0;
            while (decimalNumber > 0)
            {
                //store the binary digits in an array
                binaryDigits[i] = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                i++;
            }

            //print the binary number in reverse order
            Console.Write("The binary representation for this number is: ");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binaryDigits[j]);
            }
            Console.WriteLine();
        }
        }
    }