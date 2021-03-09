using System;

namespace Lucky_Ticket_NET5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press K to exit");
            while (true)
            {
                Console.WriteLine("Please, enter your ticket number:");
                string number = Console.ReadLine();
                if (number == "k") break;
                int num;
                bool flag = false;
                while (flag == false)
                {
                    Console.WriteLine("You entered number is: " + number);
                    if ((number.Length > 8) || (number.Length < 4))
                    {
                        Console.WriteLine("The Ticket's number should be from 4 to 8 digits length!");
                        break;
                    }
                    if (int.TryParse(number, out num))
                    {
                        if (((number.Length) % 2) != 0)
                        {
                            number = "0" + number;
                        }
                        int sum1 = 0, sum2 = 0;
                        for (int i = 0; i < number.Length; i++)
                        {
                            if (i < (number.Length / 2)) sum1 += number[i] - '0';
                            else sum2 += number[i] - '0';
                        }
                        Console.WriteLine("Your number of ticket is " + number);
                        Console.WriteLine("Sum is " + sum1 + " and " + sum2);
                        if (sum1 == sum2)
                        {
                            Console.WriteLine("Sum first half of your ticket is equal to the sum of second half. Your ticket is Lucky!");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Try another ticket to catch a Luck!");
                            flag = true;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The entered value should consists of digits only!");
                        break;
                    }
                }
            }
        }
    }
}
