using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operador sea ('+', '-', '/' o'*').
        /// </summary>
        /// <param name="operador">Recibe un operador de tipo char.</param>
        /// <returns>Retorna el operador validado.</returns>
        private static char ValidarOperador(char operador)
        {
            if(operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                return '+';
            }
            else
            {
                return operador;
            }
        }

        /// <summary>
        /// Realiza una operacion dependiendo del operador que recibe por parametro.
        /// </summary>
        /// <param name="num1">Recibe un numero de tipo Operando.</param>
        /// <param name="num2">Recibe un numero de tipo Operando.</param>
        /// <param name="operador">Recibe un operador de tipo char.</param>
        /// <returns>Retorna el resultado de la operacion.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorValidado = ValidarOperador(operador);
            double resultado;
            switch (operadorValidado)
            {
            case '+':
                    resultado = num1 + num2;
                    break;
            case '-':
                    resultado = num1 - num2;
                    break;
            case '/':
                    resultado = num1 / num2;
                    break;
            case '*':
                    resultado = num1 * num2;
                    break;
            default:
                    resultado = 0;
                    break;
            }
            return resultado;
        }
    }
}
