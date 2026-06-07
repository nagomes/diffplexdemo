using System;
using System.Drawing;
using System.Windows.Forms;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

namespace DiffPlexDemo
{
    public partial class MainForm : Form
    {
        private SideBySideDiffBuilder _diffBuilder;

        public MainForm()
        {
            InitializeComponent();
            _diffBuilder = new SideBySideDiffBuilder(new DiffPlex.Differ());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "DiffPlex 文件差异对比工具";
            this.Width = 1200;
            this.Height = 700;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOpenFile1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|C# files (*.cs)|*.cs|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string content = System.IO.File.ReadAllText(openFileDialog.FileName);
                        txtFile1.Text = content;
                        lblFile1Path.Text = "文件1: " + openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("读取文件失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|C# files (*.cs)|*.cs|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string content = System.IO.File.ReadAllText(openFileDialog.FileName);
                        txtFile2.Text = content;
                        lblFile2Path.Text = "文件2: " + openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("读取文件失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFile1.Text) || string.IsNullOrEmpty(txtFile2.Text))
            {
                MessageBox.Show("请先加载两个文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 使用 DiffPlex 进行对比
                var diffResult = _diffBuilder.BuildDiffModel(txtFile1.Text, txtFile2.Text);

                // 清空结果显示区域
                rtxtDiffResult.Clear();

                if (diffResult.Lines.Count == 0)
                {
                    rtxtDiffResult.AppendText("两个文件完全相同！");
                    return;
                }

                // 显示差异信息
                rtxtDiffResult.AppendText("=== 文件差异对比结果 ===\n\n");
                rtxtDiffResult.AppendText($"总行数: {diffResult.Lines.Count}\n");
                rtxtDiffResult.AppendText($"添加行数: {diffResult.AddedLines}\n");
                rtxtDiffResult.AppendText($"删除行数: {diffResult.RemovedLines}\n");
                rtxtDiffResult.AppendText($"\n--- 详细信息 ---\n\n");

                foreach (var line in diffResult.Lines)
                {
                    if (line.Type == ChangeType.Imaginary)
                        continue;

                    string prefix = "  ";
                    switch (line.Type)
                    {
                        case ChangeType.Added:
                            prefix = "+ ";
                            break;
                        case ChangeType.Deleted:
                            prefix = "- ";
                            break;
                        case ChangeType.Modified:
                            prefix = "~ ";
                            break;
                    }

                    rtxtDiffResult.AppendText($"{prefix}{line.Text}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("对比失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFile1.Clear();
            txtFile2.Clear();
            rtxtDiffResult.Clear();
            lblFile1Path.Text = "文件1: 未加载";
            lblFile2Path.Text = "文件2: 未加载";
        }
    }
}
