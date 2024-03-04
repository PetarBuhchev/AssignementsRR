using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CarSerialization
{
    [Serializable]
    internal class Car
    {
        public string model;
        public string brand;
        public int engineVolume;
        public int yearProd;
    }
}
