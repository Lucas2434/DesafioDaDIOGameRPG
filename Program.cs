using static System.Console;
using DIO_DesafioJogo.CRC.Entites;


namespace DIO_DesafioJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight ar = new Knight("Arus", 25, "knight\n");
            Wizard je = new Wizard("Jessica", 33, "white Wizard\n");
            Ninja wed = new Ninja("Wedce", 42, "Ninja\n");
            Wizard to = new Wizard("Topapa", 50,"Black Wizard");
            
            

            Write(ar.Attack());
            Write(je.Attack());
            Write(wed.Attack());
            Write(to.Defense());
            
        }
    }
}
