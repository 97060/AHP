using Combinatorics.Collections;

namespace AHP
{
    public partial class Form1 : Form
    {
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            tableLayoutPanel1.Visible = false;
            generateListButton.Enabled = false;
            Combinations<int> combinations = new(Enumerable.Range(1, (int)criteriaNumberNumericUpDown.Value), 2, GenerateOption.WithoutRepetition);
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            for (int i = 0; i < combinations.Count; i++)
            {
                tableLayoutPanel1.Controls.Add(new AHPRow(i + 1, combinations.ElementAt(i)[0], combinations.ElementAt(i)[1]), 1, i);
                tableLayoutPanel1.RowCount++;
            }
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            generateListButton.Enabled = true;
            tableLayoutPanel1.Visible = true;

        }
    }
}