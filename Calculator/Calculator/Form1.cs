﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1=0;
        double number2;
        double result;
        bool Is_sign_input=false;
        string sign;
        System.Timers.Timer myTimer;
        bool timer_start=false;
        bool is_button_choosed;


        public bool checknum (String value)//判断输入的字符串是否为一个合理的数字
        {
            bool result = Regex.IsMatch(value, @"^(-?[0-9]*[.]*[0-9]{0,3})$");
            return result ;

        }

        public void operation(String op_sign)//确定运算符号的方法
        {
            String op_name="";
            switch (op_sign)
            {
                case "add": op_name="加法"; break;
                case "sub": op_name = "减法"; break;
                case "mul": op_name = "乘法"; break;
                case "div": op_name = "除法"; break;
                case "power": op_name = "n次方";break;
                case "antipow": op_name = "开方"; break;

            }
            stop_timer();
            if (checknum(textBox.Text))
            {
                number1 = double.Parse(textBox.Text);
                textBox.Text = "";
                Is_sign_input = true;
                sign = op_sign;
                info.Text = "已选择算法:"+op_name+"    " +"请输入第二个运算数";
            }
            else
            {
                info.Text = "请输入有效数字";
            }
           
        }
        public void reset()//除上一次的计算结果外全部重置的方法
        {
            number1 = 0;
            number2 = 0;
            Is_sign_input = false;
            sign = "";
        }

    private void button_add_Click(object sender, EventArgs e)
        {
            operation("add");
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            operation("sub");
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            operation("mul");
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            operation("div");
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            
            stop_timer();
            if (Is_sign_input && checknum(textBox.Text))
            {
                number2 = double.Parse(textBox.Text);
                switch (sign)
                {
                    case "add" :result = number1 + number2;break;
                    case "sub": result = number1 - number2; break;
                    case "mul": result = number1 * number2; break;
                    case "div":
                        {
                            if (number2 != 0)
                                result = number1/number2;
                            else
                                info.Text = "被除数不能为0！";
                        }
                        break;
                    case "power":result = Math.Pow(number1, number2);break;
                    case "antipow":result = Math.Pow(number1, (1 / number2));break;
                       
                }
                textBox.Text = Convert.ToString(result);
                info.Text = "已算出结果";
            }
            else
            {
                if (Is_sign_input)
                {
                    info.Text = "还未输入选择运算方式！";
                }
            }

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            reset();
            result = 0;
            textBox.Text = "";
            info.Text = "请输入第一个运算数";
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            operation("power");
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            stop_timer();
            if (checknum(textBox.Text))
            {
                number1 = double.Parse(textBox.Text);
                result = number1 * number1;
                textBox.Text = Convert.ToString(result);
                info.Text = "已算出结果";
            }
        }

        private void button_antipow_Click(object sender, EventArgs e)
        {
            operation("antipow");
        }

        private void time_Click(object sender, EventArgs e)
        {
            timer_start = true;
            myTimer = new System.Timers.Timer(1000);//定时周期2秒
            myTimer.Elapsed += reset_time;//到1秒了做的事件
            myTimer.AutoReset = true; //是否不断重复定时器操作
            myTimer.Enabled = true;
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        public void reset_time(object sender, System.Timers.ElapsedEventArgs e)
        {
            info.Text = "当前时间：" + Convert.ToString(DateTime.Now);
        }
        public void stop_timer()
        {
            if (timer_start)
            {
                myTimer.Close(); //释放Timer占用的资源
                myTimer.Dispose();
            }
            
        }

        private void sin_Click(object sender, EventArgs e)
        {
            stop_timer();
            if (checknum(textBox.Text))
            {
                number1 = double.Parse(textBox.Text);
                if (number1 > 360||number1 < 0){
                    info.Text="请输入合适的角度";
                }
                else
                {
                    double RadianValue = Math.PI * number1 / 180;
                    result = Math.Sin(RadianValue);
                    textBox.Text = Convert.ToString(result);
                    info.Text = "已算出结果";
                }
               
            }

        }

        private void cos_Click(object sender, EventArgs e)
        {
            stop_timer();
            if (checknum(textBox.Text))
            {
                number1 = double.Parse(textBox.Text);
                if (number1 > 360 || number1 < 0)
                {
                    info.Text = "请输入合适的角度";
                }
                else
                {
                    double RadianValue = Math.PI * number1 / 180;
                    result = Math.Cos(RadianValue);
                    textBox.Text = Convert.ToString(result);
                    info.Text = "已算出结果";
                }

            }
        }

        private void button_Binary_Click(object sender, EventArgs e)//十进制转二进制
        {
            stop_timer();
            if (checknum(textBox.Text))
            {
                number1 = double.Parse(textBox.Text);
                int a = (int)number1;
                textBox.Text = Convert.ToString(a,2);
                result = double.Parse(textBox.Text);
                info.Text = "已算出结果";
            }

        }

        private void button_hex_Click(object sender, EventArgs e)//十进制转十六进制
        {
            stop_timer();
            if (checknum(textBox.Text))
            {
                number1 = double.Parse(textBox.Text);
                int a = (int)number1;
                textBox.Text = Convert.ToString(a, 16);
                result = double.Parse(textBox.Text);
                info.Text = "已算出结果";
            }
        }

        private void button_Ln_Click(object sender, EventArgs e)
        {
            stop_timer();
            if (checknum(textBox.Text))
            {
                number1 = double.Parse(textBox.Text);
                result = Math.Log(number1);
                textBox.Text = Convert.ToString(result);
                reset();
            }
        }
    }
}
