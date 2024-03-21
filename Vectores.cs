class Vectores()
{
    Random r = new Random();
    int[] hola(int[] numeros)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = r.Next(0, 10);
        }
        return numeros;
    }

    void imprimirVector(int[] numeros)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("[" + numeros[i] + "]");
        }
    }

    int segundoMayor(int[] numeros)
    {
        int mayor = 0;
        int segundo = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                segundo = mayor;
                mayor = numeros[i];
            }
            else if (numeros[i] > segundo && numeros[i] != mayor)
            {
                segundo = numeros[i];
            }
        }
        return segundo;
    }

    int[] eliminarRepetidos(int[] numeros)
    {
        int longitud = numeros.Length;
        int count = 0;
        // Contar la cantidad de elementos únicos
        for (int i = 0; i < longitud; i++)
        {
            bool esRepetido = false;
            for (int j = 0; j < i; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    esRepetido = true;
                    break;
                }
            }
            if (!esRepetido)
            {
                count++;
            }
        }

        // Crear un nuevo array con los elementos únicos
        int[] resultado = new int[count];
        int index = 0;
        for (int i = 0; i < longitud; i++)
        {
            bool esRepetido = false;
            for (int j = 0; j < i; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    esRepetido = true;
                    break;
                }
            }
            if (!esRepetido)
            {
                resultado[index] = numeros[i];
                index++;
            }
        }
        return resultado;
    }

    void listaSinRepetidos(int[] numeros)
    {
        // lista mostrando los que no son repetidos
        List<int> numeros_unicos = new List<int>();
        for (int i = 0; i < numeros.Length; i++)
        {
            bool esRepetido = false;
            for (int j = 0; j < i; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    esRepetido = true;
                    break;
                }
            }
            if (!esRepetido)
            {
                numeros_unicos.Add(numeros[i]);
            }
        }
        Console.WriteLine("\nsin repetidos");
        foreach (int ind in numeros_unicos)
        {
            Console.Write("-" + ind);
        }

    }

    void diccionarioRepetido(int[] numeros)
    {
        Dictionary<int, int> frecuencia = new Dictionary<int, int>();
        int longitud = numeros.Length;
        // Contar la cantidad de elementos únicos
        for (int i = 0; i < longitud; i++)
        {
            // Si la clave ya está presente en el diccionario, incrementa su valor
            if (frecuencia.ContainsKey(numeros[i]))
            {
                frecuencia[numeros[i]]++;
            }
            else // Si la clave no está presente, agrega una nueva entrada al diccionario
            {
                frecuencia.Add(numeros[i], 1);
            }
        }
        Console.WriteLine("");
        // Imprimir los resultados
        foreach (var kvp in frecuencia)
        {
            Console.WriteLine("Número {0}: {1} veces", kvp.Key, kvp.Value);
        }
    }

    public int opcion = 0;
    public void ejerciciosRealizados()
    {
        int i = 0;
        int[] numeros = new int[10];
        do
        {
            Console.WriteLine("\n=======Menu Vectores=======");
            Console.WriteLine("1. Llenar vector");
            Console.WriteLine("2. Mostrar Vector");
            Console.WriteLine("3. Segundo Mayor del vector");
            Console.WriteLine("4. Vector sin valores repetidos");
            Console.WriteLine("5. Lista sin los repetidos");
            Console.WriteLine("6. Diccionario con las veces que se repite una valor");
            Console.WriteLine("7. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    hola(numeros);
                    break;
                case 2:
                    imprimirVector(numeros);
                    break;
                case 3:
                    int segundo = segundoMayor(numeros);
                    Console.WriteLine($"El segundo mayor es: {segundo}");
                    break;
                case 4:
                    int[] resultado = eliminarRepetidos(numeros);
                    foreach (int r in resultado)
                    {
                        Console.Write("[" + r + "]");
                    }
                    break;
                case 5:
                    listaSinRepetidos(numeros);
                    break;
                case 6:
                    diccionarioRepetido(numeros);
                    break;
                case 7:
                    i = 1;
                    break;
                default:
                    Console.WriteLine($"La opcion {opcion} no existe");
                    break;
            }
        } while (i != 1);
    }
}