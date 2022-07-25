using System;

namespace Homework5
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }
}
