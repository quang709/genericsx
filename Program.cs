using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> myGeneric = new MyGeneric<int>();
            myGeneric.SoSanh<int>(2, 2);
            myGeneric.SoSanh<string>("abc", "abc");

        }
    }
}
