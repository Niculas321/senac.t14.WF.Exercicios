namespace Exercicios
{
    partial class FrmPrincipal
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
            btnUsuario = new Button();
            btnChamado = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(78, 66);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(198, 65);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnChamado
            // 
            btnChamado.Location = new Point(78, 172);
            btnChamado.Name = "btnChamado";
            btnChamado.Size = new Size(198, 65);
            btnChamado.TabIndex = 1;
            btnChamado.Text = "Chamado";
            btnChamado.UseVisualStyleBackColor = true;
            btnChamado.Click += btnChamado_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 192, 192);
            btnSair.ForeColor = SystemColors.ControlText;
            btnSair.Location = new Point(126, 311);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 41);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(380, 450);
            Controls.Add(btnSair);
            Controls.Add(btnChamado);
            Controls.Add(btnUsuario);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnChamado;
        private Button btnSair;
    }
}
