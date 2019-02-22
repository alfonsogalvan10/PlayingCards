using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajadeCartas
{
    class Carta
    {

        private int numero;
        private int palo;

        /// <summary>
        /// Nos crea una carta
        /// </summary>
        /// <param name="numero">Valores entre 1 y 10</param>
        /// <param name="palo">Valores entre 0 y 3</param>
        public Carta(int numero, int palo)
        {
            if (numero >= 1 && numero <= 10 && palo >= 0 && palo <= 3)
            {
                this.numero = numero;
                this.palo = palo;
            }
            else
            {
                throw new Exception("Valores de carta erróneo");
            }
        }

        /// <summary>
        /// Nos crea la carta por el palo escogido
        /// </summary>
        /// <param name="id">Valores entre 1 y 40</param>
        public Carta(int id)
        {
            if (id < 1 || id > 40)
            {
                throw new Exception("Número de carta erróneo");
            }
            else
            {
                if (id <= 10)
                {
                    this.palo = 0;
                    this.numero = id;
                }
                else
                {
                    if (id <= 20)
                    {
                        this.palo = 1;
                        this.numero = id - 10;
                    }
                    else
                    {
                        if (id <= 30)
                        {
                            this.palo = 2;
                            this.numero = id - 20;
                        }
                        else
                        {
                            if (id <= 40)
                            {
                                this.palo = 3;
                                this.numero = id - 30;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Numero de la carta
        /// </summary>
        public int Numero
        {
            get
            {
                return this.numero;
            }

        }

        /// <summary>
        /// Palo de la carta
        /// </summary>
        public int Palo
        {
            get
            {
                return this.palo;
            }
        }

        /// <summary>
        /// Nombre del número de la carta
        /// </summary>
        public string NombreNumero
        {
            get
            {
                string nombre = "";

                switch (this.numero)
                {
                    case 1: nombre = "as"; break;
                    case 2: nombre = "dos"; break;
                    case 3: nombre = "tres"; break;
                    case 4: nombre = "cuatro"; break;
                    case 5: nombre = "cinco"; break;
                    case 6: nombre = "seis"; break;
                    case 7: nombre = "siete"; break;
                    case 8: nombre = "sota"; break;
                    case 9: nombre = "caballo"; break;
                    case 10: nombre = "rey"; break;
                }
                return nombre;
            }
        }

        /// <summary>
        /// Nombre del palo
        /// </summary>
        public string NombrePalo
        {
            get
            {
                string[] nombres = { "oros", "copas", "espadas", "bastos" };
                return nombres[this.palo];
            }
        }

        /// <summary>
        /// Nombre de la carta completa
        /// </summary>
        public string NombreCarta
        {
            get
            {
                return NombreNumero + " de " + NombrePalo;
            }
        }

        /// <summary>
        /// Valor de la carta en el tute
        /// </summary>
        public int ValorTute
        {
            get
            {
                switch (this.numero)
                {
                    case 1: return 11;
                    case 3: return 10;
                    case 8: return 2;
                    case 9: return 3;
                    case 10: return 4;
                    default: return 0;
                }
            }
        }

        /// <summary>
        /// Valor de la carta en el mus
        /// </summary>
        public int ValorMus
        {
            get
            {
                switch (this.numero)
                {
                    case 1:
                    case 2: return 1;

                    case 3:
                    case 8:
                    case 9:
                    case 10: return 10;

                    default: return this.numero;
                }
            }
        }

        /// <summary>
        /// Valor de la carta en el siete y medio
        /// </summary>
        public decimal Valor7ymedia
        {
            get
            {
                switch (this.numero)
                {
                    case 8:
                    case 9:
                    case 10: return 0.5m;
                    default: return this.numero;
                }
            }
        }
    }
}
