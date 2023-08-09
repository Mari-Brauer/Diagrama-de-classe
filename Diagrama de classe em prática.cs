using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_Poa_Mari
{
    class Jogador : Program
    {
        string nome;
        int idade, drible, velocidade, chute, força;

        public void correr()
        {
            int aceleração = força + velocidade;
        }
        public int chutar()
        {
            int potenciachute = força * chute;
            return potenciachute;
        }
        public double toque()
        {
            double forcatoque = chute / 3 + força / 3;
            return forcatoque;
        }
        public double potenciacarrinho()
        {
            double carrinho = (velocidade * velocidade) + força / 2;
            return carrinho;
        }
        public int eficaciadrible()
        {
            int eficienciadrible = drible + (velocidade * velocidade);
            return eficienciadrible;
        }
    }
}
