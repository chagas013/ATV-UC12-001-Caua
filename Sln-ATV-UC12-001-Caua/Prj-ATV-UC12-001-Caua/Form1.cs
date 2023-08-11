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
            Correntista correntista = new Correntista(txtNome.Text, txtCpf.Text,
                Convert.ToDateTime(dtNasc.Text), Convert.ToDecimal(txtRendaMensal.Text));

            if (correntista.verificarSeCorrentistaMaior() >= 18)
            {
                MessageBox.Show($"Cliente cadastrado com sucesso!\nId:{correntista.IdCliente}\n{correntista.NomeCliente}\n{correntista.CpfCliente}\n{correntista.DataNasc}\n{correntista.RendaMensal}\n{correntista.verificarSeCorrentistaMaior()}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opa! Você não é maior de idade para criar uma conta, sentimos muito!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
                
            

            

            


        }

        private void dtNasc_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}