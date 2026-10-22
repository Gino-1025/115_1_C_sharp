using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有控制項。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三次測驗分數與平均分數的變數。
            double test1, test2, test3, average;

            try
            {
                // 讀取輸入框中的內容，並將文字轉換為數值。
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三次測驗分數的平均值。
                average=(test1 + test2 + test3) / 3;

                // 將平均分數格式化為小數點後一位並顯示在畫面上。
                averageLabel.Text = average.ToString("F1");
            }
            catch (FormatException ex)
            {
                // 當輸入內容不是有效數字時，提示使用者重新輸入。
                MessageBox.Show("Please enter valid numeric values for all three tests.", "Input Error");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三次測驗的輸入內容與平均分數輸出結果。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單並結束畫面操作。
            this.Close();
        }
    }
}
