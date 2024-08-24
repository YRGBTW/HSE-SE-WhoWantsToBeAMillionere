namespace WhoWantsToBeAMillionere_lab03
{
    partial class Welcome
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            errorProvider1 = new ErrorProvider(components);
            OkW = new Button();
            declineW = new Button();
            topUsers = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana Pro Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 43);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 1;
            label1.Text = "Введите ваше имя";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana Pro", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(315, 46);
            label2.Name = "label2";
            label2.Size = new Size(273, 23);
            label2.TabIndex = 2;
            label2.Text = "Выберите несгораемую сумму";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana Pro", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(56, 152);
            label3.Name = "label3";
            label3.Size = new Size(221, 24);
            label3.TabIndex = 3;
            label3.Text = "Выберите подсказки (3)";
            // 
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Помощь зала", "50 на 50", "Звонок другу", "Право на ошибку", "Замена вопроса" });
            checkedListBox2.Location = new Point(59, 204);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(207, 114);
            checkedListBox2.TabIndex = 5;
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "3 000 000", "1 500 000", "800 000", "400 000", "200 000", "100 000", "50 000", "25 000", "15 000", "10 000", "5 000", "3 000", "2 000", "1 000", "500" });
            checkedListBox1.Location = new Point(315, 72);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(273, 246);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // OkW
            // 
            OkW.Location = new Point(436, 353);
            OkW.Name = "OkW";
            OkW.Size = new Size(94, 29);
            OkW.TabIndex = 6;
            OkW.Text = "Начать игру";
            OkW.UseVisualStyleBackColor = true;
            OkW.Click += OkW_Click;
            // 
            // declineW
            // 
            declineW.Location = new Point(536, 353);
            declineW.Name = "declineW";
            declineW.Size = new Size(94, 29);
            declineW.TabIndex = 7;
            declineW.Text = "Отмена";
            declineW.UseVisualStyleBackColor = true;
            declineW.Click += declineW_Click;
            // 
            // topUsers
            // 
            topUsers.Location = new Point(82, 337);
            topUsers.Name = "topUsers";
            topUsers.Size = new Size(169, 45);
            topUsers.TabIndex = 8;
            topUsers.Text = "Показать статистику";
            topUsers.UseVisualStyleBackColor = true;
            topUsers.Click += topUsers_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 401);
            Controls.Add(topUsers);
            Controls.Add(declineW);
            Controls.Add(OkW);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Welcome";
            Text = "Welcome";
            Load += Welcome_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
        private ErrorProvider errorProvider1;
        private Button declineW;
        private Button OkW;
        private Button topUsers;
    }
}