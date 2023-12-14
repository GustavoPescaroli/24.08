using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_2__POO____EX1
{
    internal class soma
    {
        #region Atributos
        private int n1;
        private int n2;
        private int resultado;
        public int x;
        public int y;
        #endregion

        #region MetodosConstrutores
        public soma()
        {
            this.n1 = 0;
            this.n2 = 0;
            this.resultado = 0;
        }

        public soma(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.resultado = 99;
        }
        #endregion

        #region MetodosInterface
        public void setN1(int n1)
        {
            this.n1 = n1;
        }
        public void setN2(int n2)
        {
            this.n2 = n2;
        }
        public int getN1()
        {
            return this.n1;
        }
        public int getN2()
        {
            return this.n2;
        }
        public int getResultado()
        {
            return this.resultado;
        }
        #endregion

        #region MetodosFuncionais
        public void calcular()
        {
            this.resultado = this.n1 * this.n1;
        }
        #endregion
    }
}
