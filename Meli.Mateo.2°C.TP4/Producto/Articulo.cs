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

        public Articulo(TipoProdcto tipoProducto, int codigo, string nombre)
        {
            this.Nombre = nombre;
            this.Tipo = tipoProducto;
            this.Codigo = codigo;
            switch (tipoProducto)
            {
                case TipoProdcto.Analgesico:
                    this.Precio = 120f;
                    break;
                case TipoProdcto.Antibiotico:
                    this.Precio = 150f;
                    break;
                case TipoProdcto.Crema:
                    this.Precio = 250f;
                    break;
            }
        }
    }
}
