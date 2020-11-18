using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arboles_y_Grafos__Estructuras_de_Datos.Modelo.Grafo;
using Arboles_y_Grafos__Estructuras_de_Datos.Modelo;
using System.Windows.Forms;

namespace Arboles_y_Grafos__Estructuras_de_Datos
{
    public partial class Creador_Arboles : Form
    {
        LecturaJSOn lectura = new LecturaJSOn();
        int contador = 0;
        int posicionraizx = 310;
        int posicionraizy = 36;
        decimal NodoActual = 0;
        NodoBinario valorraiz;
        ArbolBinario ArbolBinario = new ArbolBinario();
        List<int[]> nodosRelacionados = new List<int[]>();
        public Creador_Arboles()
        {
            InitializeComponent();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Boron crear nodos
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupo_creacion.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Grupo_creacion.Visible = false;
            grupoJson.Visible = true;
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_agregarDato_Click(object sender, EventArgs e)
        {
            Graphics Nodo;
            String dato = txt_dato.Text;
            decimal raiz;
            String valor_parcial = "";
            decimal[] dato_final = new decimal[9];
            int cont = 0;
            try
            {
                if (dato == "")
                {
                    throw new Exception("por favor ingrese datos");
                }
                for (int i = 0; i <= dato.Length; i++)
                {
                    if (i == dato.Length)
                    {
                        i--;
                        dato_final[cont] = Convert.ToDecimal(valor_parcial);
                        break;
                    }
                    if (dato.Substring(i, 1) == ",")
                    {
                        dato_final[cont] = Convert.ToDecimal(valor_parcial);
                        valor_parcial = "";
                        cont++;
                    }
                    else
                    {
                        valor_parcial += dato.Substring(i, 1);
                    }
                }
                for (int j = 0; j <= cont; j++)
                {   
                    if (contador < 15)
                    {
                        if (ArbolBinario.arbolVacio())
                        {
                            raiz = dato_final[j];
                            ArbolBinario.insertarNodo(raiz);
                            ArbolBinario.raiz.X = posicionraizx;
                            ArbolBinario.raiz.Y = posicionraizy;
                            Nodo = CreateGraphics();
                            Nodo.FillEllipse(Brushes.Black, posicionraizx, posicionraizy, 35, 35);
                            Nodo.DrawString(Convert.ToString(raiz), Font, Brushes.White, 320, 46);
                            Pen borde = new Pen(Color.Green, 3);
                            Nodo.DrawEllipse(borde, posicionraizx, posicionraizy, 35, 35);
                            contador ++;
                        }
                        else
                        {
                            NodoBinario nodoNuevo = ArbolBinario.insertarNodo(dato_final[j]);
                            ArbolBinario.padreCoordenadas.calcularPoscision(nodoNuevo);
                            Nodo = CreateGraphics();
                            Pen linea = new Pen(Color.Red, 3);
                            Nodo.DrawLine(linea, ArbolBinario.padreCoordenadas.X + 18, ArbolBinario.padreCoordenadas.Y + 35, nodoNuevo.X + 10, nodoNuevo.Y + 10);
                            Nodo.FillEllipse(Brushes.Black, nodoNuevo.X, nodoNuevo.Y, 35, 35);
                            Nodo.DrawString(Convert.ToString(dato_final[j]), Font, Brushes.White, nodoNuevo.X + 10, nodoNuevo.Y + 10);
                            Pen borde = new Pen(Color.Green, 3);
                            Nodo.DrawEllipse(borde, nodoNuevo.X, nodoNuevo.Y, 35, 35);
                            contador ++;


                        }
                        txt_dato.Text = "";
                    }
                    else
                    {
                        throw new Exception("Numero Maximo de nodos permitidos");
                        
                    }
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void btn_Agregar_Directorio_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            string Directorio = txt_directorio.Text;
            List<Grafo> grafo = lectura.lecturajson(Directorio);
            List<Nodo> listadonodos = new List<Nodo>();
            List<Arco> listadoarcos = new List<Arco>();
            foreach (Grafo g in grafo)
            {
                listadonodos.AddRange(g.nodo);
                listadoarcos.AddRange(g.Arco);
            }
            Nodo nodo = new Nodo();
            dibujo(listadonodos);
            dibujoArco(listadoarcos);
            creartabla(listadonodos,listadoarcos);
            //crearListaAdyacencia(listadonodos);
        }

        public void dibujo(List<Nodo> nodos)
        {
            foreach (Nodo n in nodos)
            {
                Graphics Nodo;
                Nodo = CreateGraphics();
                Pen linea = new Pen(Color.Black, 5);
                Nodo.FillEllipse(Brushes.Black, n.posicionX, n.posicionY, 35, 35);
                Nodo.DrawString(Convert.ToString(n.identificador), Font, Brushes.White, n.posicionX + 10, n.posicionY + 10);
                Pen borde = new Pen(Color.Green, 3);
                Nodo.DrawEllipse(borde, n.posicionX, n.posicionY, 35, 35);

            }
        }
        public void dibujoArco(List<Arco> arcos)
        {
            foreach (Arco a in arcos)
            {
                Graphics Nodo;
                Nodo = CreateGraphics();
                Pen linea = new Pen(Color.Fuchsia, 1);
                Nodo.DrawLine(linea, a.posicion_inicialx+ 18, a.Posicion_inicialy + 35, a.Posicion_finalx + 10, a.posicion_finalY + 10);
                Nodo.DrawString(Convert.ToString(a.Valorpeso), Font, Brushes.Blue, (a.posicion_inicialx+a.Posicion_finalx)/2,(a.Posicion_inicialy + a.posicion_finalY)/2);
                
            }
        }

        public void creartabla(List<Nodo> nodos, List<Arco> arcos)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col21 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col32 = new DataGridViewTextBoxColumn();
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { col, col2, col3 });
            col.Name = "Arco";
            col2.Name = "inicia " ; 
            col3.Name = "termina " ;

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col1, col21, col32 });
            col1.Name = "NODO";
            col21.Name = "Adyacente 1";
            col32.Name = "Adyacente 2";

            int nombrevertice= 0;
            int inicia = 0;
            int termina=0;
            List<int> iniciales = new List<int>();
            List<int> finales =new List < int>();

            for (int i = 0; i < arcos.Count; i++)
            {
                
                for (int j = 0; j < nodos.Count; j++)
                {
                    if (arcos[i].Posicion_inicialx == nodos[j].posicionX && arcos[i].posicion_inicialy == nodos[j].posicionY)
                    {
                        nombrevertice = arcos[i].vertice;
                        inicia = nodos[j].identificador;
                        iniciales.Add(inicia);
                    }
                    if (arcos[i].posicion_finalx == nodos[j].posicionX && arcos[i].posicion_finalY == nodos[j].posicionY)
                    {
                        termina = nodos[j].identificador;
                        finales.Add(termina);
                    }  
                }
                int[] nodos_Relacionados = new int[2];
                nodos_Relacionados[0] = inicia;
                nodos_Relacionados[1] = termina;

                nodosRelacionados.Add(nodos_Relacionados);
                dataGridView2.Rows.Add(nombrevertice, inicia, termina);
            }

            foreach (Nodo n in nodos)
            {
                int ad1 = 5;
                int ad2 = 5;
                for (int i=0;  i<iniciales.Count;i++)
                {
                    
                        if (n.identificador == iniciales[i]) 
                        {
                             ad1 = finales[i];
                        }
                        if (n.identificador == finales[i])
                        {
                            ad2 = iniciales[i];
                        }
                    int nombrenodo = n.identificador;
                    dataGridView1.Rows.Add(nombrenodo, ad1, ad2);
                }
                
            }
        }

      /*  public void crearListaAdyacencia(List<Nodo> nodos)
        {
            for (int i = 0; i < nodos.Count; i++)
            {
                foreach (int[] item in nodosRelacionados)
                {
                    List<int> nodos_a = new List<int>();
                    foreach (Nodo nodo in nodos)
                    {
                        
                        if (item[0] == nodo.identificador)
                        {
                            
                            nodos_a.Add(item[0]);
                            nodos_a.Add(item[1]);
                        }
                        if(item[1] == nodo.identificador)
                        {
                            nodos_a.Add(item[1]);
                            nodos_a.Add(item[0]);
                        }
                    }
                    int[] nodosAdyacentes = new int [nodos_a.Count];
                    dataGridView1.Rows.Add(nodosAdyacentes);
                }
            }
        }*/
    }
}
