using System;
using System.Windows.Forms;
using DBRunner.Core;
namespace DBRunner.Front
{
    public partial class UserControlService : UserControl
    {
        public UserControlService()
        {
            InitializeComponent();
        }

        private void txtNomeServico_TextChanged(object sender, EventArgs e)
        {

        }
        GerenciaServicoDb gerenciaServicoDb = new GerenciaServicoDb();

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                string nomeservico = txtNomeServico.Text.ToString();
                var servico = gerenciaServicoDb.BuscarServicoNome(nomeservico);
                if (gerenciaServicoDb.IniciarServico(servico))
                {
                    servico.Refresh();
                    lbStatus.Text = "Ativo";
                    lbStatus.ForeColor = System.Drawing.Color.Green;
                    MessageBox.Show("Serviço iniciado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                string nomeservico = txtNomeServico.Text.ToString();
                var servico = gerenciaServicoDb.BuscarServicoNome(nomeservico);
                if (gerenciaServicoDb.PararServico(servico))
                {
                    servico.Refresh();
                    lbStatus.Text = "Parado";
                    lbStatus.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Serviço parado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UserControlService_Load(object sender, EventArgs e)
        {

        }
    }
}
