namespace NDP_Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.atikPb = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metalicButton = new System.Windows.Forms.Button();
            this.metalEmptyButton = new System.Windows.Forms.Button();
            this.metalListBox = new System.Windows.Forms.ListBox();
            this.metalPb = new System.Windows.Forms.ProgressBar();
            this.glassButton = new System.Windows.Forms.Button();
            this.camEmptyButton = new System.Windows.Forms.Button();
            this.camListBox = new System.Windows.Forms.ListBox();
            this.camPb = new System.Windows.Forms.ProgressBar();
            this.organicButton = new System.Windows.Forms.Button();
            this.organicEmptyButton = new System.Windows.Forms.Button();
            this.organicListBox = new System.Windows.Forms.ListBox();
            this.organicAtikPb = new System.Windows.Forms.ProgressBar();
            this.paperButton = new System.Windows.Forms.Button();
            this.kagitEmptyButton = new System.Windows.Forms.Button();
            this.kagitListBox = new System.Windows.Forms.ListBox();
            this.kagitPb = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sureTextBox = new System.Windows.Forms.TextBox();
            this.puanTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.atikPb)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(80, 0, 72, 0);
            this.label1.Size = new System.Drawing.Size(311, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATIK KUTULARI";
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.Green;
            this.newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newGame.Location = new System.Drawing.Point(13, 42);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(193, 50);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "YENİ OYUN";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // atikPb
            // 
            this.atikPb.BackColor = System.Drawing.Color.White;
            this.atikPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.atikPb.Location = new System.Drawing.Point(13, 14);
            this.atikPb.Name = "atikPb";
            this.atikPb.Size = new System.Drawing.Size(200, 200);
            this.atikPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.atikPb.TabIndex = 1;
            this.atikPb.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.puanTextBox);
            this.panel1.Controls.Add(this.sureTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.newGame);
            this.panel1.Location = new System.Drawing.Point(12, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 404);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.atikPb);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 230);
            this.panel2.TabIndex = 9;
            // 
            // metalicButton
            // 
            this.metalicButton.Location = new System.Drawing.Point(6, 13);
            this.metalicButton.Name = "metalicButton";
            this.metalicButton.Size = new System.Drawing.Size(140, 23);
            this.metalicButton.TabIndex = 0;
            this.metalicButton.Text = "METAL";
            this.metalicButton.UseVisualStyleBackColor = true;
            this.metalicButton.Click += new System.EventHandler(this.metalicButton_Click);
            // 
            // metalEmptyButton
            // 
            this.metalEmptyButton.Location = new System.Drawing.Point(6, 269);
            this.metalEmptyButton.Name = "metalEmptyButton";
            this.metalEmptyButton.Size = new System.Drawing.Size(140, 23);
            this.metalEmptyButton.TabIndex = 1;
            this.metalEmptyButton.Text = "BOŞALT";
            this.metalEmptyButton.UseVisualStyleBackColor = true;
            this.metalEmptyButton.Click += new System.EventHandler(this.metalEmptyButton_Click);
            // 
            // metalListBox
            // 
            this.metalListBox.FormattingEnabled = true;
            this.metalListBox.Location = new System.Drawing.Point(6, 42);
            this.metalListBox.Name = "metalListBox";
            this.metalListBox.Size = new System.Drawing.Size(140, 186);
            this.metalListBox.TabIndex = 2;
            this.metalListBox.SelectedIndexChanged += new System.EventHandler(this.metalListBox_SelectedIndexChanged);
            // 
            // metalPb
            // 
            this.metalPb.Location = new System.Drawing.Point(6, 241);
            this.metalPb.Name = "metalPb";
            this.metalPb.Size = new System.Drawing.Size(140, 23);
            this.metalPb.TabIndex = 5;
            // 
            // glassButton
            // 
            this.glassButton.Location = new System.Drawing.Point(7, 13);
            this.glassButton.Name = "glassButton";
            this.glassButton.Size = new System.Drawing.Size(140, 23);
            this.glassButton.TabIndex = 0;
            this.glassButton.Text = "CAM";
            this.glassButton.UseVisualStyleBackColor = true;
            this.glassButton.Click += new System.EventHandler(this.glassButton_Click);
            // 
            // camEmptyButton
            // 
            this.camEmptyButton.Location = new System.Drawing.Point(7, 269);
            this.camEmptyButton.Name = "camEmptyButton";
            this.camEmptyButton.Size = new System.Drawing.Size(140, 23);
            this.camEmptyButton.TabIndex = 1;
            this.camEmptyButton.Text = "BOŞALT";
            this.camEmptyButton.UseVisualStyleBackColor = true;
            this.camEmptyButton.Click += new System.EventHandler(this.camEmptyButton_Click);
            // 
            // camListBox
            // 
            this.camListBox.FormattingEnabled = true;
            this.camListBox.Location = new System.Drawing.Point(7, 42);
            this.camListBox.Name = "camListBox";
            this.camListBox.Size = new System.Drawing.Size(140, 186);
            this.camListBox.TabIndex = 2;
            // 
            // camPb
            // 
            this.camPb.Location = new System.Drawing.Point(7, 241);
            this.camPb.Name = "camPb";
            this.camPb.Size = new System.Drawing.Size(140, 23);
            this.camPb.TabIndex = 4;
            // 
            // organicButton
            // 
            this.organicButton.Location = new System.Drawing.Point(7, 9);
            this.organicButton.Name = "organicButton";
            this.organicButton.Size = new System.Drawing.Size(140, 23);
            this.organicButton.TabIndex = 0;
            this.organicButton.Text = "ORGANİK ATIK";
            this.organicButton.UseVisualStyleBackColor = true;
            this.organicButton.Click += new System.EventHandler(this.organicButton_Click);
            // 
            // organicEmptyButton
            // 
            this.organicEmptyButton.Location = new System.Drawing.Point(7, 271);
            this.organicEmptyButton.Name = "organicEmptyButton";
            this.organicEmptyButton.Size = new System.Drawing.Size(140, 23);
            this.organicEmptyButton.TabIndex = 1;
            this.organicEmptyButton.Text = "BOŞALT";
            this.organicEmptyButton.UseVisualStyleBackColor = true;
            this.organicEmptyButton.Click += new System.EventHandler(this.organicEmptyButton_Click);
            // 
            // organicListBox
            // 
            this.organicListBox.FormattingEnabled = true;
            this.organicListBox.Location = new System.Drawing.Point(7, 38);
            this.organicListBox.Name = "organicListBox";
            this.organicListBox.Size = new System.Drawing.Size(140, 186);
            this.organicListBox.TabIndex = 2;
            // 
            // organicAtikPb
            // 
            this.organicAtikPb.Location = new System.Drawing.Point(7, 244);
            this.organicAtikPb.Name = "organicAtikPb";
            this.organicAtikPb.Size = new System.Drawing.Size(140, 23);
            this.organicAtikPb.TabIndex = 3;
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(6, 9);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(140, 23);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "KAĞIT";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // kagitEmptyButton
            // 
            this.kagitEmptyButton.Location = new System.Drawing.Point(6, 271);
            this.kagitEmptyButton.Name = "kagitEmptyButton";
            this.kagitEmptyButton.Size = new System.Drawing.Size(140, 23);
            this.kagitEmptyButton.TabIndex = 2;
            this.kagitEmptyButton.Text = "BOŞALT";
            this.kagitEmptyButton.UseVisualStyleBackColor = true;
            this.kagitEmptyButton.Click += new System.EventHandler(this.kagitEmptyButton_Click);
            // 
            // kagitListBox
            // 
            this.kagitListBox.FormattingEnabled = true;
            this.kagitListBox.Location = new System.Drawing.Point(6, 38);
            this.kagitListBox.Name = "kagitListBox";
            this.kagitListBox.Size = new System.Drawing.Size(140, 186);
            this.kagitListBox.TabIndex = 3;
            // 
            // kagitPb
            // 
            this.kagitPb.Location = new System.Drawing.Point(6, 244);
            this.kagitPb.Name = "kagitPb";
            this.kagitPb.Size = new System.Drawing.Size(140, 23);
            this.kagitPb.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.paperButton);
            this.panel3.Controls.Add(this.kagitListBox);
            this.panel3.Controls.Add(this.kagitPb);
            this.panel3.Controls.Add(this.kagitEmptyButton);
            this.panel3.Location = new System.Drawing.Point(418, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 300);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Controls.Add(this.metalicButton);
            this.panel4.Controls.Add(this.metalListBox);
            this.panel4.Controls.Add(this.metalPb);
            this.panel4.Controls.Add(this.metalEmptyButton);
            this.panel4.Location = new System.Drawing.Point(418, 362);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 300);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Controls.Add(this.glassButton);
            this.panel5.Controls.Add(this.camEmptyButton);
            this.panel5.Controls.Add(this.camListBox);
            this.panel5.Controls.Add(this.camPb);
            this.panel5.Location = new System.Drawing.Point(260, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 300);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel6.Controls.Add(this.organicButton);
            this.panel6.Controls.Add(this.organicEmptyButton);
            this.panel6.Controls.Add(this.organicListBox);
            this.panel6.Controls.Add(this.organicAtikPb);
            this.panel6.Location = new System.Drawing.Point(260, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 300);
            this.panel6.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(65, 0, 65, 0);
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "SÜRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(65, 0, 65, 0);
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "PUAN";
            // 
            // sureTextBox
            // 
            this.sureTextBox.BackColor = System.Drawing.Color.Turquoise;
            this.sureTextBox.Enabled = false;
            this.sureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.sureTextBox.Location = new System.Drawing.Point(12, 140);
            this.sureTextBox.Name = "sureTextBox";
            this.sureTextBox.ReadOnly = true;
            this.sureTextBox.Size = new System.Drawing.Size(195, 45);
            this.sureTextBox.TabIndex = 4;
            this.sureTextBox.Text = "60";
            this.sureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // puanTextBox
            // 
            this.puanTextBox.BackColor = System.Drawing.Color.Turquoise;
            this.puanTextBox.Enabled = false;
            this.puanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.puanTextBox.Location = new System.Drawing.Point(11, 273);
            this.puanTextBox.Name = "puanTextBox";
            this.puanTextBox.ReadOnly = true;
            this.puanTextBox.Size = new System.Drawing.Size(195, 45);
            this.puanTextBox.TabIndex = 5;
            this.puanTextBox.Text = "0";
            this.puanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(11, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(584, 671);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atikPb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.PictureBox atikPb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox sureTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button metalicButton;
        private System.Windows.Forms.Button metalEmptyButton;
        private System.Windows.Forms.ListBox metalListBox;
        private System.Windows.Forms.ProgressBar metalPb;
        private System.Windows.Forms.Button glassButton;
        private System.Windows.Forms.Button camEmptyButton;
        private System.Windows.Forms.ListBox camListBox;
        private System.Windows.Forms.ProgressBar camPb;
        private System.Windows.Forms.Button organicButton;
        private System.Windows.Forms.Button organicEmptyButton;
        private System.Windows.Forms.ListBox organicListBox;
        private System.Windows.Forms.ProgressBar organicAtikPb;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button kagitEmptyButton;
        private System.Windows.Forms.ListBox kagitListBox;
        private System.Windows.Forms.ProgressBar kagitPb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox puanTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}

