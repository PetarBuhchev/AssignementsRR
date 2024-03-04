using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CarSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Serialization
            Car myCar = new Car() { model = "Escalade", brand = "Cadilac", engineVolume = 4500, yearProd = 2023 };

            IFormatter formatterCreate = new BinaryFormatter();
            using (Stream streamCreate = new FileStream("myCar.bin", FileMode.Create, FileAccess.Write))
            {
                formatterCreate.Serialize(streamCreate, myCar);
            }
            

            //Deserialization
            IFormatter formatterRead = new BinaryFormatter();
            Stream streamRead = new FileStream("myCar.bin", FileMode.Open, FileAccess.Read);

            Car newCar = (Car)formatterRead.Deserialize(streamRead);

            Console.WriteLine(newCar.brand);
            Console.WriteLine(newCar.model);
            Console.WriteLine(newCar.engineVolume);
            Console.WriteLine(newCar.yearProd);
        }
    }
}
