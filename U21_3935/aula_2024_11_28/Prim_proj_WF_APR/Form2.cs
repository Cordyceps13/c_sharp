namespace Prim_proj_WF_APR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Adicione os controles e personalizações para o segundo formulário aqui.
            this.Button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // Button0 (Botão Voltar)
            // 
            this.Button0.Text = "Voltar";
            this.Button0.Location = new System.Drawing.Point(144, 144);
            this.Button0.Size = new System.Drawing.Size(184, 48);
            this.Button0.Click += new System.EventHandler(this.Button0_Click);

            // 
            // Form2
            // 
            this.Size = new System.Drawing.Size(480, 400);
            this.Text = "Segunda Janela - Form2";
            this.Controls.Add(this.Button0);
            this.ResumeLayout(false);
        }

        private void Button0_Click(object sender, System.EventArgs e)
        {
            // Fecha o Form2 e retorna ao Form1
            this.Close();
        }

        private System.Windows.Forms.Button Button0;
    }
}
