using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Arboles_y_Grafos__Estructuras_de_Datos.Modelo.Grafo;

 class LecturaJSOn
{
    public List<Grafo> lecturajson(string Directorio)
    {
        string datosjson = LecturaJSONfromfile(Directorio);
        List<Grafo> listagrafo = Extraerdatos(datosjson);
        return listagrafo;
       
    }


    public  string LecturaJSONfromfile(string Directorio)
    {
        string datosjson;
        using (var reader = new StreamReader(Directorio))
        {
            datosjson = reader.ReadToEnd();

        }
        return datosjson; 
    }
  

    public List<Grafo> Extraerdatos(string datosjson)
     {
        
         var listadatos = JsonConvert.DeserializeObject<List<Grafo>>(datosjson);

        return listadatos;
        
     }


}