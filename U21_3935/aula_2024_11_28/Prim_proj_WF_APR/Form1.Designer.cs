namespace Prim_proj_WF_APR
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
            this.Titulo = new System.Windows.Forms.Label();
            this.Input_nome = new System.Windows.Forms.TextBox();
            this.Botao = new System.Windows.Forms.Button();
            this.Msg = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // Titulo
            //
            this.Titulo.AutoSize = true;
            this.Titulo.Text = "Insere o teu nome na caixa de texto abaixo";
            this.Titulo.Location = new System.Drawing.Point(124, 48);
            this.Titulo.Size = new System.Drawing.Size(232, 15);
            this.Titulo.TabIndex = 1;
            //
            // Input_nome
            //
            this.Input_nome.Location = new System.Drawing.Point(132, 104);
            this.Input_nome.Size = new System.Drawing.Size(208, 23);
            this.Input_nome.TabIndex = 2;
            //
            // Botao
            //
            this.Botao.Text = "Clica aqui";
            this.Botao.Location = new System.Drawing.Point(150, 150);
            this.Botao.Size = new System.Drawing.Size(176, 40);
            //
            // Msg
            //
            this.Msg.AutoSize = true;
            this.Msg.Text = "";
            this.Msg.Location = new System.Drawing.Point(200, 216);
            this.Msg.Size = new System.Drawing.Size(41, 15);
            this.Msg.TabIndex = 3;
            //
            // Next
            //
            this.Next.Text =  "Next";
            this.Next.Location = new System.Drawing.Point(368,248);
            this.Next.TabIndex = 4;
            //
            // form
            //
            this.Size = new System.Drawing.Size(484, 340);
            // Change window color
            this.BackColor = System.Drawing.Color.LightGray;
            this.Text = "Primeira aplicação Windows Forms Cordyceps®";
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Input_nome);
            this.Controls.Add(this.Botao);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.Next);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Botao;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox Input_nome;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.Button Next;
    }
}

