namespace KK
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.helloPanel = new System.Windows.Forms.Panel();
            this.kkStartBtn = new System.Windows.Forms.Button();
            this.usrInpB = new System.Windows.Forms.TextBox();
            this.userLblB = new System.Windows.Forms.Label();
            this.usrInpA = new System.Windows.Forms.TextBox();
            this.userLblA = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.turnB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.turnA = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.box01 = new System.Windows.Forms.PictureBox();
            this.box00 = new System.Windows.Forms.PictureBox();
            this.box02 = new System.Windows.Forms.PictureBox();
            this.box12 = new System.Windows.Forms.PictureBox();
            this.box10 = new System.Windows.Forms.PictureBox();
            this.box11 = new System.Windows.Forms.PictureBox();
            this.box20 = new System.Windows.Forms.PictureBox();
            this.box21 = new System.Windows.Forms.PictureBox();
            this.box22 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restartBtn = new System.Windows.Forms.Button();
            this.helloPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // helloPanel
            // 
            this.helloPanel.Controls.Add(this.kkStartBtn);
            this.helloPanel.Controls.Add(this.usrInpB);
            this.helloPanel.Controls.Add(this.userLblB);
            this.helloPanel.Controls.Add(this.usrInpA);
            this.helloPanel.Controls.Add(this.userLblA);
            this.helloPanel.Location = new System.Drawing.Point(12, 12);
            this.helloPanel.Name = "helloPanel";
            this.helloPanel.Size = new System.Drawing.Size(689, 339);
            this.helloPanel.TabIndex = 0;
            // 
            // kkStartBtn
            // 
            this.kkStartBtn.Location = new System.Drawing.Point(456, 87);
            this.kkStartBtn.Name = "kkStartBtn";
            this.kkStartBtn.Size = new System.Drawing.Size(179, 58);
            this.kkStartBtn.TabIndex = 1;
            this.kkStartBtn.Text = "Rozpocznij grę";
            this.kkStartBtn.UseVisualStyleBackColor = true;
            this.kkStartBtn.Click += new System.EventHandler(this.kkStartBtn_Click);
            // 
            // usrInpB
            // 
            this.usrInpB.Location = new System.Drawing.Point(359, 42);
            this.usrInpB.Name = "usrInpB";
            this.usrInpB.Size = new System.Drawing.Size(276, 22);
            this.usrInpB.TabIndex = 3;
            // 
            // userLblB
            // 
            this.userLblB.AutoSize = true;
            this.userLblB.Location = new System.Drawing.Point(356, 22);
            this.userLblB.Name = "userLblB";
            this.userLblB.Size = new System.Drawing.Size(122, 17);
            this.userLblB.TabIndex = 2;
            this.userLblB.Text = "Gracz B (Krzyżyk)";
            // 
            // usrInpA
            // 
            this.usrInpA.Location = new System.Drawing.Point(15, 42);
            this.usrInpA.Name = "usrInpA";
            this.usrInpA.Size = new System.Drawing.Size(276, 22);
            this.usrInpA.TabIndex = 1;
            // 
            // userLblA
            // 
            this.userLblA.AutoSize = true;
            this.userLblA.Location = new System.Drawing.Point(12, 22);
            this.userLblA.Name = "userLblA";
            this.userLblA.Size = new System.Drawing.Size(108, 17);
            this.userLblA.TabIndex = 0;
            this.userLblA.Text = "Gracz A (Kółko)";
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.label1);
            this.gamePanel.Controls.Add(this.panel4);
            this.gamePanel.Controls.Add(this.panel1);
            this.gamePanel.Controls.Add(this.panel3);
            this.gamePanel.Controls.Add(this.turnB);
            this.gamePanel.Controls.Add(this.panel2);
            this.gamePanel.Controls.Add(this.turnA);
            this.gamePanel.Controls.Add(this.tableLayoutPanel1);
            this.gamePanel.Controls.Add(this.pictureBox1);
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(689, 555);
            this.gamePanel.TabIndex = 2;
            this.gamePanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "VS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Location = new System.Drawing.Point(0, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(683, 2);
            this.panel4.TabIndex = 6;
            this.panel4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(456, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 500);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(0, 220);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.panel3.Size = new System.Drawing.Size(683, 2);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            // 
            // turnB
            // 
            this.turnB.AutoSize = true;
            this.turnB.Location = new System.Drawing.Point(540, 22);
            this.turnB.Name = "turnB";
            this.turnB.Size = new System.Drawing.Size(29, 17);
            this.turnB.TabIndex = 1;
            this.turnB.Text = "X ?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(232, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 500);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // turnA
            // 
            this.turnA.AutoSize = true;
            this.turnA.Location = new System.Drawing.Point(77, 22);
            this.turnA.Name = "turnA";
            this.turnA.Size = new System.Drawing.Size(31, 17);
            this.turnA.TabIndex = 0;
            this.turnA.Text = "O ?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.box01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.box00, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.box02, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.box12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.box10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.box11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.box20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.box21, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.box22, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 502);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // box01
            // 
            this.box01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box01.Location = new System.Drawing.Point(231, 3);
            this.box01.Name = "box01";
            this.box01.Size = new System.Drawing.Size(222, 161);
            this.box01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box01.TabIndex = 3;
            this.box01.TabStop = false;
            this.box01.Click += new System.EventHandler(this.box01_Click);
            // 
            // box00
            // 
            this.box00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box00.Location = new System.Drawing.Point(3, 3);
            this.box00.Name = "box00";
            this.box00.Size = new System.Drawing.Size(222, 161);
            this.box00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box00.TabIndex = 0;
            this.box00.TabStop = false;
            this.box00.Click += new System.EventHandler(this.box00_Click);
            // 
            // box02
            // 
            this.box02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box02.Location = new System.Drawing.Point(459, 3);
            this.box02.Name = "box02";
            this.box02.Size = new System.Drawing.Size(223, 161);
            this.box02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box02.TabIndex = 6;
            this.box02.TabStop = false;
            this.box02.Click += new System.EventHandler(this.box02_Click);
            // 
            // box12
            // 
            this.box12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box12.Location = new System.Drawing.Point(459, 170);
            this.box12.Name = "box12";
            this.box12.Size = new System.Drawing.Size(223, 161);
            this.box12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box12.TabIndex = 7;
            this.box12.TabStop = false;
            this.box12.Click += new System.EventHandler(this.box12_Click);
            // 
            // box10
            // 
            this.box10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box10.Location = new System.Drawing.Point(3, 170);
            this.box10.Name = "box10";
            this.box10.Size = new System.Drawing.Size(222, 161);
            this.box10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box10.TabIndex = 1;
            this.box10.TabStop = false;
            this.box10.Click += new System.EventHandler(this.box10_Click);
            // 
            // box11
            // 
            this.box11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box11.Location = new System.Drawing.Point(231, 170);
            this.box11.Name = "box11";
            this.box11.Size = new System.Drawing.Size(222, 161);
            this.box11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box11.TabIndex = 4;
            this.box11.TabStop = false;
            this.box11.Click += new System.EventHandler(this.box11_Click);
            // 
            // box20
            // 
            this.box20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box20.Location = new System.Drawing.Point(3, 337);
            this.box20.Name = "box20";
            this.box20.Size = new System.Drawing.Size(222, 162);
            this.box20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box20.TabIndex = 2;
            this.box20.TabStop = false;
            this.box20.Click += new System.EventHandler(this.box20_Click);
            // 
            // box21
            // 
            this.box21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box21.Location = new System.Drawing.Point(231, 337);
            this.box21.Name = "box21";
            this.box21.Size = new System.Drawing.Size(222, 162);
            this.box21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box21.TabIndex = 5;
            this.box21.TabStop = false;
            this.box21.Click += new System.EventHandler(this.box21_Click);
            // 
            // box22
            // 
            this.box22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box22.Location = new System.Drawing.Point(459, 337);
            this.box22.Name = "box22";
            this.box22.Size = new System.Drawing.Size(223, 162);
            this.box22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box22.TabIndex = 8;
            this.box22.TabStop = false;
            this.box22.Click += new System.EventHandler(this.box22_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 495);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(472, 593);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(223, 51);
            this.restartBtn.TabIndex = 3;
            this.restartBtn.Text = "Od nowa";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(713, 656);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.helloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Kółko i Krzyżyk";
            this.helloPanel.ResumeLayout(false);
            this.helloPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel helloPanel;
        private System.Windows.Forms.TextBox usrInpB;
        private System.Windows.Forms.Label userLblB;
        private System.Windows.Forms.TextBox usrInpA;
        private System.Windows.Forms.Label userLblA;
        private System.Windows.Forms.Button kkStartBtn;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox box00;
        private System.Windows.Forms.PictureBox box10;
        private System.Windows.Forms.PictureBox box20;
        private System.Windows.Forms.Label turnB;
        private System.Windows.Forms.Label turnA;
        private System.Windows.Forms.PictureBox box01;
        private System.Windows.Forms.PictureBox box11;
        private System.Windows.Forms.PictureBox box21;
        private System.Windows.Forms.PictureBox box02;
        private System.Windows.Forms.PictureBox box12;
        private System.Windows.Forms.PictureBox box22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button restartBtn;
    }
}

