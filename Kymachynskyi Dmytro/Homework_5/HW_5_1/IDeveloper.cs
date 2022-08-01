using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal interface IDeveloper
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }
}
