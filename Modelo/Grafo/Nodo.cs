using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace Arboles_y_Grafos__Estructuras_de_Datos.Modelo.Grafo
{
    public class Nodo : Form
    {
        public int identificador;
        public int posicionX;
        public int posicionY;

        public int Identificador { get => identificador; set => identificador = value; }
        public int PosicionX { get => posicionX; set => posicionX = value; }
        public int PosicionY { get => posicionY; set => posicionY = value; }
    }
}
