using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloworld_dotnet.Models
{
    public class Calculadora
    {
        public double Somar(params double[] numbers)
        {
            return numbers.Sum();
        }
        public double Multiplicar(params double[] numbers)
        {
            double valorAcumulado = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                valorAcumulado *= numbers[i];
            }

            return valorAcumulado;
        }
        public double Subtrair(params double[] numbers)
        {
            double valorAcumulado = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                valorAcumulado -= numbers[i];
            }

            return valorAcumulado;
        }
        public double Dividir(params double[] numbers)
        {
            double valorAcumulado = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                valorAcumulado /= numbers[i];
            }

            return valorAcumulado;
        }
        public double Exponenciar(params double[] numbers)
        {
            double valorAcumulado = numbers.Last();

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                valorAcumulado = Math.Pow(numbers[i - 1], valorAcumulado);
            }

            return valorAcumulado;
        }
        public double Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            return Math.Round(seno, 4);
        }
        public double Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double conseno = Math.Cos(radiano);
            return Math.Round(conseno, 4);

        }
        public double Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            return Math.Round(tangente, 4);
        }
    }
}