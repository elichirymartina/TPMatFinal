using System;

int opcion = 0;

do
{
    int i = 0, cantidadTerminos = 0, quiereTodos = 0;
    decimal numeroInicial = 0, razonOdiferencia = 0, resultado = 0;

    Console.Clear(); // Limpia la consola para una nueva iteración
    opcion = (int)validarEntradaNumerica("Elija una opción presionando el número por teclado \n 1.Aritmética \n 2.Geométrica \n 3.Conjunto \n 4.Salir");

    switch (opcion)
    {
        case 1: // Sucesión aritmética
            numeroInicial = validarEntradaNumerica("Ingrese el primer término. Si el término es un número decimal, escríbalo con coma. Por ejemplo: 2,1.");
            razonOdiferencia = validarEntradaNumerica("Ingrese la diferencia. Si el término es un número decimal, escríbalo con coma. Por ejemplo: 2,1.");

            do
            {
                cantidadTerminos = (int)validarEntradaNumerica("¿Cuántos términos desea? Para mayor precisión ingrese mínimamente 3 términos.");
                if (cantidadTerminos < 3)
                {
                    Console.WriteLine("Error: Debe ingresar al menos 3 términos.");
                }
            } while (cantidadTerminos < 3);

            quiereTodos = 0;
            // Bucle para asegurar que la opción de mostrar términos es válida
            while (quiereTodos < 1 || quiereTodos > 2)
            {
                quiereTodos = (int)validarEntradaNumerica("Si desea solamente el término a" + cantidadTerminos + " ingrese 1. Si desea todos los términos de la sucesión, ingrese 2");
                if (quiereTodos < 1 || quiereTodos > 2)
                {
                    Console.WriteLine("Error: Ingrese una opción válida (1 o 2).");
                }
            }

            //Elige si mostrar todos los términos o solo el último
            switch (quiereTodos)
            {
                case 1:
                    //El último
                    resultado = numeroInicial;

                    for (i = 0; i < cantidadTerminos; i++)
                    {
                        resultado = numeroInicial + i * razonOdiferencia;
                    }
                    Console.WriteLine("a" + (i+1) + "=" + resultado);
                    break;

                case 2:
                    //Todos
                    resultado = numeroInicial;

                    for (i = 0; i < cantidadTerminos; i++)
                    {
                        resultado = numeroInicial + i * razonOdiferencia;
                        Console.WriteLine("a" + (i+1) + "=" + resultado);

                    }
                    break;

                default:
                    Console.WriteLine("Ingrese un valor válido para las opciones presentadas. Elige la opción 1 o 2.");
                    break;
            }

            // Determina la clasificación de la sucesión aritmética
            if (EsConstante(razonOdiferencia))
                Console.WriteLine("La sucesión es constante.");
            else if (EsAritmeticaEstrCreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es aritmética estrictamente creciente.");
            else if (EsAritmeticaCreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es aritmética creciente.");
            else if (EsAritmeticaEstrDecreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es aritmética estrictamente decreciente.");
            else if (EsAritmeticaDecreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es aritmética decreciente.");
            break;

        case 2: // Sucesión geométrica
            numeroInicial = validarEntradaNumerica("Ingrese el primer término");
            razonOdiferencia = validarEntradaNumerica("Ingrese la razón");

            do
            {
                cantidadTerminos = (int)validarEntradaNumerica("¿Cuántos números desea? Para mayor precisión ingrese mínimamente 3 términos.");

                if (cantidadTerminos < 3)
                {
                    Console.WriteLine("Error: Debe ingresar al menos 3 términos.");
                }
            } while (cantidadTerminos < 3);

            quiereTodos = 0;
            while (quiereTodos < 1 || quiereTodos > 2)
            {
                quiereTodos = (int)validarEntradaNumerica("Si desea solamente el término a" + cantidadTerminos + " ingrese 1. Si desea todos los términos de la sucesión, ingrese 2");
                if (quiereTodos < 1 || quiereTodos > 2)
                {
                    Console.WriteLine("Error: Ingrese una opción válida (1 o 2).");
                }
            }

            decimal[] sucesionGeometrica = new decimal[cantidadTerminos];

            switch (quiereTodos)
            {
                case 1:
                    resultado = numeroInicial;

                    for (i = 0; i < cantidadTerminos; i++)
                    {
                        resultado = numeroInicial *= razonOdiferencia;

                    }
                    Console.WriteLine("a" + i + "=" + resultado);
                    break;

                case 2:
                    resultado = numeroInicial;

                    for (i = 0; i < cantidadTerminos; i++)
                    {
                        resultado =  numeroInicial *= razonOdiferencia;


                        Console.WriteLine("a" + (i+2) + "=" + resultado);
                    }
                    break;

                default:
                    Console.WriteLine("Ingrese un valor válido para las opciones presentadas. Presione 1 o 2.");
                    break;
            
    }

            // Determina la clasificación de la sucesión geométrica
            if (EsGeomConstante(razonOdiferencia))
                Console.WriteLine("La sucesión es geométrica constante.");
            else if (EsGeomEstrCreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es geométrica estrictamente creciente.");
            else if (EsGeomCreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es geométrica creciente.");
            else if (EsGeomAlternante(sucesionGeometrica))
                Console.WriteLine("La sucesión es geométrica alternante.");
            else if (EsGeomEstrDecreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es geométrica estrictamente decreciente.");
            else if (EsGeomDecreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es geométrica decreciente.");
            break;

        case 3: // Sucesión de conjunto
            
            
            do
            {
                cantidadTerminos = (int)validarEntradaNumerica("Ingrese qué cantidad de términos escribirá del conjunto. Para mayor presición, ingrese mínimamente 3 términos.");

                if (cantidadTerminos < 3)
                {
                    Console.WriteLine("Error: Debe ingresar al menos 3 términos del conjunto.");
                }
            } while (cantidadTerminos < 3);

            
            decimal[] conjunto = new decimal[cantidadTerminos];

            for (i = 0; i < cantidadTerminos; i++)
            {
                conjunto[i] = validarEntradaNumerica($"Ingrese el término {i + 1}");

            }

            bool esAritmetica = true;
            bool esGeometrica = true;
            decimal diferenciaAritmetica = conjunto[1] - conjunto[0];
            decimal razonGeometrica = conjunto[1] / conjunto[0];

            for (i = 2; i < cantidadTerminos; i++)
            {
                if (conjunto[i] - conjunto[i - 1] != diferenciaAritmetica)
                    esAritmetica = false;

                if (conjunto[i] / conjunto[i - 1] != razonGeometrica)
                    esGeometrica = false;
            }

            if (esAritmetica)
                Console.WriteLine("El conjunto es una sucesión aritmética.");
            else if (esGeometrica)
                Console.WriteLine("El conjunto es una sucesión geométrica.");
            else
                Console.WriteLine("El conjunto no es una sucesión aritmética ni geométrica.");


            if (EsAlternante(conjunto))
            {
                Console.WriteLine("El conjunto es una sucesión alternante.");
            }
            else if (EsConjuntoConstante(conjunto))
            {
                Console.WriteLine("El conjunto es una sucesión constante.");
            }
            else if (EsConjuntoEstrCreciente(conjunto))
            {
                Console.WriteLine("El conjunto es una sucesión estrictamente creciente.");
            }
            else if (EsConjuntoCreciente(conjunto))
            {
                Console.WriteLine("El conjunto es una sucesión creciente.");
            }
            else if (EsConjuntoEstrDecreciente(conjunto))
            {
                Console.WriteLine("El conjunto es una sucesión estrictamente decreciente.");
            }
            else if (EsConjuntoDecreciente(conjunto))
            {
                Console.WriteLine("El conjunto es una sucesión decreciente.");
            }
            break;

        case 4: // Salir
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válida. Elija una opción: 1.Aritmética; 2.Geométrica; 3.Conjunto; 4.Salir");
            break;

    }

    // Mantener la consola abierta después de cada operación
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();

} while (opcion != 4); // El bucle se repite hasta que el usuario elige salir

// Fin del programa
Console.WriteLine("Gracias por usar el programa. Presione cualquier tecla para salir...");
Console.ReadKey();

static decimal validarEntradaNumerica(string mensaje)
{
    decimal numero;
    string entrada;

    while (true)
    {
        Console.WriteLine(mensaje);
        entrada = Console.ReadLine();

        if (decimal.TryParse(entrada, out numero))
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Error: Ingrese un número válido; ya sea entero, decimal, negativo o positivo. No ingrese letras ni símbolos.");
        }
    }
}

// Funciones para clasificaciones aritméticas
static bool EsConstante(decimal razonOdiferencia) =>
    razonOdiferencia == 0;

static bool EsAritmeticaEstrCreciente(decimal razonOdiferencia) =>
    razonOdiferencia > 0;

static bool EsAritmeticaCreciente(decimal razonOdiferencia) =>
    razonOdiferencia >= 0;

static bool EsAritmeticaEstrDecreciente(decimal razonOdiferencia) =>
    razonOdiferencia < 0;

static bool EsAritmeticaDecreciente(decimal razonOdiferencia) =>
    razonOdiferencia <= 0;

// Funciones para clasificaciones geométricas
static bool EsGeomConstante(decimal razonOdiferencia) =>
    razonOdiferencia == 1 || razonOdiferencia == 0;

static bool EsGeomEstrCreciente(decimal razonOdiferencia) =>
    razonOdiferencia > 1;

static bool EsGeomCreciente(decimal razonOdiferencia) =>
    razonOdiferencia >= 1;

static bool EsGeomAlternante(decimal[] conjunto)
{
    for (int i = 1; i < conjunto.Length; i++)
    {
        if ((conjunto[i] > 0 && conjunto[i - 1] < 0) || (conjunto[i] < 0 && conjunto[i - 1] > 0))
            return true;
    }
    return false;
}

static bool EsGeomEstrDecreciente(decimal razonOdiferencia) =>
    razonOdiferencia < 1 && razonOdiferencia > 0;

static bool EsGeomDecreciente(decimal razonOdiferencia) =>
    razonOdiferencia <= 1 && razonOdiferencia > 0;

// Funciones para clasificaciones del conjunto
static bool EsAlternante(decimal[] conjunto)
{
    for (int i = 1; i < conjunto.Length - 1; i++)
    {
        if (!((conjunto[i - 1] < conjunto[i] && conjunto[i] > conjunto[i + 1]) || (conjunto[i - 1] > conjunto[i] && conjunto[i] < conjunto[i + 1])))
        {
            return false;
        }
    }
    return true;
}
static bool EsConjuntoConstante(decimal[] conjunto)
{
    for (int i = 1; i < conjunto.Length; i++)
    {
        if (conjunto[i] != conjunto[0])
            return false;
    }
    return true;
}

static bool EsConjuntoEstrCreciente(decimal[] conjunto)
{
    for (int i = 1; i < conjunto.Length; i++)
    {
        if (conjunto[i] <= conjunto[i - 1])
            return false;
    }
    return true;
}

static bool EsConjuntoCreciente(decimal[] conjunto)
{
    for (int i = 1; i < conjunto.Length; i++)
    {
        if (conjunto[i] < conjunto[i - 1])
            return false;
    }
    return true;
}

static bool EsConjuntoEstrDecreciente(decimal[] conjunto)
{
    for (int i = 1; i < conjunto.Length; i++)
    {
        if (conjunto[i] >= conjunto[i - 1])
            return false;
    }
    return true;
}

static bool EsConjuntoDecreciente(decimal[] conjunto)
{
    for (int i = 1; i < conjunto.Length; i++)
    {
        if (conjunto[i] > conjunto[i - 1])
            return false;
    }
    return true;
}
