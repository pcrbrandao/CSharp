using System.Windows.Forms;
using System;

namespace UmAppParaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileCounter counter = new WhileCounter();
            counter.Execute();
            MessageBox.Show("Olá, você!");
        }
    }

    public class WhileCounter
    {
        public string CountString(int fim)
        {
            int count = 0;
            string saida = "";
            while (++count <= fim)
            {
                saida += count.ToString();
                if (count < fim )
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
