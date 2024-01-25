using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHW
{
    internal interface IPerson
    {
        int Age { get; }
        string Name { get; }

        bool IsAdult();
        void ToString();
    }
}
