using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.Services
{
    public class Calculadora
    {
        private List<string> _historico = new List<string>();
        public int Somar(int a, int b) {
            var resultado = a + b;
            _historico.Insert(0, "Res: " + resultado);
            return resultado;
        }
        public int Subtrair(int a, int b) {
            var resultado = a - b;
             _historico.Insert(0, "Res: " + resultado);
            return resultado;
        }
        public int Multiplicar(int a, int b) {
            var resultado = a * b;
            _historico.Insert(0, "Res: " + resultado);
            return resultado;
        } 
        public int Dividir(int a, int b) {
            if (b == 0) throw new DivideByZeroException();

            var resultado = a / b;
            _historico.Insert(0, "Res: " + resultado);
            
            return resultado;
        }
        public List<string> Historico() {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }
    }
}