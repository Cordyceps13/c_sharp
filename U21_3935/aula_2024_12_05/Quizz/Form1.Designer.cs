namespace Quizz
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            time_label = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            mais = new Label();
            plusRightLabel = new Label();
            label4 = new Label();
            soma = new NumericUpDown();
            diferenca = new NumericUpDown();
            label3 = new Label();
            minusRightLabel = new Label();
            menos = new Label();
            minusLeftLabel = new Label();
            produto = new NumericUpDown();
            label8 = new Label();
            timesRightLabel = new Label();
            vezes = new Label();
            timesLeftLabel = new Label();
            quociente = new NumericUpDown();
            label12 = new Label();
            dividedRightLabel = new Label();
            divisao = new Label();
            dividedLeftLabel = new Label();
            StartBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)soma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diferenca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quociente).BeginInit();
            SuspendLayout();
            // 
            // time_label
            // 
            time_label.BorderStyle = BorderStyle.FixedSingle;
            time_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            time_label.Location = new Point(310, 9);
            time_label.Name = "time_label";
            time_label.Size = new Size(162, 35);
            time_label.TabIndex = 0;
            time_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 1;
            label1.Text = "Tempo restante";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusLeftLabel.Location = new Point(58, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mais
            // 
            mais.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            mais.Location = new Point(124, 75);
            mais.Name = "mais";
            mais.Size = new Size(60, 50);
            mais.TabIndex = 3;
            mais.Text = "+";
            mais.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusRightLabel.Location = new Point(190, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 4;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(256, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 5;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // soma
            // 
            soma.BackColor = SystemColors.ActiveCaption;
            soma.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            soma.Location = new Point(322, 82);
            soma.MaximumSize = new Size(100, 0);
            soma.Name = "soma";
            soma.Size = new Size(100, 39);
            soma.TabIndex = 1;
            soma.Enter += submeter_resposta;
            // 
            // diferenca
            // 
            diferenca.BackColor = SystemColors.ActiveCaption;
            diferenca.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            diferenca.Location = new Point(322, 144);
            diferenca.MaximumSize = new Size(100, 0);
            diferenca.Name = "diferenca";
            diferenca.Size = new Size(100, 39);
            diferenca.TabIndex = 2;
            diferenca.Enter += submeter_resposta;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(256, 137);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 10;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusRightLabel.Location = new Point(190, 137);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 9;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menos
            // 
            menos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            menos.Location = new Point(124, 137);
            menos.Name = "menos";
            menos.Size = new Size(60, 50);
            menos.TabIndex = 8;
            menos.Text = "-";
            menos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusLeftLabel.Location = new Point(58, 137);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // produto
            // 
            produto.BackColor = SystemColors.ActiveCaption;
            produto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            produto.Location = new Point(322, 204);
            produto.MaximumSize = new Size(100, 0);
            produto.Name = "produto";
            produto.Size = new Size(100, 39);
            produto.TabIndex = 3;
            produto.Enter += submeter_resposta;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(256, 197);
            label8.Name = "label8";
            label8.Size = new Size(60, 50);
            label8.TabIndex = 15;
            label8.Text = "=";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesRightLabel.Location = new Point(190, 197);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 14;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vezes
            // 
            vezes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            vezes.Location = new Point(124, 197);
            vezes.Name = "vezes";
            vezes.Size = new Size(60, 50);
            vezes.TabIndex = 13;
            vezes.Text = "x";
            vezes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesLeftLabel.Location = new Point(58, 197);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quociente
            // 
            quociente.BackColor = SystemColors.ActiveCaption;
            quociente.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quociente.Location = new Point(322, 263);
            quociente.MaximumSize = new Size(100, 0);
            quociente.Name = "quociente";
            quociente.Size = new Size(100, 39);
            quociente.TabIndex = 4;
            quociente.Enter += submeter_resposta;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(256, 256);
            label12.Name = "label12";
            label12.Size = new Size(60, 50);
            label12.TabIndex = 20;
            label12.Text = "=";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedRightLabel.Location = new Point(190, 256);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 19;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divisao
            // 
            divisao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            divisao.Location = new Point(124, 256);
            divisao.Name = "divisao";
            divisao.Size = new Size(60, 50);
            divisao.TabIndex = 18;
            divisao.Text = "÷";
            divisao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedLeftLabel.Location = new Point(58, 256);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 17;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartBtn
            // 
            StartBtn.AutoSize = true;
            StartBtn.BackColor = SystemColors.ActiveCaption;
            StartBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.Location = new Point(157, 342);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(150, 35);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Começar Quizz";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += startBtn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(480, 413);
            Controls.Add(StartBtn);
            Controls.Add(quociente);
            Controls.Add(label12);
            Controls.Add(dividedRightLabel);
            Controls.Add(divisao);
            Controls.Add(dividedLeftLabel);
            Controls.Add(produto);
            Controls.Add(label8);
            Controls.Add(timesRightLabel);
            Controls.Add(vezes);
            Controls.Add(timesLeftLabel);
            Controls.Add(diferenca);
            Controls.Add(label3);
            Controls.Add(minusRightLabel);
            Controls.Add(menos);
            Controls.Add(minusLeftLabel);
            Controls.Add(soma);
            Controls.Add(label4);
            Controls.Add(plusRightLabel);
            Controls.Add(mais);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(time_label);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Quizz Cordyceps®";
            ((System.ComponentModel.ISupportInitialize)soma).EndInit();
            ((System.ComponentModel.ISupportInitialize)diferenca).EndInit();
            ((System.ComponentModel.ISupportInitialize)produto).EndInit();
            ((System.ComponentModel.ISupportInitialize)quociente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label time_label;
        private Label label1;
        private Label plusLeftLabel;
        private Label mais;
        private Label plusRightLabel;
        private Label label4;
        private NumericUpDown soma;
        private NumericUpDown diferenca;
        private Label label3;
        private Label minusRightLabel;
        private Label menos;
        private Label minusLeftLabel;
        private NumericUpDown produto;
        private Label label8;
        private Label timesRightLabel;
        private Label vezes;
        private Label timesLeftLabel;
        private NumericUpDown quociente;
        private Label label12;
        private Label dividedRightLabel;
        private Label divisao;
        private Label dividedLeftLabel;
        private Button StartBtn;
        private System.Windows.Forms.Timer timer1;
    }
}
