namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Small2 = new System.Windows.Forms.TextBox();
            this.Small1 = new System.Windows.Forms.TextBox();
            this.Big1 = new System.Windows.Forms.TextBox();
            this.Big2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Label();
            this.alert21 = new System.Windows.Forms.Label();
            this.alert11 = new System.Windows.Forms.Label();
            this.alert12 = new System.Windows.Forms.Label();
            this.alert22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Більша частина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Менша частина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Додавання";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Віднімання";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Множення";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(282, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ділення";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Compare";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Small2
            // 
            this.Small2.Location = new System.Drawing.Point(338, 85);
            this.Small2.Name = "Small2";
            this.Small2.Size = new System.Drawing.Size(100, 20);
            this.Small2.TabIndex = 8;
            this.Small2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Small2_KeyPress);
            // 
            // Small1
            // 
            this.Small1.Location = new System.Drawing.Point(127, 85);
            this.Small1.Name = "Small1";
            this.Small1.Size = new System.Drawing.Size(100, 20);
            this.Small1.TabIndex = 9;
            this.Small1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Small1_KeyPress);
            // 
            // Big1
            // 
            this.Big1.Location = new System.Drawing.Point(127, 43);
            this.Big1.Name = "Big1";
            this.Big1.Size = new System.Drawing.Size(100, 20);
            this.Big1.TabIndex = 10;
            this.Big1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Big1_KeyPress);
            // 
            // Big2
            // 
            this.Big2.Location = new System.Drawing.Point(338, 43);
            this.Big2.Name = "Big2";
            this.Big2.Size = new System.Drawing.Size(100, 20);
            this.Big2.TabIndex = 11;
            this.Big2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Big2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Друге число";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Перше число";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(537, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Equal";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(444, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Compare More";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(101, 199);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(16, 13);
            this.res.TabIndex = 17;
            this.res.Text = ",,,";
            // 
            // alert21
            // 
            this.alert21.AutoSize = true;
            this.alert21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alert21.ForeColor = System.Drawing.Color.Red;
            this.alert21.Location = new System.Drawing.Point(134, 69);
            this.alert21.Name = "alert21";
            this.alert21.Size = new System.Drawing.Size(81, 13);
            this.alert21.TabIndex = 21;
            this.alert21.Text = "Друге число";
            // 
            // alert11
            // 
            this.alert11.AutoSize = true;
            this.alert11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alert11.ForeColor = System.Drawing.Color.Red;
            this.alert11.Location = new System.Drawing.Point(134, 27);
            this.alert11.Name = "alert11";
            this.alert11.Size = new System.Drawing.Size(81, 13);
            this.alert11.TabIndex = 22;
            this.alert11.Text = "Друге число";
            // 
            // alert12
            // 
            this.alert12.AutoSize = true;
            this.alert12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alert12.ForeColor = System.Drawing.Color.Red;
            this.alert12.Location = new System.Drawing.Point(347, 27);
            this.alert12.Name = "alert12";
            this.alert12.Size = new System.Drawing.Size(81, 13);
            this.alert12.TabIndex = 23;
            this.alert12.Text = "Друге число";
            // 
            // alert22
            // 
            this.alert22.AutoSize = true;
            this.alert22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alert22.ForeColor = System.Drawing.Color.Red;
            this.alert22.Location = new System.Drawing.Point(347, 69);
            this.alert22.Name = "alert22";
            this.alert22.Size = new System.Drawing.Size(81, 13);
            this.alert22.TabIndex = 24;
            this.alert22.Text = "Друге число";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alert22);
            this.Controls.Add(this.alert12);
            this.Controls.Add(this.alert11);
            this.Controls.Add(this.alert21);
            this.Controls.Add(this.res);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Big2);
            this.Controls.Add(this.Big1);
            this.Controls.Add(this.Small1);
            this.Controls.Add(this.Small2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Small2;
        private System.Windows.Forms.TextBox Small1;
        private System.Windows.Forms.TextBox Big1;
        private System.Windows.Forms.TextBox Big2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label alert21;
        private System.Windows.Forms.Label alert11;
        private System.Windows.Forms.Label alert12;
        private System.Windows.Forms.Label alert22;
    }
}

