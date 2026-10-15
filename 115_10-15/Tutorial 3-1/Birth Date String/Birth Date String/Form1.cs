using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 檔案說明：
// 此檔案為表單主程式，提供輸入星期、月份、日期與年份的欄位，
// 並在按下「顯示日期」按鈕後，組合並顯示格式化的出生日期字串。
// 所有註解皆以繁體中文撰寫。

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單元件（由 Designer 產生）
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入並組合成顯示字串
            // 範例輸出格式：星期, 月份 日期, 年份
            string output = string.Format("{0}, {1} {2}, {3}",
                dayOfWeekTextBox.Text.Trim(),
                monthTextBox.Text.Trim(),
                dayOfMonthTextBox.Text.Trim(),
                yearTextBox.Text.Trim());

            // 將結果顯示在輸出標籤上
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除所有輸入欄位與輸出顯示
            dayOfWeekTextBox.Text = string.Empty;
            monthTextBox.Text = string.Empty;
            dayOfMonthTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;

            dateOutputLabel.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單並結束程式
            this.Close();
        }
    }
}
