using System;
using System.Globalization;
using System.Xml;

namespace testing
{
    public class Program 
    {

        public static void Main (String[] args) 
        {
            Console.Write("What is your name?\nName: ");
            string name = Console.ReadLine();
            Console.Write("Hello " + name + "! My name is SYSTEM-5353.\nDo you want to listen music?\nWrite Yes or No.\nAnswer: ");
            Answering();
        }

        public static void Answering()
        {
            var command = Console.ReadLine().ToLower();
            switch (command)
            {
                case "yes":
                    ShowMusic();
                    break;
                case "no":
                    Console.Write("Closing program..");
                    Environment.Exit(1);
                    break;
                default:
                    Console.Write("Error, please, try again!\nAnswer: ");
                    Answering();
                    break;
            }
        }
        public static void ShowMusic() 
      {
            Console.Write("Choose type of music that you're prefer:\n1) K-pop\n2) Rock\n3) Rap\n4) Hip-hop\n5) Jazz\nInput: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("BTS - Sea");
                    break;
                case 2:
                    Console.WriteLine("Nirvana - teen spirit");
                    break;
                case 3:
                    Console.WriteLine("Eminem - lose yourself");
                    break;
                case 4:
                    Console.WriteLine("Noize MC - Chasing the Horizon");
                    break;
                case 5:
                    Console.WriteLine("Louis Armstrong - What a Wonderful World");
                    break;
            }
            Console.Write("Do you want to exit or continue?\nPlease, choose Yes or No.\nAnswer: ");
            Answering();

           /* int a = scan.nextInt();
            if (a == 1)
                System.out.println("BTS - Sea");
            if (a == 2)
                System.out.println("Nirvana - teen spirit");
            if (a == 3)
                System.out.println("Eminem - lose yourself");
            if (a == 4)
                System.out.println("Noize MC - Chasing the Horizon");
            if (a == 5)
                System.out.println("Louis Armstrong - What a Wonderful World");
            System.out.print("Do you want to exit or continue?\nPlease, choose Yes or No.\nAnswer: ");
            CheckAnswer(scan);
        }

        public static void CheckAnswer(Scanner scan)
        {
            String answer = scan.next().toLowerCase();
            if (answer.equals("yes"))
                ShowMusic(scan);
            else if(answer.equals("no"));

            else {
                System.out.print("Please, choose Yes or No.\nAnswer: ");
                CheckAnswer(scan); 
            } */
        } 
    } 
}