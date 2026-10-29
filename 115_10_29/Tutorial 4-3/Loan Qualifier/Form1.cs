using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有元件。
        public Form1()
        {
            InitializeComponent();
        }

        // 檢查年收入與目前工作年資是否符合貸款資格。
        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MIN_SALARY = 4000m; // 最低年薪要求
            const int MIN_YEARS = 2; // 最低工作年資要求

            decimal salary;
            int yearsOnJob;

            try
            {
                // 讀取使用者輸入的年收入與工作年資。
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                // 依照年收入與工作年資顯示審核結果。
                if (salary>= MIN_SALARY)
                {
                    if (yearsOnJob>= MIN_YEARS)
                    {
                        decisionLabel.Text = "符合貸款資格";
                    }
                    else
                    {
                        decisionLabel.Text="薪資符合但是年資不符合貸款資格";
                    }
                }             
            }
            catch (Exception ex)
            {
                // 發生輸入或其他錯誤時顯示錯誤訊息。
                MessageBox.Show(ex.Message);
            }
        }

        // 清除所有輸入內容與審核結果。
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除文字框與貸款決定標籤的內容。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將輸入焦點移回年收入文字框。
            salaryTextBox.Focus();
        }

        // 關閉貸款資格審核程式。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        // 貸款結果標籤的點擊事件。
        private void decisionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
