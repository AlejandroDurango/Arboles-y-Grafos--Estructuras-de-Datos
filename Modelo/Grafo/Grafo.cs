using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arboles_y_Grafos__Estructuras_de_Datos.Modelo.Grafo;
using System.Collections;

namespace Arboles_y_Grafos__Estructuras_de_Datos.Modelo.Grafo
{
    public class Grafo
    {
        public List<Nodo> nodo;
        private List<Arco> arco;


      
        public List<Nodo> Nodo { get => nodo; set => nodo = value; }
        public List<Arco> Arco { get => arco; set => arco = value; }
    }
}
