using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Articulo
    {
        public enum TipoProdcto
        {
            Antibiotico, Crema, Analgesico
        }

        private TipoProdcto tipo;
        private float precio;
        private string nombre;
        private int codigo;

        public TipoProdcto Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public Articulo(TipoProdcto tipoProdcto, float precio, int codigo, string nombre)
        {
            this.Nombre = nombre;
            this.Tipo = tipoProdcto;
            this.Precio = precio;
            this.Codigo = codigo;
        }
    }
}
