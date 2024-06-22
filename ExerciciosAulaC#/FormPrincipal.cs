using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosAulaC_
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            criarBancoDeDados();
        }

        private void criarBancoDeDados()
        {
            using (var banco = new AppDbContext())
            {
                banco.Database.Migrate();
            }
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            new FormChamados().ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FormUsuarios().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
