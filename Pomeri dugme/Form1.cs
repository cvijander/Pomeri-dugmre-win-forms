namespace Pomeri_dugme
{
    public partial class Form1 : Form
    {
        private List<Point> listaTacaka = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            listaTacaka.Add(new Point(button1.Location.X, button1.Location.Y));
            button1.Location = new Point(e.X - 30, e.Y - 30);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.U && listaTacaka.Count > 0)
            {
                int max = listaTacaka.Count - 1;
                button1.Location = listaTacaka[max];
                listaTacaka.RemoveAt(max);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}