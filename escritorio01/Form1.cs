namespace escritorio01
{
    public partial class ejercicio01 : Form
    {
        public ejercicio01()
        {
            InitializeComponent();
        }

        private void lblTituloejercicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblsalida.Text = txtnombre.Text + " " + txtApellido.Text;
            //lbl_texto.Text = numero.ToString();(asignarle un numero a un label);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
