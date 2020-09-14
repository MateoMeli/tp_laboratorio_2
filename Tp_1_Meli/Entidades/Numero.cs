using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string numero)
        {
            SetNumero = numero; ;   
        }
        private double ValidarNumero(string strNumero)
        {
            double valid;
            if(double.TryParse(strNumero, out valid))
            {
                return valid;
            }
            else
            {
                return 0;
            }
        }
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator /(Numero num1, Numero num2)
        {
            if(num2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return num1.numero / num2.numero;
            }
        }
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                return Convert.ToInt32(binario, 2).ToString();
            }
            else
            {
                return "Valor invalido";
            }
        }
        public string DecimalBinario(double numero)
        {
            int num = (int)Math.Abs(numero);
            return Convert.ToString(num, 2);
        }
        public string DecimalBinario(string numero)
        {
            int num;
            if(int.TryParse(numero, out num))
            {
                num = (int)Math.Abs(num);
                return Convert.ToString(num, 2);

            }
            else
            {
                return "Invalido";
            }
        }
        private bool EsBinario(string numero)
        {
            if(!(numero.Contains("1")) && !(numero.Contains("0")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
