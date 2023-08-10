namespace Prj_ATV_UC12_001_Caua
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblNome = new Label();
            lblDataNasc = new Label();
            lblCpfCliente = new Label();
            lblRendaMes = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtRendaMensal = new TextBox();
            txtId = new TextBox();
            btnCadastrar = new Button();
            dtNasc = new DateTimePicker();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(87, 72);
            lblId.Name = "lblId";
            lblId.Size = new Size(35, 25);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(133, 170);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataNasc.Location = new Point(133, 262);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(186, 25);
            lblDataNasc.TabIndex = 2;
            lblDataNasc.Text = "Data de Nascimento:";
            // 
            // lblCpfCliente
            // 
            lblCpfCliente.AutoSize = true;
            lblCpfCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCpfCliente.Location = new Point(133, 215);
            lblCpfCliente.Name = "lblCpfCliente";
            lblCpfCliente.Size = new Size(48, 25);
            lblCpfCliente.TabIndex = 3;
            lblCpfCliente.Text = "CPF:";
            // 
            // lblRendaMes
            // 
            lblRendaMes.AutoSize = true;
            lblRendaMes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblRendaMes.Location = new Point(133, 306);
            lblRendaMes.Name = "lblRendaMes";
            lblRendaMes.Size = new Size(172, 25);
            lblRendaMes.TabIndex = 4;
            lblRendaMes.Text = "Renda Mensal (R$):";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(206, 172);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(362, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(206, 217);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(362, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtRendaMensal
            // 
            txtRendaMensal.Location = new Point(325, 308);
            txtRendaMensal.Name = "txtRendaMensal";
            txtRendaMensal.Size = new Size(243, 23);
            txtRendaMensal.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(143, 74);
            txtId.Name = "txtId";
            txtId.Size = new Size(128, 23);
            txtId.TabIndex = 1;
            
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(146, 366);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 36);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dtNasc
            // 
            dtNasc.Location = new Point(325, 264);
            dtNasc.Name = "dtNasc";
            dtNasc.Size = new Size(243, 23);
            dtNasc.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtNasc);
            Controls.Add(btnCadastrar);
            Controls.Add(txtId);
            Controls.Add(txtRendaMensal);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(lblRendaMes);
            Controls.Add(lblCpfCliente);
            Controls.Add(lblDataNasc);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblDataNasc;
        private Label lblCpfCliente;
        private Label lblRendaMes;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtRendaMensal;
        private TextBox txtId;
        private Button btnCadastrar;
        private DateTimePicker dtNasc;
    }
}