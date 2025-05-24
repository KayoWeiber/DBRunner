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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                string nomeservico = txtNomeServico.Text;
                GerenciaServicoDb gerenciaServicoDb = new GerenciaServicoDb();
                if (gerenciaServicoDb.IniciarServico(nomeservico))
                {
                    lbStatus.Text = "Ativo";
                    MessageBox.Show("Serviço iniciado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
