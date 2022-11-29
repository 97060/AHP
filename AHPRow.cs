namespace AHP
{
    public partial class AHPRow : UserControl
    {
        public int Kr1 { get; set; }
        public int Kr2 { get; set; }
        public string Name1 => $"Kr-{Kr1}";
        public string Name2 => $"Kr-{Kr2}";
        public int Value => trackBar.Value;


        public AHPRow(int nr, int kr1, int kr2)
        {
            this.Kr1 = kr1;
            this.Kr2 = kr2;
            InitializeComponent();
            nrLabel.Text = nr.ToString();
            label1.Text = Name1;
            label2.Text = Name2;

        }
    }
}
