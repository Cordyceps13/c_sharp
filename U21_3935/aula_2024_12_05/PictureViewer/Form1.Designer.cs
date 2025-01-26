namespace PictureViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            botao_img = new Button();
            botao_limpar = new Button();
            botao_escolher = new Button();
            botao_fechar = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(808, 568);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 505);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Location = new Point(3, 514);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 51);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Esticar Imagem";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(botao_img);
            flowLayoutPanel1.Controls.Add(botao_limpar);
            flowLayoutPanel1.Controls.Add(botao_escolher);
            flowLayoutPanel1.Controls.Add(botao_fechar);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(124, 514);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(681, 51);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // botao_img
            // 
            botao_img.AutoSize = true;
            botao_img.Location = new Point(570, 3);
            botao_img.Name = "botao_img";
            botao_img.Size = new Size(108, 25);
            botao_img.TabIndex = 0;
            botao_img.Text = "Escolher Imagem";
            botao_img.UseVisualStyleBackColor = true;
            botao_img.Click += botao_img_Click;
            // 
            // botao_limpar
            // 
            botao_limpar.AutoSize = true;
            botao_limpar.Location = new Point(489, 3);
            botao_limpar.Name = "botao_limpar";
            botao_limpar.Size = new Size(75, 25);
            botao_limpar.TabIndex = 1;
            botao_limpar.Text = "Limpar";
            botao_limpar.UseVisualStyleBackColor = true;
            botao_limpar.Click += botao_limpar_Click;
            // 
            // botao_escolher
            // 
            botao_escolher.AutoSize = true;
            botao_escolher.Location = new Point(351, 3);
            botao_escolher.Name = "botao_escolher";
            botao_escolher.Size = new Size(132, 25);
            botao_escolher.TabIndex = 2;
            botao_escolher.Text = "Escolher cor de fundo";
            botao_escolher.UseVisualStyleBackColor = true;
            botao_escolher.Click += botao_escolher_Click;
            // 
            // botao_fechar
            // 
            botao_fechar.AutoSize = true;
            botao_fechar.Location = new Point(270, 3);
            botao_fechar.Name = "botao_fechar";
            botao_fechar.Size = new Size(75, 25);
            botao_fechar.TabIndex = 3;
            botao_fechar.Text = "Fechar";
            botao_fechar.UseVisualStyleBackColor = true;
            botao_fechar.Click += botao_fechar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.Title = "Escolher imagem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 568);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Visualizador de Imagens Cordyceps ®";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button botao_img;
        private Button botao_limpar;
        private Button botao_escolher;
        private Button botao_fechar;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}
