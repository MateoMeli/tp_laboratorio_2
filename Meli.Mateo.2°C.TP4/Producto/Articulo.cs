using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Articulo
    {
        public enum TipoProducto
        {
            Antibiotico, Crema, Analgesico
        }

        private TipoProducto tipo;
        private float precio;

        public TipoProducto Tipo
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
        

        public Articulo(TipoProducto tipoProducto)
        {
            this.Tipo = tipoProducto;
            switch (tipoProducto)
            {
                case TipoProducto.Analgesico:
                    this.Precio = 120f;
                    break;
                case TipoProducto.Antibiotico:
                    this.Precio = 150f;
                    break;
                case TipoProducto.Crema:
                    this.Precio = 250f;
                    break;
            }
        }
    }
}
