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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnTesteConexao = new System.Windows.Forms.Button();
            this.lbNomeServicoBanco = new System.Windows.Forms.Label();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.lbStatusServico = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(21, 233);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(86, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar Serviço";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(113, 233);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(86, 23);
            this.btnParar.TabIndex = 1;
            this.btnParar.Text = "Parar Serviço";
            this.btnParar.UseVisualStyleBackColor = true;
            // 
            // btnTesteConexao
            // 
            this.btnTesteConexao.Location = new System.Drawing.Point(405, 233);
            this.btnTesteConexao.Name = "btnTesteConexao";
            this.btnTesteConexao.Size = new System.Drawing.Size(98, 23);
            this.btnTesteConexao.TabIndex = 2;
            this.btnTesteConexao.Text = "Testar Conexão";
            this.btnTesteConexao.UseVisualStyleBackColor = true;
            // 
            // lbNomeServicoBanco
            // 
            this.lbNomeServicoBanco.AutoSize = true;
            this.lbNomeServicoBanco.Location = new System.Drawing.Point(18, 20);
            this.lbNomeServicoBanco.Name = "lbNomeServicoBanco";
            this.lbNomeServicoBanco.Size = new System.Drawing.Size(89, 13);
            this.lbNomeServicoBanco.TabIndex = 3;
            this.lbNomeServicoBanco.Text = "Nome do Serviço";
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.Location = new System.Drawing.Point(21, 37);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(236, 20);
            this.txtNomeServico.TabIndex = 4;
            this.txtNomeServico.TextChanged += new System.EventHandler(this.txtNomeServico_TextChanged);
            // 
            // lbStatusServico
            // 
            this.lbStatusServico.AutoSize = true;
            this.lbStatusServico.Location = new System.Drawing.Point(427, 20);
            this.lbStatusServico.Name = "lbStatusServico";
            this.lbStatusServico.Size = new System.Drawing.Size(76, 13);
            this.lbStatusServico.TabIndex = 5;
            this.lbStatusServico.Text = "Status Serviço";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(445, 37);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(41, 13);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Parado";
            // 
            // UserControlService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbStatusServico);
            this.Controls.Add(this.txtNomeServico);
            this.Controls.Add(this.lbNomeServicoBanco);
            this.Controls.Add(this.btnTesteConexao);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "UserControlService";
            this.Size = new System.Drawing.Size(528, 273);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnTesteConexao;
        private System.Windows.Forms.Label lbNomeServicoBanco;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.Label lbStatusServico;
        private System.Windows.Forms.Label lbStatus;
    }
}
