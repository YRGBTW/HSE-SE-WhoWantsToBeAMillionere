namespace WhoWantsToBeAMillionere_lab03
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
            Aanswer = new Button();
            BAnswer = new Button();
            CAnswer = new Button();
            DAnswer = new Button();
            pictureBox1 = new PictureBox();
            lblQuestion = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            listBox1 = new ListBox();
            btnFiftyFifty = new Button();
            btnCall = new Button();
            btnPeople = new Button();
            btnskipQuestion = new Button();
            btnAvailableMistake = new Button();
            imageList1 = new ImageList(components);
            btnTakeMoney = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // Aanswer
            // 
            Aanswer.FlatAppearance.BorderSize = 10;
            Aanswer.Location = new Point(322, 417);
            Aanswer.Name = "Aanswer";
            Aanswer.Size = new Size(228, 36);
            Aanswer.TabIndex = 1;
            Aanswer.Tag = "1";
            Aanswer.Text = "button1";
            Aanswer.UseVisualStyleBackColor = true;
            Aanswer.Click += Aanswer_Click;
            // 
            // BAnswer
            // 
            BAnswer.Location = new Point(590, 417);
            BAnswer.Name = "BAnswer";
            BAnswer.Size = new Size(250, 36);
            BAnswer.TabIndex = 2;
            BAnswer.Tag = "2";
            BAnswer.Text = "button2";
            BAnswer.UseVisualStyleBackColor = true;
            BAnswer.Click += button2_Click;
            // 
            // CAnswer
            // 
            CAnswer.Location = new Point(322, 474);
            CAnswer.Name = "CAnswer";
            CAnswer.Size = new Size(228, 32);
            CAnswer.TabIndex = 3;
            CAnswer.Tag = "3";
            CAnswer.Text = "button3";
            CAnswer.UseVisualStyleBackColor = true;
            CAnswer.Click += button3_Click;
            // 
            // DAnswer
            // 
            DAnswer.Location = new Point(590, 474);
            DAnswer.Name = "DAnswer";
            DAnswer.Size = new Size(250, 32);
            DAnswer.TabIndex = 4;
            DAnswer.Tag = "4";
            DAnswer.Text = "button4";
            DAnswer.UseVisualStyleBackColor = true;
            DAnswer.Click += DAnswer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.maxresdefault__1_;
            pictureBox1.Location = new Point(322, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblQuestion
            // 
            lblQuestion.Cursor = Cursors.IBeam;
            lblQuestion.Font = new Font("Verdana Pro Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.Location = new Point(326, 360);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(514, 45);
            lblQuestion.TabIndex = 5;
            lblQuestion.Text = "Текущий вопрос";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Verdana Pro Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Items.AddRange(new object[] { "3 000 000", "1 500 000", "800 000", "400 000", "200 000", "100 000", "50 000", "25 000", "15 000", "10 000", "5 000", "3 000", "2 000", "1 000", "500" });
            listBox1.Location = new Point(867, 53);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.Size = new Size(173, 290);
            listBox1.TabIndex = 6;
            // 
            // btnFiftyFifty
            // 
            btnFiftyFifty.BackgroundImage = (Image)resources.GetObject("btnFiftyFifty.BackgroundImage");
            btnFiftyFifty.BackgroundImageLayout = ImageLayout.Zoom;
            btnFiftyFifty.Location = new Point(83, 36);
            btnFiftyFifty.Name = "btnFiftyFifty";
            btnFiftyFifty.Size = new Size(84, 59);
            btnFiftyFifty.TabIndex = 7;
            btnFiftyFifty.UseVisualStyleBackColor = true;
            btnFiftyFifty.Click += btnFiftyFifty_Click;
            // 
            // btnCall
            // 
            btnCall.BackgroundImage = (Image)resources.GetObject("btnCall.BackgroundImage");
            btnCall.BackgroundImageLayout = ImageLayout.Zoom;
            btnCall.Location = new Point(83, 102);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(84, 59);
            btnCall.TabIndex = 8;
            btnCall.UseVisualStyleBackColor = true;
            btnCall.Click += btnCall_Click;
            // 
            // btnPeople
            // 
            btnPeople.BackColor = Color.White;
            btnPeople.BackgroundImage = (Image)resources.GetObject("btnPeople.BackgroundImage");
            btnPeople.BackgroundImageLayout = ImageLayout.Zoom;
            btnPeople.Location = new Point(83, 167);
            btnPeople.Name = "btnPeople";
            btnPeople.Size = new Size(84, 59);
            btnPeople.TabIndex = 9;
            btnPeople.UseVisualStyleBackColor = false;
            btnPeople.Click += btnPeople_Click;
            // 
            // btnskipQuestion
            // 
            btnskipQuestion.BackColor = Color.Transparent;
            btnskipQuestion.BackgroundImage = (Image)resources.GetObject("btnskipQuestion.BackgroundImage");
            btnskipQuestion.BackgroundImageLayout = ImageLayout.Zoom;
            btnskipQuestion.Location = new Point(83, 232);
            btnskipQuestion.Name = "btnskipQuestion";
            btnskipQuestion.Size = new Size(84, 59);
            btnskipQuestion.TabIndex = 10;
            btnskipQuestion.UseVisualStyleBackColor = false;
            btnskipQuestion.Click += btnskipQuestion_Click;
            // 
            // btnAvailableMistake
            // 
            btnAvailableMistake.BackgroundImage = (Image)resources.GetObject("btnAvailableMistake.BackgroundImage");
            btnAvailableMistake.BackgroundImageLayout = ImageLayout.Zoom;
            btnAvailableMistake.Location = new Point(83, 297);
            btnAvailableMistake.Name = "btnAvailableMistake";
            btnAvailableMistake.Size = new Size(84, 59);
            btnAvailableMistake.TabIndex = 11;
            btnAvailableMistake.UseVisualStyleBackColor = true;
            btnAvailableMistake.Click += btnAvailableMistake_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "blue_prodpictxmark_2_1484336300-1.png");
            // 
            // btnTakeMoney
            // 
            btnTakeMoney.Location = new Point(867, 360);
            btnTakeMoney.Name = "btnTakeMoney";
            btnTakeMoney.Size = new Size(173, 45);
            btnTakeMoney.TabIndex = 12;
            btnTakeMoney.Tag = "2";
            btnTakeMoney.Text = "Забрать деньги";
            btnTakeMoney.UseVisualStyleBackColor = true;
            btnTakeMoney.Click += btnTakeMoney_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 539);
            Controls.Add(btnTakeMoney);
            Controls.Add(btnAvailableMistake);
            Controls.Add(btnskipQuestion);
            Controls.Add(btnPeople);
            Controls.Add(btnCall);
            Controls.Add(btnFiftyFifty);
            Controls.Add(listBox1);
            Controls.Add(lblQuestion);
            Controls.Add(DAnswer);
            Controls.Add(CAnswer);
            Controls.Add(BAnswer);
            Controls.Add(Aanswer);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Игра";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Aanswer;
        private Button BAnswer;
        private Button CAnswer;
        private Button DAnswer;
        private PictureBox pictureBox1;
        private Label lblQuestion;
        private FileSystemWatcher fileSystemWatcher1;
        private ListBox listBox1;
        private Button btnAvailableMistake;
        private Button btnskipQuestion;
        private Button btnPeople;
        private Button btnCall;
        private Button btnFiftyFifty;
        private ImageList imageList1;
        private Button btnTakeMoney;
    }
}