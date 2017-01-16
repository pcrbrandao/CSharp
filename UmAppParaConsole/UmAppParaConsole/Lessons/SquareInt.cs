using System;
using System.Windows.Forms;
using System.Drawing;

namespace UmAppParaConsole.Lessons
{
    /// <summary>
    /// Exibe uma janela (Form) com um botão, que ao ser precionado exibe
    /// uma lista de números de 1 a 10 e seus recpectivos quadrados.
    /// O código original no livro da Deitel não está correto. Abaixo está marcado
    /// as linha que tiveram que ser acrescentadas.
    /// </summary>
    public class SquareInt : Form
    {
        private Button calculateButton; // esse é o botão
        private Label outputLabel; // esse é o texto

        public SquareInt()
        {
            calculateButton = new Button();
            outputLabel = new Label();

            calculateButton.Text = "Calcular quadrados";
            calculateButton.Location = new Point(50, 10); // aqui
            calculateButton.AutoSize = true; // aqui
            calculateButton.Click += CalculateButton_Click; // aqui

            outputLabel.Location = new Point(50, 40); // aqui
            outputLabel.AutoSize = true; // aqui
            outputLabel.Text = "o resultado aparece aqui";

            // aqui
            Controls.AddRange(
                new Control[]
                {
                    calculateButton,
                    outputLabel
                });
            ResumeLayout(false);
        }

        public static void Execute()
        {
            Application.Run(new SquareInt());
        }

        /// <summary>
        /// Calcula o quadrado de um número inteiro
        /// </summary>
        /// <param name="y">um número inteiro qualquer</param>
        /// <returns>O quadrado de y</returns>
        int Square(int y)
        {
            return y * y;
        }

        /// <summary>
        /// Atualiza o conteúdo de outputLabel
        /// </summary>
        void AtualizaLabel()
        {
            outputLabel.Text = "";

            // repete o laço 10 vezes
            for (int counter = 1; counter <= 10; counter++)
            {
                // coloca o resultado em outputLabel
                outputLabel.Text += counter + "² é " + Square(counter) + "\n";
            }
        }

        /// <summary>
        /// O método existe em Form e é sobrescrito para executar o código quando o evento,
        /// no caso, o Click, ocorrer.
        /// </summary>
        /// <param name="sender">é o calculateButton. Está aqui para compor o método sobrescrito</param>
        /// <param name="e">Contém os argumentos do evento.</param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AtualizaLabel();
        }
    }
}
