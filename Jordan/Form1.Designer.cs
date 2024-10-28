namespace Jordan
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.button3 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.Format = "N2";
      dataGridViewCellStyle3.NullValue = null;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(24, 117);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 47;
      this.dataGridView1.Size = new System.Drawing.Size(727, 489);
      this.dataGridView1.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 23);
      this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(244, 25);
      this.label3.TabIndex = 5;
      this.label3.Text = "Размерность матрицы:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(384, 67);
      this.textBox1.Margin = new System.Windows.Forms.Padding(6);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(64, 31);
      this.textBox1.TabIndex = 6;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(384, 17);
      this.textBox2.Margin = new System.Windows.Forms.Padding(6);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(64, 31);
      this.textBox2.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(272, 73);
      this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(96, 25);
      this.label4.TabIndex = 8;
      this.label4.Text = "столбцы";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(272, 23);
      this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 25);
      this.label5.TabIndex = 9;
      this.label5.Text = "строки";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Wheat;
      this.button1.Location = new System.Drawing.Point(464, 10);
      this.button1.Margin = new System.Windows.Forms.Padding(6);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(150, 96);
      this.button1.TabIndex = 10;
      this.button1.Text = "Построить";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(767, 169);
      this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(107, 25);
      this.label6.TabIndex = 15;
      this.label6.Text = "№ строки";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(767, 225);
      this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(120, 25);
      this.label7.TabIndex = 14;
      this.label7.Text = "№ столбца";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(903, 163);
      this.textBox3.Margin = new System.Windows.Forms.Padding(6);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(64, 31);
      this.textBox3.TabIndex = 13;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(903, 219);
      this.textBox4.Margin = new System.Windows.Forms.Padding(6);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(64, 31);
      this.textBox4.TabIndex = 12;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(767, 117);
      this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(198, 25);
      this.label8.TabIndex = 11;
      this.label8.Text = "Ведущий элемент:";
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Wheat;
      this.button2.Location = new System.Drawing.Point(763, 446);
      this.button2.Margin = new System.Windows.Forms.Padding(6);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(264, 92);
      this.button2.TabIndex = 16;
      this.button2.Text = "Вычислить";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // dataGridView2
      // 
      this.dataGridView2.AllowUserToAddRows = false;
      this.dataGridView2.AllowUserToDeleteRows = false;
      this.dataGridView2.AllowUserToResizeColumns = false;
      this.dataGridView2.AllowUserToResizeRows = false;
      this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.Format = "N2";
      dataGridViewCellStyle4.NullValue = null;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new System.Drawing.Point(1075, 117);
      this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersWidth = 47;
      this.dataGridView2.Size = new System.Drawing.Size(693, 489);
      this.dataGridView2.TabIndex = 17;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Wheat;
      this.button3.Location = new System.Drawing.Point(763, 350);
      this.button3.Margin = new System.Windows.Forms.Padding(6);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(264, 85);
      this.button3.TabIndex = 18;
      this.button3.Text = "<< Обменять значения";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(1911, 859);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dataGridView1);
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form1";
      this.Text = "Метод искусственного базиса";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
    }
}

