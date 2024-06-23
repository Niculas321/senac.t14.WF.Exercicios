namespace Exercicios
{
    partial class FrmUsuario
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnVoltarUsuario = new Button();
            LinkCadartrar = new LinkLabel();
            checkBoxSenha = new CheckBox();
            groupBoxLogin = new GroupBox();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(58, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(58, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 88);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 162);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Senha :";
            // 
            // btnVoltarUsuario
            // 
            btnVoltarUsuario.BackColor = Color.FromArgb(192, 255, 255);
            btnVoltarUsuario.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarUsuario.Location = new Point(23, 26);
            btnVoltarUsuario.Name = "btnVoltarUsuario";
            btnVoltarUsuario.Size = new Size(42, 37);
            btnVoltarUsuario.TabIndex = 6;
            btnVoltarUsuario.Text = "↶";
            btnVoltarUsuario.UseVisualStyleBackColor = false;
            btnVoltarUsuario.Click += btnVoltarUsuario_Click;
            // 
            // LinkCadartrar
            // 
            LinkCadartrar.AutoSize = true;
            LinkCadartrar.Location = new Point(120, 270);
            LinkCadartrar.Name = "LinkCadartrar";
            LinkCadartrar.Size = new Size(69, 15);
            LinkCadartrar.TabIndex = 7;
            LinkCadartrar.TabStop = true;
            LinkCadartrar.Text = "Cadastre-se";
            // 
            // checkBoxSenha
            // 
            checkBoxSenha.AutoSize = true;
            checkBoxSenha.Location = new Point(58, 226);
            checkBoxSenha.Name = "checkBoxSenha";
            checkBoxSenha.Size = new Size(134, 19);
            checkBoxSenha.TabIndex = 8;
            checkBoxSenha.Text = "Manter-me Logado?";
            checkBoxSenha.UseVisualStyleBackColor = true;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(label1);
            groupBoxLogin.Controls.Add(checkBoxSenha);
            groupBoxLogin.Controls.Add(textBox1);
            groupBoxLogin.Controls.Add(LinkCadartrar);
            groupBoxLogin.Controls.Add(textBox2);
            groupBoxLogin.Controls.Add(textBox3);
            groupBoxLogin.Controls.Add(label3);
            groupBoxLogin.Controls.Add(label2);
            groupBoxLogin.Location = new Point(23, 90);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(326, 292);
            groupBoxLogin.TabIndex = 9;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Login";
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(379, 450);
            Controls.Add(groupBoxLogin);
            Controls.Add(btnVoltarUsuario);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnVoltarUsuario;
        private LinkLabel LinkCadartrar;
        private CheckBox checkBoxSenha;
        private GroupBox groupBoxLogin;
    }
}