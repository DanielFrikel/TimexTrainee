using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    public class TestingDataTables
    {
        public void testingDataTables() {
            // Crear una nueva DataTable
            DataTable dataTable = new DataTable("EjemploTabla");            

            // Definir las columnas (Encabezados)
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Edad", typeof(int));

            // Agregar filas a la DataTable (Contenido)
            dataTable.Rows.Add(1, "Juan", 30);
            dataTable.Rows.Add(2, "María", 25);
            dataTable.Rows.Add(3, "Carlos", 35);

            // Iterar a través de las filas y columnas de la DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Nombre: {row["Nombre"]}, Edad: {row["Edad"]}");
            }

            Console.Write("Columnas: ");
            foreach (DataColumn column in dataTable.Columns)
            {
                Console.Write($"{column} ");
            }

            // Realizar una consulta utilizando LINQ to DataSet
            var consulta = from fila in dataTable.AsEnumerable()
                           where fila.Field<int>("Edad") > 30
                           select fila;

            Console.WriteLine("\n\nPersonas mayores de 30 años:");
            foreach (var resultado in consulta)
            {
                Console.WriteLine($"ID: {resultado["ID"]}, Nombre: {resultado["Nombre"]}, Edad: {resultado["Edad"]}");
            }
            
            //Esta comparacion es sensible a mayusculas y minusculas
            //la variable a se crea es tipo var y es temporal.
            var consulta2 = from a in dataTable.AsEnumerable()
                            where a.Field<string>("Nombre") == "Carlos"
                            select new 
                            { 
                                Edad = a.Field<int>("Edad"), 
                                Nombre = a.Field<string>("Nombre")
                            };
  
            foreach (var resultado2 in consulta2)
            {
                Console.WriteLine($"Nombre: {resultado2.Nombre}, Edad: {resultado2.Edad}");                
                //Console.WriteLine($"ID: {resultado["ID"]}, Nombre: {resultado["Nombre"]}, Edad: {resultado["Edad"]}");
            }

            //var consulta = from fila in dataTable.AsEnumerable()
            //               where fila.Field<int>("Edad") > 30
            //               select new
            //               {
            //                   Nombre = fila.Field<string>("Nombre"),
            //                   Edad = fila.Field<int>("Edad")
            //               };
        }
    }
}
