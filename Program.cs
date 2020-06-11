using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.AbstractClass; //Abstract Class//
//Abstraction.Interface  //Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ClubBola clubbola;  //Abstract Class//
            clubbola = new Pemain();
            clubbola.Posisi();

            Console.WriteLine();
            clubbola = new Captain();
            clubbola.Posisi();

            Console.WriteLine();
            clubbola = new Pelatih();
            clubbola.Posisi();


            /*IClubBola clubbola; //Abstract Class//
            clubbola = new Pemain();
            clubbola.Posisi();
            Console.WriteLine();
            clubbola = new Captain();
            clubbola.Posisi();
            Console.WriteLine();
            clubbola = new Pelatih();
            clubbola.Posisi()*/

            Console.ReadKey();
        }
    }
}