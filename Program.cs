namespace Workers_database;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Display();
        menu.WyborOpcji();
    }
}
