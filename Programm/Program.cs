using System;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Videocard vc = new Videocard();
            vc.Input();
            if (vc.Check() == 1) vc.Print();
        }
    }
}
