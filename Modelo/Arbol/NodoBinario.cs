using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_y_Grafos__Estructuras_de_Datos.Modelo
{
    public class NodoBinario
    {
        private decimal dato;
        private NodoBinario izquierda;
        private NodoBinario derecha;
        private Boolean posicionHijo;
        private int x;
        private int y;
        private bool control;

        public NodoBinario(decimal dato)
        {
            Dato = dato;
            Izquierda = null;
            Derecha = null;
            X = 0;
            Y = 0;
            control = false;
        }

        public decimal Dato { get => dato; set => dato = value; }
        internal NodoBinario Izquierda { get => izquierda; set => izquierda = value; }
        internal NodoBinario Derecha { get => derecha; set => derecha = value; }
        public Boolean PosicionHijo { get => posicionHijo; set => posicionHijo = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Boolean esHoja()
        {
            return (Izquierda == null && Derecha == null) ? true : false;
        }

        public Boolean tieneUnHijo()
        {
            if(Izquierda != null && Derecha == null)
            {
                PosicionHijo = false;
                return true;
            }
            else if(Izquierda == null && Derecha != null)
            {
                PosicionHijo = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void calcularPoscision(NodoBinario dato)
        { 

            if (Derecha != null)
            {

                if (Derecha.Dato == dato.dato && control ==true)
                {
                    dato.X = X + 120;
                    dato.Y = Y + 90;
                    control = false;
                }
                else if (Derecha.Dato == dato.dato && control == false)

                {
                    dato.X = X + 50;
                    dato.Y = Y + 40;
                    control = true;
                }
            }
            if(Izquierda != null)
            {
                if (Izquierda.Dato == dato.dato && control == false)
                {
                    dato.X = X - 80;
                    dato.Y = Y + 60;
                    control = true;
                }
                else if (Izquierda.Dato == dato.dato && control == true)
                {
                    dato.X = X - 30;
                    dato.Y = Y + 25;
                    control = false;
                }
            }
        }
    }
}
