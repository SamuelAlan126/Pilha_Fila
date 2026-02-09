namespace filaePilha
{
    public partial class Form1 : Form
    {
        Queue<string> fila = new Queue<string>();
        Stack<string> pilha = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarP_Click(object sender, EventArgs e)
        {
            pilha.Push(txtPilha.Text);
            AtualizarPilha();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AtualizarPilha()
        {
            listBox1.Items.Clear();
            foreach (string item in pilha)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnAdicionarF_Click(object sender, EventArgs e)
        {
            fila.Enqueue(txtFila.Text);
            AtualizarFila();
           
        }

        private void btnRemoverF_Click(object sender, EventArgs e)
        {
            if (fila.Count > 0)
                fila.Dequeue();
            AtualizarFila();
        }

        private void btnRemoverP_Click(object sender, EventArgs e)
        {
            if (pilha.Count > 0)
                pilha.Pop();
            AtualizarPilha();
        }

        private void txtPilha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFila_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AtualizarFila()
        {
            listBox2.Items.Clear();
            foreach (string item in fila)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
