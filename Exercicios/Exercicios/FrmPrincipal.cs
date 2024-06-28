namespace Exercicios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChamado_Click(object sender, EventArgs e)
        {
            new FrmChamado().ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }
    }
}
