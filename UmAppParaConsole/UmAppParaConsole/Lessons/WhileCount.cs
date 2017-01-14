using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmAppParaConsole
{
    public class WhileCount
    {
        public string CountString(int fim)
        {
            int count = 0;
            string saida = "";
            while (++count <= fim)
            {
                saida += count.ToString();
                if (count < fim)
                {
                    saida += " ";
                }
            }

            return saida;
        }

        public void Execute()
        {
            Console.WriteLine(CountString(fim: 5));
        }
    }
}
