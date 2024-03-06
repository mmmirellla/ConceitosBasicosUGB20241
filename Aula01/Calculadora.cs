using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    public class Calculadora
    {   
        public static int Soma(int num1, int num2) //o primeiro int é o que vai retornr,
                                            //e os de dentro os que recebe
                                            // o static torna o metodo soma como um metodo de classe,
                                            // ou seja, nao precisa explicitar a instancia
        {
            return num1 + num2;

        }
    }
}
