using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;

namespace Entidades
{
    public class Cliente : Persona
    {
        private Articulo articulo;
        private FormaDePago formaDePago;
        private float totalAbonar;
        public enum FormaDePago
        {
            Tarjeta, Efectivo, TarjetaJubilado
        }

        public float Total
        {
            get
            {
                return this.totalAbonar;
            }
            set
            {
                this.totalAbonar = PrecioFinal(value, formaDePago);
            }
        }

        public Cliente(string nombre, string apellido, Articulo articulo, FormaDePago forma) : base(nombre, apellido)
        {
            this.articulo = articulo;
            this.formaDePago = forma;
            this.Total = articulo.Precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLIENTE");
            sb.Append(base.ToString());
            sb.AppendLine($"Producto del rubro: {articulo.Tipo} de precio: ${articulo.Precio}");
            sb.AppendLine($"Abonando con: {this.formaDePago}, abona total de: ${this.Total}");
            return sb.ToString();
        }

        private float PrecioFinal(float precio, FormaDePago forma)
        {
            float precioFinal = precio;
            switch (forma)
            {
                case FormaDePago.Tarjeta:
                    return precioFinal;
                case FormaDePago.Efectivo:
                    float descuento = 10 * precio / 100;
                    precioFinal -= descuento;
                    break;
                case FormaDePago.TarjetaJubilado:
                    float descuentoJ = 50 * precio / 100;
                    precioFinal -=  descuentoJ;
                    break;
            }
            return precioFinal;
        }
    }
}
