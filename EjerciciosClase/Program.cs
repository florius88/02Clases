using System;
using System.Globalization;
//using Metodos;

namespace EjerciciosClase
{
    class Program
    {
        Metodos met = new Metodos();

        void Main(string[] args)
        {

            int opc, opc2, num;
            DateTime fecha, otraFecha;

            do
            {
                Console.WriteLine("Menú de opciones");
                Console.WriteLine("1.-Manejar Fechas");
                Console.WriteLine("2.-Clase Película");
                Console.WriteLine("3.-Alquiler Puerto");
                Console.WriteLine("4.-Salir");
                Console.Write("Elija una opcion: ");
                opc = met.SolicitarNumero();

                Console.WriteLine("");


                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Manejar Fechas");

                        fecha = met.IntroducirFecha();

                        do
                        {
                            Console.WriteLine("Que desea hacer?");
                            Console.WriteLine("1.-Averiguar día de la semana");
                            Console.WriteLine("2.- Incrementar fecha");
                            Console.WriteLine("3.-Diferenciar fechas");
                            Console.WriteLine("4.-Comparar fechas");
                            Console.WriteLine("6.-Salir");

                            opc2 = met.SolicitarNumero();

                            switch (opc2)
                            {
                                case 1:
                                    Console.WriteLine("El día de la semana de la fecha " +
                                    fecha.ToShortDateString() + " es : " + fecha.ToString("dddd", new CultureInfo("es-ES")));

                                    break;

                                case 2:
                                    Console.WriteLine("Cuántos días quieres añadir?");
                                    num = met.SolicitarNumero();
                                    _ = new DateTime();
                                    otraFecha = fecha.AddDays(num);
                                    Console.WriteLine("La fecha " + fecha.ToShortDateString() + " se le han añadido " + num + " dias y ahora es: " + otraFecha.ToShortDateString());
                                    
                                    break;

                                case 3:
                                    Console.WriteLine("Introduzca la otra fecha para ver la diferencia");
                                    _ = new DateTime();
                                    otraFecha = met.IntroducirFecha();
                                    Console.WriteLine("Entre las dos fechas hay ");
                                    break;
                                case 4:
                                    Console.WriteLine("Introduzca la otra fecha para compararlas");
                                    _ = new DateTime();
                                    otraFecha = met.IntroducirFecha();
                                    met.CompararFechas(fecha, otraFecha);
                                    break;
                                case 6:
                                    //terminar esta operacion
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Elija una opcion correcta");
                                    break;
                            }
                        } while (opc2 != 6);

                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Clase Película");


                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("Alquiler Puerto");


                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.WriteLine("¡¡Hasta Pronto!!");

                        break;

                    default:
                        Console.WriteLine("Elija un número del menú de opciones...");

                        Console.WriteLine("");
                        break;
                }







            } while (opc != 4);

        }

        //***************************METODOS***************************************
       
    }
}
