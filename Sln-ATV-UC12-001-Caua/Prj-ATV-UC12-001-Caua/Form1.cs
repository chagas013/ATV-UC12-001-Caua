namespace Prj_ATV_UC12_001_Caua
{

    public partial class Form1 : Form
    {

        Correntista correntista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                Correntista correntista = new Correntista(txtNome.Text, txtCpf.Text,
                    Convert.ToDateTime(dtNasc.Text), Convert.ToDecimal(txtRendaMensal.Text));

                               
                    MessageBox.Show($"Cliente cadastrado com sucesso!\nId:{correntista.IdCliente}\n{correntista.NomeCliente}\n{correntista.CpfCliente}\n{correntista.DataNasc}\n{correntista.RendaMensal}\n{correntista.RetornarPerfilCliente()}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblBoasVindas.Text = correntista.MensagemBoasVindas();              
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblBoasVindas_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNome.Text, out var nomeDigitado))
            {
                txtNome.Clear();
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCpf.Text, out var cpfDigitafo))
            {
                txtCpf.Clear();
            }
        }

        private void txtRendaMensal_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRendaMensal.Text, out var rendaDigitada))
            {
                txtRendaMensal.Clear();
            }
        }
    }
}