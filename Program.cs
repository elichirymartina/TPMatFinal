using System;

int opcion = 0, i = 0, cantidadTerminos = 0, quiereTodos = 0;
decimal numeroInicial = 0, razonOdiferencia = 0, resultado = 0;


        //
        opcion = (int)validarEntradaNumerica("Elija una opción presionando el número por teclado \n 1.Aritmética \n 2.Geométrica \n 3.Conjunto");


        switch (opcion)
        {
            //artimetica 
            case 1:

                numeroInicial = validarEntradaNumerica("Ingrese el primer término");
                razonOdiferencia = validarEntradaNumerica("Ingrese la diferencia");
                cantidadTerminos = (int)validarEntradaNumerica("¿Cuántos números desea?");
                quiereTodos = (int)validarEntradaNumerica("Si desea solamente el termino a" + cantidadTerminos + " ingrese 1. Si desea todos los terminos de la sucesion, ingrese 2");

                /*
                do
                {
                    quiereTodos = (int)validarEntradaNumerica("Si desea solamente el termino a" + cantidadTerminos + " ingrese 1. Si desea todos los terminos de la sucesion, ingrese 2");
                        if (quiereTodos != 1 && quiereTodos != 2)
                        {
                            Console.WriteLine("Error: Ingrese una opción válida (1 o 2).");
                        }
                } while (quiereTodos != 1 && quiereTodos != 2);
                */


                switch (quiereTodos)
                {
                    case 1:
                        for (i = 0; i < cantidadTerminos; i++)
                        {
                            resultado = numeroInicial + i * razonOdiferencia;
                        }
                        Console.WriteLine("a" + i + "=" + resultado);
                        break;
                    case 2:
                        for (i = 0; i < cantidadTerminos; i++)
                        {
                            resultado = numeroInicial + i * razonOdiferencia;
                            Console.WriteLine($"a{i + 1} = {resultado}");
                        }
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor valido para las opciones presentadas");
                        break;
                }

                if (EsConstante(numeroInicial, razonOdiferencia))
                Console.WriteLine("La sucesión es constante.");
                else if (EsAritmeticaCreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es aritmética creciente.");
                else if (EsAritmeticaDecreciente(razonOdiferencia))
                Console.WriteLine("La sucesión es aritmética decreciente.");
                
                break;
            
            // geometrica 
            case 2:

                numeroInicial = validarEntradaNumerica("Ingrese el primer término");
                razonOdiferencia = validarEntradaNumerica("Ingrese la razón");
                cantidadTerminos = (int)validarEntradaNumerica("¿Cuántos números desea?");
                quiereTodos = (int)validarEntradaNumerica("Si desea solamente el termino a" + cantidadTerminos + " ingrese 1. Si desea todos los terminos de la sucesion, ingrese 2");

                /*
                do
                {
                    quiereTodos = (int)validarEntradaNumerica("Si desea solamente el termino a" + cantidadTerminos + " ingrese 1. Si desea todos los terminos de la sucesion, ingrese 2");
                        if (quiereTodos != 1 && quiereTodos != 2)
                        {
                    Console.WriteLine("Error: Ingrese una opción válida (1 o 2).");
                        }
                } while (quiereTodos != 1 && quiereTodos != 2);
                 */

        switch (quiereTodos)
                {
                    case 1:
                        for (i = 0; i < cantidadTerminos; i++)
                        {
                    resultado = numeroInicial *= razonOdiferencia;
                }
                Console.WriteLine("a" + i + "=" + resultado);

                    break;

                    case 2:
                        for (i = 0; i < cantidadTerminos; i++)
                        {
                    resultado = numeroInicial *= razonOdiferencia;
                    Console.WriteLine($"a{i + 1} = {resultado}");
                        }
                    break;

                    default:
                        Console.WriteLine("Ingrese un valor valido para las opciones presentadas");
                    break;
                }

                if (EsGeometricaCreciente(numeroInicial, razonOdiferencia))
                Console.WriteLine("La sucesión es geométrica creciente.");
                else if (EsGeometricaDecreciente(numeroInicial, razonOdiferencia))
                Console.WriteLine("La sucesión es geométrica decreciente.");

                break;

                

            //conjuntos    
            case 3:

                cantidadTerminos = (int)validarEntradaNumerica("Ingrese que cantidad de números escribirá del conjunto");

                // Crea un vector para almacenar los números ingresados por el usuario
                decimal[] conjunto = new decimal[cantidadTerminos];

                // Llena el vector con los números proporcionados por el usuario
                for (i = 0; i < cantidadTerminos; i++)
                {
                    conjunto[i] = validarEntradaNumerica($"Ingrese el número {i + 1}");
                }

                bool esAritmetica = true;
                bool esGeometrica = true;

                //Declara y verifica si es una sucesión aritmética

                decimal diferenciaAritmetica = conjunto[1] - conjunto[0];

                for (i = 2; i < cantidadTerminos; i++)
                {
                    if (conjunto[i] - conjunto[i - 1] != diferenciaAritmetica)
                    {
                        esAritmetica = false;
                        break;
                    }
                }

                // Declara y verifica si es una sucesión geométrica

                decimal razonGeometrica = conjunto[1] / conjunto[0];
                for (i = 2; i < cantidadTerminos; i++)
                {
                    if (conjunto[i] / conjunto[i - 1] != razonGeometrica)
                    {
                        esGeometrica = false;
                        break;
                    }
                }

                if (esAritmetica)
                {
                    Console.WriteLine("El conjunto es una sucesión aritmética.");
                }
                else if (esGeometrica)
                {
                    Console.WriteLine("El conjunto es una sucesión geométrica.");
                }
                else
                {
                    Console.WriteLine("El conjunto no es una sucesión.");
                }
                break;
        }


        //validar el teclado del usuario; función estática

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
                    Console.WriteLine("Error: Ingrese un número válido");
                }
            }

        }

static bool EsConstante(decimal numeroInicial, decimal razonOdiferencia) =>
    razonOdiferencia == 0;

static bool EsAritmeticaCreciente(decimal razonOdiferencia) =>
    razonOdiferencia > 0;

static bool EsAritmeticaDecreciente(decimal razonOdiferencia) =>
    razonOdiferencia < 0;

static bool EsGeometricaCreciente(decimal numeroInicial, decimal razonOdiferencia) =>
    numeroInicial > 0 && razonOdiferencia > 1;

static bool EsGeometricaDecreciente(decimal numeroInicial, decimal razonOdiferencia) =>
    numeroInicial > 0 && razonOdiferencia > 0 && razonOdiferencia < 1;



