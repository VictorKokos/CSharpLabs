namespace Lab1
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
            this.Header = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueTextbox = new System.Windows.Forms.TextBox();
            this.Sin = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.AnswerValue = new System.Windows.Forms.Label();
            this.CosButton = new System.Windows.Forms.Button();
            this.TgButton = new System.Windows.Forms.Button();
            this.CtgButton = new System.Windows.Forms.Button();
            this.ButtonSqrt = new System.Windows.Forms.Button();
            this.ButtonCbrt = new System.Windows.Forms.Button();
            this.ButtonPow = new System.Windows.Forms.Button();
            this.ButtonPow3 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ButtonPaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Location = new System.Drawing.Point(175, 27);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(452, 20);
            this.Header.TabIndex = 0;
            this.Header.Text = "Тригонометрическо-степенной калькулятор для вещественных";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(79, 121);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(76, 20);
            this.ValueLabel.TabIndex = 2;
            this.ValueLabel.Text = "Значение";
            // 
            // ValueTextbox
            // 
            this.ValueTextbox.Location = new System.Drawing.Point(175, 118);
            this.ValueTextbox.Name = "ValueTextbox";
            this.ValueTextbox.Size = new System.Drawing.Size(125, 27);
            this.ValueTextbox.TabIndex = 3;
            this.ValueTextbox.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(84, 183);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(71, 29);
            this.Sin.TabIndex = 4;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(126, 357);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(57, 20);
            this.Answer.TabIndex = 5;
            this.Answer.Text = "Answer";
            // 
            // AnswerValue
            // 
            this.AnswerValue.AutoSize = true;
            this.AnswerValue.Location = new System.Drawing.Point(204, 355);
            this.AnswerValue.Name = "AnswerValue";
            this.AnswerValue.Size = new System.Drawing.Size(0, 20);
            this.AnswerValue.TabIndex = 6;
            this.AnswerValue.Click += new System.EventHandler(this.AnswerValue_Click);
            // 
            // CosButton
            // 
            this.CosButton.Location = new System.Drawing.Point(175, 183);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(71, 29);
            this.CosButton.TabIndex = 7;
            this.CosButton.Text = "Cos";
            this.CosButton.UseVisualStyleBackColor = true;
            this.CosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // TgButton
            // 
            this.TgButton.Location = new System.Drawing.Point(272, 186);
            this.TgButton.Name = "TgButton";
            this.TgButton.Size = new System.Drawing.Size(62, 29);
            this.TgButton.TabIndex = 8;
            this.TgButton.Text = "Tg";
            this.TgButton.UseVisualStyleBackColor = true;
            this.TgButton.Click += new System.EventHandler(this.TgButton_Click);
            // 
            // CtgButton
            // 
            this.CtgButton.Location = new System.Drawing.Point(357, 186);
            this.CtgButton.Name = "CtgButton";
            this.CtgButton.Size = new System.Drawing.Size(72, 29);
            this.CtgButton.TabIndex = 9;
            this.CtgButton.Text = "Ctg";
            this.CtgButton.UseVisualStyleBackColor = true;
            this.CtgButton.Click += new System.EventHandler(this.CtgButton_Click);
            // 
            // ButtonSqrt
            // 
            this.ButtonSqrt.Location = new System.Drawing.Point(450, 186);
            this.ButtonSqrt.Name = "ButtonSqrt";
            this.ButtonSqrt.Size = new System.Drawing.Size(70, 29);
            this.ButtonSqrt.TabIndex = 10;
            this.ButtonSqrt.Text = "sqrt";
            this.ButtonSqrt.UseVisualStyleBackColor = true;
            this.ButtonSqrt.Click += new System.EventHandler(this.ButtonSqrt_Click);
            // 
            // ButtonCbrt
            // 
            this.ButtonCbrt.Location = new System.Drawing.Point(537, 186);
            this.ButtonCbrt.Name = "ButtonCbrt";
            this.ButtonCbrt.Size = new System.Drawing.Size(62, 29);
            this.ButtonCbrt.TabIndex = 11;
            this.ButtonCbrt.Text = "Cbrt";
            this.ButtonCbrt.UseVisualStyleBackColor = true;
            this.ButtonCbrt.Click += new System.EventHandler(this.ButtonCbrt_Click);
            // 
            // ButtonPow
            // 
            this.ButtonPow.Location = new System.Drawing.Point(84, 244);
            this.ButtonPow.Name = "ButtonPow";
            this.ButtonPow.Size = new System.Drawing.Size(94, 29);
            this.ButtonPow.TabIndex = 12;
            this.ButtonPow.Text = "Квадрат";
            this.ButtonPow.UseVisualStyleBackColor = true;
            this.ButtonPow.Click += new System.EventHandler(this.ButtonPow_Click);
            // 
            // ButtonPow3
            // 
            this.ButtonPow3.Location = new System.Drawing.Point(200, 244);
            this.ButtonPow3.Name = "ButtonPow3";
            this.ButtonPow3.Size = new System.Drawing.Size(94, 29);
            this.ButtonPow3.TabIndex = 13;
            this.ButtonPow3.Text = "Куб";
            this.ButtonPow3.UseVisualStyleBackColor = true;
            this.ButtonPow3.Click += new System.EventHandler(this.ButtonPow3_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(321, 244);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Очистка";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(110, 395);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ButtonPaste
            // 
            this.ButtonPaste.Location = new System.Drawing.Point(325, 117);
            this.ButtonPaste.Name = "ButtonPaste";
            this.ButtonPaste.Size = new System.Drawing.Size(94, 29);
            this.ButtonPaste.TabIndex = 16;
            this.ButtonPaste.Text = "Paste";
            this.ButtonPaste.UseVisualStyleBackColor = true;
            this.ButtonPaste.Click += new System.EventHandler(this.ButtonPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonPaste);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ButtonPow3);
            this.Controls.Add(this.ButtonPow);
            this.Controls.Add(this.ButtonCbrt);
            this.Controls.Add(this.ButtonSqrt);
            this.Controls.Add(this.CtgButton);
            this.Controls.Add(this.TgButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.AnswerValue);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.ValueTextbox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.Header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Header;
        private Label ValueLabel;
        private TextBox ValueTextbox;
        private Button Sin;
        private Label Answer;
        private Label AnswerValue;
        private Button CosButton;
        private Button TgButton;
        private Button CtgButton;
        private Button ButtonSqrt;
        private Button ButtonCbrt;
        private Button ButtonPow;
        private Button ButtonPow3;
        private Button ClearButton;
        private Button SaveButton;
        private Button ButtonPaste;
    }
}