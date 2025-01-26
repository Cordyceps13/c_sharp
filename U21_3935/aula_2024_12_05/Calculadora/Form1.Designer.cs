namespace Calculadora
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
            PainelSuperior = new Panel();
            icon = new Button();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            CloseBtn = new Button();
            PainelInferior = new Panel();
            RtBoxDisplay = new RichTextBox();
            BtnLimparHistorico = new Button();
            PainelHistorico = new Panel();
            historico = new Button();
            menu = new Button();
            Display2 = new TextBox();
            Display1 = new TextBox();
            MaisOuMenos = new CustomControls.RJControls.RJButton();
            Btn0 = new CustomControls.RJControls.RJButton();
            BtnVirgula = new CustomControls.RJControls.RJButton();
            BtnIgual = new CustomControls.RJControls.RJButton();
            Btn3 = new CustomControls.RJControls.RJButton();
            Btn2 = new CustomControls.RJControls.RJButton();
            Btn1 = new CustomControls.RJControls.RJButton();
            Btn6 = new CustomControls.RJControls.RJButton();
            Btn5 = new CustomControls.RJControls.RJButton();
            Btn4 = new CustomControls.RJControls.RJButton();
            Btn9 = new CustomControls.RJControls.RJButton();
            Btn8 = new CustomControls.RJControls.RJButton();
            btn7 = new CustomControls.RJControls.RJButton();
            BtnRaizQuadrada = new CustomControls.RJControls.RJButton();
            BtnQuadrado = new CustomControls.RJControls.RJButton();
            BtnFraccao = new CustomControls.RJControls.RJButton();
            BtnC = new CustomControls.RJControls.RJButton();
            BtnCE = new CustomControls.RJControls.RJButton();
            BtnPercent = new CustomControls.RJControls.RJButton();
            BtnApagar = new CustomControls.RJControls.RJButton();
            BtnDivisao = new CustomControls.RJControls.RJButton();
            BtnVezes = new CustomControls.RJControls.RJButton();
            BtnMenos = new CustomControls.RJControls.RJButton();
            BtnMais = new CustomControls.RJControls.RJButton();
            BtnMC = new CustomControls.RJControls.RJButton();
            BtnMmenos = new CustomControls.RJControls.RJButton();
            BtnMmais = new CustomControls.RJControls.RJButton();
            BtnMR = new CustomControls.RJControls.RJButton();
            BtnMS = new CustomControls.RJControls.RJButton();
            BtnM = new CustomControls.RJControls.RJButton();
            PainelSuperior.SuspendLayout();
            PainelInferior.SuspendLayout();
            PainelHistorico.SuspendLayout();
            SuspendLayout();
            // 
            // PainelSuperior
            // 
            PainelSuperior.Controls.Add(icon);
            PainelSuperior.Controls.Add(label1);
            PainelSuperior.Controls.Add(button2);
            PainelSuperior.Controls.Add(button1);
            PainelSuperior.Controls.Add(CloseBtn);
            PainelSuperior.Dock = DockStyle.Top;
            PainelSuperior.Location = new Point(0, 0);
            PainelSuperior.Margin = new Padding(0);
            PainelSuperior.Name = "PainelSuperior";
            PainelSuperior.Size = new Size(347, 40);
            PainelSuperior.TabIndex = 0;
            PainelSuperior.MouseDown += OnMouseDown;
            PainelSuperior.MouseMove += OnMouseMove;
            // 
            // icon
            // 
            icon.BackColor = Color.Transparent;
            icon.Dock = DockStyle.Left;
            icon.FlatAppearance.BorderSize = 0;
            icon.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            icon.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            icon.FlatStyle = FlatStyle.Flat;
            icon.ForeColor = Color.FromArgb(32, 32, 32);
            icon.Image = (Image)resources.GetObject("icon.Image");
            icon.Location = new Point(0, 0);
            icon.Margin = new Padding(0);
            icon.Name = "icon";
            icon.Size = new Size(25, 40);
            icon.TabIndex = 4;
            icon.UseVisualStyleBackColor = false;
            icon.MouseDown += OnMouseDown;
            icon.MouseMove += OnMouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(140, 16);
            label1.TabIndex = 3;
            label1.Text = "Calculadora Cordyceps®";
            label1.MouseDown += OnMouseDown;
            label1.MouseMove += OnMouseMove;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 62);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(197, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(50, 40);
            button2.TabIndex = 2;
            button2.Text = "−";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 62);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(247, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 1;
            button1.Text = "□︎";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Dock = DockStyle.Right;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(190, 9, 9);
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(297, 0);
            CloseBtn.Margin = new Padding(0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(50, 40);
            CloseBtn.TabIndex = 0;
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // PainelInferior
            // 
            PainelInferior.Controls.Add(RtBoxDisplay);
            PainelInferior.Controls.Add(BtnLimparHistorico);
            PainelInferior.Dock = DockStyle.Bottom;
            PainelInferior.Location = new Point(0, 534);
            PainelInferior.Margin = new Padding(0);
            PainelInferior.Name = "PainelInferior";
            PainelInferior.Size = new Size(347, 1);
            PainelInferior.TabIndex = 1;
            // 
            // RtBoxDisplay
            // 
            RtBoxDisplay.BackColor = Color.FromArgb(32, 32, 32);
            RtBoxDisplay.BorderStyle = BorderStyle.None;
            RtBoxDisplay.Dock = DockStyle.Fill;
            RtBoxDisplay.ForeColor = Color.Silver;
            RtBoxDisplay.Location = new Point(0, 0);
            RtBoxDisplay.Margin = new Padding(0);
            RtBoxDisplay.Name = "RtBoxDisplay";
            RtBoxDisplay.ScrollBars = RichTextBoxScrollBars.Horizontal;
            RtBoxDisplay.Size = new Size(347, 0);
            RtBoxDisplay.TabIndex = 4;
            RtBoxDisplay.Text = "";
            // 
            // BtnLimparHistorico
            // 
            BtnLimparHistorico.Dock = DockStyle.Bottom;
            BtnLimparHistorico.FlatAppearance.BorderSize = 0;
            BtnLimparHistorico.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 62);
            BtnLimparHistorico.FlatStyle = FlatStyle.Flat;
            BtnLimparHistorico.Image = (Image)resources.GetObject("BtnLimparHistorico.Image");
            BtnLimparHistorico.Location = new Point(0, -39);
            BtnLimparHistorico.Margin = new Padding(0);
            BtnLimparHistorico.Name = "BtnLimparHistorico";
            BtnLimparHistorico.Size = new Size(347, 40);
            BtnLimparHistorico.TabIndex = 3;
            BtnLimparHistorico.UseVisualStyleBackColor = true;
            BtnLimparHistorico.Click += BtnLimparHistClick;
            // 
            // PainelHistorico
            // 
            PainelHistorico.Controls.Add(historico);
            PainelHistorico.Controls.Add(menu);
            PainelHistorico.Dock = DockStyle.Top;
            PainelHistorico.Location = new Point(0, 40);
            PainelHistorico.Margin = new Padding(0);
            PainelHistorico.Name = "PainelHistorico";
            PainelHistorico.Size = new Size(347, 40);
            PainelHistorico.TabIndex = 2;
            // 
            // historico
            // 
            historico.Dock = DockStyle.Right;
            historico.FlatAppearance.BorderSize = 0;
            historico.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 62);
            historico.FlatStyle = FlatStyle.Flat;
            historico.Image = (Image)resources.GetObject("historico.Image");
            historico.Location = new Point(297, 0);
            historico.Margin = new Padding(0);
            historico.Name = "historico";
            historico.Size = new Size(50, 40);
            historico.TabIndex = 2;
            historico.UseVisualStyleBackColor = true;
            historico.Click += historicoClick;
            // 
            // menu
            // 
            menu.Dock = DockStyle.Left;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 62);
            menu.FlatStyle = FlatStyle.Flat;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.Location = new Point(0, 0);
            menu.Margin = new Padding(0);
            menu.Name = "menu";
            menu.Size = new Size(50, 40);
            menu.TabIndex = 1;
            menu.UseVisualStyleBackColor = true;
            // 
            // Display2
            // 
            Display2.BackColor = Color.FromArgb(30, 30, 30);
            Display2.BorderStyle = BorderStyle.None;
            Display2.ForeColor = Color.Silver;
            Display2.Location = new Point(0, 94);
            Display2.Margin = new Padding(0);
            Display2.Multiline = true;
            Display2.Name = "Display2";
            Display2.Size = new Size(343, 23);
            Display2.TabIndex = 3;
            Display2.TextAlign = HorizontalAlignment.Right;
            // 
            // Display1
            // 
            Display1.BackColor = Color.FromArgb(30, 30, 30);
            Display1.BorderStyle = BorderStyle.None;
            Display1.Font = new Font("Gadugi", 28F, FontStyle.Bold, GraphicsUnit.Point);
            Display1.ForeColor = Color.White;
            Display1.Location = new Point(-9, 126);
            Display1.Margin = new Padding(0);
            Display1.Multiline = true;
            Display1.Name = "Display1";
            Display1.Size = new Size(347, 45);
            Display1.TabIndex = 4;
            Display1.Text = "0";
            Display1.TextAlign = HorizontalAlignment.Right;
            // 
            // MaisOuMenos
            // 
            MaisOuMenos.BackColor = Color.FromArgb(60, 60, 60);
            MaisOuMenos.BackgroundColor = Color.FromArgb(60, 60, 60);
            MaisOuMenos.BorderColor = Color.PaleVioletRed;
            MaisOuMenos.BorderRadius = 6;
            MaisOuMenos.BorderSize = 0;
            MaisOuMenos.FlatAppearance.BorderSize = 0;
            MaisOuMenos.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            MaisOuMenos.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            MaisOuMenos.FlatStyle = FlatStyle.Flat;
            MaisOuMenos.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MaisOuMenos.ForeColor = Color.White;
            MaisOuMenos.Location = new Point(3, 481);
            MaisOuMenos.Margin = new Padding(0);
            MaisOuMenos.Name = "MaisOuMenos";
            MaisOuMenos.Size = new Size(85, 50);
            MaisOuMenos.TabIndex = 5;
            MaisOuMenos.Text = "+/-";
            MaisOuMenos.TextColor = Color.White;
            MaisOuMenos.UseVisualStyleBackColor = false;
            MaisOuMenos.Click += BtnOperacaoSpec;
            // 
            // Btn0
            // 
            Btn0.BackColor = Color.FromArgb(60, 60, 60);
            Btn0.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn0.BorderColor = Color.PaleVioletRed;
            Btn0.BorderRadius = 6;
            Btn0.BorderSize = 0;
            Btn0.FlatAppearance.BorderSize = 0;
            Btn0.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            Btn0.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btn0.FlatStyle = FlatStyle.Flat;
            Btn0.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn0.ForeColor = Color.White;
            Btn0.Location = new Point(88, 481);
            Btn0.Margin = new Padding(0);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(85, 50);
            Btn0.TabIndex = 6;
            Btn0.Text = "0";
            Btn0.TextColor = Color.White;
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += BtnNumClick;
            // 
            // BtnVirgula
            // 
            BtnVirgula.BackColor = Color.FromArgb(60, 60, 60);
            BtnVirgula.BackgroundColor = Color.FromArgb(60, 60, 60);
            BtnVirgula.BorderColor = Color.PaleVioletRed;
            BtnVirgula.BorderRadius = 6;
            BtnVirgula.BorderSize = 0;
            BtnVirgula.FlatAppearance.BorderSize = 0;
            BtnVirgula.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            BtnVirgula.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            BtnVirgula.FlatStyle = FlatStyle.Flat;
            BtnVirgula.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVirgula.ForeColor = Color.White;
            BtnVirgula.Location = new Point(173, 481);
            BtnVirgula.Margin = new Padding(0);
            BtnVirgula.Name = "BtnVirgula";
            BtnVirgula.Size = new Size(85, 50);
            BtnVirgula.TabIndex = 7;
            BtnVirgula.Text = ",";
            BtnVirgula.TextColor = Color.White;
            BtnVirgula.UseVisualStyleBackColor = false;
            BtnVirgula.Click += BtnNumClick;
            // 
            // BtnIgual
            // 
            BtnIgual.BackColor = Color.CornflowerBlue;
            BtnIgual.BackgroundColor = Color.CornflowerBlue;
            BtnIgual.BorderColor = Color.PaleVioletRed;
            BtnIgual.BorderRadius = 6;
            BtnIgual.BorderSize = 0;
            BtnIgual.FlatAppearance.BorderSize = 0;
            BtnIgual.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 120, 200);
            BtnIgual.FlatStyle = FlatStyle.Flat;
            BtnIgual.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnIgual.ForeColor = Color.Black;
            BtnIgual.Location = new Point(258, 481);
            BtnIgual.Margin = new Padding(0);
            BtnIgual.Name = "BtnIgual";
            BtnIgual.Size = new Size(85, 50);
            BtnIgual.TabIndex = 8;
            BtnIgual.Text = "＝";
            BtnIgual.TextColor = Color.Black;
            BtnIgual.UseVisualStyleBackColor = false;
            BtnIgual.Click += BtnIgualClick;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.FromArgb(60, 60, 60);
            Btn3.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn3.BorderColor = Color.PaleVioletRed;
            Btn3.BorderRadius = 6;
            Btn3.BorderSize = 0;
            Btn3.FlatAppearance.BorderSize = 0;
            Btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            Btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btn3.FlatStyle = FlatStyle.Flat;
            Btn3.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn3.ForeColor = Color.White;
            Btn3.Location = new Point(173, 431);
            Btn3.Margin = new Padding(0);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(85, 50);
            Btn3.TabIndex = 12;
            Btn3.Text = "3";
            Btn3.TextColor = Color.White;
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += BtnNumClick;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.FromArgb(60, 60, 60);
            Btn2.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn2.BorderColor = Color.PaleVioletRed;
            Btn2.BorderRadius = 6;
            Btn2.BorderSize = 0;
            Btn2.FlatAppearance.BorderSize = 0;
            Btn2.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            Btn2.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn2.ForeColor = Color.White;
            Btn2.Location = new Point(88, 431);
            Btn2.Margin = new Padding(0);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(85, 50);
            Btn2.TabIndex = 11;
            Btn2.Text = "2";
            Btn2.TextColor = Color.White;
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += BtnNumClick;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.FromArgb(60, 60, 60);
            Btn1.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn1.BorderColor = Color.PaleVioletRed;
            Btn1.BorderRadius = 6;
            Btn1.BorderSize = 0;
            Btn1.FlatAppearance.BorderSize = 0;
            Btn1.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            Btn1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn1.ForeColor = Color.White;
            Btn1.Location = new Point(3, 431);
            Btn1.Margin = new Padding(0);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(85, 50);
            Btn1.TabIndex = 10;
            Btn1.Text = "1";
            Btn1.TextColor = Color.White;
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += BtnNumClick;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.FromArgb(60, 60, 60);
            Btn6.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn6.BorderColor = Color.PaleVioletRed;
            Btn6.BorderRadius = 6;
            Btn6.BorderSize = 0;
            Btn6.FlatAppearance.BorderSize = 0;
            Btn6.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            Btn6.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btn6.FlatStyle = FlatStyle.Flat;
            Btn6.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn6.ForeColor = Color.White;
            Btn6.Location = new Point(173, 381);
            Btn6.Margin = new Padding(0);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(85, 50);
            Btn6.TabIndex = 15;
            Btn6.Text = "6";
            Btn6.TextColor = Color.White;
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += BtnNumClick;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.FromArgb(60, 60, 60);
            Btn5.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn5.BorderColor = Color.PaleVioletRed;
            Btn5.BorderRadius = 6;
            Btn5.BorderSize = 0;
            Btn5.FlatAppearance.BorderSize = 0;
            Btn5.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            Btn5.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btn5.FlatStyle = FlatStyle.Flat;
            Btn5.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn5.ForeColor = Color.White;
            Btn5.Location = new Point(88, 381);
            Btn5.Margin = new Padding(0);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(85, 50);
            Btn5.TabIndex = 14;
            Btn5.Text = "5";
            Btn5.TextColor = Color.White;
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += BtnNumClick;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.FromArgb(60, 60, 60);
            Btn4.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn4.BorderColor = Color.PaleVioletRed;
            Btn4.BorderRadius = 6;
            Btn4.BorderSize = 0;
            Btn4.FlatAppearance.BorderSize = 0;
            Btn4.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            Btn4.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btn4.FlatStyle = FlatStyle.Flat;
            Btn4.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn4.ForeColor = Color.White;
            Btn4.Location = new Point(3, 381);
            Btn4.Margin = new Padding(0);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(85, 50);
            Btn4.TabIndex = 13;
            Btn4.Text = "4";
            Btn4.TextColor = Color.White;
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += BtnNumClick;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.FromArgb(60, 60, 60);
            Btn9.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn9.BorderColor = Color.PaleVioletRed;
            Btn9.BorderRadius = 6;
            Btn9.BorderSize = 0;
            Btn9.FlatAppearance.BorderSize = 0;
            Btn9.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            Btn9.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btn9.FlatStyle = FlatStyle.Flat;
            Btn9.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn9.ForeColor = Color.White;
            Btn9.Location = new Point(173, 331);
            Btn9.Margin = new Padding(0);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(85, 50);
            Btn9.TabIndex = 18;
            Btn9.Text = "9";
            Btn9.TextColor = Color.White;
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += BtnNumClick;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.FromArgb(60, 60, 60);
            Btn8.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn8.BorderColor = Color.PaleVioletRed;
            Btn8.BorderRadius = 6;
            Btn8.BorderSize = 0;
            Btn8.FlatAppearance.BorderSize = 0;
            Btn8.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            Btn8.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btn8.FlatStyle = FlatStyle.Flat;
            Btn8.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn8.ForeColor = Color.White;
            Btn8.Location = new Point(88, 331);
            Btn8.Margin = new Padding(0);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(85, 50);
            Btn8.TabIndex = 17;
            Btn8.Text = "8";
            Btn8.TextColor = Color.White;
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += BtnNumClick;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(60, 60, 60);
            btn7.BackgroundColor = Color.FromArgb(60, 60, 60);
            btn7.BorderColor = Color.PaleVioletRed;
            btn7.BorderRadius = 6;
            btn7.BorderSize = 0;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btn7.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(3, 331);
            btn7.Margin = new Padding(0);
            btn7.Name = "btn7";
            btn7.Size = new Size(85, 50);
            btn7.TabIndex = 16;
            btn7.Text = "7";
            btn7.TextColor = Color.White;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += BtnNumClick;
            // 
            // BtnRaizQuadrada
            // 
            BtnRaizQuadrada.BackColor = Color.FromArgb(50, 50, 50);
            BtnRaizQuadrada.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnRaizQuadrada.BorderColor = Color.PaleVioletRed;
            BtnRaizQuadrada.BorderRadius = 6;
            BtnRaizQuadrada.BorderSize = 0;
            BtnRaizQuadrada.FlatAppearance.BorderSize = 0;
            BtnRaizQuadrada.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnRaizQuadrada.FlatStyle = FlatStyle.Flat;
            BtnRaizQuadrada.Font = new Font("Gadugi", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRaizQuadrada.ForeColor = Color.White;
            BtnRaizQuadrada.Location = new Point(173, 281);
            BtnRaizQuadrada.Margin = new Padding(0);
            BtnRaizQuadrada.Name = "BtnRaizQuadrada";
            BtnRaizQuadrada.Size = new Size(85, 50);
            BtnRaizQuadrada.TabIndex = 21;
            BtnRaizQuadrada.Text = "²√𝑥";
            BtnRaizQuadrada.TextColor = Color.White;
            BtnRaizQuadrada.UseVisualStyleBackColor = false;
            BtnRaizQuadrada.Click += BtnOperacaoSpec;
            // 
            // BtnQuadrado
            // 
            BtnQuadrado.BackColor = Color.FromArgb(50, 50, 50);
            BtnQuadrado.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnQuadrado.BorderColor = Color.PaleVioletRed;
            BtnQuadrado.BorderRadius = 6;
            BtnQuadrado.BorderSize = 0;
            BtnQuadrado.FlatAppearance.BorderSize = 0;
            BtnQuadrado.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnQuadrado.FlatStyle = FlatStyle.Flat;
            BtnQuadrado.Font = new Font("Gadugi", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BtnQuadrado.ForeColor = Color.White;
            BtnQuadrado.Location = new Point(88, 281);
            BtnQuadrado.Margin = new Padding(0);
            BtnQuadrado.Name = "BtnQuadrado";
            BtnQuadrado.Size = new Size(85, 50);
            BtnQuadrado.TabIndex = 20;
            BtnQuadrado.Text = "𝑥²";
            BtnQuadrado.TextColor = Color.White;
            BtnQuadrado.UseVisualStyleBackColor = false;
            BtnQuadrado.Click += BtnOperacaoSpec;
            // 
            // BtnFraccao
            // 
            BtnFraccao.BackColor = Color.FromArgb(50, 50, 50);
            BtnFraccao.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnFraccao.BorderColor = Color.PaleVioletRed;
            BtnFraccao.BorderRadius = 6;
            BtnFraccao.BorderSize = 0;
            BtnFraccao.FlatAppearance.BorderSize = 0;
            BtnFraccao.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnFraccao.FlatStyle = FlatStyle.Flat;
            BtnFraccao.Font = new Font("Gadugi", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFraccao.ForeColor = Color.White;
            BtnFraccao.Location = new Point(3, 281);
            BtnFraccao.Margin = new Padding(0);
            BtnFraccao.Name = "BtnFraccao";
            BtnFraccao.Size = new Size(85, 50);
            BtnFraccao.TabIndex = 19;
            BtnFraccao.Text = "¹/𝑥";
            BtnFraccao.TextColor = Color.White;
            BtnFraccao.UseVisualStyleBackColor = false;
            BtnFraccao.Click += BtnOperacaoSpec;
            // 
            // BtnC
            // 
            BtnC.BackColor = Color.FromArgb(50, 50, 50);
            BtnC.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnC.BorderColor = Color.PaleVioletRed;
            BtnC.BorderRadius = 6;
            BtnC.BorderSize = 0;
            BtnC.FlatAppearance.BorderSize = 0;
            BtnC.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnC.FlatStyle = FlatStyle.Flat;
            BtnC.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnC.ForeColor = Color.White;
            BtnC.Location = new Point(173, 231);
            BtnC.Margin = new Padding(0);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(85, 50);
            BtnC.TabIndex = 24;
            BtnC.Text = "C";
            BtnC.TextColor = Color.White;
            BtnC.UseVisualStyleBackColor = false;
            BtnC.Click += BtnC_Click;
            // 
            // BtnCE
            // 
            BtnCE.BackColor = Color.FromArgb(50, 50, 50);
            BtnCE.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnCE.BorderColor = Color.PaleVioletRed;
            BtnCE.BorderRadius = 6;
            BtnCE.BorderSize = 0;
            BtnCE.FlatAppearance.BorderSize = 0;
            BtnCE.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnCE.FlatStyle = FlatStyle.Flat;
            BtnCE.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCE.ForeColor = Color.White;
            BtnCE.Location = new Point(88, 231);
            BtnCE.Margin = new Padding(0);
            BtnCE.Name = "BtnCE";
            BtnCE.Size = new Size(85, 50);
            BtnCE.TabIndex = 23;
            BtnCE.Text = "CE";
            BtnCE.TextColor = Color.White;
            BtnCE.UseVisualStyleBackColor = false;
            BtnCE.Click += BtnCE_Click;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = Color.FromArgb(50, 50, 50);
            BtnPercent.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnPercent.BorderColor = Color.PaleVioletRed;
            BtnPercent.BorderRadius = 6;
            BtnPercent.BorderSize = 0;
            BtnPercent.FlatAppearance.BorderSize = 0;
            BtnPercent.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnPercent.FlatStyle = FlatStyle.Flat;
            BtnPercent.Font = new Font("Gadugi", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPercent.ForeColor = Color.White;
            BtnPercent.Location = new Point(3, 231);
            BtnPercent.Margin = new Padding(0);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(85, 50);
            BtnPercent.TabIndex = 22;
            BtnPercent.Text = "%\t";
            BtnPercent.TextColor = Color.White;
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += BtnOperacaoSpec;
            // 
            // BtnApagar
            // 
            BtnApagar.BackColor = Color.FromArgb(50, 50, 50);
            BtnApagar.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnApagar.BorderColor = Color.PaleVioletRed;
            BtnApagar.BorderRadius = 6;
            BtnApagar.BorderSize = 0;
            BtnApagar.FlatAppearance.BorderSize = 0;
            BtnApagar.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnApagar.FlatStyle = FlatStyle.Flat;
            BtnApagar.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnApagar.ForeColor = Color.White;
            BtnApagar.Location = new Point(258, 231);
            BtnApagar.Margin = new Padding(0);
            BtnApagar.Name = "BtnApagar";
            BtnApagar.Size = new Size(85, 50);
            BtnApagar.TabIndex = 29;
            BtnApagar.Text = "⌫︎";
            BtnApagar.TextColor = Color.White;
            BtnApagar.UseVisualStyleBackColor = false;
            BtnApagar.Click += BtnApagar_Click;
            // 
            // BtnDivisao
            // 
            BtnDivisao.BackColor = Color.FromArgb(50, 50, 50);
            BtnDivisao.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnDivisao.BorderColor = Color.PaleVioletRed;
            BtnDivisao.BorderRadius = 6;
            BtnDivisao.BorderSize = 0;
            BtnDivisao.FlatAppearance.BorderSize = 0;
            BtnDivisao.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnDivisao.FlatStyle = FlatStyle.Flat;
            BtnDivisao.Font = new Font("Gadugi", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDivisao.ForeColor = Color.White;
            BtnDivisao.Location = new Point(258, 281);
            BtnDivisao.Margin = new Padding(0);
            BtnDivisao.Name = "BtnDivisao";
            BtnDivisao.Size = new Size(85, 50);
            BtnDivisao.TabIndex = 28;
            BtnDivisao.Text = "÷";
            BtnDivisao.TextColor = Color.White;
            BtnDivisao.UseVisualStyleBackColor = false;
            BtnDivisao.Click += BtnOperacaoClick;
            // 
            // BtnVezes
            // 
            BtnVezes.BackColor = Color.FromArgb(50, 50, 50);
            BtnVezes.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnVezes.BorderColor = Color.PaleVioletRed;
            BtnVezes.BorderRadius = 6;
            BtnVezes.BorderSize = 0;
            BtnVezes.FlatAppearance.BorderSize = 0;
            BtnVezes.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnVezes.FlatStyle = FlatStyle.Flat;
            BtnVezes.Font = new Font("Gadugi", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVezes.ForeColor = Color.White;
            BtnVezes.Location = new Point(258, 331);
            BtnVezes.Margin = new Padding(0);
            BtnVezes.Name = "BtnVezes";
            BtnVezes.Size = new Size(85, 50);
            BtnVezes.TabIndex = 27;
            BtnVezes.Text = "×";
            BtnVezes.TextColor = Color.White;
            BtnVezes.UseVisualStyleBackColor = false;
            BtnVezes.Click += BtnOperacaoClick;
            // 
            // BtnMenos
            // 
            BtnMenos.BackColor = Color.FromArgb(50, 50, 50);
            BtnMenos.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnMenos.BorderColor = Color.PaleVioletRed;
            BtnMenos.BorderRadius = 6;
            BtnMenos.BorderSize = 0;
            BtnMenos.FlatAppearance.BorderSize = 0;
            BtnMenos.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnMenos.FlatStyle = FlatStyle.Flat;
            BtnMenos.Font = new Font("Gadugi", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMenos.ForeColor = Color.White;
            BtnMenos.Location = new Point(258, 381);
            BtnMenos.Margin = new Padding(0);
            BtnMenos.Name = "BtnMenos";
            BtnMenos.Size = new Size(85, 50);
            BtnMenos.TabIndex = 26;
            BtnMenos.Text = "−";
            BtnMenos.TextColor = Color.White;
            BtnMenos.UseVisualStyleBackColor = false;
            BtnMenos.Click += BtnOperacaoClick;
            // 
            // BtnMais
            // 
            BtnMais.BackColor = Color.FromArgb(50, 50, 50);
            BtnMais.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnMais.BorderColor = Color.PaleVioletRed;
            BtnMais.BorderRadius = 6;
            BtnMais.BorderSize = 0;
            BtnMais.FlatAppearance.BorderSize = 0;
            BtnMais.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            BtnMais.FlatStyle = FlatStyle.Flat;
            BtnMais.Font = new Font("Gadugi", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMais.ForeColor = Color.White;
            BtnMais.Location = new Point(258, 431);
            BtnMais.Margin = new Padding(0);
            BtnMais.Name = "BtnMais";
            BtnMais.Size = new Size(85, 50);
            BtnMais.TabIndex = 25;
            BtnMais.Text = "+";
            BtnMais.TextColor = Color.White;
            BtnMais.UseVisualStyleBackColor = false;
            BtnMais.Click += BtnOperacaoClick;
            // 
            // BtnMC
            // 
            BtnMC.BackColor = Color.FromArgb(32, 32, 32);
            BtnMC.BackgroundColor = Color.FromArgb(32, 32, 32);
            BtnMC.BorderColor = Color.PaleVioletRed;
            BtnMC.BorderRadius = 4;
            BtnMC.BorderSize = 0;
            BtnMC.FlatAppearance.BorderSize = 0;
            BtnMC.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            BtnMC.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            BtnMC.FlatStyle = FlatStyle.Flat;
            BtnMC.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMC.ForeColor = Color.Gray;
            BtnMC.Location = new Point(3, 201);
            BtnMC.Margin = new Padding(0);
            BtnMC.Name = "BtnMC";
            BtnMC.Size = new Size(57, 30);
            BtnMC.TabIndex = 30;
            BtnMC.Text = "MC";
            BtnMC.TextColor = Color.Gray;
            BtnMC.UseVisualStyleBackColor = false;
            // 
            // BtnMmenos
            // 
            BtnMmenos.BackColor = Color.FromArgb(32, 32, 32);
            BtnMmenos.BackgroundColor = Color.FromArgb(32, 32, 32);
            BtnMmenos.BorderColor = Color.PaleVioletRed;
            BtnMmenos.BorderRadius = 4;
            BtnMmenos.BorderSize = 0;
            BtnMmenos.FlatAppearance.BorderSize = 0;
            BtnMmenos.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            BtnMmenos.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            BtnMmenos.FlatStyle = FlatStyle.Flat;
            BtnMmenos.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMmenos.ForeColor = Color.White;
            BtnMmenos.Location = new Point(173, 201);
            BtnMmenos.Margin = new Padding(0);
            BtnMmenos.Name = "BtnMmenos";
            BtnMmenos.Size = new Size(57, 30);
            BtnMmenos.TabIndex = 31;
            BtnMmenos.Text = "M−";
            BtnMmenos.TextColor = Color.White;
            BtnMmenos.UseVisualStyleBackColor = false;
            // 
            // BtnMmais
            // 
            BtnMmais.BackColor = Color.FromArgb(32, 32, 32);
            BtnMmais.BackgroundColor = Color.FromArgb(32, 32, 32);
            BtnMmais.BorderColor = Color.PaleVioletRed;
            BtnMmais.BorderRadius = 4;
            BtnMmais.BorderSize = 0;
            BtnMmais.FlatAppearance.BorderSize = 0;
            BtnMmais.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            BtnMmais.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            BtnMmais.FlatStyle = FlatStyle.Flat;
            BtnMmais.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMmais.ForeColor = Color.White;
            BtnMmais.Location = new Point(116, 201);
            BtnMmais.Margin = new Padding(0);
            BtnMmais.Name = "BtnMmais";
            BtnMmais.Size = new Size(57, 30);
            BtnMmais.TabIndex = 32;
            BtnMmais.Text = "M+";
            BtnMmais.TextColor = Color.White;
            BtnMmais.UseVisualStyleBackColor = false;
            // 
            // BtnMR
            // 
            BtnMR.BackColor = Color.FromArgb(32, 32, 32);
            BtnMR.BackgroundColor = Color.FromArgb(32, 32, 32);
            BtnMR.BorderColor = Color.PaleVioletRed;
            BtnMR.BorderRadius = 4;
            BtnMR.BorderSize = 0;
            BtnMR.FlatAppearance.BorderSize = 0;
            BtnMR.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            BtnMR.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            BtnMR.FlatStyle = FlatStyle.Flat;
            BtnMR.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMR.ForeColor = Color.Gray;
            BtnMR.Location = new Point(60, 201);
            BtnMR.Margin = new Padding(0);
            BtnMR.Name = "BtnMR";
            BtnMR.Size = new Size(57, 30);
            BtnMR.TabIndex = 33;
            BtnMR.Text = "MR";
            BtnMR.TextColor = Color.Gray;
            BtnMR.UseVisualStyleBackColor = false;
            // 
            // BtnMS
            // 
            BtnMS.BackColor = Color.FromArgb(32, 32, 32);
            BtnMS.BackgroundColor = Color.FromArgb(32, 32, 32);
            BtnMS.BorderColor = Color.PaleVioletRed;
            BtnMS.BorderRadius = 4;
            BtnMS.BorderSize = 0;
            BtnMS.FlatAppearance.BorderSize = 0;
            BtnMS.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            BtnMS.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            BtnMS.FlatStyle = FlatStyle.Flat;
            BtnMS.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMS.ForeColor = Color.White;
            BtnMS.Location = new Point(229, 201);
            BtnMS.Margin = new Padding(0);
            BtnMS.Name = "BtnMS";
            BtnMS.Size = new Size(57, 30);
            BtnMS.TabIndex = 35;
            BtnMS.Text = "MS";
            BtnMS.TextColor = Color.White;
            BtnMS.UseVisualStyleBackColor = false;
            // 
            // BtnM
            // 
            BtnM.BackColor = Color.FromArgb(32, 32, 32);
            BtnM.BackgroundColor = Color.FromArgb(32, 32, 32);
            BtnM.BorderColor = Color.PaleVioletRed;
            BtnM.BorderRadius = 4;
            BtnM.BorderSize = 0;
            BtnM.FlatAppearance.BorderSize = 0;
            BtnM.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            BtnM.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            BtnM.FlatStyle = FlatStyle.Flat;
            BtnM.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnM.ForeColor = Color.Gray;
            BtnM.Location = new Point(286, 201);
            BtnM.Margin = new Padding(0);
            BtnM.Name = "BtnM";
            BtnM.Size = new Size(57, 30);
            BtnM.TabIndex = 34;
            BtnM.Text = "M▼";
            BtnM.TextColor = Color.Gray;
            BtnM.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(347, 535);
            Controls.Add(PainelInferior);
            Controls.Add(BtnMS);
            Controls.Add(BtnM);
            Controls.Add(BtnMR);
            Controls.Add(BtnMmais);
            Controls.Add(BtnMmenos);
            Controls.Add(BtnMC);
            Controls.Add(BtnApagar);
            Controls.Add(BtnDivisao);
            Controls.Add(BtnVezes);
            Controls.Add(BtnMenos);
            Controls.Add(BtnMais);
            Controls.Add(BtnC);
            Controls.Add(BtnCE);
            Controls.Add(BtnPercent);
            Controls.Add(BtnRaizQuadrada);
            Controls.Add(BtnQuadrado);
            Controls.Add(BtnFraccao);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(BtnIgual);
            Controls.Add(BtnVirgula);
            Controls.Add(Btn0);
            Controls.Add(MaisOuMenos);
            Controls.Add(Display1);
            Controls.Add(Display2);
            Controls.Add(PainelHistorico);
            Controls.Add(PainelSuperior);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            PainelSuperior.ResumeLayout(false);
            PainelSuperior.PerformLayout();
            PainelInferior.ResumeLayout(false);
            PainelHistorico.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel PainelSuperior;
        private Panel PainelInferior;
        private Button CloseBtn;
        private Button button2;
        private Button button1;
        private Button icon;
        private Label label1;
        private Panel PainelHistorico;
        private Button menu;
        private TextBox Display2;
        private TextBox Display1;
        private Button historico;
        private Button BtnLimparHistorico;
        private RichTextBox RtBoxDisplay;
        private CustomControls.RJControls.RJButton MaisOuMenos;
        private CustomControls.RJControls.RJButton Btn0;
        private CustomControls.RJControls.RJButton BtnVirgula;
        private CustomControls.RJControls.RJButton BtnIgual;
        private CustomControls.RJControls.RJButton Btn3;
        private CustomControls.RJControls.RJButton Btn2;
        private CustomControls.RJControls.RJButton Btn1;
        private CustomControls.RJControls.RJButton Btn6;
        private CustomControls.RJControls.RJButton Btn5;
        private CustomControls.RJControls.RJButton Btn4;
        private CustomControls.RJControls.RJButton Btn9;
        private CustomControls.RJControls.RJButton Btn8;
        private CustomControls.RJControls.RJButton btn7;
        private CustomControls.RJControls.RJButton BtnRaizQuadrada;
        private CustomControls.RJControls.RJButton BtnQuadrado;
        private CustomControls.RJControls.RJButton BtnFraccao;
        private CustomControls.RJControls.RJButton BtnC;
        private CustomControls.RJControls.RJButton BtnCE;
        private CustomControls.RJControls.RJButton BtnPercent;
        private CustomControls.RJControls.RJButton BtnApagar;
        private CustomControls.RJControls.RJButton BtnDivisao;
        private CustomControls.RJControls.RJButton BtnVezes;
        private CustomControls.RJControls.RJButton BtnMenos;
        private CustomControls.RJControls.RJButton BtnMais;
        private CustomControls.RJControls.RJButton BtnMC;
        private CustomControls.RJControls.RJButton BtnMmenos;
        private CustomControls.RJControls.RJButton BtnMmais;
        private CustomControls.RJControls.RJButton BtnMR;
        private CustomControls.RJControls.RJButton BtnMS;
        private CustomControls.RJControls.RJButton BtnM;
    }
}
