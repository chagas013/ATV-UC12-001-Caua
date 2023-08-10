namespace Prj_ATV_UC12_001_Caua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Correntista correntista = new Correntista(txtNome.Text, txtCpf.Text,
                Convert.ToDateTime(dtNasc.Text), Convert.ToDecimal(txtRendaMensal.Text));

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            MessageBox.Show($"Cliente cadastrado com sucesso!\nId:{correntista.IdCliente}\n{correntista.NomeCliente}\n{correntista.CpfCliente}\n{correntista.DataNasc}\n{correntista.RendaMensal}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

      
    }
}