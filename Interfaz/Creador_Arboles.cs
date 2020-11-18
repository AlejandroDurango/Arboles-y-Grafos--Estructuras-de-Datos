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
            decimal valor = txt_dato.Value;
            decimal raiz;

            if (contador < 10)
            {
                try
                {
                    if (ArbolBinario.arbolVacio())
                    {
                        raiz = valor;
                        ArbolBinario.insertarNodo(valor);
                        ArbolBinario.raiz.X = posicionraizx;
                        ArbolBinario.raiz.Y = posicionraizy;
                        Nodo = CreateGraphics();
                        Nodo.FillEllipse(Brushes.Black, posicionraizx, posicionraizy, 35, 35);
                        Nodo.DrawString(Convert.ToString(raiz), Font, Brushes.White, 320, 46);
                        Pen borde = new Pen(Color.Green, 3);
                        Nodo.DrawEllipse(borde, posicionraizx, posicionraizy, 35, 35);
                        contador += 1;


                    }
                    else
                    {
                        NodoBinario nodoNuevo = ArbolBinario.insertarNodo(valor);
                        ArbolBinario.padreCoordenadas.calcularPoscision(nodoNuevo);
                        Nodo = CreateGraphics();
                        Pen linea = new Pen(Color.Red, 3);
                        Nodo.DrawLine(linea, ArbolBinario.padreCoordenadas.X + 18, ArbolBinario.padreCoordenadas.Y + 35, nodoNuevo.X + 10, nodoNuevo.Y + 10);
                        Nodo.FillEllipse(Brushes.Black, nodoNuevo.X, nodoNuevo.Y, 35, 35);
                        Nodo.DrawString(Convert.ToString(valor), Font, Brushes.White, nodoNuevo.X + 10, nodoNuevo.Y + 10);
                        Pen borde = new Pen(Color.Green, 3);
                        Nodo.DrawEllipse(borde, nodoNuevo.X, nodoNuevo.Y, 35, 35);
                        contador += 1;
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_dato.Value = 1;
            }
            else
            {
                MessageBox.Show("Numero Maximo de nodos permitidos");
                btn_agregarDato.Visible = false;

            }
        }

        private void btn_Agregar_Directorio_Click(object sender, EventArgs e)
        {
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

            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { col, col2 });
            foreach (Arco a in arcos)
            {
                DataGridViewRow row = new DataGridViewRow();
                dataGridView2.Rows.AddRange(new DataGridViewRow[] { row });

            }
            

            for (int i = 0; i < arcos.Count; i++)
            {
                for (int j = 0; j < nodos.Count; j++)
                {
                    if (arcos[i].Posicion_inicialx == nodos[j].posicionX && arcos[i].posicion_inicialy == nodos[j].posicionY)
                    {
                        dataGridView2.Rows.Insert(i, nodos[j].identificador);
                    }
                }
               
            }
           
            foreach (Nodo n in nodos)
            {
                string nombre = (Convert.ToString(n.identificador));
                DataGridViewRow row = new DataGridViewRow();
                col.Name = nombre;
                dataGridView1.Columns.AddRange(new DataGridViewColumn[] {col});
                dataGridView1.Rows.AddRange(new DataGridViewRow[]{ row });
            }
            
            dataGridView1.ColumnHeadersVisible = true; //Oculta las cabecera de columnas
            dataGridView1.RowHeadersVisible = true; //Oculta las cabecera de columnas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Rows.Insert(0, 4, 18, 37, 59, 60);

           
        }
    

    }
}
