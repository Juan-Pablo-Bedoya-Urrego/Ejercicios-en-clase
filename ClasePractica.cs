class ClasePractica
{
    public void operacionesEHistotial()
    {
        //operaciones e historial de la ultima operacion realizada
        String historia = "";

        int i = 1;

        while (i != 0)
        {
            Console.WriteLine("======Menu======");
            Console.WriteLine("1.Operaciones");
            Console.WriteLine("2.Historial");
            Console.WriteLine("3.Salir");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese el primer numero entero");
                    int nu1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el operador");
                    string operador = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo numero entero");
                    int nu2 = int.Parse(Console.ReadLine());

                    if (operador == "+")
                    {
                        int suma = nu1 + nu2;
                        historia = "La ultima operacion fue suma y es entre " + nu1 + " y " + nu2 + " y el resultado fue: " + suma;
                        Console.WriteLine($"El resultado es {suma}");
                    }
                    else if (operador == "-")
                    {
                        int resta = nu1 - nu2;
                        historia = "La ultima operacion fue resta y es entre " + nu1 + " y " + nu2 + " y el resultado fue: " + resta;
                        Console.WriteLine($"El resultado es {resta}");
                    }else if(operador == "*"){
                        int multiplicacion = nu1 * nu2;
                        historia = "La ultima operacion fue multiplicacion y es entre " + nu1 + " y " + nu2 + " y el resultado fue: " + multiplicacion;
                        Console.WriteLine($"El resultado es {multiplicacion}");
                    }
                    else if(operador == "/"){
                        int division = nu1 / nu2;
                        historia = "La ultima operacion fue multiplicacion y es entre " + nu1 + " y " + nu2 + " y el resultado fue: " + division;
                        Console.WriteLine($"El resultado es {division}");
                    }else{
                        Console.WriteLine($"El operador {operador} no existe");
                    }
                    break;
                case 2:
                    Console.WriteLine(historia);
                    break;
                case 3:
                    i = 0;
                    break;

            }
        }
    }

    public void calcularDescuentos()
    {
        //Calcular descuentos dependiendo la categoria
        Console.WriteLine("Ingrese la categria del producto (Categrias Disponible: [ropa,aseo,comida])");
        string cat = Console.ReadLine();

        Console.WriteLine("Ingrese nombre del producto");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del producto");
        int pre = int.Parse(Console.ReadLine());

        double descuento = 0.0;
        double preciofinal = 0.0;
        switch (cat)
        {
            case "ropa":
                descuento = pre * 0.10;
                preciofinal = pre - descuento;

                Console.WriteLine($" El producto {nombre} \n Categoria {cat} \n Precio {pre} \n Descuento (10%): {descuento} \n Precio final es {preciofinal}");
                break;
            case "aseo":
                descuento = pre * 0.05;
                preciofinal = pre - descuento;

                Console.WriteLine($"El producto {nombre} de la categoria {cat} queda con un descuento es de: {descuento} y el precio final es {preciofinal}");
                break;
            case "comida":
                descuento = pre * 0.40;
                preciofinal = pre - descuento;

                Console.WriteLine($"El producto {nombre} de la categoria {cat} queda con un descuento es de: {descuento} y el precio final es {preciofinal}");
                break;
        }
    }

    public void juegoAdivinarNumero()
    {
        //Juego adivinar numero Random
        Random r = new Random();

        int numero = r.Next(0, 51);

        int intentos = 4;

        while (intentos != 0)
        {
            Console.WriteLine($"Tiene {intentos} intentos");
            Console.WriteLine("ingrese numero del 1 al 50");
            int NumeroConsole = int.Parse(Console.ReadLine());

            if (NumeroConsole > numero)
            {
                Console.WriteLine("Calor");
                intentos--;
            }
            else if (NumeroConsole < numero)
            {
                Console.WriteLine("Frio");
                intentos--;
            }
            else if (numero == NumeroConsole)
            {
                Console.WriteLine("Que Hpta mas chepon");
                intentos = 0;
            }
        }
        Console.WriteLine($"Era el {numero}");
    }
}