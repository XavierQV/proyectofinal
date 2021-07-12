using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinal
{
    class sumar
    {
        public double sumas(double num1, double num2)
        {
            double resp;

            resp = num1 + num2;
            return resp;
        }
    }
    class restar
    {
        public double resta(double num1, double num2)
        {
            double resp;
            resp = num1 - num2;
            return resp;
        }
    }
    class multiplicar
    {
        public double multiplicacion(double num1, double num2)
        {
            double resp;
            resp = num1 * num2;
            return resp;
        }
    }
    class dividir
    {
        public double dividicion(double num1, double num2)
        {
            double resp;
            resp = num1 / num2;
            return resp;
        }
    }
    class porciento
    {
        public double porcentaje(double num1, double num2)
        {
            double resp;
            resp = ((num1) *(num2)/100);
            return resp;
        }
    }
    class unodividido
    {
        public double unodivididos(double num1)
        {
            double resp;
            resp = 1 / num1;
            return resp;
        }
    }
}