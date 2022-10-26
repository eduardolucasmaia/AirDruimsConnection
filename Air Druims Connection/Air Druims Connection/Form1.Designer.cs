namespace Air_Druims_Connection
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portaUsb = new System.Windows.Forms.ComboBox();
            this.botaoLiga = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.caixa = new System.Windows.Forms.ComboBox();
            this.bumbo = new System.Windows.Forms.ComboBox();
            this.pedalChimbal = new System.Windows.Forms.ComboBox();
            this.chimbal = new System.Windows.Forms.ComboBox();
            this.calibrar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // portaUsb
            // 
            this.portaUsb.FormattingEnabled = true;
            this.portaUsb.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.portaUsb.Location = new System.Drawing.Point(12, 12);
            this.portaUsb.Name = "portaUsb";
            this.portaUsb.Size = new System.Drawing.Size(121, 21);
            this.portaUsb.TabIndex = 0;
            // 
            // botaoLiga
            // 
            this.botaoLiga.Location = new System.Drawing.Point(139, 10);
            this.botaoLiga.Name = "botaoLiga";
            this.botaoLiga.Size = new System.Drawing.Size(75, 23);
            this.botaoLiga.TabIndex = 1;
            this.botaoLiga.Text = "Ligar";
            this.botaoLiga.UseVisualStyleBackColor = true;
            this.botaoLiga.Click += new System.EventHandler(this.botaoLiga_Click_1);
            // 
            // caixa
            // 
            this.caixa.FormattingEnabled = true;
            this.caixa.Items.AddRange(new object[] {
            "som1",
            "som2",
            "som3",
            "som4",
            "som5",
            "som6",
            "som7",
            "som8",
            "som9",
            "som10",
            "som11",
            "som12",
            "som13",
            "som14",
            "som15",
            "som16",
            "som17",
            "som18",
            "som19",
            "som20",
            "som21",
            "som22",
            "som23",
            "som24",
            "som25",
            "som26",
            "som27",
            "som28",
            "som29",
            "som30",
            "som31",
            "som32",
            "som33",
            "som34",
            "som35",
            "som36",
            "som37",
            "som38",
            "som39"});
            this.caixa.Location = new System.Drawing.Point(4, 142);
            this.caixa.Name = "caixa";
            this.caixa.Size = new System.Drawing.Size(121, 21);
            this.caixa.TabIndex = 4;
            this.caixa.Text = "som1";
            this.caixa.SelectedIndexChanged += new System.EventHandler(this.caixa_SelectedIndexChanged);
            // 
            // bumbo
            // 
            this.bumbo.FormattingEnabled = true;
            this.bumbo.Items.AddRange(new object[] {
            "som1",
            "som2",
            "som3",
            "som4",
            "som5",
            "som6",
            "som7",
            "som8",
            "som9",
            "som10",
            "som11",
            "som12",
            "som13",
            "som14",
            "som15",
            "som16",
            "som17",
            "som18",
            "som19",
            "som20",
            "som21",
            "som22",
            "som23",
            "som24",
            "som25",
            "som26"});
            this.bumbo.Location = new System.Drawing.Point(38, 461);
            this.bumbo.Name = "bumbo";
            this.bumbo.Size = new System.Drawing.Size(121, 21);
            this.bumbo.TabIndex = 5;
            this.bumbo.Text = "som1";
            this.bumbo.SelectedIndexChanged += new System.EventHandler(this.bumbo_SelectedIndexChanged);
            // 
            // pedalChimbal
            // 
            this.pedalChimbal.FormattingEnabled = true;
            this.pedalChimbal.Items.AddRange(new object[] {
            "som1",
            "som2",
            "som3",
            "som4",
            "som5",
            "som6",
            "som7",
            "som8",
            "som9",
            "som10",
            "som11",
            "som12",
            "som13",
            "som14",
            "som15",
            "som16",
            "som17",
            "som18",
            "som19",
            "som20",
            "som21",
            "som22",
            "som23",
            "som24",
            "som25"});
            this.pedalChimbal.Location = new System.Drawing.Point(619, 535);
            this.pedalChimbal.Name = "pedalChimbal";
            this.pedalChimbal.Size = new System.Drawing.Size(121, 21);
            this.pedalChimbal.TabIndex = 6;
            this.pedalChimbal.SelectedIndexChanged += new System.EventHandler(this.pedalChimbal_SelectedIndexChanged);
            // 
            // chimbal
            // 
            this.chimbal.FormattingEnabled = true;
            this.chimbal.Items.AddRange(new object[] {
            "som1",
            "som2",
            "som3",
            "som4",
            "som5",
            "som6",
            "som7",
            "som8",
            "som9",
            "som10",
            "som11",
            "som12",
            "som13",
            "som14",
            "som15",
            "som16",
            "som17",
            "som18",
            "som19",
            "som20",
            "som21",
            "som22",
            "som23",
            "som24",
            "som25"});
            this.chimbal.Location = new System.Drawing.Point(690, 170);
            this.chimbal.Name = "chimbal";
            this.chimbal.Size = new System.Drawing.Size(121, 21);
            this.chimbal.TabIndex = 7;
            this.chimbal.Text = "som1";
            this.chimbal.SelectedIndexChanged += new System.EventHandler(this.chimbal_SelectedIndexChanged);
            // 
            // calibrar
            // 
            this.calibrar.Location = new System.Drawing.Point(696, 48);
            this.calibrar.Name = "calibrar";
            this.calibrar.Size = new System.Drawing.Size(114, 23);
            this.calibrar.TabIndex = 10;
            this.calibrar.Text = "Calibrar Baquetas";
            this.calibrar.UseVisualStyleBackColor = true;
            this.calibrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Air_Druims_Connection.Properties.Resources.Baquetas;
            this.pictureBox4.Location = new System.Drawing.Point(591, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Air_Druims_Connection.Properties.Resources.desconectado;
            this.pictureBox3.Location = new System.Drawing.Point(220, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Air_Druims_Connection.Properties.Resources.conectado;
            this.pictureBox2.Location = new System.Drawing.Point(220, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air_Druims_Connection.Properties.Resources.Bateria___Riscada;
            this.pictureBox1.Location = new System.Drawing.Point(55, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 593);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.calibrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chimbal);
            this.Controls.Add(this.pedalChimbal);
            this.Controls.Add(this.bumbo);
            this.Controls.Add(this.caixa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaoLiga);
            this.Controls.Add(this.portaUsb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Drums Connection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portaUsb;
        private System.Windows.Forms.Button botaoLiga;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox caixa;
        private System.Windows.Forms.ComboBox bumbo;
        private System.Windows.Forms.ComboBox pedalChimbal;
        private System.Windows.Forms.ComboBox chimbal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button calibrar;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

