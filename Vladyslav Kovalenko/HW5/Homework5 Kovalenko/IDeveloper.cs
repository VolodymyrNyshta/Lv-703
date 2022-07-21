using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Kovalenko
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        public void Create();
        public void Destroy();
    }
    
}
