using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arboles_y_Grafos__Estructuras_de_Datos.Modelo
{
     class ArbolBinario
    {
        public NodoBinario raiz;
        private decimal nodos;
        private decimal hojas;
        private NodoBinario padre;
        public NodoBinario padreCoordenadas;
        private Boolean posicionPadre;

        public ArbolBinario()
        {
            raiz = null;
            nodos = 0;
        }

        //Buscar un nodo

        public NodoBinario buscarNodo(decimal dato)
        {
            return buscarNodo(dato, raiz);
        }

        private NodoBinario buscarNodo(decimal dato, NodoBinario nodoActual)
        {
            if(nodoActual == null)
            {
                return null;
            }

            if(dato == nodoActual.Dato)
            {
                return nodoActual;
            }

            padre = nodoActual;

            if (dato > nodoActual.Dato)
            {
                posicionPadre = true;
                return buscarNodo(dato, nodoActual.Derecha);
            }
            else
            {
                posicionPadre = false;
                return buscarNodo(dato, nodoActual.Izquierda);
            }
        }
        //--------------------------------------------------------

        // Insertar nodo
        public NodoBinario insertarNodo(decimal dato)
        {
            if(raiz == null)
            {
                raiz = new NodoBinario(dato);
                return raiz;
            }
            else if(buscarNodo(dato) != null)
            {
                throw new Exception("No se puede repetir nodos");
                
            }
            else
            {
                return insertarNodo(dato, raiz);
            }
        }

        public Boolean arbolVacio()
        {
            if(raiz == null)
            {
                return true;
            }
            return false;
        }

        private NodoBinario insertarNodo(decimal dato, NodoBinario nodoActual)
        {
            if(dato < nodoActual.Dato)
            {
                if(nodoActual.Izquierda == null)
                {
                    nodoActual.Izquierda = new NodoBinario(dato);
                    padreCoordenadas = nodoActual;
                    return nodoActual.Izquierda;
                }
                else
                {
                    return insertarNodo(dato, nodoActual.Izquierda);
                }
            }
            else if (nodoActual.Derecha == null)
            {
                nodoActual.Derecha = new NodoBinario(dato);
                padreCoordenadas = nodoActual;
                return nodoActual.Derecha;
            }
            else
            {
                return insertarNodo(dato, nodoActual.Derecha);
            }
        }

        //NodoMayor
        public Boolean nodoMayor(NodoBinario nodoAnalizable)
        {
            return (nodoAnalizable.Derecha.Dato > nodoAnalizable.Izquierda.Dato) ? true : false;
        }

        //--------------------------------------------------------

        //eliminar nodo

        public void eliminarNodo(decimal dato)
        {
            if(raiz == null)
            {
                throw new Exception("El arbol está vacio");
            }
            if(dato == raiz.Dato)
            {
                eliminarRaiz();
            }
            if(buscarNodo(dato) == null)
            {
                throw new Exception("No se puede eliminar un nodo que no existe");
            }
            else
            {
                eliminar(dato);
            }
        }

        private void eliminarRaiz()
        {
            if(raiz.esHoja())
            {
                raiz = null;
            }
            else if(raiz.tieneUnHijo())
            {
                if(raiz.PosicionHijo)
                {
                    raiz = raiz.Derecha;
                }
                else
                {
                    raiz = raiz.Izquierda;
                }
            }
            else
            {
                Boolean mayor = nodoMayor(raiz);
                if(mayor)
                {
                    raiz = raiz.Derecha;
                }
            }
        }

        private void eliminar(decimal dato)
        {
            NodoBinario nodo = buscarNodo(dato);
            
            if(nodo.esHoja())
            {
                nodo = null;
                if(posicionPadre)
                {
                    padre.Derecha = null;
                }
                else
                {
                    padre.Izquierda = null;
                }
            }
            if(nodo.tieneUnHijo())
            {
                if(nodo.PosicionHijo)
                {
                    if(posicionPadre)
                    {
                        padre.Derecha = nodo.Derecha;
                    }
                    else
                    {
                        padre.Izquierda = nodo.Izquierda;
                    }
                }
            }
            else
            {
                Boolean mayor = nodoMayor(nodo);
                if(mayor)
                {
                    if(posicionPadre)
                    {
                        padre.Derecha = nodo.Derecha;
                    }
                    else
                    {
                        padre.Izquierda = nodo.Derecha;
                    }
                    nodo.Derecha.Izquierda = nodo.Izquierda;
                }
                else
                {
                    if(posicionPadre)
                    {
                        padre.Derecha = nodo.Izquierda;
                    }
                    else
                    {
                        padre.Izquierda = nodo.Izquierda;
                    }
                    nodo.Izquierda.Derecha = nodo.Derecha;;
                }

            }
        }
    }
}
