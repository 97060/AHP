using Combinatorics.Collections;
using MathNet.Numerics.LinearAlgebra.Factorization;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace AHP
{
    public partial class Form1 : Form
    {
        private readonly AboutBox AboutBox = new();
        public Form1()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void GenerateListButton_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            calculateButton.Enabled = false;
            generateListButton.Enabled = false;
            tableLayoutPanel.Visible = false;
            generateListButton.Enabled = false;
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.RowCount= 0;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Combinations<int> combinations = new(Enumerable.Range(1, (int)criteriaNumberNumericUpDown.Value), 2, GenerateOption.WithoutRepetition);
            for (int i = 0; i < combinations.Count; i++)
            {
                tableLayoutPanel.Controls.Add(new AHPRow(i + 1, combinations.ElementAt(i)[0], combinations.ElementAt(i)[1]), 1, i);
                tableLayoutPanel.RowCount++;
            }
            generateListButton.Enabled = true;
            tableLayoutPanel.Visible = true;
            calculateButton.Enabled = true;
            generateListButton.Enabled = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!tableLayoutPanel.Created)
                return;

            calculateButton.Enabled = false;
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Plik tekstowy (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = "wynik.txt"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Calculate(saveFileDialog.FileName);
                MessageBox.Show($"Wynik został zapisany w pliku\n{saveFileDialog.FileName}");
            }
            calculateButton.Enabled = true;

        }

        private static double GetRange(int x)
        {
            if (Enumerable.Range(1, 20).Contains(x))
                return 9;
            if (Enumerable.Range(20, 20).Contains(x))
                return 7;
            if (Enumerable.Range(40, 20).Contains(x))
                return 5;
            if (Enumerable.Range(60, 20).Contains(x))
                return 3;
            if (Enumerable.Range(80, 20).Contains(x))
                return 1;
            if (Enumerable.Range(100, 20).Contains(x))
                return (double)1 /3;
            if (Enumerable.Range(120, 20).Contains(x))
                return (double)1 /5;
            if (Enumerable.Range(140, 20).Contains(x))
                return (double)1 / 7;
            if (Enumerable.Range(160, 20).Contains(x))
                return (double)1 / 9;
            return -1;
        }

        private void Calculate(string savePath)
        {
            StringBuilder stringBuilder = new("{");

            for (int i = 0; i < tableLayoutPanel.RowCount - 1; i++)
            {
                var row = (AHPRow)tableLayoutPanel.GetControlFromPosition(0, i)!;
                stringBuilder.AppendFormat("('{0}', '{1}'): {2}", row.Name1, row.Name2, GetRange(row.Value));
                if (i != tableLayoutPanel.RowCount - 2)
                    stringBuilder.Append(", ");
            }
            stringBuilder.Append('}');
            string command = $"solve.py \"{stringBuilder}\" \"{Path.GetFullPath(savePath)}\"";

            var processStartInfo = new ProcessStartInfo
            {
                Arguments = command,
                FileName = "python/python.exe",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process.Start(processStartInfo);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox.ShowDialog();
        }
    }
}