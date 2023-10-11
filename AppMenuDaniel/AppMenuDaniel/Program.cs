using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenuDaniel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicaciones:
            //Proyecto de Consola
            //con Interfaz de Menu
            //con Opciones: 1,2,3,4 Numerico,
            //de ahi que lleve al Proceso a realizar
            //Separar Responsabilidades, SOLO Trasladar Valores o Datos NO un Objeto Completo para Comunicar.
            //Utilizar Proyectos del Curso como Opciones.
            Menu.startMenu();

            Console.ReadKey();
        }
    }
}
