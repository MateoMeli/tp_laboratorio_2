using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;
using Excepciones;

namespace Entidades
{
    public class Cliente : Persona
    {
        private Articulo articulo;
        private FormaDePago formaDePago;
        private float totalAbonar;
        private DateTime fechaYHora;
        public enum FormaDePago
        {
            Tarjeta, Efectivo, TarjetaJubilado
        }

        public DateTime FechaYHora
        {
            get
            {
                return DateTime.Now;
            }
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
            try
            {
                this.articulo = articulo;
                this.formaDePago = forma;
                this.fechaYHora = FechaYHora;
                this.Total = articulo.Precio;
            }
            catch (Exception)
            {
                throw new TicketException("Complete todos los datos");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Producto: {articulo.Tipo} de precio: ${articulo.Precio}");
            sb.AppendLine($"Abonando con: {this.formaDePago}, abona total de: ${this.Total}");
            sb.AppendLine($"FECHA DE VENTA {this.fechaYHora}");
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
