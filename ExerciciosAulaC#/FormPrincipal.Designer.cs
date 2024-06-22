namespace ExerciciosAulaC_
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuario = new Button();
            btnChamados = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(164, 92);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(174, 70);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuarios";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnChamados
            // 
            btnChamados.Location = new Point(164, 220);
            btnChamados.Name = "btnChamados";
            btnChamados.Size = new Size(174, 70);
            btnChamados.TabIndex = 1;
            btnChamados.Text = "Chamados";
            btnChamados.UseVisualStyleBackColor = true;
            btnChamados.Click += btnChamados_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 192, 192);
            btnSair.Location = new Point(200, 403);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(95, 62);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 497);
            Controls.Add(btnSair);
            Controls.Add(btnChamados);
            Controls.Add(btnUsuario);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnChamados;
        private Button btnSair;
    }
}