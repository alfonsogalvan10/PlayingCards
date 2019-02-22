using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajadeCartas
{
    class Baraja
    {
        private List<Carta> listaCartas;

        /// <summary>
        /// Inicia la Baraja
        /// </summary>
        public Baraja()
        {
           listaCartas = new List<Carta>();
        }

        /// <summary>
        /// Nos crea una baraja
        /// </summary>
        /// <param name="tipobaraja">Con 1 una baraja española y con 2 una doble</param>
        public Baraja(int tipobaraja)
        {
            if(tipobaraja < 1 || tipobaraja > 2)
            {
                throw new Exception("Tipo de baraja no válida");
            }
            if(tipobaraja == 1)
            {
                int pal, num;
                listaCartas = new List<Carta>();

                for (pal = 0; pal <= 3; pal++)
                {
                    for (num = 1; num <= 10; num++)
                    {
                        Carta c = new Carta(num, pal);
                        listaCartas.Add(c);
                    }
                }
            }
            else
            {
                int pal, num, doble;
                listaCartas = new List<Carta>();

                for (doble = 1; doble <= 2; doble++)
                {
                    for (pal = 0; pal <= 3; pal++)
                    {
                        for (num = 1; num <= 10; num++)
                        {
                            Carta c = new Carta(num, pal);
                            listaCartas.Add(c);
                        }
                    }
                }          
            }
            
        }

        /// <summary>
        /// Nos crea una baraja del tipo que digamos y nos la baraja si lo especificamos
        /// </summary>
        /// <param name="tipobaraja">Con 1 una baraja española y con 2 una doble</param>
        /// <param name="barajar">true barajada false no</param>
        public Baraja(int tipobaraja, bool barajar)
        {
            if (tipobaraja < 1 || tipobaraja > 2)
            {
                throw new Exception("Tipo de baraja no válida");
            }
            if (tipobaraja == 1)
            {
                int pal, num;
                listaCartas = new List<Carta>();

                for (pal = 0; pal <= 3; pal++)
                {
                    for (num = 1; num <= 10; num++)
                    {
                        Carta c = new Carta(num, pal);
                        listaCartas.Add(c);
                    }
                }
            }
            else
            {
                int pal, num, doble;
                listaCartas = new List<Carta>();

                for (doble = 1; doble <= 2; doble++)
                {
                    for (pal = 0; pal <= 3; pal++)
                    {
                        for (num = 1; num <= 10; num++)
                        {
                            Carta c = new Carta(num, pal);
                            listaCartas.Add(c);
                        }
                    }
                }
            }

            if (barajar == true)
            {
                Barajar();
            }
        }

        /// <summary>
        /// Baraja la baraja
        /// </summary>
        public void Barajar()
        {
            int p;
            List<Carta> ldesordenada = new List<Carta>();
            Random rds = new Random();

            while (listaCartas.Count > 0)
            {
                p = rds.Next(0, listaCartas.Count);
                ldesordenada.Add(listaCartas[p]);
                listaCartas.RemoveAt(p);
            }

            listaCartas.AddRange(ldesordenada);
        }

        /// <summary>
        /// Corta la baraja
        /// </summary>
        /// <param name="posicion">posición del corte</param>
        public void Cortar(int posicion)
        {
            int i;
            List<Carta> ldesordenada = new List<Carta>();

            for (i = 0; i <= posicion; i++)
            {
                ldesordenada.Add(listaCartas[i]);
                listaCartas.RemoveAt(i);
            }

            listaCartas.AddRange(ldesordenada);
        }

        /// <summary>
        /// Roba la primera carta de la baraja
        /// </summary>
        /// <returns>devuelve el valor de la primera carta de la baraja</returns>
        public Carta Robar()
        {
            if (listaCartas.Count == 0)
            {
                throw new Exception("No quedan cartas en la baraja");
            }
            else
            {
                Carta c = listaCartas[0];
                listaCartas.RemoveAt(0);
                return c;
            }  
        }

        /// <summary>
        /// Inserta una carta nueva al final de la baraja
        /// </summary>
        /// <param name="idcarta">número representa la carta</param>
        public void InsertaCartaFinal(int idcarta)
        {
            listaCartas.Add(new Carta(idcarta));
        }

        /// <summary>
        /// Inserta una carta al principio de la baraja
        /// </summary>
        /// <param name="idcarta">número representa la carta</param>
        public void InsertaCartaPrincipio(int idcarta)
        {
            listaCartas.Insert(0, new Carta(idcarta));
        }

        /// <summary>
        /// Introduce al final de la baraja la carta c
        /// </summary>
        /// <param name="c">carta</param>
        public void InsertaCartaFinal(Carta c)
        {
            listaCartas.Add(c);
        }

        /// <summary>
        /// Inserta la carta c al principio de la baraja
        /// </summary>
        /// <param name="c">carta</param>
        public void InsertaCartaPrincipio(Carta c)
        {
            listaCartas.Insert(0, c);
        }

        /// <summary>
        /// Número de cartas que quedan en mi baraja
        /// </summary>
        public int NumeroCartas
        {
            get
            {
                return this.listaCartas.Count;
            }
        }

        /// <summary>
        /// Nos devuelve true si esta vacio y false si no
        /// </summary>
        public bool Vacia
        {
            get
            {
                bool vacio = false;
                if (this.listaCartas.Count == 0)
                {
                     vacio = true;
                }

                return vacio;
            }
        }
    }
}
