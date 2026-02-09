namespace filaePilha
{
    partial class Form1
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
            btnRemoverP = new Button();
            btnAdicionarP = new Button();
            btnAdicionarF = new Button();
            btnRemoverF = new Button();
            txtPilha = new TextBox();
            txtFila = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnRemoverP
            // 
            btnRemoverP.BackColor = Color.Red;
            btnRemoverP.Location = new Point(229, 225);
            btnRemoverP.Name = "btnRemoverP";
            btnRemoverP.Size = new Size(75, 23);
            btnRemoverP.TabIndex = 0;
            btnRemoverP.Text = "Remover";
            btnRemoverP.UseVisualStyleBackColor = false;
            btnRemoverP.Click += btnRemoverP_Click;
            // 
            // btnAdicionarP
            // 
            btnAdicionarP.BackColor = Color.Lime;
            btnAdicionarP.Location = new Point(148, 225);
            btnAdicionarP.Name = "btnAdicionarP";
            btnAdicionarP.Size = new Size(75, 23);
            btnAdicionarP.TabIndex = 1;
            btnAdicionarP.Text = "Adicionar";
            btnAdicionarP.UseVisualStyleBackColor = false;
            btnAdicionarP.Click += btnAdicionarP_Click;
            // 
            // btnAdicionarF
            // 
            btnAdicionarF.BackColor = Color.FromArgb(128, 255, 128);
            btnAdicionarF.Location = new Point(464, 225);
            btnAdicionarF.Name = "btnAdicionarF";
            btnAdicionarF.Size = new Size(75, 23);
            btnAdicionarF.TabIndex = 2;
            btnAdicionarF.Text = "Adicionar";
            btnAdicionarF.UseVisualStyleBackColor = false;
            btnAdicionarF.Click += btnAdicionarF_Click;
            // 
            // btnRemoverF
            // 
            btnRemoverF.BackColor = Color.Red;
            btnRemoverF.Location = new Point(545, 225);
            btnRemoverF.Name = "btnRemoverF";
            btnRemoverF.Size = new Size(75, 23);
            btnRemoverF.TabIndex = 3;
            btnRemoverF.Text = "Remover";
            btnRemoverF.UseVisualStyleBackColor = false;
            btnRemoverF.Click += btnRemoverF_Click;
            // 
            // txtPilha
            // 
            txtPilha.Location = new Point(42, 225);
            txtPilha.Name = "txtPilha";
            txtPilha.Size = new Size(100, 23);
            txtPilha.TabIndex = 4;
            txtPilha.TextChanged += txtPilha_TextChanged;
            // 
            // txtFila
            // 
            txtFila.Location = new Point(358, 225);
            txtFila.Name = "txtFila";
            txtFila.Size = new Size(100, 23);
            txtFila.TabIndex = 5;
            txtFila.TextChanged += txtFila_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(42, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(262, 169);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(358, 50);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(262, 169);
            listBox2.TabIndex = 7;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(42, 15);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 8;
            label1.Text = "Pilha";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(358, 15);
            label2.Name = "label2";
            label2.Size = new Size(50, 32);
            label2.TabIndex = 9;
            label2.Text = "Fila";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.kLaAM_SN_400x400;
            ClientSize = new Size(687, 378);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(txtFila);
            Controls.Add(txtPilha);
            Controls.Add(btnRemoverF);
            Controls.Add(btnAdicionarF);
            Controls.Add(btnAdicionarP);
            Controls.Add(btnRemoverP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoverP;
        private Button btnAdicionarP;
        private Button btnAdicionarF;
        private Button btnRemoverF;
        private TextBox txtPilha;
        private TextBox txtFila;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
    }
}
