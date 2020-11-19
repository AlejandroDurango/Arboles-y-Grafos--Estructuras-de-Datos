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
        List<NodoBinario> NodosDibujados = new List<NodoBinario>();
        ArbolBinario ArbolBinario = new ArbolBinario();
        List<int[]> nodosRelacionados = new List<int[]>();
        List<Graphics> nodosArboles = new List<Graphics>();
        Graphics Nodo;

        public Creador_Arboles()
        {
            Nodo = CreateGraphics();
            InitializeComponent();
        }

        //Boron crear nodos
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Grupo_creacion.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            grupoJson.Visible = false;
            txt_directorio.Clear();
            Nodo.Clear(Color.White);

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
                    if (contador < 10)
                    {
                        if (ArbolBinario.arbolVacio())
                        {
                            raiz = dato_final[j];
                            NodoBinario nodoRaiz = ArbolBinario.insertarNodo(raiz);
                            NodosDibujados.Add(nodoRaiz);
                            ArbolBinario.raiz.X = posicionraizx;
                            ArbolBinario.raiz.Y = posicionraizy;
                            Nodo = CreateGraphics();
                            Nodo.FillEllipse(Brushes.Black, posicionraizx, posicionraizy, 35, 35);
                            Nodo.DrawString(Convert.ToString(raiz), Font, Brushes.White, 320, 46);
                            Pen borde = new Pen(Color.Green, 3);
                            Nodo.DrawEllipse(borde, posicionraizx, posicionraizy, 35, 35);
                            contador++;
                        }
                        else
                        {
                            NodoBinario nodoNuevo = ArbolBinario.insertarNodo(dato_final[j]);
                            NodosDibujados.Add(nodoNuevo);
                            ArbolBinario.padreCoordenadas.calcularPoscision(nodoNuevo);
                            Nodo = CreateGraphics();
                            Pen linea = new Pen(Color.Red, 3);
                            Nodo.DrawLine(linea, ArbolBinario.padreCoordenadas.X + 18, ArbolBinario.padreCoordenadas.Y + 35, nodoNuevo.X + 10, nodoNuevo.Y + 10);
                            Nodo.FillEllipse(Brushes.Black, nodoNuevo.X, nodoNuevo.Y, 35, 35);
                            Nodo.DrawString(Convert.ToString(dato_final[j]), Font, Brushes.White, nodoNuevo.X + 10, nodoNuevo.Y + 10);
                            Pen borde = new Pen(Color.Green, 3);
                            Nodo.DrawEllipse(borde, nodoNuevo.X, nodoNuevo.Y, 35, 35);
                            contador++;


                        }
                        txt_dato.Text = "";
                    }
                    else
                    {
                        throw new Exception("Numero Maximo de nodos permitidos");
                       

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = txt_EliminarDato.Text;
                NodoBinario nodo = ArbolBinario.buscarNodo(Convert.ToDecimal(dato));
                if (nodo == null)
                {
                    MessageBox.Show("No se puede eliminar un nodo que no existe");
                }
                else
                {
                    foreach (NodoBinario nodo_dibujo in NodosDibujados)
                    {
                        if (nodo == nodo_dibujo)
                        {
                            NodosDibujados.Remove(nodo);
                            break;
                        }
                    }
                    int cont = 0;
                    string datos = "";
                    foreach (NodoBinario item in NodosDibujados)
                    {
                        if (item == null)
                        {
                            continue;
                        }
                        else
                        {
                            ArbolBinario.eliminarNodo(Convert.ToDecimal(item.Dato));
                        }

                    }
                    foreach (NodoBinario nodo_dibujo in NodosDibujados)
                    {
                        nodo_dibujo.X = 0;
                        nodo_dibujo.Y = 0;
                        if (cont == 0)
                        {
                            datos += Convert.ToString(nodo_dibujo.Dato);
                        }
                        else
                        {
                            datos += "," + Convert.ToString(nodo_dibujo.Dato);
                        }
                        cont++;
                    }
                    Nodo.Clear(Color.White);
                    txt_dato.Text = datos;
                    btn_agregarDato_Click(sender, e);

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
            dataGridView3.Visible = true;
            dataGridView1.Visible = true;
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
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col21 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col32 = new DataGridViewTextBoxColumn();
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { col, col2, col3 });
            col.Name = "Arco";
            col2.Name = "inicia ";
            col3.Name = "termina ";

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col1, col21, col32 });
            col1.Name = "NODO";
            col21.Name = "Adyacente 1";
            col32.Name = "Adyacente 2";

            int nombrevertice = 0;
            int inicia = 0;
            int termina = 0;
            List<int> iniciales = new List<int>();
            List<int> finales = new List<int>();

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

            //crea filas con los nombres
            for (int d = 0; d < nodos.Count; d++)
            {
                int nombrenodo = nodos[d].identificador;
                dataGridView1.Rows.Add(nombrenodo, null, null);
            }
            // lista adyacencia
            for (int j = 0; j < nodos.Count; j++)
            {
                //ingresa los datos adyacentes1
                for (int i = 0; i < iniciales.Count; i++)
                {

                    if (nodos[j].identificador == finales[i])
                    {

                        dataGridView1.Rows[j].Cells[1].Value = Convert.ToString(iniciales[i]);
                       
                    }

                }
                //ingresa los datos adyacentes2
                for (int k = 0; k < finales.Count; k++)
                {
                    if (nodos[j].identificador == iniciales[k])
                    {
                        dataGridView1.Rows[j].Cells[2].Value = Convert.ToString(finales[k]);

                    }
                }
                dataGridView1.Rows[0].Cells[1].Value = 1;

            }
            dataGridView3.Visible = true;
            //crear Matriz  
            {
                DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
                dataGridView3.Columns.AddRange(new DataGridViewColumn[] { name });
                name.Name = "NODOS";
                foreach (Nodo item in nodos)
                {
                    
                    dataGridView3.Columns.AddRange(new DataGridViewColumn[] { new DataGridViewTextBoxColumn() });
                    new DataGridViewTextBoxColumn().Name = Convert.ToString(item.identificador);
                    dataGridView3.Rows.Add(item.identificador, null);
                }
                foreach (int[] nr in nodosRelacionados)
                {
                    int n1 = nr[0];
                    int n2 = nr[1];
                    for (int i = 0; i < nodos.Count; i++)
                    {
                        if (n1 == Convert.ToInt32( dataGridView3.Rows[i].Cells[0].Value))
                        {
                            for (int j = 0; j < nodos.Count; j++)
                            {   
                                if (n2 ==nodos[j].identificador)
                                {
                                    dataGridView3.Rows[i].Cells[j+1].Value= 1;
                                }

                            }
                        }
                        if (n2 == Convert.ToInt32(dataGridView3.Rows[i].Cells[0].Value))
                        {
                            for (int j = 0; j < nodos.Count; j++)
                            {
                                if (n1 == nodos[j].identificador)
                                {
                                    dataGridView3.Rows[i].Cells[j + 1].Value = 1;
                                }

                            }
                        }
                    }
                }

            }
        }
            
          

    }




    
}
