using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Constructor sin parametros de clase Operando. Inicializa el campo numero en 0.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Inicializa el campo numero con el valor pasado por parametro.
        /// </summary>
        /// <param name="numero">Recibe un numero como parametro de tipo Double</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Inicializa el campo numero con el valor pasado por parametro.
        /// </summary>
        /// <param name="strNumero">Recibe un numero como parametro de tipo string.</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Propiedad set que valida el operando.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Valida que el string recibido como parometro contenga solo numeros.
        /// </summary>
        /// <param name="strNumero">Recibe un numero como parametro de tipo string.</param>
        /// <returns>Retorna el valor numerico en caso de que sea valido o 0 si no es valido.</returns>
        private double ValidarOperando(string strNumero) 
        {
            bool validar = true;

            foreach (char c in strNumero)
            {
                if (c < '0' || c > '9')
                {
                    validar = false;
                }
            }

            if (validar)
            {
                return Convert.ToDouble(strNumero);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Sobrecarga el operador '+' para poder sumar numeros de la clase Operando.
        /// </summary>
        /// <param name="n1">Recibe como parametro un numero de tipo Operando.</param>
        /// <param name="n2">Recibe como parametro un numero de tipo Operando.</param>
        /// <returns>Retorna el resultado de la suma entre los operandos.</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador '-' para poder restar numeros de la clase Operando.
        /// </summary>
        /// <param name="n1">Recibe como parametro un numero de tipo Operando.</param>
        /// <param name="n2">Recibe como parametro un numero de tipo Operando.</param>
        /// <returns>Retorna el resultado de la resta entre los operandos.</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador '*' para poder multiplicar numeros de la clase Operando.
        /// </summary>
        /// <param name="n1">Recibe como parametro un numero de tipo Operando.</param>
        /// <param name="n2">Recibe como parametro un numero de tipo Operando.</param>
        /// <returns>Retorna el resultado de la multiplicacion entre los operandos.</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador '/' para poder dividir numeros de la clase Operando.
        /// </summary>
        /// <param name="n1">Recibe como parametro un numero de tipo Operando.</param>
        /// <param name="n2">Recibe como parametro un numero de tipo Operando.</param>
        /// <returns>Retorna el resultado de la division entre los operandos.</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        /// <summary>
        /// Convierte un numero binario a decimal siempre y cuando sea posible.
        /// </summary>
        /// <param name="binario">Recibe un numero binario de tipo string.</param>
        /// <returns>Retorna el valor convertido en caso de que sea posible o "Valor invalido".</returns>
        public static string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                double resultado = 0;
                int cantidadCaracteres = binario.Length;
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if(caracter == '1')
                    {
                        resultado += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
                return Convert.ToString(resultado);
            }
            else
            {
                return "Valor invalido";
            }
        }

        /// <summary>
        /// Convierte un numero decimal a binario siempre y cuando sea posible.
        /// </summary>
        /// <param name="numero">Recibe un numero decimal de tipo double.</param>
        /// <returns>Retorna el valor convertido en caso de que sea posible o "Valor invalido".</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = String.Empty;
            int resultDiv = (int)numero;
            int restoDiv;
            if(numero > -1)
            {
                if (resultDiv >= 0)
                {
                    do
                    {
                        restoDiv = resultDiv % 2;
                        resultDiv /= 2;
                        binario = restoDiv.ToString() + binario;
                    } while (resultDiv > 0);
                }
            }
            else
            {
                return "Valor invalido";
            }
            return binario;
        }

        /// <summary>
        /// Convierte un numero decimal a binario siempre y cuando sea posible.
        /// </summary>
        /// <param name="numero">Recibe un numero decimal de tipo string.</param>
        /// <returns>Retorna el valor convertido en caso de que sea posible o "Valor invalido".</returns>
        public string DecimalBinario(string numero)
        {
            string binario = DecimalBinario(Convert.ToDouble(numero));
            return binario;
        }

        /// <summary>
        /// Valida que sea un numero binario.
        /// </summary>
        /// <param name="binario">Recibe un numero binario de tipo string.</param>
        /// <returns>Retorna True si es binario. False si no es binario.</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = false;
            if (binario.Contains('0') || binario.Contains('1'))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
