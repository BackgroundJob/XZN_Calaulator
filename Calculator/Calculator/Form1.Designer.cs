
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.button_power = new System.Windows.Forms.Button();
            this.button_square = new System.Windows.Forms.Button();
            this.button_antipow = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.button_Binary = new System.Windows.Forms.Button();
            this.button_hex = new System.Windows.Forms.Button();
            this.button_Ln = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.Button();
            this.input3 = new System.Windows.Forms.Button();
            this.input4 = new System.Windows.Forms.Button();
            this.input5 = new System.Windows.Forms.Button();
            this.input6 = new System.Windows.Forms.Button();
            this.input7 = new System.Windows.Forms.Button();
            this.input8 = new System.Windows.Forms.Button();
            this.input9 = new System.Windows.Forms.Button();
            this.input10 = new System.Windows.Forms.Button();
            this.input_point = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox.Location = new System.Drawing.Point(46, 34);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(495, 46);
            this.textBox.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(339, 114);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(124, 69);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sub.Location = new System.Drawing.Point(459, 114);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(124, 69);
            this.button_sub.TabIndex = 2;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_result
            // 
            this.button_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_result.Location = new System.Drawing.Point(339, 306);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(124, 69);
            this.button_result.TabIndex = 3;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // button_mul
            // 
            this.button_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mul.Location = new System.Drawing.Point(339, 178);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(124, 69);
            this.button_mul.TabIndex = 4;
            this.button_mul.Text = "x";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_div.Location = new System.Drawing.Point(459, 178);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(124, 69);
            this.button_div.TabIndex = 5;
            this.button_div.Text = "÷";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(459, 306);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(124, 69);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.info.Location = new System.Drawing.Point(46, 87);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(134, 17);
            this.info.TabIndex = 8;
            this.info.Text = "请输入第一个运算数";
            // 
            // button_power
            // 
            this.button_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_power.Location = new System.Drawing.Point(579, 114);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(124, 69);
            this.button_power.TabIndex = 9;
            this.button_power.Text = "x^n";
            this.button_power.UseVisualStyleBackColor = true;
            this.button_power.Click += new System.EventHandler(this.button_power_Click);
            // 
            // button_square
            // 
            this.button_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_square.Location = new System.Drawing.Point(699, 114);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(124, 69);
            this.button_square.TabIndex = 10;
            this.button_square.Text = "x^2";
            this.button_square.UseVisualStyleBackColor = true;
            this.button_square.Click += new System.EventHandler(this.button_square_Click);
            // 
            // button_antipow
            // 
            this.button_antipow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_antipow.Location = new System.Drawing.Point(579, 178);
            this.button_antipow.Name = "button_antipow";
            this.button_antipow.Size = new System.Drawing.Size(124, 69);
            this.button_antipow.TabIndex = 11;
            this.button_antipow.Text = "n√";
            this.button_antipow.UseVisualStyleBackColor = true;
            this.button_antipow.Click += new System.EventHandler(this.button_antipow_Click);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(579, 306);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(124, 69);
            this.time.TabIndex = 12;
            this.time.Text = "time";
            this.time.UseVisualStyleBackColor = true;
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // sin
            // 
            this.sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sin.Location = new System.Drawing.Point(579, 242);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(124, 69);
            this.sin.TabIndex = 13;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cos.Location = new System.Drawing.Point(699, 242);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(124, 69);
            this.cos.TabIndex = 14;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // button_Binary
            // 
            this.button_Binary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_Binary.Location = new System.Drawing.Point(339, 242);
            this.button_Binary.Name = "button_Binary";
            this.button_Binary.Size = new System.Drawing.Size(124, 69);
            this.button_Binary.TabIndex = 15;
            this.button_Binary.Text = "十进制转二进制";
            this.button_Binary.UseVisualStyleBackColor = true;
            this.button_Binary.Click += new System.EventHandler(this.button_Binary_Click);
            // 
            // button_hex
            // 
            this.button_hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_hex.Location = new System.Drawing.Point(459, 242);
            this.button_hex.Name = "button_hex";
            this.button_hex.Size = new System.Drawing.Size(124, 69);
            this.button_hex.TabIndex = 16;
            this.button_hex.Text = "十进制转十六进制";
            this.button_hex.UseVisualStyleBackColor = true;
            this.button_hex.Click += new System.EventHandler(this.button_hex_Click);
            // 
            // button_Ln
            // 
            this.button_Ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ln.Location = new System.Drawing.Point(699, 178);
            this.button_Ln.Name = "button_Ln";
            this.button_Ln.Size = new System.Drawing.Size(124, 69);
            this.button_Ln.TabIndex = 17;
            this.button_Ln.Text = "ln";
            this.button_Ln.UseVisualStyleBackColor = true;
            this.button_Ln.Click += new System.EventHandler(this.button_Ln_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(46, 115);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(69, 69);
            this.input1.TabIndex = 18;
            this.input1.Text = "1";
            this.input1.UseVisualStyleBackColor = true;
            this.input1.Click += new System.EventHandler(this.input1_Click);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(116, 115);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(69, 69);
            this.input2.TabIndex = 19;
            this.input2.Text = "2";
            this.input2.UseVisualStyleBackColor = true;
            this.input2.Click += new System.EventHandler(this.input2_Click);
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(185, 114);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(69, 69);
            this.input3.TabIndex = 20;
            this.input3.Text = "3";
            this.input3.UseVisualStyleBackColor = true;
            this.input3.Click += new System.EventHandler(this.input3_Click);
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(46, 178);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(69, 69);
            this.input4.TabIndex = 21;
            this.input4.Text = "4";
            this.input4.UseVisualStyleBackColor = true;
            this.input4.Click += new System.EventHandler(this.input4_Click);
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(116, 178);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(69, 69);
            this.input5.TabIndex = 22;
            this.input5.Text = "5";
            this.input5.UseVisualStyleBackColor = true;
            this.input5.Click += new System.EventHandler(this.input5_Click);
            // 
            // input6
            // 
            this.input6.Location = new System.Drawing.Point(185, 179);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(69, 69);
            this.input6.TabIndex = 23;
            this.input6.Text = "6";
            this.input6.UseVisualStyleBackColor = true;
            this.input6.Click += new System.EventHandler(this.input6_Click);
            // 
            // input7
            // 
            this.input7.Location = new System.Drawing.Point(46, 243);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(69, 69);
            this.input7.TabIndex = 24;
            this.input7.Text = "7";
            this.input7.UseVisualStyleBackColor = true;
            this.input7.Click += new System.EventHandler(this.input7_Click);
            // 
            // input8
            // 
            this.input8.Location = new System.Drawing.Point(116, 242);
            this.input8.Name = "input8";
            this.input8.Size = new System.Drawing.Size(69, 69);
            this.input8.TabIndex = 25;
            this.input8.Text = "8";
            this.input8.UseVisualStyleBackColor = true;
            this.input8.Click += new System.EventHandler(this.input8_Click);
            // 
            // input9
            // 
            this.input9.Location = new System.Drawing.Point(185, 243);
            this.input9.Name = "input9";
            this.input9.Size = new System.Drawing.Size(69, 69);
            this.input9.TabIndex = 26;
            this.input9.Text = "9";
            this.input9.UseVisualStyleBackColor = true;
            this.input9.Click += new System.EventHandler(this.input9_Click);
            // 
            // input10
            // 
            this.input10.Location = new System.Drawing.Point(116, 307);
            this.input10.Name = "input10";
            this.input10.Size = new System.Drawing.Size(69, 69);
            this.input10.TabIndex = 27;
            this.input10.Text = "0";
            this.input10.UseVisualStyleBackColor = true;
            this.input10.Click += new System.EventHandler(this.input10_Click);
            // 
            // input_point
            // 
            this.input_point.Location = new System.Drawing.Point(185, 307);
            this.input_point.Name = "input_point";
            this.input_point.Size = new System.Drawing.Size(69, 69);
            this.input_point.TabIndex = 28;
            this.input_point.Text = ".";
            this.input_point.UseVisualStyleBackColor = true;
            this.input_point.Click += new System.EventHandler(this.input_point_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 455);
            this.Controls.Add(this.input_point);
            this.Controls.Add(this.input10);
            this.Controls.Add(this.input9);
            this.Controls.Add(this.input8);
            this.Controls.Add(this.input7);
            this.Controls.Add(this.input6);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.button_Ln);
            this.Controls.Add(this.button_hex);
            this.Controls.Add(this.button_Binary);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.time);
            this.Controls.Add(this.button_antipow);
            this.Controls.Add(this.button_square);
            this.Controls.Add(this.button_power);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button button_power;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button button_antipow;
        private System.Windows.Forms.Button time;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button button_Binary;
        private System.Windows.Forms.Button button_hex;
        private System.Windows.Forms.Button button_Ln;
        private System.Windows.Forms.Button input1;
        private System.Windows.Forms.Button input2;
        private System.Windows.Forms.Button input3;
        private System.Windows.Forms.Button input4;
        private System.Windows.Forms.Button input5;
        private System.Windows.Forms.Button input6;
        private System.Windows.Forms.Button input7;
        private System.Windows.Forms.Button input8;
        private System.Windows.Forms.Button input9;
        private System.Windows.Forms.Button input10;
        private System.Windows.Forms.Button input_point;
    }
}

