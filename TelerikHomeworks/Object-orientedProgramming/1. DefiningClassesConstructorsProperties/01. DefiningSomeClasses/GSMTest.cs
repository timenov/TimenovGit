using System;

namespace _01.DefiningSomeClasses
{
    class GSMTest
    {
        static void Main()
        {
            Console.Write("Phones to be set: ");
            int numberOfPhones = int.Parse(Console.ReadLine());
            GSM[] phones = new GSM[numberOfPhones];

            for (int i = 0; i < numberOfPhones; i++)
            {
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Manufacturer: ");
                string manufacturer = Console.ReadLine();
                phones[i] = new GSM(model, manufacturer);

                Console.Write("Price: ");
                phones[i].Price = decimal.Parse(Console.ReadLine());
                Console.Write("Owner: ");
                phones[i].Owner = Console.ReadLine();
                Console.Write("battery model: ");
                phones[i].Battery.Model = Console.ReadLine();
                Console.Write("idle time: ");
                phones[i].Battery.IdleTime = float.Parse(Console.ReadLine());
                Console.Write("talking time: ");
                phones[i].Battery.TalkingTime = float.Parse(Console.ReadLine());
                Console.Write("battery type (0 - LiPoly, 1 - LiIon, 2 - NiCd, 3 - NiMH): ");
                phones[i].Battery.Type = (BatteryType)int.Parse(Console.ReadLine());
                Console.Write("display height: ");
                phones[i].Display.Height = int.Parse(Console.ReadLine());
                Console.Write("display width: ");
                phones[i].Display.Width = int.Parse(Console.ReadLine());
                Console.Write("display colors: ");
                phones[i].Display.Colors = uint.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-', 50));
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Call history test!\n");
            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}
