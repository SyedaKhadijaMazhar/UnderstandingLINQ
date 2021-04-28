using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCar = new List<Car>()
            {
                new Car(){VIN = "A1" , Make = "BMW", Model = "550i", StickerPrice = 55000 , Year = 2007 },
                new Car(){VIN = "B2" , Make = "Ford" , Model = "Explorer" , StickerPrice = 66000 , Year = 1998},
                new Car(){VIN = "C3" , Make = "Honda" , Model = "Odessy" , StickerPrice = 30000 , Year = 2005},
                new Car(){VIN = "D4" , Make = "Toyota" , Model = "4Runner" , StickerPrice = 35000 , Year = 2004},
                new Car(){VIN = "E5" , Make = "BMW" , Model = "55i" , StickerPrice = 57000 , Year = 2012}
            };

            // LINQ Query
            //  var bmws = from car in myCar where car.Make == "BMW" && car.Year == 2012 select car;
            // var OrderedCars = from car in myCar orderby car.Year descending select car;
            //LINQ Method
            // var bmws = myCar.Where(p => p.Make == "BMW" && p.Year == 2012);
            // var FirstCar = myCar.First(p => p.Make == "BMW");
            /*
            var FirstCar = myCar.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine("{0} {1}",FirstCar.VIN, FirstCar.Year);
            */
            //Console.WriteLine(myCar.TrueForAll(p => p.Year > 1997));
            /*
            myCar.ForEach(p => p.StickerPrice -= 3000);
            myCar.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
            */
            //   Console.WriteLine(myCar.Exists(p => p.Model == "Explorer"));
            //  Console.WriteLine(myCar.Sum(p => p.StickerPrice) );
            // Console.WriteLine(myCar.Where(p => p.Make == "BMW").Sum(p => p.StickerPrice));
           /*
            var FirstCar = myCar.Where(p => p.Make == "BMW").Sum(p => p.StickerPrice);
            Console.WriteLine("{0:C}",FirstCar);
           */
            
            /*
            var OrderedCars = myCar.OrderByDescending(p => p.Year);
            foreach (var car in OrderedCars)
            {
                Console.WriteLine("{0} {1} {2} {3}", car.Model, car.VIN, car.StickerPrice, car.Year);
               
            }
            */
            //Get Type
            Console.WriteLine(myCar.GetType());
            var OrderedCars = myCar.OrderByDescending(p => p.Year);
            Console.WriteLine(OrderedCars.GetType());
            var bmws = myCar.Where(p => p.Make == "BMW" && p.Year == 2012);
            Console.WriteLine(bmws.GetType());
            var bmws1 = from car in myCar where car.Make == "BMW" && car.Year == 2012 select new {car.Make, car.Model };
            Console.WriteLine(bmws1.GetType());
            


            Console.ReadLine();
        }
            
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
