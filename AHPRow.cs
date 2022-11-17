namespace AHP
{
    public partial class AHPRow : UserControl
    {
        private int nr;
        private int kr1;
        private int kr2;

        public AHPRow(int nr, int kr1, int kr2)
        {
            this.nr = nr;
            this.kr1 = kr1;
            this.kr2 = kr2;
            InitializeComponent();
            nrLabel.Text = nr.ToString();
            checkBox1.Text = $"Kr-{kr1}";
            checkBox2.Text = $"Kr-{kr2}";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox2.Checked;
        }
    }
}
