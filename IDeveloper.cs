using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool { get; set; }
        public void Create();
        public void Destroy();

    }
}
