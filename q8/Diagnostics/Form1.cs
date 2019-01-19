using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Diagnostics
{
    public partial class DiagnosticsForm : Form
    {
        public DiagnosticsForm()
        {
            InitializeComponent();
        }

        private void DiagnosticsForm_Load(object sender, EventArgs e)
        {
            UpdateListButton_Click(sender, e);
        }

        private void UpdateListButton_Click(object sender, EventArgs e)
        {
            ListListBox.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ListListBox.Items.Add(process.ProcessName + "(" + process.Id + ")");
            }
        }

        private void ListListBox_Click(object sender, EventArgs e)
        {
            string selected = (string)ListListBox.SelectedItem;
            int leftParenthesis = selected.IndexOf('(');
            int rightParenthesis = selected.IndexOf(')');
            selected = selected.Substring(leftParenthesis + 1, rightParenthesis - leftParenthesis - 1);
            Process process = Process.GetProcessById(int.Parse(selected));

            InfoGroupBox.Text = process.ProcessName + "进程的详细信息";
            InfoTextBox.Clear();
            InfoTextBox.Text += "进程映像名：" + process.ProcessName + "\r\n";
            InfoTextBox.Text += "进程ID：" + process.Id + "\r\n";
            InfoTextBox.Text += "启动线程数：" + process.Threads.Count + "\r\n";
            try
            {
                InfoTextBox.Text += "CPU占用时间：" + process.TotalProcessorTime + "\r\n";
            }
            catch (Exception)
            {
                InfoTextBox.Text += "CPU占用时间：权限不足\r\n";
            }
            try
            {
                InfoTextBox.Text += "线程优先级：" + process.PriorityClass + "\r\n";
            }
            catch (Exception)
            {
                InfoTextBox.Text += "线程优先级：权限不足\r\n";
            }
            try
            {
                InfoTextBox.Text += "启动时间：" + process.StartTime + "\r\n";
            }
            catch (Exception)
            {
                InfoTextBox.Text += "启动时间：权限不足\r\n";
            }
            InfoTextBox.Text += "专用内存：" + process.PrivateMemorySize64 / 1024 + "KB\r\n";
            InfoTextBox.Text += "峰值虚拟内存：" + process.PeakVirtualMemorySize64 / 1024 + "KB\r\n";
            InfoTextBox.Text += "峰值分页内存：" + process.PeakPagedMemorySize64 / 1024 + "KB\r\n";
            InfoTextBox.Text += "分页系统内存：" + process.PagedSystemMemorySize64 / 1024 + "KB\r\n";
            InfoTextBox.Text += "分页内存：" + process.PagedMemorySize64 / 1024 + "KB\r\n";
            InfoTextBox.Text += "未分页系统内存：" + process.NonpagedSystemMemorySize64 / 1024 + "KB\r\n";
            InfoTextBox.Text += "物理内存：" + process.WorkingSet64 / 1024 + "KB\r\n";
            InfoTextBox.Text += "虚拟内存：" + process.VirtualMemorySize64 / 1024 + "KB\r\n";
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutText = "dy\r\n2019年1月";
            MessageBox.Show(aboutText, "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
