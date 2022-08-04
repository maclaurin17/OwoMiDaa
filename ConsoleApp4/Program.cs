using System;
namespace OwoMiDaa
{
    public class CollectionPoint1
    {
        public int AmtToPay(int motorType, int noOfTrips)
        {
            int totalAmtToPay = motorType * noOfTrips;
            return totalAmtToPay;
        }
        public double UnionPay(int totalAmtTopay)
        {
            double discount = totalAmtTopay * 0.7;
            return discount;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {

            
            var collectionPoint = new CollectionPoint1();

            Console.WriteLine("Welcome to Owoda. \n Please enter your first name :");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome {0}, What is the type of your vehicle? \n Bus; 1 \n Keke; 2 \n Okada; 3 \n minibus; 4", name);
            int vehicleType = Convert.ToInt32(Console.ReadLine());
            int y;
            if (vehicleType == 1)
            {
                y = 500;
            }
            else if (vehicleType == 2)
            {
                y = 200;
            }
            else if (vehicleType == 3)
            {
                y = 100;
            }
            else if (vehicleType == 4)
            {
                y = 50;
            }
            else
            {
                y = 0;
            }
            Console.WriteLine("Enter your number of trips");
            int noOfTrips = Convert.ToInt32(Console.ReadLine());

            int result1 = collectionPoint.AmtToPay(y, noOfTrips);
            Console.WriteLine(result1);
            Console.WriteLine("Are you a union member? (Yes/No)");
            string unionMember = Console.ReadLine();
            string unionMemberSmalCase = unionMember.ToLower();
                if (unionMemberSmalCase == "yes")
                {
                    int result2 = (int)collectionPoint.UnionPay(noOfTrips);
                    Console.WriteLine("Hello {0}, you made {1} no of trips and your toll is {2}. You qualify for a discount, your new toll is {3}", name, noOfTrips, result1, result2);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Hello {0}, you made {1} trips and your toll is {2}", name, noOfTrips, result1);

                   }      }
        }

    }
}