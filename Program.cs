using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args)
    {
        subMenus submenus = new subMenus();
        Console.WriteLine("===============Menu===============");
        Console.WriteLine("Los ejercicios de que clase desea revisar [Clase1, Vectores]");
        string clase = Console.ReadLine();

        switch (clase)
        {
            case "Clase1":
            submenus.subMenuClasePracticas();
            break;
            case "Vectores":
            submenus.subMenuVectores();
            break;
        }
    }
}