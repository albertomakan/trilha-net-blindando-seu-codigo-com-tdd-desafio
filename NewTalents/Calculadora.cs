using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historicoList;
        private string data;

        public Calculadora(string data)
        {
            historicoList = [];
            this.data = data;
        }

        public int somar(int num1, int num2)
        {
            int result = num1 + num2;
            historicoList.Insert(0, "Val: " + result + " - data: " + data);
            return result;
        }

        public int subtrair(int num1, int num2)
        {
            int result = num1 - num2;
            historicoList.Insert(0, "Val: " + result + " - data: " + data);
            return result;
        }

        public int multiplicar(int num1, int num2)
        {
            int result = num1 * num2;
            historicoList.Insert(0, "Val: " + result + " - data: " + data);
            return result;
        }

        public int dividir(int num1, int num2)
        {
            int result = num1 / num2;
            historicoList.Insert(0, "Val: " + result + " - data: " + data);
            return result;
        }

        public List<string> historico()
        {
            historicoList.RemoveRange(3, historicoList.Count - 3);
            return historicoList;
        }
    }
}