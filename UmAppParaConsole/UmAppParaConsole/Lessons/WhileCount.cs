using System;
using System.Windows.Forms;

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

        static public void Execute()
        {
            WhileCount counter = new WhileCount();
            Console.WriteLine(counter.CountString(fim: 5));
            MessageBox.Show("Olá, você!");
        }
    }
}
