namespace DBRunner.Front
{
    partial class UserControlService
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciar = new Button();
            btnParar = new Button();
            btnTesteConexao = new Button();
            lbNomeServicoBanco = new Label();
            txtNomeServico = new TextBox();
            lbStatusServico = new Label();
            lbStatus = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(24, 269);
            btnIniciar.Margin = new Padding(4, 3, 4, 3);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(100, 27);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Serviço";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(132, 269);
            btnParar.Margin = new Padding(4, 3, 4, 3);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(100, 27);
            btnParar.TabIndex = 1;
            btnParar.Text = "Parar Serviço";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // btnTesteConexao
            // 
            btnTesteConexao.Location = new Point(472, 269);
            btnTesteConexao.Margin = new Padding(4, 3, 4, 3);
            btnTesteConexao.Name = "btnTesteConexao";
            btnTesteConexao.Size = new Size(114, 27);
            btnTesteConexao.TabIndex = 2;
            btnTesteConexao.Text = "Testar Conexão";
            btnTesteConexao.UseVisualStyleBackColor = true;
            // 
            // lbNomeServicoBanco
            // 
            lbNomeServicoBanco.AutoSize = true;
            lbNomeServicoBanco.Location = new Point(21, 23);
            lbNomeServicoBanco.Margin = new Padding(4, 0, 4, 0);
            lbNomeServicoBanco.Name = "lbNomeServicoBanco";
            lbNomeServicoBanco.Size = new Size(98, 15);
            lbNomeServicoBanco.TabIndex = 3;
            lbNomeServicoBanco.Text = "Nome do Serviço";
            // 
            // txtNomeServico
            // 
            txtNomeServico.Location = new Point(24, 43);
            txtNomeServico.Margin = new Padding(4, 3, 4, 3);
            txtNomeServico.Name = "txtNomeServico";
            txtNomeServico.Size = new Size(275, 23);
            txtNomeServico.TabIndex = 4;
            txtNomeServico.TextChanged += txtNomeServico_TextChanged;
            // 
            // lbStatusServico
            // 
            lbStatusServico.AutoSize = true;
            lbStatusServico.Location = new Point(498, 23);
            lbStatusServico.Margin = new Padding(4, 0, 4, 0);
            lbStatusServico.Name = "lbStatusServico";
            lbStatusServico.Size = new Size(80, 15);
            lbStatusServico.TabIndex = 5;
            lbStatusServico.Text = "Status Serviço";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.ForeColor = Color.Red;
            lbStatus.Location = new Point(519, 43);
            lbStatus.Margin = new Padding(4, 0, 4, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(0, 15);
            lbStatus.TabIndex = 6;
            // 
            // UserControlService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbStatus);
            Controls.Add(lbStatusServico);
            Controls.Add(txtNomeServico);
            Controls.Add(lbNomeServicoBanco);
            Controls.Add(btnTesteConexao);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlService";
            Size = new Size(616, 315);
            Load += UserControlService_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnTesteConexao;
        private System.Windows.Forms.Label lbNomeServicoBanco;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.Label lbStatusServico;
        private System.Windows.Forms.Label lbStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
