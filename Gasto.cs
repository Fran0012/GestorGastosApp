using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorGastosApp
{
   public class Gasto
    {
        private static int ultimoID = 0;
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        
        public string Descripcion { get; set; }
        public float Monto { get; set; }
        public string Categoria { get; set; }



        public Gasto() { }
        public Gasto(float monto, string categoria, DateTime fecha, string descripcion)
        {
            ID = ++ultimoID; // Se incrementa automáticamente
            Monto = monto;
            Categoria = categoria;
            Fecha = fecha;
            Descripcion = descripcion;
        }
        public string Format()
        {
            return $"{ID};{Fecha};{Monto};{Categoria};{Descripcion}";
        }
        public override string ToString()
        {
            return $"{ID} - {Fecha.ToString("yyyy-MM-dd")} - ${Monto} - {Categoria} - {Descripcion}";
        }
        public string GetID()
        {
            return $"{ID}";
        }

    }
}
