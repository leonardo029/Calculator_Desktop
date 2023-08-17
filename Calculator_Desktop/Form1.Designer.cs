namespace Calculator_Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.padrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.científicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtShowType = new System.Windows.Forms.ToolStripTextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.BtnOct = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnExponential = new System.Windows.Forms.Button();
            this.btnlx = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnx3 = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnx2 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.txtHistoric = new System.Windows.Forms.TextBox();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(9, 63);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(501, 48);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Ebrima", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnDivide.ForeColor = System.Drawing.Color.Black;
            this.btnDivide.Location = new System.Drawing.Point(222, 172);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(70, 55);
            this.btnDivide.TabIndex = 23;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.NumberOp);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Ebrima", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnMultiplication.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplication.Location = new System.Drawing.Point(222, 227);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(70, 55);
            this.btnMultiplication.TabIndex = 27;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.NumberOp);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(151, 227);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 55);
            this.btn9.TabIndex = 26;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(80, 227);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 55);
            this.btn8.TabIndex = 25;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(9, 227);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 55);
            this.btn7.TabIndex = 24;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Ebrima", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnEqual.ForeColor = System.Drawing.Color.Black;
            this.btnEqual.Location = new System.Drawing.Point(222, 392);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(70, 54);
            this.btnEqual.TabIndex = 31;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Ebrima", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnDecimal.ForeColor = System.Drawing.Color.Black;
            this.btnDecimal.Location = new System.Drawing.Point(151, 392);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(70, 55);
            this.btnDecimal.TabIndex = 30;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(80, 392);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 55);
            this.btn0.TabIndex = 29;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnModule
            // 
            this.btnModule.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModule.ForeColor = System.Drawing.Color.Black;
            this.btnModule.Location = new System.Drawing.Point(9, 392);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(70, 55);
            this.btnModule.TabIndex = 28;
            this.btnModule.Text = "+/-";
            this.btnModule.UseVisualStyleBackColor = false;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Font = new System.Drawing.Font("Ebrima", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnSubtraction.ForeColor = System.Drawing.Color.Black;
            this.btnSubtraction.Location = new System.Drawing.Point(222, 282);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(70, 55);
            this.btnSubtraction.TabIndex = 35;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            this.btnSubtraction.Click += new System.EventHandler(this.NumberOp);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(151, 282);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 55);
            this.btn6.TabIndex = 34;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(80, 282);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 55);
            this.btn5.TabIndex = 33;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(9, 282);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 55);
            this.btn4.TabIndex = 32;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Ebrima", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnSum.ForeColor = System.Drawing.Color.Black;
            this.btnSum.Location = new System.Drawing.Point(222, 337);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(70, 55);
            this.btnSum.TabIndex = 39;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.NumberOp);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(151, 337);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 55);
            this.btn3.TabIndex = 38;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(80, 337);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 55);
            this.btn2.TabIndex = 37;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(9, 337);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 55);
            this.btn1.TabIndex = 36;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBackspace.ForeColor = System.Drawing.Color.Black;
            this.btnBackspace.Location = new System.Drawing.Point(222, 117);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(70, 55);
            this.btnBackspace.TabIndex = 43;
            this.btnBackspace.Text = "Õ";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.Location = new System.Drawing.Point(151, 117);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(70, 55);
            this.btnC.TabIndex = 42;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.Black;
            this.btnCE.Location = new System.Drawing.Point(80, 117);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(70, 55);
            this.btnCE.TabIndex = 41;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.txtShowType});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.padrãoToolStripMenuItem,
            this.científicaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 20);
            this.toolStripMenuItem1.Text = "☰";
            // 
            // padrãoToolStripMenuItem
            // 
            this.padrãoToolStripMenuItem.Name = "padrãoToolStripMenuItem";
            this.padrãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.padrãoToolStripMenuItem.Text = "Padrão";
            this.padrãoToolStripMenuItem.Click += new System.EventHandler(this.padrãoToolStripMenuItem_Click);
            // 
            // científicaToolStripMenuItem
            // 
            this.científicaToolStripMenuItem.Name = "científicaToolStripMenuItem";
            this.científicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.científicaToolStripMenuItem.Text = "Científica";
            this.científicaToolStripMenuItem.Click += new System.EventHandler(this.científicaToolStripMenuItem_Click);
            // 
            // txtShowType
            // 
            this.txtShowType.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtShowType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShowType.Enabled = false;
            this.txtShowType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtShowType.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.txtShowType.Name = "txtShowType";
            this.txtShowType.ReadOnly = true;
            this.txtShowType.Size = new System.Drawing.Size(100, 20);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Location = new System.Drawing.Point(440, 172);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(70, 55);
            this.btnLog.TabIndex = 66;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.ForeColor = System.Drawing.Color.Black;
            this.btnPi.Location = new System.Drawing.Point(299, 117);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(70, 55);
            this.btnPi.TabIndex = 65;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // BtnOct
            // 
            this.BtnOct.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOct.ForeColor = System.Drawing.Color.Black;
            this.BtnOct.Location = new System.Drawing.Point(440, 392);
            this.BtnOct.Name = "BtnOct";
            this.BtnOct.Size = new System.Drawing.Size(70, 55);
            this.BtnOct.TabIndex = 63;
            this.BtnOct.Text = "oct";
            this.BtnOct.UseVisualStyleBackColor = false;
            this.BtnOct.Click += new System.EventHandler(this.BtnOct_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.Color.Black;
            this.btnMod.Location = new System.Drawing.Point(370, 392);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(70, 55);
            this.btnMod.TabIndex = 62;
            this.btnMod.Text = "mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.NumberOp);
            // 
            // btnExponential
            // 
            this.btnExponential.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponential.ForeColor = System.Drawing.Color.Black;
            this.btnExponential.Location = new System.Drawing.Point(299, 392);
            this.btnExponential.Name = "btnExponential";
            this.btnExponential.Size = new System.Drawing.Size(70, 55);
            this.btnExponential.TabIndex = 61;
            this.btnExponential.Text = "exp";
            this.btnExponential.UseVisualStyleBackColor = false;
            this.btnExponential.Click += new System.EventHandler(this.NumberOp);
            // 
            // btnlx
            // 
            this.btnlx.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnlx.ForeColor = System.Drawing.Color.Black;
            this.btnlx.Location = new System.Drawing.Point(370, 172);
            this.btnlx.Name = "btnlx";
            this.btnlx.Size = new System.Drawing.Size(70, 55);
            this.btnlx.TabIndex = 60;
            this.btnlx.Text = "ln";
            this.btnlx.UseVisualStyleBackColor = false;
            this.btnlx.Click += new System.EventHandler(this.btnlx_Click);
            // 
            // btnHex
            // 
            this.btnHex.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.ForeColor = System.Drawing.Color.Black;
            this.btnHex.Location = new System.Drawing.Point(440, 337);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(70, 55);
            this.btnHex.TabIndex = 59;
            this.btnHex.Text = "hex";
            this.btnHex.UseVisualStyleBackColor = false;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.ForeColor = System.Drawing.Color.Black;
            this.btnTan.Location = new System.Drawing.Point(370, 337);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(70, 55);
            this.btnTan.TabIndex = 58;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanh.ForeColor = System.Drawing.Color.Black;
            this.btnTanh.Location = new System.Drawing.Point(299, 337);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(70, 55);
            this.btnTanh.TabIndex = 57;
            this.btnTanh.Text = "tanh";
            this.btnTanh.UseVisualStyleBackColor = false;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnx3
            // 
            this.btnx3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnx3.ForeColor = System.Drawing.Color.Black;
            this.btnx3.Location = new System.Drawing.Point(370, 117);
            this.btnx3.Name = "btnx3";
            this.btnx3.Size = new System.Drawing.Size(70, 55);
            this.btnx3.TabIndex = 52;
            this.btnx3.Text = "x³";
            this.btnx3.UseVisualStyleBackColor = false;
            this.btnx3.Click += new System.EventHandler(this.btnx3_Click);
            // 
            // btnBin
            // 
            this.btnBin.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBin.ForeColor = System.Drawing.Color.Black;
            this.btnBin.Location = new System.Drawing.Point(440, 282);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(70, 55);
            this.btnBin.TabIndex = 51;
            this.btnBin.Text = "bin";
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.Color.Black;
            this.btnCos.Location = new System.Drawing.Point(370, 282);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(70, 55);
            this.btnCos.TabIndex = 50;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosh.ForeColor = System.Drawing.Color.Black;
            this.btnCosh.Location = new System.Drawing.Point(299, 282);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(70, 55);
            this.btnCosh.TabIndex = 49;
            this.btnCosh.Text = "cosh";
            this.btnCosh.UseVisualStyleBackColor = false;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.ForeColor = System.Drawing.Color.Black;
            this.btnDec.Location = new System.Drawing.Point(440, 227);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(70, 55);
            this.btnDec.TabIndex = 47;
            this.btnDec.Text = "dec";
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.ForeColor = System.Drawing.Color.Black;
            this.btnSin.Location = new System.Drawing.Point(370, 227);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(70, 55);
            this.btnSin.TabIndex = 46;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinh.ForeColor = System.Drawing.Color.Black;
            this.btnSinh.Location = new System.Drawing.Point(299, 227);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(70, 55);
            this.btnSinh.TabIndex = 45;
            this.btnSinh.Text = "sinh";
            this.btnSinh.UseVisualStyleBackColor = false;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.Color.Black;
            this.btnPercent.Location = new System.Drawing.Point(9, 117);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(70, 55);
            this.btnPercent.TabIndex = 40;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btn1x
            // 
            this.btn1x.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1x.ForeColor = System.Drawing.Color.Black;
            this.btn1x.Location = new System.Drawing.Point(151, 172);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(70, 55);
            this.btn1x.TabIndex = 1;
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = false;
            this.btn1x.Click += new System.EventHandler(this.btn1x_Click);
            // 
            // btnx2
            // 
            this.btnx2.BackColor = System.Drawing.SystemColors.Control;
            this.btnx2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx2.ForeColor = System.Drawing.Color.Black;
            this.btnx2.Location = new System.Drawing.Point(9, 172);
            this.btnx2.Name = "btnx2";
            this.btnx2.Size = new System.Drawing.Size(70, 55);
            this.btnx2.TabIndex = 21;
            this.btnx2.Text = "x²";
            this.btnx2.UseVisualStyleBackColor = false;
            this.btnx2.Click += new System.EventHandler(this.btnx2_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.Black;
            this.btnSqrt.Location = new System.Drawing.Point(80, 172);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(70, 55);
            this.btnSqrt.TabIndex = 22;
            this.btnSqrt.Text = "²√x";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.Black;
            this.btnE.Location = new System.Drawing.Point(299, 172);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(70, 55);
            this.btnE.TabIndex = 67;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // txtHistoric
            // 
            this.txtHistoric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistoric.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtHistoric.Enabled = false;
            this.txtHistoric.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoric.ForeColor = System.Drawing.Color.Black;
            this.txtHistoric.Location = new System.Drawing.Point(9, 30);
            this.txtHistoric.Multiline = true;
            this.txtHistoric.Name = "txtHistoric";
            this.txtHistoric.ReadOnly = true;
            this.txtHistoric.Size = new System.Drawing.Size(501, 34);
            this.txtHistoric.TabIndex = 0;
            this.txtHistoric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.ForeColor = System.Drawing.Color.Black;
            this.btnFactorial.Location = new System.Drawing.Point(440, 117);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(70, 55);
            this.btnFactorial.TabIndex = 68;
            this.btnFactorial.Text = "x!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(521, 456);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.txtHistoric);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.BtnOct);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnExponential);
            this.Controls.Add(this.btnlx);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btnx3);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnModule);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnx2);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem padrãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem científicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtShowType;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button BtnOct;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnExponential;
        private System.Windows.Forms.Button btnlx;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnx3;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button btnx2;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.TextBox txtHistoric;
        private System.Windows.Forms.Button btnFactorial;
    }
}

