class subMenus{

    public int opcion = 0;
    
    public void subMenuClasePracticas(){
        ClasePractica cp = new ClasePractica();
        Console.WriteLine("=======Menu Clase1=======");
        Console.WriteLine("1. Operaciones e historial");
        Console.WriteLine("2. Calcular descuentos");
        Console.WriteLine("3. Juego adivinar");
        Console.Write("Opcion: ");
        opcion = int.Parse(Console.ReadLine());

        switch(opcion){
            case 1:
            cp.operacionesEHistotial();
            break;
            case 2:
            cp.calcularDescuentos();
            break;
            case 3:
            cp.juegoAdivinarNumero();
            break;
            default:
            Console.WriteLine($"La opcion {opcion} no existe");
            break;
        }
    }

    public void subMenuVectores(){
        Vectores vectores = new Vectores();
        vectores.ejerciciosRealizados();
    }
}