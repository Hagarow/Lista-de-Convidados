
namespace projeto_lista_de_convidados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.dglistadeconvidados = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbtelefone = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbcpf = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbtelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dglistadeconvidados)).BeginInit();
            this.SuspendLayout();
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(235, 32);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 0;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(235, 109);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // dglistadeconvidados
            // 
            this.dglistadeconvidados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglistadeconvidados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNome,
            this.ColCPF,
            this.ColEmail,
            this.ColTelefone});
            this.dglistadeconvidados.Location = new System.Drawing.Point(35, 216);
            this.dglistadeconvidados.Name = "dglistadeconvidados";
            this.dglistadeconvidados.Size = new System.Drawing.Size(654, 184);
            this.dglistadeconvidados.TabIndex = 2;
            this.dglistadeconvidados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglistadeconvidados_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Width = 50;
            // 
            // ColNome
            // 
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.Width = 150;
            // 
            // ColCPF
            // 
            this.ColCPF.HeaderText = "CPF";
            this.ColCPF.Name = "ColCPF";
            this.ColCPF.Width = 130;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 150;
            // 
            // ColTelefone
            // 
            this.ColTelefone.HeaderText = "Telefone";
            this.ColTelefone.Name = "ColTelefone";
            this.ColTelefone.Width = 130;
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(12, 61);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(35, 13);
            this.lbnome.TabIndex = 3;
            this.lbnome.Text = "Nome";
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Location = new System.Drawing.Point(12, 90);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(27, 13);
            this.lbcpf.TabIndex = 4;
            this.lbcpf.Text = "CPF";
            this.lbcpf.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(12, 119);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(32, 13);
            this.lbemail.TabIndex = 5;
            this.lbemail.Text = "Email";
            // 
            // lbtelefone
            // 
            this.lbtelefone.AutoSize = true;
            this.lbtelefone.Location = new System.Drawing.Point(12, 148);
            this.lbtelefone.Name = "lbtelefone";
            this.lbtelefone.Size = new System.Drawing.Size(49, 13);
            this.lbtelefone.TabIndex = 6;
            this.lbtelefone.Text = "Telefone";
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(64, 58);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(100, 20);
            this.tbnome.TabIndex = 7;
            // 
            // tbcpf
            // 
            this.tbcpf.Location = new System.Drawing.Point(64, 87);
            this.tbcpf.Name = "tbcpf";
            this.tbcpf.Size = new System.Drawing.Size(100, 20);
            this.tbcpf.TabIndex = 8;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(64, 116);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(100, 20);
            this.tbemail.TabIndex = 9;
            // 
            // tbtelefone
            // 
            this.tbtelefone.Location = new System.Drawing.Point(64, 145);
            this.tbtelefone.Name = "tbtelefone";
            this.tbtelefone.Size = new System.Drawing.Size(100, 20);
            this.tbtelefone.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(64, 25);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(52, 20);
            this.tbID.TabIndex = 12;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(235, 71);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 13;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(235, 148);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Remover";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtelefone);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbcpf);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.lbtelefone);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.dglistadeconvidados);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncadastrar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Convidados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dglistadeconvidados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.DataGridView dglistadeconvidados;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbtelefone;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbcpf;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbtelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
    }
}

