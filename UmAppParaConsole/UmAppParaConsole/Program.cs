using System.Windows.Forms;
using System;

namespace UmAppParaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileCount counter = new WhileCount();
            counter.Execute();
            MessageBox.Show("Olá, você!");
        }
    }
}
