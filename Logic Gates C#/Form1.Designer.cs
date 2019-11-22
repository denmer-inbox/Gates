namespace Logic_Gates
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butSQDOWN1 = new System.Windows.Forms.Button();
            this.butSQDOWN0 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timDown = new System.Windows.Forms.Label();
            this.timUP = new System.Windows.Forms.Label();
            this.timerDown = new System.Windows.Forms.Timer(this.components);
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.info = new System.Windows.Forms.RichTextBox();
            this.butSQUP1 = new System.Windows.Forms.Button();
            this.butSQUP0 = new System.Windows.Forms.Button();
            this.IUP1 = new System.Windows.Forms.Label();
            this.IUP0 = new System.Windows.Forms.Label();
            this.IDOWN1 = new System.Windows.Forms.Label();
            this.iDOWN0 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mode = new System.Windows.Forms.Label();
            this.DayNight = new System.Windows.Forms.Label();
            this.butDownUP = new System.Windows.Forms.Button();
            this.butDownDOWN = new System.Windows.Forms.Button();
            this.carImage = new System.Windows.Forms.PictureBox();
            this.toggleButton = new System.Windows.Forms.PictureBox();
            this.butSense = new System.Windows.Forms.Button();
            this.TLUP = new System.Windows.Forms.PictureBox();
            this.openDOWN = new System.Windows.Forms.PictureBox();
            this.butLoop1 = new System.Windows.Forms.Button();
            this.butLoop3 = new System.Windows.Forms.Button();
            this.butLoop2 = new System.Windows.Forms.Button();
            this.TLDOWN = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openUP = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openDOWN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLDOWN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // butSQDOWN1
            // 
            this.butSQDOWN1.Location = new System.Drawing.Point(783, 41);
            this.butSQDOWN1.Name = "butSQDOWN1";
            this.butSQDOWN1.Size = new System.Drawing.Size(75, 23);
            this.butSQDOWN1.TabIndex = 0;
            this.butSQDOWN1.Text = "SQDOWN1";
            this.butSQDOWN1.UseVisualStyleBackColor = true;
            this.butSQDOWN1.Click += new System.EventHandler(this.b_sqdown1);
            // 
            // butSQDOWN0
            // 
            this.butSQDOWN0.Location = new System.Drawing.Point(783, 206);
            this.butSQDOWN0.Name = "butSQDOWN0";
            this.butSQDOWN0.Size = new System.Drawing.Size(75, 23);
            this.butSQDOWN0.TabIndex = 0;
            this.butSQDOWN0.Text = "SQDOWN0";
            this.butSQDOWN0.UseVisualStyleBackColor = true;
            this.butSQDOWN0.Click += new System.EventHandler(this.b_sqdown0);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Start);
            // 
            // timDown
            // 
            this.timDown.AutoSize = true;
            this.timDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timDown.Location = new System.Drawing.Point(228, 9);
            this.timDown.Name = "timDown";
            this.timDown.Size = new System.Drawing.Size(19, 20);
            this.timDown.TabIndex = 4;
            this.timDown.Text = "0";
            this.timDown.Click += new System.EventHandler(this.TimDown_Click);
            // 
            // timUP
            // 
            this.timUP.AutoSize = true;
            this.timUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timUP.Location = new System.Drawing.Point(745, 12);
            this.timUP.Name = "timUP";
            this.timUP.Size = new System.Drawing.Size(19, 20);
            this.timUP.TabIndex = 4;
            this.timUP.Text = "0";
            this.timUP.Click += new System.EventHandler(this.TimUP_Click);
            // 
            // timerDown
            // 
            this.timerDown.Interval = 1000;
            this.timerDown.Tick += new System.EventHandler(this.timDOO);
            // 
            // timerUp
            // 
            this.timerUp.Interval = 1000;
            this.timerUp.Tick += new System.EventHandler(this.timUPP);
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(318, 311);
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(409, 127);
            this.info.TabIndex = 5;
            this.info.Text = "";
            this.info.TextChanged += new System.EventHandler(this.Info_TextChanged);
            // 
            // butSQUP1
            // 
            this.butSQUP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSQUP1.Location = new System.Drawing.Point(135, 41);
            this.butSQUP1.Name = "butSQUP1";
            this.butSQUP1.Size = new System.Drawing.Size(75, 23);
            this.butSQUP1.TabIndex = 0;
            this.butSQUP1.Text = "SQUP1";
            this.butSQUP1.UseVisualStyleBackColor = true;
            this.butSQUP1.Click += new System.EventHandler(this.b_squp1);
            // 
            // butSQUP0
            // 
            this.butSQUP0.Location = new System.Drawing.Point(135, 206);
            this.butSQUP0.Name = "butSQUP0";
            this.butSQUP0.Size = new System.Drawing.Size(75, 23);
            this.butSQUP0.TabIndex = 0;
            this.butSQUP0.Text = "SQUP0";
            this.butSQUP0.UseVisualStyleBackColor = true;
            this.butSQUP0.Click += new System.EventHandler(this.b_squp0);
            // 
            // IUP1
            // 
            this.IUP1.AutoSize = true;
            this.IUP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IUP1.Location = new System.Drawing.Point(150, 25);
            this.IUP1.Name = "IUP1";
            this.IUP1.Size = new System.Drawing.Size(0, 15);
            this.IUP1.TabIndex = 6;
            this.IUP1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // IUP0
            // 
            this.IUP0.AutoSize = true;
            this.IUP0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IUP0.Location = new System.Drawing.Point(141, 232);
            this.IUP0.Name = "IUP0";
            this.IUP0.Size = new System.Drawing.Size(0, 15);
            this.IUP0.TabIndex = 7;
            // 
            // IDOWN1
            // 
            this.IDOWN1.AutoSize = true;
            this.IDOWN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDOWN1.Location = new System.Drawing.Point(806, 25);
            this.IDOWN1.Name = "IDOWN1";
            this.IDOWN1.Size = new System.Drawing.Size(0, 15);
            this.IDOWN1.TabIndex = 8;
            // 
            // iDOWN0
            // 
            this.iDOWN0.AutoSize = true;
            this.iDOWN0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDOWN0.Location = new System.Drawing.Point(806, 232);
            this.iDOWN0.Name = "iDOWN0";
            this.iDOWN0.Size = new System.Drawing.Size(0, 15);
            this.iDOWN0.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(457, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 66);
            this.button9.TabIndex = 10;
            this.button9.Text = "Сбросить";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.restart);
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.Location = new System.Drawing.Point(94, 373);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(0, 13);
            this.mode.TabIndex = 16;
            // 
            // DayNight
            // 
            this.DayNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayNight.Location = new System.Drawing.Point(212, 362);
            this.DayNight.Name = "DayNight";
            this.DayNight.Size = new System.Drawing.Size(75, 20);
            this.DayNight.TabIndex = 17;
            this.DayNight.Text = "Режим";
            this.DayNight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butDownUP
            // 
            this.butDownUP.Location = new System.Drawing.Point(798, 311);
            this.butDownUP.Name = "butDownUP";
            this.butDownUP.Size = new System.Drawing.Size(75, 23);
            this.butDownUP.TabIndex = 18;
            this.butDownUP.Text = "ВВЕРХ";
            this.butDownUP.UseVisualStyleBackColor = true;
            this.butDownUP.Click += new System.EventHandler(this.ButDownUP_Click);
            // 
            // butDownDOWN
            // 
            this.butDownDOWN.Location = new System.Drawing.Point(798, 349);
            this.butDownDOWN.Name = "butDownDOWN";
            this.butDownDOWN.Size = new System.Drawing.Size(75, 23);
            this.butDownDOWN.TabIndex = 19;
            this.butDownDOWN.Text = "ВНИЗ";
            this.butDownDOWN.UseVisualStyleBackColor = true;
            this.butDownDOWN.Click += new System.EventHandler(this.ButDownDOWN_Click);
            // 
            // carImage
            // 
            this.carImage.BackColor = System.Drawing.Color.Transparent;
            this.carImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.carImage.Image = global::Logic_Gates.Properties.Resources.carUp;
            this.carImage.Location = new System.Drawing.Point(978, 152);
            this.carImage.Name = "carImage";
            this.carImage.Size = new System.Drawing.Size(224, 77);
            this.carImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carImage.TabIndex = 20;
            this.carImage.TabStop = false;
            // 
            // toggleButton
            // 
            this.toggleButton.Image = global::Logic_Gates.Properties.Resources.toggleOFF;
            this.toggleButton.Location = new System.Drawing.Point(212, 385);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(75, 38);
            this.toggleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toggleButton.TabIndex = 15;
            this.toggleButton.TabStop = false;
            this.toggleButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toggleCheck);
            // 
            // butSense
            // 
            this.butSense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSense.BackgroundImage")));
            this.butSense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butSense.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butSense.FlatAppearance.BorderSize = 0;
            this.butSense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSense.Location = new System.Drawing.Point(24, 246);
            this.butSense.Name = "butSense";
            this.butSense.Size = new System.Drawing.Size(70, 75);
            this.butSense.TabIndex = 3;
            this.butSense.UseVisualStyleBackColor = true;
            this.butSense.Click += new System.EventHandler(this.b_sense);
            // 
            // TLUP
            // 
            this.TLUP.BackColor = System.Drawing.SystemColors.Info;
            this.TLUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TLUP.Enabled = false;
            this.TLUP.Image = ((System.Drawing.Image)(resources.GetObject("TLUP.Image")));
            this.TLUP.Location = new System.Drawing.Point(872, 12);
            this.TLUP.Name = "TLUP";
            this.TLUP.Size = new System.Drawing.Size(42, 70);
            this.TLUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TLUP.TabIndex = 2;
            this.TLUP.TabStop = false;
            this.TLUP.Visible = false;
            // 
            // openDOWN
            // 
            this.openDOWN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.openDOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openDOWN.Enabled = false;
            this.openDOWN.Image = global::Logic_Gates.Properties.Resources.open;
            this.openDOWN.Location = new System.Drawing.Point(698, 41);
            this.openDOWN.Name = "openDOWN";
            this.openDOWN.Size = new System.Drawing.Size(29, 198);
            this.openDOWN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openDOWN.TabIndex = 2;
            this.openDOWN.TabStop = false;
            this.openDOWN.Visible = false;
            // 
            // butLoop1
            // 
            this.butLoop1.BackgroundImage = global::Logic_Gates.Properties.Resources.loop;
            this.butLoop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butLoop1.FlatAppearance.BorderSize = 0;
            this.butLoop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLoop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butLoop1.ForeColor = System.Drawing.Color.Black;
            this.butLoop1.Location = new System.Drawing.Point(318, 229);
            this.butLoop1.Name = "butLoop1";
            this.butLoop1.Size = new System.Drawing.Size(75, 23);
            this.butLoop1.TabIndex = 0;
            this.butLoop1.UseVisualStyleBackColor = true;
            this.butLoop1.Click += new System.EventHandler(this.loop1_Click);
            // 
            // butLoop3
            // 
            this.butLoop3.BackgroundImage = global::Logic_Gates.Properties.Resources.loop;
            this.butLoop3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butLoop3.FlatAppearance.BorderSize = 0;
            this.butLoop3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLoop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butLoop3.ForeColor = System.Drawing.Color.DarkRed;
            this.butLoop3.Location = new System.Drawing.Point(872, 229);
            this.butLoop3.Name = "butLoop3";
            this.butLoop3.Size = new System.Drawing.Size(75, 23);
            this.butLoop3.TabIndex = 0;
            this.butLoop3.UseVisualStyleBackColor = true;
            this.butLoop3.Click += new System.EventHandler(this.loop3_Click);
            // 
            // butLoop2
            // 
            this.butLoop2.BackgroundImage = global::Logic_Gates.Properties.Resources.loop;
            this.butLoop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butLoop2.FlatAppearance.BorderSize = 0;
            this.butLoop2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLoop2.Location = new System.Drawing.Point(617, 229);
            this.butLoop2.Name = "butLoop2";
            this.butLoop2.Size = new System.Drawing.Size(75, 23);
            this.butLoop2.TabIndex = 0;
            this.butLoop2.UseVisualStyleBackColor = true;
            this.butLoop2.Click += new System.EventHandler(this.loop2_Click);
            // 
            // TLDOWN
            // 
            this.TLDOWN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TLDOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TLDOWN.Enabled = false;
            this.TLDOWN.Image = ((System.Drawing.Image)(resources.GetObject("TLDOWN.Image")));
            this.TLDOWN.Location = new System.Drawing.Point(87, 12);
            this.TLDOWN.Name = "TLDOWN";
            this.TLDOWN.Size = new System.Drawing.Size(42, 70);
            this.TLDOWN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TLDOWN.TabIndex = 2;
            this.TLDOWN.TabStop = false;
            this.TLDOWN.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::Logic_Gates.Properties.Resources.rolletnye1;
            this.pictureBox3.Location = new System.Drawing.Point(153, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // openUP
            // 
            this.openUP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.openUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openUP.Enabled = false;
            this.openUP.Image = global::Logic_Gates.Properties.Resources.open;
            this.openUP.Location = new System.Drawing.Point(271, 41);
            this.openUP.Name = "openUP";
            this.openUP.Size = new System.Drawing.Size(29, 198);
            this.openUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openUP.TabIndex = 2;
            this.openUP.TabStop = false;
            this.openUP.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Logic_Gates.Properties.Resources.rolletnye1;
            this.pictureBox2.Location = new System.Drawing.Point(733, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.carImage);
            this.Controls.Add(this.butDownDOWN);
            this.Controls.Add(this.butDownUP);
            this.Controls.Add(this.DayNight);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.iDOWN0);
            this.Controls.Add(this.IDOWN1);
            this.Controls.Add(this.IUP0);
            this.Controls.Add(this.IUP1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.timUP);
            this.Controls.Add(this.timDown);
            this.Controls.Add(this.butSense);
            this.Controls.Add(this.TLUP);
            this.Controls.Add(this.openDOWN);
            this.Controls.Add(this.butSQDOWN0);
            this.Controls.Add(this.butLoop1);
            this.Controls.Add(this.butLoop3);
            this.Controls.Add(this.butLoop2);
            this.Controls.Add(this.butSQUP0);
            this.Controls.Add(this.butSQDOWN1);
            this.Controls.Add(this.butSQUP1);
            this.Controls.Add(this.TLDOWN);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.openUP);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Автоматические ворота";
            this.Load += new System.EventHandler(this.Start);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controlCar);
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openDOWN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLDOWN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butSQDOWN1;
        private System.Windows.Forms.Button butSQDOWN0;
        private System.Windows.Forms.Button butLoop2;
        private System.Windows.Forms.Button butLoop1;
        private System.Windows.Forms.Button butLoop3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox TLUP;
        private System.Windows.Forms.PictureBox TLDOWN;
        private System.Windows.Forms.Button butSense;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timDown;
        private System.Windows.Forms.Label timUP;
        private System.Windows.Forms.Timer timerDown;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.PictureBox openDOWN;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Button butSQUP1;
        private System.Windows.Forms.Button butSQUP0;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox openUP;
        private System.Windows.Forms.Label IUP1;
        private System.Windows.Forms.Label IUP0;
        private System.Windows.Forms.Label IDOWN1;
        private System.Windows.Forms.Label iDOWN0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox toggleButton;
        private System.Windows.Forms.Label mode;
        private System.Windows.Forms.Label DayNight;
        private System.Windows.Forms.Button butDownUP;
        private System.Windows.Forms.Button butDownDOWN;
        private System.Windows.Forms.PictureBox carImage;
    }
}

