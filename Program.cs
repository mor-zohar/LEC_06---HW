using System.Diagnostics.Metrics;
using System.Drawing;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------- EX_1: ----------------");
        Console.WriteLine("---------------------------------------\n");
        /*
                int a, b, c = 0,num;
                Console.WriteLine("Enter 3 Digit Number: \n");
                a=int.Parse(Console.ReadLine());

                num = a;

                while (a > 0)
                {
                    b = a % 10;
                    c = (c * 10) + b;
                    a = a / 10;
                }
                if (num == c)
                {
                    Console.WriteLine($"\nYour Number \"{num}\" Is Palindrome");
                }
                else
                {
                    Console.WriteLine($"\nYour Number \"{num}\" Is Not Palindrome");
                }
        */
        Console.WriteLine("\n---------------------------------------\n");
        /*************************************************************************************/

        Console.WriteLine("\n---------------- EX_2: ----------------");
        Console.WriteLine("---------------------------------------\n");
        /*
        Console.WriteLine("Enter A Number Between 1-10:\n");
        int.TryParse(Console.ReadLine(), out int a);
        Console.WriteLine();

        PrintNumberName(a);
        */
        Console.WriteLine("\n---------------------------------------\n");
        /*************************************************************************************/

        Console.WriteLine("\n---------------- EX_3: ----------------");
        Console.WriteLine("---------------------------------------\n");
        /*
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        */
        Console.WriteLine("\n---------------------------------\n");

        Console.WriteLine("\n------------ EX_3_A: ------------");
        Console.WriteLine("---------------------------------\n");

        int a;
        // PrintNumber1To10(out a);

        Console.WriteLine("\n---------------------------------\n");

        Console.WriteLine("\n------------ EX_3_B: ------------");
        Console.WriteLine("---------------------------------\n");


        // PrintNumbers(out int number);

        Console.WriteLine("\n---------------------------------\n");

        Console.WriteLine("\n------------ EX_3_C: ------------");
        Console.WriteLine("---------------------------------\n");

        //PrintNumber();

        Console.WriteLine("\n---------------------------------\n");
        Console.WriteLine("---------------------------------------\n");
        /*************************************************************************************/

        Console.WriteLine("\n---------------- EX_4: ----------------");
        Console.WriteLine("---------------------------------------\n");

        // IsPrime();

        Console.WriteLine("---------------------------------------\n");
        /*************************************************************************************/

        Console.WriteLine("\n---------------- EX_5: ----------------");
        Console.WriteLine("---------------------------------------\n");
        /*
        int[] arr = { 2, 4, 9, 13, 17 };
        CheckArray(arr);
        */

        Console.WriteLine("---------------------------------------\n");
        /*************************************************************************************/

        Console.WriteLine("\n---------------- EX_6: ----------------");
        Console.WriteLine("---------------------------------------\n");
        /*
        int[] arr1 = { 1, 3, 7, 5, 2};
        int[] arr2 = { 4, 9, 3, 1, 8 };
        WhichArrayIsBigger(arr1,arr2);
        */

        Console.WriteLine("---------------------------------------\n");
        /*************************************************************************************/
    }
    //---------------- EX_2: ----------------
    static void PrintNumberName(int num)
    {
        switch (num)
        {
            case 1:
                Console.WriteLine("YOUR NUMBER IS: \"ONE\"");
                break;
            case 2:
                Console.WriteLine("YOUR NUMBER IS: \"TWO\"");
                break;
            case 3:
                Console.WriteLine("YOUR NUMBER IS: \"THREE\"");
                break;
            case 4:
                Console.WriteLine("YOUR NUMBER IS: \"FOUR\"");
                break;
            case 5:
                Console.WriteLine("YOUR NUMBER IS: \"FIVE\"");
                break;
            case 6:
                Console.WriteLine("YOUR NUMBER IS: \"SIX\"");
                break;
            case 7:
                Console.WriteLine("YOUR NUMBER IS: \"SEVEN\"");
                break;
            case 8:
                Console.WriteLine("YOUR NUMBER IS: \"EIGHT\"");
                break;
            case 9:
                Console.WriteLine("YOUR NUMBER IS: \"NINE\"");
                break;
            case 10:
                Console.WriteLine("YOUR NUMBER IS: \"TEN\"");
                break;
            default:
                Console.WriteLine("NUMBER NOT IN RANGE");
                break;
        }
    }
    /*************************************************************************************/

    //---------------- EX_3_A: ----------------
    static void PrintNumber1To10(out int a)
    {
        for (a = 1; a <= 10; a++)
        {
            Console.WriteLine(a);
        }
    }
    /******************************************/

    //---------------- EX_3_B: ----------------
    static void PrintNumbers(out int number)
    {
        Console.WriteLine("Enter Until Which Number You Want To Print:");
        int.TryParse(Console.ReadLine(), out number);

        Console.WriteLine($"\nCount Until: {number}\n");
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }

    //---------------- EX_3_C: ----------------

    static bool PrintNumber()
    {
        Console.WriteLine("Enter A Number Between 1 To 10:\n");
        int.TryParse(Console.ReadLine(), out int number1);

        if (number1 >= 1 && number1 <= 10)
        {
            Console.WriteLine("\nYour Number Is \"True\"");
            return true;
        }
        else
        {
            Console.WriteLine("\nYour Number Is \"False\"");
            return false;

        }

        Console.WriteLine(number1);

    }

    /*************************************************************************************/

    //---------------- EX_4: ----------------

    static void IsPrime()
    {
        int m;
        Console.WriteLine("Enter Number to check Prime:\n");
        int.TryParse(Console.ReadLine(), out int num);
        m = num / 2;

        for (int i = 2; i <= m; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine($"\n\"{num}\" Is Not Prime!!");
                break;
            }
            else
            {
                Console.WriteLine($"\n\"{num}\" Is A Prime!!");
                break;
            }
        }

    }
    /*************************************************************************************/

    //---------------- EX_5: ----------------

    static void CheckArray(int[] arr)
    {
        int arrayLength = arr.Length - 1;
        int arrayPosition = arr[0];


        while (arrayLength >= 0)
        {
            int c = 0;
            for (int i = 1; i <= arrayPosition; i++)
            {
                if (arrayPosition % i == 0)
                {
                    c++;
                }
            }
            if (c == 2)
            {
                Console.WriteLine($"\"{arrayPosition}\" Is A Prime");
            }
            else
            {
                Console.WriteLine($"\"{arrayPosition}\" Is Not A Prime");
            }
            arrayPosition++;
            arrayLength--;

        }
    }
    /*************************************************************************************/

    //---------------- EX_6: ----------------

    static void WhichArrayIsBigger(int[] arr1, int[] arr2)
    {
        int result1 = 0;
        int result2 = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            result1 += arr1[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            result2 += arr2[i];
        }
        Console.WriteLine($"arr1 = {result1}\narr2 = {result2}\n");
        if(result1 > result2)
        {
            Console.WriteLine("arr1 Is Bigger");
        }
        else if (result1 < result2)
        {
            Console.WriteLine("arr2 Is Bigger");
        }
        else
        {
            Console.WriteLine("arr1 = arr2");
        }
    }
}