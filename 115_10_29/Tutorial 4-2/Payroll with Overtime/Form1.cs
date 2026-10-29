using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有元件。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 設定正常工時上限與加班薪資倍率。
            const int BASE_HOURS = 40; // 基本工時
            const decimal OVERTIME_RATE = 1.5m; // 加班費率
            decimal hoursWorked; // 工作時數
            decimal hourlyPayRate; // 時薪
            decimal grossPay; // 總薪資

            try
            {
                // 將使用者輸入的文字轉換為數值。
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                // 正常工時依原時薪計算，超過正常工時的部分依加班倍率計算。
                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    decimal overtimeHours = hoursWorked - BASE_HOURS;
                    grossPay = (BASE_HOURS * hourlyPayRate) + (overtimeHours * hourlyPayRate * OVERTIME_RATE);
                }

                // 將計算結果顯示在總薪資欄位。
                grossPayLabel.Text = grossPay.ToString("C");
            }
            catch (FormatException)
            {
                // 輸入內容不是有效數字時，提示使用者重新輸入。
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除輸入欄位與總薪資顯示。
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將焦點移回工作時數欄位。
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
