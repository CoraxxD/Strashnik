namespace Strashnik
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
            this.labelTypeUser = new System.Windows.Forms.Label();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.labelPassUser = new System.Windows.Forms.Label();
            this.labelSecretWord = new System.Windows.Forms.Label();
            this.TBLoginUser = new System.Windows.Forms.TextBox();
            this.TBPassUser = new System.Windows.Forms.TextBox();
            this.TBSecretWord = new System.Windows.Forms.TextBox();
            this.CBTypeUser = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelForgPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTypeUser
            // 
            this.labelTypeUser.AutoSize = true;
            this.labelTypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeUser.Location = new System.Drawing.Point(111, 65);
            this.labelTypeUser.Name = "labelTypeUser";
            this.labelTypeUser.Size = new System.Drawing.Size(149, 20);
            this.labelTypeUser.TabIndex = 0;
            this.labelTypeUser.Text = "Тип пользователя";
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginUser.Location = new System.Drawing.Point(111, 122);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(55, 20);
            this.labelLoginUser.TabIndex = 1;
            this.labelLoginUser.Text = "Логин";
            // 
            // labelPassUser
            // 
            this.labelPassUser.AutoSize = true;
            this.labelPassUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassUser.Location = new System.Drawing.Point(111, 179);
            this.labelPassUser.Name = "labelPassUser";
            this.labelPassUser.Size = new System.Drawing.Size(67, 20);
            this.labelPassUser.TabIndex = 2;
            this.labelPassUser.Text = "Пароль";
            // 
            // labelSecretWord
            // 
            this.labelSecretWord.AutoSize = true;
            this.labelSecretWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecretWord.Location = new System.Drawing.Point(111, 237);
            this.labelSecretWord.Name = "labelSecretWord";
            this.labelSecretWord.Size = new System.Drawing.Size(140, 20);
            this.labelSecretWord.TabIndex = 3;
            this.labelSecretWord.Text = "Секретное слово";
            // 
            // TBLoginUser
            // 
            this.TBLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLoginUser.Location = new System.Drawing.Point(328, 122);
            this.TBLoginUser.Name = "TBLoginUser";
            this.TBLoginUser.Size = new System.Drawing.Size(214, 22);
            this.TBLoginUser.TabIndex = 4;
            this.TBLoginUser.Text = "Введите логин";
            // 
            // TBPassUser
            // 
            this.TBPassUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPassUser.Location = new System.Drawing.Point(328, 179);
            this.TBPassUser.Name = "TBPassUser";
            this.TBPassUser.Size = new System.Drawing.Size(214, 22);
            this.TBPassUser.TabIndex = 5;
            this.TBPassUser.Text = "Введите пароль";
            // 
            // TBSecretWord
            // 
            this.TBSecretWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSecretWord.Location = new System.Drawing.Point(328, 237);
            this.TBSecretWord.Name = "TBSecretWord";
            this.TBSecretWord.Size = new System.Drawing.Size(214, 22);
            this.TBSecretWord.TabIndex = 6;
            this.TBSecretWord.Text = "Введите секретное слово";
            // 
            // CBTypeUser
            // 
            this.CBTypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBTypeUser.FormattingEnabled = true;
            this.CBTypeUser.Location = new System.Drawing.Point(328, 63);
            this.CBTypeUser.Name = "CBTypeUser";
            this.CBTypeUser.Size = new System.Drawing.Size(214, 24);
            this.CBTypeUser.TabIndex = 7;
            this.CBTypeUser.Text = "Введите тип пользователя";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(243, 323);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(148, 29);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Войти в систему";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // labelForgPass
            // 
            this.labelForgPass.AutoSize = true;
            this.labelForgPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForgPass.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelForgPass.Location = new System.Drawing.Point(230, 394);
            this.labelForgPass.Name = "labelForgPass";
            this.labelForgPass.Size = new System.Drawing.Size(177, 16);
            this.labelForgPass.TabIndex = 9;
            this.labelForgPass.Text = "Забыли данные для входа";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.labelForgPass);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.CBTypeUser);
            this.Controls.Add(this.TBSecretWord);
            this.Controls.Add(this.TBPassUser);
            this.Controls.Add(this.TBLoginUser);
            this.Controls.Add(this.labelSecretWord);
            this.Controls.Add(this.labelPassUser);
            this.Controls.Add(this.labelLoginUser);
            this.Controls.Add(this.labelTypeUser);
            this.Name = "LoginForm";
            this.Text = "Стражник - Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeUser;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Label labelPassUser;
        private System.Windows.Forms.Label labelSecretWord;
        private System.Windows.Forms.TextBox TBLoginUser;
        private System.Windows.Forms.TextBox TBPassUser;
        private System.Windows.Forms.TextBox TBSecretWord;
        private System.Windows.Forms.ComboBox CBTypeUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelForgPass;
    }
}

