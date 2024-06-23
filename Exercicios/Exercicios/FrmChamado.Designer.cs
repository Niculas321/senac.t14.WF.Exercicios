namespace Exercicios
{
    partial class FrmChamado
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
            btnCancelarChamado = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            labelSetorChamado = new Label();
            label1 = new Label();
            labelCategoriaChamado = new Label();
            labelMsgChamado = new Label();
            btnCriarChamado = new Button();
            SuspendLayout();
            // 
            // btnCancelarChamado
            // 
            btnCancelarChamado.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelarChamado.ForeColor = SystemColors.ControlText;
            btnCancelarChamado.Location = new Point(228, 382);
            btnCancelarChamado.Name = "btnCancelarChamado";
            btnCancelarChamado.Size = new Size(107, 42);
            btnCancelarChamado.TabIndex = 0;
            btnCancelarChamado.Text = "Cancelar";
            btnCancelarChamado.UseVisualStyleBackColor = false;
            btnCancelarChamado.Click += btnCancelarChamado_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(71, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(73, 117);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(233, 23);
            comboBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 190);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 135);
            textBox1.TabIndex = 3;
            // 
            // labelSetorChamado
            // 
            labelSetorChamado.AutoSize = true;
            labelSetorChamado.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSetorChamado.Location = new Point(156, 29);
            labelSetorChamado.Name = "labelSetorChamado";
            labelSetorChamado.Size = new Size(49, 16);
            labelSetorChamado.TabIndex = 4;
            labelSetorChamado.Text = "Setor :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 162);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // labelCategoriaChamado
            // 
            labelCategoriaChamado.AutoSize = true;
            labelCategoriaChamado.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategoriaChamado.Location = new Point(145, 98);
            labelCategoriaChamado.Name = "labelCategoriaChamado";
            labelCategoriaChamado.Size = new Size(77, 16);
            labelCategoriaChamado.TabIndex = 6;
            labelCategoriaChamado.Text = "Categoria :";
            // 
            // labelMsgChamado
            // 
            labelMsgChamado.AutoSize = true;
            labelMsgChamado.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMsgChamado.Location = new Point(138, 161);
            labelMsgChamado.Name = "labelMsgChamado";
            labelMsgChamado.Size = new Size(84, 16);
            labelMsgChamado.TabIndex = 7;
            labelMsgChamado.Text = "Mensagem :";
            // 
            // btnCriarChamado
            // 
            btnCriarChamado.BackColor = Color.FromArgb(192, 255, 192);
            btnCriarChamado.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarChamado.Location = new Point(42, 382);
            btnCriarChamado.Name = "btnCriarChamado";
            btnCriarChamado.Size = new Size(146, 37);
            btnCriarChamado.TabIndex = 8;
            btnCriarChamado.Text = "Criar Chamado";
            btnCriarChamado.UseVisualStyleBackColor = false;
            // 
            // FrmChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(379, 450);
            Controls.Add(btnCriarChamado);
            Controls.Add(labelMsgChamado);
            Controls.Add(labelCategoriaChamado);
            Controls.Add(label1);
            Controls.Add(labelSetorChamado);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnCancelarChamado);
            Name = "FrmChamado";
            Text = "FrmChamado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarChamado;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label labelSetorChamado;
        private Label label1;
        private Label labelCategoriaChamado;
        private Label labelMsgChamado;
        private Button btnCriarChamado;
    }
}