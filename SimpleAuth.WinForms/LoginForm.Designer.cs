namespace SimpleAuth.WinForms
{
    partial class LoginForm
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
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(45, 33);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(171, 20);
            this.txtBox_Email.TabIndex = 0;
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.Location = new System.Drawing.Point(45, 59);
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.PasswordChar = '*';
            this.txtBox_Pass.Size = new System.Drawing.Size(171, 20);
            this.txtBox_Pass.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(77, 95);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(102, 28);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 151);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.txtBox_Email);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.Button btn_Login;
    }
}

