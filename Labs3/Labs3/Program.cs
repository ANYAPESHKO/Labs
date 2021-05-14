using System;


namespace Labs3
{
    class Transport
    {
        private string manufactureCountry;
        private int ID;
        private static int id;
        private int maxSpeed;
        //private string fuel;
        private int mileAge;

        bool[] wheels = new bool[4] { true, true, true, true };

        public bool this[int index]
        {
            get
            { if (index > 4) return false;
                else return wheels[index - 1];
            }
            set
            { if (index > 0 && index <= 4) 
                    wheels[index - 1] = value; }
                
        }

        static Transport()
        {
            id = 0;
        }

        public Transport() {
           // fuel = "petrol";
            manufactureCountry = "USA";
            maxSpeed = 75;
            ID = ++id;
            mileAge = 100000;
           

        }
        public Transport(int _maxSpeed)
        {
         //   fuel = "gas";
            manufactureCountry = "France";
            maxSpeed = _maxSpeed;
            ID = ++id;
            mileAge = 120000;
           

        }
        public Transport(string _manufactureCountry)
        {
          //  fuel = "diesel";
            manufactureCountry = _manufactureCountry;
            maxSpeed = 50;
            ID = ++id;
            mileAge = 80000;
           
        }

        public Transport(int _maxSpeed, string _manufactureCountry)
        {
           // fuel = "electricity";
            manufactureCountry = _manufactureCountry;
            maxSpeed = _maxSpeed;
            ID = ++id;
            mileAge = 150000;
            

        }

        public void PrintInfo() => Console.WriteLine("ID : {0}, MAXSPEED : {1}, FROM : {2}, MILEAGE : {3}",
            ID, maxSpeed, manufactureCountry, /*fuel*/ mileAge);

        public void Go(int delta) => mileAge += delta;

        public  void CheckWheels (Transport car)
        {
            for (int i = 1; i <= 4; i++)
            {
                if (car[i] == false)
                {
                    Console.WriteLine("your car has " + i + " broken wheel");
                }
                else
                {
                    Console.WriteLine("wheel " + i + " works");
                }
            }
        }

        public void CheckWheels(Transport car, int random)
        { 
            for (int j = 1; j <= 4; j++)
            {
                if (random == 0)
                    car[j] = true;
                else car[j] = false;
            }
            Go(50);
        }   
    }


    class Program
    {
        public static void Music()
        {
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(329, 500);
            Console.Beep(247, 500);
            Console.Beep(247, 500);
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(497, 500);
            Console.Beep(497, 500);
            Console.Beep(277, 500);
            Console.Beep(277, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(329, 500);
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(329, 500);
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(0,1);

            Transport car1 = new Transport();
            Transport car2 = new Transport(80);
            Transport car3 = new Transport("Germany");
            Transport car4 = new Transport(90, "Japan");

            for(int i=1; i<=4; i++)
            {
                car1[i] = false;  car2[i] = true;
                if (i % 2 == 0)
                { car3[i] = true; car4[i] = false;
                }else{
                    car3[i] = false; car4[i] = true;
                }
            }
            
            
            while (true)
            {
                Console.WriteLine("1.Print all\n" +
                                         "2.Сhoose a car\n" +
                                         "3.Exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    car1.PrintInfo();
                    car2.PrintInfo();
                    car3.PrintInfo();
                    car4.PrintInfo();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the number of the car you want to take:");
                    car1.PrintInfo();
                    car2.PrintInfo();
                    car3.PrintInfo();
                    car4.PrintInfo();
                    int currentСar = int.Parse(Console.ReadLine());
                    if(currentСar==1)
                    {
                        Console.WriteLine("Your car:\n");
                        car1.PrintInfo();
                        Console.WriteLine("1.Turn on music\n" + "2.Check wheels\n"+ "3.Go to a car service\n" );
                        int choiceUser = int.Parse(Console.ReadLine());
                        switch (choiceUser)
                        {
                            case 1: Music(); break;
                            case 2: car1.CheckWheels(car1); break;
                            case 3: car1.CheckWheels(car1, random); break;
                        }
                    }
                    if (currentСar == 2)
                    {
                        Console.WriteLine("Your car:\n");
                        car2.PrintInfo();
                        Console.WriteLine("1.Turn on music\n" + "2.Check wheels\n" + "3.Go to a car service\n" );
                        int choiceUser = int.Parse(Console.ReadLine());
                        switch (choiceUser)
                        {
                            case 1: Music(); break;
                            case 2: car2.CheckWheels(car2); break;
                            case 3: car2.CheckWheels(car2, random); break;
                        }
                    }
                    if (currentСar == 3)
                    {
                        Console.WriteLine("Your car:\n");
                        car3.PrintInfo();
                        Console.WriteLine("1.Turn on music\n" + "2.Check wheels\n" + "3.Go to a car service\n" + "4.Back");
                        int choiceUser = int.Parse(Console.ReadLine());
                        switch (choiceUser)
                        {
                            case 1: Music(); break;
                            case 2: car3.CheckWheels(car3); break;
                            case 3: car3.CheckWheels(car3, random); break;
                        }
                    }
                    if (currentСar == 4)
                    {
                        Console.WriteLine("Your car:\n");
                        car4.PrintInfo();
                        Console.WriteLine("1.Turn on music\n" + "2.Check wheels\n" + "3.Go to a car service\n" );
                        int choiceUser = int.Parse(Console.ReadLine());
                        switch (choiceUser)
                        {
                            case 1: Music(); break;
                            case 2: car4.CheckWheels(car4); break;
                            case 3: car4.CheckWheels(car4, random); break;
                        }
                    }

                }
                else return;
            }
            
            Console.ReadKey();
        }

    }

}
