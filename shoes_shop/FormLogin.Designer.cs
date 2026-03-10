namespace shoes_shop
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            LogoPictureBox = new PictureBox();
            MainPanel = new Panel();
            LoginLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            EnterButton = new Button();
            GuestEnterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Anchor = AnchorStyles.None;
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.Location = new Point(137, 37);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(111, 98);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 0;
            LogoPictureBox.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(GuestEnterButton);
            MainPanel.Controls.Add(EnterButton);
            MainPanel.Controls.Add(PasswordTextBox);
            MainPanel.Controls.Add(PasswordLabel);
            MainPanel.Controls.Add(LoginTextBox);
            MainPanel.Controls.Add(LoginLabel);
            MainPanel.Location = new Point(12, 141);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(360, 208);
            MainPanel.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(160, 19);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(41, 15);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Логин";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(19, 43);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(323, 23);
            LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(19, 99);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(323, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(156, 75);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(49, 15);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Пароль";
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.MediumSpringGreen;
            EnterButton.Location = new Point(143, 131);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(75, 23);
            EnterButton.TabIndex = 4;
            EnterButton.Text = "Войти";
            EnterButton.UseVisualStyleBackColor = false;
            // 
            // GuestEnterButton
            // 
            GuestEnterButton.BackColor = Color.Chartreuse;
            GuestEnterButton.Location = new Point(117, 163);
            GuestEnterButton.Name = "GuestEnterButton";
            GuestEnterButton.Size = new Size(126, 23);
            GuestEnterButton.TabIndex = 5;
            GuestEnterButton.Text = "Войти как гость";
            GuestEnterButton.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(MainPanel);
            Controls.Add(LogoPictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox LogoPictureBox;
        private Panel MainPanel;
        private TextBox LoginTextBox;
        private Label LoginLabel;
        private Button GuestEnterButton;
        private Button EnterButton;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
    }
}