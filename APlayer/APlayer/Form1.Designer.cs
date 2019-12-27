namespace APlayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayList = new System.Windows.Forms.ListBox();
            this.PlayandPause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.addAudio = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.Button();
            this.trackBarAudio = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.previousAudio = new System.Windows.Forms.Button();
            this.nextAudio = new System.Windows.Forms.Button();
            this.DeleteAudio = new System.Windows.Forms.Button();
            this.statusBarPanel1 = new System.Windows.Forms.Label();
            this.statusBarPanel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.Color.White;
            this.PlayList.FormattingEnabled = true;
            this.PlayList.Location = new System.Drawing.Point(12, 178);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(353, 186);
            this.PlayList.TabIndex = 0;
            this.PlayList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PlayandPause
            // 
            this.PlayandPause.BackColor = System.Drawing.Color.White;
            this.PlayandPause.Location = new System.Drawing.Point(12, 27);
            this.PlayandPause.Name = "PlayandPause";
            this.PlayandPause.Size = new System.Drawing.Size(95, 40);
            this.PlayandPause.TabIndex = 1;
            this.PlayandPause.Text = "Play/Pause";
            this.PlayandPause.UseVisualStyleBackColor = false;
            this.PlayandPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.White;
            this.Stop.Location = new System.Drawing.Point(219, 27);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(95, 40);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // addAudio
            // 
            this.addAudio.BackColor = System.Drawing.Color.White;
            this.addAudio.Location = new System.Drawing.Point(371, 60);
            this.addAudio.Name = "addAudio";
            this.addAudio.Size = new System.Drawing.Size(75, 40);
            this.addAudio.TabIndex = 3;
            this.addAudio.Text = "Add Audio";
            this.addAudio.UseVisualStyleBackColor = false;
            this.addAudio.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveList
            // 
            this.SaveList.BackColor = System.Drawing.Color.White;
            this.SaveList.Location = new System.Drawing.Point(371, 243);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(75, 55);
            this.SaveList.TabIndex = 5;
            this.SaveList.Text = "Save PlayList";
            this.SaveList.UseVisualStyleBackColor = false;
            this.SaveList.Click += new System.EventHandler(this.button5_Click);
            // 
            // trackBarAudio
            // 
            this.trackBarAudio.BackColor = System.Drawing.Color.White;
            this.trackBarAudio.Location = new System.Drawing.Point(12, 127);
            this.trackBarAudio.Name = "trackBarAudio";
            this.trackBarAudio.Size = new System.Drawing.Size(302, 45);
            this.trackBarAudio.TabIndex = 9;
            this.trackBarAudio.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.White;
            this.trackBarVolume.Location = new System.Drawing.Point(320, 60);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(45, 117);
            this.trackBarVolume.TabIndex = 8;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // previousAudio
            // 
            this.previousAudio.BackColor = System.Drawing.Color.White;
            this.previousAudio.Location = new System.Drawing.Point(37, 77);
            this.previousAudio.Name = "previousAudio";
            this.previousAudio.Size = new System.Drawing.Size(70, 23);
            this.previousAudio.TabIndex = 6;
            this.previousAudio.Text = "<<";
            this.previousAudio.UseVisualStyleBackColor = false;
            this.previousAudio.Click += new System.EventHandler(this.button7_Click);
            // 
            // nextAudio
            // 
            this.nextAudio.BackColor = System.Drawing.Color.White;
            this.nextAudio.Location = new System.Drawing.Point(219, 77);
            this.nextAudio.Name = "nextAudio";
            this.nextAudio.Size = new System.Drawing.Size(70, 23);
            this.nextAudio.TabIndex = 7;
            this.nextAudio.Text = ">>";
            this.nextAudio.UseVisualStyleBackColor = false;
            this.nextAudio.Click += new System.EventHandler(this.button8_Click);
            // 
            // DeleteAudio
            // 
            this.DeleteAudio.BackColor = System.Drawing.Color.White;
            this.DeleteAudio.Location = new System.Drawing.Point(371, 137);
            this.DeleteAudio.Name = "DeleteAudio";
            this.DeleteAudio.Size = new System.Drawing.Size(75, 40);
            this.DeleteAudio.TabIndex = 4;
            this.DeleteAudio.Text = "Clear PlayList";
            this.DeleteAudio.UseVisualStyleBackColor = false;
            this.DeleteAudio.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = true;
            this.statusBarPanel1.Location = new System.Drawing.Point(12, 108);
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Size = new System.Drawing.Size(0, 13);
            this.statusBarPanel1.TabIndex = 10;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.AutoSize = true;
            this.statusBarPanel2.Location = new System.Drawing.Point(278, 108);
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Size = new System.Drawing.Size(0, 13);
            this.statusBarPanel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::APlayer.Properties.Resources.BGImg;
            this.ClientSize = new System.Drawing.Size(454, 376);
            this.Controls.Add(this.statusBarPanel2);
            this.Controls.Add(this.statusBarPanel1);
            this.Controls.Add(this.DeleteAudio);
            this.Controls.Add(this.nextAudio);
            this.Controls.Add(this.previousAudio);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.trackBarAudio);
            this.Controls.Add(this.SaveList);
            this.Controls.Add(this.addAudio);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.PlayandPause);
            this.Controls.Add(this.PlayList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.Button PlayandPause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button addAudio;
        private System.Windows.Forms.Button SaveList;
        private System.Windows.Forms.TrackBar trackBarAudio;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button previousAudio;
        private System.Windows.Forms.Button nextAudio;
        private System.Windows.Forms.Button DeleteAudio;
        private System.Windows.Forms.Label statusBarPanel1;
        private System.Windows.Forms.Label statusBarPanel2;
    }
}

