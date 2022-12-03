namespace Refactor
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
            this.StrTxb1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StrTxb3 = new System.Windows.Forms.TextBox();
            this.StrTxb2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StrTxb1
            // 
            this.StrTxb1.Location = new System.Drawing.Point(64, 158);
            this.StrTxb1.Name = "StrTxb1";
            this.StrTxb1.Size = new System.Drawing.Size(291, 20);
            this.StrTxb1.TabIndex = 14;
            this.StrTxb1.Text = "Сюда первую сторону";
            this.StrTxb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrTxb1.TextChanged += new System.EventHandler(this.StrTxb1_TextChanged);
            this.StrTxb1.Enter += new System.EventHandler(this.StrTxb1_Enter);
            this.StrTxb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trTxb1_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ваш ответ появится тут";
            // 
            // StrTxb3
            // 
            this.StrTxb3.Location = new System.Drawing.Point(64, 242);
            this.StrTxb3.Name = "StrTxb3";
            this.StrTxb3.Size = new System.Drawing.Size(291, 20);
            this.StrTxb3.TabIndex = 12;
            this.StrTxb3.Text = "Ну и как без третьей";
            this.StrTxb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrTxb3.TextChanged += new System.EventHandler(this.StrTxb3_TextChanged);
            this.StrTxb3.Enter += new System.EventHandler(this.StrTxb3_Enter);
            this.StrTxb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StrTxb3_KeyPress);
            // 
            // StrTxb2
            // 
            this.StrTxb2.Location = new System.Drawing.Point(64, 204);
            this.StrTxb2.Name = "StrTxb2";
            this.StrTxb2.Size = new System.Drawing.Size(291, 20);
            this.StrTxb2.TabIndex = 11;
            this.StrTxb2.Text = "Сюда вторую сторону";
            this.StrTxb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrTxb2.TextChanged += new System.EventHandler(this.StrTxb2_TextChanged);
            this.StrTxb2.Enter += new System.EventHandler(this.StrTxb2_Enter);
            this.StrTxb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StrTxb2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ответ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите три стороны вашего треугольника:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResultBtn
            // 
            this.ResultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBtn.Location = new System.Drawing.Point(68, 289);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(104, 34);
            this.ResultBtn.TabIndex = 8;
            this.ResultBtn.Text = "Рассчитать";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StrTxb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StrTxb3);
            this.Controls.Add(this.StrTxb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultBtn);
            this.Name = "Form1";
            this.Text = "Треугольники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StrTxb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StrTxb3;
        private System.Windows.Forms.TextBox StrTxb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultBtn;
    }
}

