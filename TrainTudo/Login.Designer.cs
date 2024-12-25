namespace TrainTudo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            loginBtn = new Guna.UI2.WinForms.Guna2Button();
            PasswordTb = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            UNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            ResetBtn = new Label();
            label4 = new Label();
            label11 = new Label();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UNameTb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ResetBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(30, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 521);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(164, 140);
            label2.Name = "label2";
            label2.Size = new Size(353, 30);
            label2.TabIndex = 13;
            label2.Text = "아이디: Admin , 비밀번호: Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(300, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gold;
            label9.Location = new Point(300, 408);
            label9.Name = "label9";
            label9.Size = new Size(25, 25);
            label9.TabIndex = 4;
            label9.Text = "+";
            // 
            // loginBtn
            // 
            loginBtn.BorderRadius = 15;
            loginBtn.CustomizableEdges = customizableEdges1;
            loginBtn.DisabledState.BorderColor = Color.DarkGray;
            loginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginBtn.FillColor = Color.Gold;
            loginBtn.Font = new Font("Segoe UI", 9F);
            loginBtn.ForeColor = Color.Black;
            loginBtn.Location = new Point(164, 393);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            loginBtn.Size = new Size(374, 55);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "로그인";
            loginBtn.Click += guna2Button1_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.CustomizableEdges = customizableEdges3;
            PasswordTb.DefaultText = "Admin";
            PasswordTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTb.Font = new Font("Segoe UI", 9F);
            PasswordTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTb.Location = new Point(164, 318);
            PasswordTb.Margin = new Padding(4, 5, 4, 5);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.PlaceholderText = "";
            PasswordTb.SelectedText = "";
            PasswordTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PasswordTb.Size = new Size(374, 50);
            PasswordTb.TabIndex = 3;
            PasswordTb.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(164, 277);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 2;
            label1.Text = "Password";
            label1.Click += label1_Click;
            // 
            // UNameTb
            // 
            UNameTb.CustomizableEdges = customizableEdges5;
            UNameTb.DefaultText = "Admin";
            UNameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UNameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UNameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UNameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UNameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UNameTb.Font = new Font("Segoe UI", 9F);
            UNameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UNameTb.Location = new Point(164, 211);
            UNameTb.Margin = new Padding(4, 5, 4, 5);
            UNameTb.Name = "UNameTb";
            UNameTb.PasswordChar = '\0';
            UNameTb.PlaceholderText = "";
            UNameTb.SelectedText = "";
            UNameTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            UNameTb.Size = new Size(374, 50);
            UNameTb.TabIndex = 3;
            UNameTb.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(672, 13);
            label3.Name = "label3";
            label3.Size = new Size(27, 30);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.AutoSize = true;
            ResetBtn.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ResetBtn.ForeColor = Color.Red;
            ResetBtn.Location = new Point(265, 466);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(183, 30);
            ResetBtn.TabIndex = 2;
            ResetBtn.Text = "입력 내용 지우기";
            ResetBtn.Click += ResetBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(164, 170);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 2;
            label4.Text = "UserName";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label11.ForeColor = Color.LimeGreen;
            label11.Location = new Point(274, 13);
            label11.Name = "label11";
            label11.Size = new Size(131, 30);
            label11.TabIndex = 1;
            label11.Text = "기차표 예약";
            label11.Click += label11_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = panel1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(781, 580);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label11;
        private Guna.UI2.WinForms.Guna2TextBox UNameTb;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTb;
        private Label label1;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private PictureBox pictureBox1;
        private Label ResetBtn;
        private Label label3;
        private Label label2;
    }
}