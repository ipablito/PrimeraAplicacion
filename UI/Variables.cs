using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace UI
{
    public class Variables
    {
        public static int idUsuarioLogeado=0;//para almacenar el id del usuario q se logee


        public static bool encontrado = false;

        public static int indice;//serian los id
        public static string nombre_indice;

        public static string contexto;//esto es lo q voy a mostar en los textos
        public static string nombre_contexto;

        public static void resetearvariables()
        {
            encontrado = false;
            indice = 0;
            nombre_indice = null;
            contexto = null;
            nombre_contexto = null;
        }



        //estas variables me van a servir para las compras
        public static int nidproveedor;
    }
}
