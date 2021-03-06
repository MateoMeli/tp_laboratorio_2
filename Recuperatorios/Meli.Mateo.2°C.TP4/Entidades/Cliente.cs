﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;
using Excepciones;

namespace Entidades
{
    public class Cliente : Persona, IToString<string>
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
                return DateTime.Today;
            }
            set
            {
                fechaYHora = value;
            }
        }

        public DateTime LaFecha
        {
            get
            {
                return fechaYHora;
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

        public Articulo Producto
        {
            get
            {
                return this.articulo;
            }
        }

        public FormaDePago Forma
        {
            get
            {
                return this.formaDePago;
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

        public Cliente(string nombre, string apellido, Articulo articulo, FormaDePago forma, DateTime fecha) : this(nombre, apellido, articulo, forma)
        {
            this.FechaYHora = fecha;
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

        public string Escribirlo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Producto: {articulo.Tipo} de precio: ${articulo.Precio}");
            sb.AppendLine($"Abonando con: {this.formaDePago}, abona total de: ${this.Total}");
            sb.AppendLine($"FECHA DE VENTA {this.fechaYHora.Date}");
            return sb.ToString();
        }
    }
}
