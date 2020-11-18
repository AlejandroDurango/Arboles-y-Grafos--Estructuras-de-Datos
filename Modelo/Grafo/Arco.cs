using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_y_Grafos__Estructuras_de_Datos.Modelo.Grafo
{
    public class Arco
    {
        public int vertice;
        public int posicion_inicialx;
        public int posicion_inicialy;
        public int posicion_finalx;
        public int posicion_finalY;
        public int valorpeso;





        public int Vertice { get => vertice; set => vertice = value; }
        public int Posicion_inicialx { get => posicion_inicialx; set => posicion_inicialx = value; }
        public int Posicion_inicialy { get => posicion_inicialy; set => posicion_inicialy = value; }
        public int Posicion_finalx { get => posicion_finalx; set => posicion_finalx = value; }
        public int Posicion_finalY { get => posicion_finalY; set => posicion_finalY = value; }
        public int Valorpeso { get => valorpeso; set => valorpeso = value; }
    }
}
