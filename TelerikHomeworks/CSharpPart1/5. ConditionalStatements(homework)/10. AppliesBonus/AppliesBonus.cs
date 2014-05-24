using System;

    class AppliesBonus
    {
        static void Main()
        {
            Console.Write("Please enter number between 1 and 9: ");
            int key = int.Parse(Console.ReadLine());

            switch (key)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your score is {0}", key * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Your score is {0}", key * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Your score is {0}", key * 1000);
                    break;
                default:
                    Console.WriteLine("Invalid number!");
                    break;
            }
        }
    }