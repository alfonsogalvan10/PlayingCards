using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace BarajadeCartas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal puntosusuario = 0;
            string opcion = "Si";
            string usuario = "USUARIO";
            //int contadorfiguras = 12, contadoras = 4, cartas = 40;

            Baraja b = new Baraja(1, true);
            Console.WriteLine(usuario.PadLeft(15));
            Console.WriteLine("||=========================||");
            Carta c = b.Robar();
            //cartas--;
            Console.WriteLine(c.NombreCarta);
            while (opcion.ToLower() != "no" && puntosusuario < 7.5m)
            {
                puntosusuario = puntosusuario + c.Valor7ymedia;
                Console.WriteLine("Tu puntos son: " + puntosusuario);
                //if (c.Valor7ymedia == 0.5m)
                //{
                //    contadorfiguras--;
                //}
                //else
                //{
                //    if (c.Valor7ymedia == 1)
                //    {
                //        contadoras--;
                //    }
                //}

                if (puntosusuario < 7.5m)
                {
                    Console.WriteLine("¿Quieres robar otra carta?");
                    Console.Write("(Si/No): ");
                    opcion = Console.ReadLine();

                    if (opcion.ToLower() == "si")
                    {
                        c = b.Robar();
                        //cartas--;
                        Console.WriteLine(c.NombreCarta);
                    }
                }
            }
            Console.WriteLine("||=========================||");

            //IA
            string ia = "IA";
            decimal puntosia = 0;
            Console.WriteLine(ia.PadLeft(15));
            Console.WriteLine("||=========================||");
            while (puntosia </*=*/ 5m)
            {
                //if (puntosia < 6)
                //{
                    c = b.Robar();
                    //cartas--;
                    Console.WriteLine(c.NombreCarta);
                    puntosia = puntosia + c.Valor7ymedia;
                    Console.WriteLine("Tu puntos son: " + puntosia);
                    //if (c.Valor7ymedia == 0.5m)
                    //{
                    //    contadorfiguras--;
                    //}
                    //else
                    //{
                    //    if (c.Valor7ymedia == 1)
                    //    {
                    //        contadoras--;
                    //    }
                    //}
                //}
                //else
                //{

                //    if ((contadorfiguras / cartas) * 100 >= 15)
                //    {
                //        c = b.Robar();
                //        Console.WriteLine(c.NombreCarta);
                //        puntosia = puntosia + c.Valor7ymedia;
                //        Console.WriteLine("Tu puntos son: " + puntosia);
                //    }
                //    else
                //    {
                //        if ((contadoras / cartas) * 100 >= 5)
                //        {
                //            c = b.Robar();
                //            Console.WriteLine(c.NombreCarta);
                //            puntosia = puntosia + c.Valor7ymedia;
                //            Console.WriteLine("Tu puntos son: " + puntosia);
                //        }
                //    }

                //}
                Thread.Sleep(1000);
            }
            Console.WriteLine("||=========================||");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            string resultado = "RESULTADO";
            string espacio = "";
            Console.WriteLine(resultado.PadLeft(19));
            Console.WriteLine("||=========================||");
            Console.ForegroundColor = ConsoleColor.Gray;
            if (puntosusuario > 7.5m && puntosia > 7.5m || puntosia == puntosusuario)
            {
                Console.WriteLine(espacio.PadLeft(10) + "Empate");
                Console.WriteLine(espacio.PadLeft(10) + puntosia + " vs " + puntosusuario);
            }
            else
            {
                if (puntosusuario <= 7.5m && puntosia > 7.5m)
                {
                    Console.WriteLine(espacio.PadLeft(10) + "Gana el usuario");
                    Console.WriteLine(espacio.PadLeft(10) + puntosia + " vs " + puntosusuario);
                }
                else
                {
                    if (puntosusuario > 7.5m && puntosia <= 7.5m)
                    {
                        Console.WriteLine(espacio.PadLeft(10) + "Gana la IA");
                        Console.WriteLine(espacio.PadLeft(10) + puntosia + " vs " + puntosusuario);
                    }
                    else
                    {
                        if (puntosusuario > puntosia)
                        {
                            Console.WriteLine(espacio.PadLeft(10) + "Gana el usuario");
                            Console.WriteLine(espacio.PadLeft(10) + puntosia + " vs " + puntosusuario);
                        }
                        else
                        {
                            Console.WriteLine(espacio.PadLeft(10) + "Gana la IA");
                            Console.WriteLine(espacio.PadLeft(10) + puntosia + " vs " + puntosusuario);

                        }
                    }
                }

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("||=========================||");
            Console.ReadKey();

        }
    }

}
