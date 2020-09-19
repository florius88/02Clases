using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosClase
{
    class Metodos
    {
        public int SolicitarNumero()
        {
            Boolean valido;
            int num;
            do
            {
                valido = int.TryParse(Console.ReadLine(), out num);
                if (!valido) Console.WriteLine("Numero no válido");

            } while (!valido);

            return num;
        }

        public DateTime IntroducirFecha()
        {
            int dia, mes, anio;
            bool valido;
            do
            {
                Console.WriteLine("Introduzca una fecha:");
                Console.Write("Dia: ");
                dia = SolicitarNumero();
                Console.Write("Mes: ");
                mes = SolicitarNumero();
                Console.Write("año: ");
                anio = SolicitarNumero();
                try
                {
                    return new DateTime(anio, mes, dia);

                }
                catch (Exception)
                {
                    valido = false;
                }

            } while (!valido);

            return new DateTime(anio, mes, dia);
        }

        public void CompararFechas(DateTime fecha1, DateTime fecha2)
        {
            int res = DateTime.Compare(fecha1, fecha2);
            if (res < 0)
            {
                Console.WriteLine(fecha1.ToString("dd/MM/yy") + " es menor que " + fecha2.ToString("dd/MM/yy"));
            }
            else if (res == 0)
            {
                Console.WriteLine(fecha1.ToString("dd/MM/yy") + " es igual que " + fecha2.ToString("dd/MM/yy"));
            }
            else
            {
                Console.WriteLine(fecha1.ToString("dd/MM/yy") + " es mayor que " + fecha2.ToString("dd/MM/yy"));
            }
        }
        public void DiferenciarFechas(DateTime fecha1, DateTime fecha2)
        {
            TimeSpan ts = new TimeSpan();
            int res = DateTime.Compare(fecha1, fecha2);
            if (res < 0)
            {
                ts = (fecha2 - fecha1);
                Console.WriteLine("Han pasado " + ts.Days + " dias " + ts.+);
            }
            else if (res == 0)
            {

            }
            else
            {

            }






        }
}
