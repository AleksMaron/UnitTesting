using System;

namespace ConsoleAccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();


        }

        static void Exercise1()
        {
            Console.WriteLine("Exercise 1:");

            RentCar c1 = new RentCar();
            c1.CarNumber = 234568;
            c1.CarType = "Volvo";
            c1.RentPrice = 20;
            RentCar c2 = new RentCar(146545);
            c2.CarType = "Audi";
            c2.RentPrice = 30;
            RentCar c3 = new RentCar(493257, "Mazda");
            c3.RentPrice = 27.5;
            RentCar c4 = new RentCar(391556, "Subaru", 25.5);

            Console.WriteLine("{0}, {1}, {2}$. The car was on rent for {3} days.",
                              c1.CarNumber, c1.CarType, c1.RentPrice, c1.DaysOnRent);
            Console.WriteLine("{0}, {1}, {2}$. The car was on rent for {3} days.",
                              c2.CarNumber, c2.CarType, c2.RentPrice, c2.DaysOnRent);
            Console.WriteLine("{0}, {1}, {2}$. The car was on rent for {3} days.",
                              c3.CarNumber, c3.CarType, c3.RentPrice, c3.DaysOnRent);
            Console.WriteLine("{0}, {1}, {2}$. The car was on rent for {3} days.",
                              c4.CarNumber, c4.CarType, c4.RentPrice, c4.DaysOnRent);

        }
    }


    class RentCar
    {
        int carNumber;
        string carType;
        double rentPrice;
        int daysOnRent;

        public RentCar() : this(default(int))
        {

        }

        public RentCar(int carNumber) : this(carNumber, default(string))
        {

        }

        public RentCar(int carNumber, string carType) : this(carNumber, carType, default(int))
        {
            
        }

        public RentCar(int carNumber, string carType, double rentPrice)
        {
            this.carNumber = carNumber;
            this.carType = carType;
            this.rentPrice = rentPrice;
            daysOnRent = 0;

        }

        public double RentFullPrice(int days)
        {
            daysOnRent += days;
            double fullPrice = days * rentPrice;
            return fullPrice;
        }

        public int CarNumber
        {
            get
            {
                return carNumber;
            }

            set
            {
                carNumber = value;
            }
        }
        public string CarType
        {
            get
            {
                return carType;
            }

            set
            {
                carType = value;
            }
        }

        public double RentPrice
        {
            get
            {
                return rentPrice;
            }

            set
            {
                rentPrice = value;
            }
        }

        public int DaysOnRent
        {
            get
            {
                return daysOnRent;
            }

            set
            {
                daysOnRent = value;
            }
        }
        public double FullProfit
        {
            get
            {
                double fullProfit = daysOnRent * rentPrice;
                return fullProfit;
            }
        }

    }
}
