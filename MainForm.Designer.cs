namespace DiffPlexDemo
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.Button btnOpenFile2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFile1Path;
        private System.Windows.Forms.Label lblFile2Path;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer topSplitContainer;
        private System.Windows.Forms.TextBox txtFile1;
        private System.Windows.Forms.TextBox txtFile2;
        private System.Windows.Forms.RichTextBox rtxtDiffResult;
        private System.Windows.Forms.Label lblFile1;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.btnOpenFile2 = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFile1Path = new System.Windows.Forms.Label();
            this.lblFile2Path = new System.Windows.Forms.Label();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.topSplitContainer = new System.Windows.Forms.SplitContainer();
            this.lblFile1 = new System.Windows.Forms.Label();
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.txtFile2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.rtxtDiffResult = new System.Windows.Forms.RichTextBox();

            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topSplitContainer)).BeginInit();
            this.topSplitContainer.Panel1.SuspendLayout();
            this.topSplitContainer.Panel2.SuspendLayout();
            this.topSplitContainer.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnOpenFile1);
            this.pnlTop.Controls.Add(this.btnOpenFile2);
            this.pnlTop.Controls.Add(this.btnCompare);
            this.pnlTop.Controls.Add(this.btnClear);
            this.pnlTop.Controls.Add(this.lblFile1Path);
            this.pnlTop.Controls.Add(this.lblFile2Path);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 80);
            this.pnlTop.TabIndex = 0;

            // btnOpenFile1
            this.btnOpenFile1.Location = new System.Drawing.Point(10, 10);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(100, 25);
            this.btnOpenFile1.TabIndex = 0;
            this.btnOpenFile1.Text = "打开文件1";
            this.btnOpenFile1.UseVisualStyleBackColor = true;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile1_Click);

            // btnOpenFile2
            this.btnOpenFile2.Location = new System.Drawing.Point(120, 10);
            this.btnOpenFile2.Name = "btnOpenFile2";
            this.btnOpenFile2.Size = new System.Drawing.Size(100, 25);
            this.btnOpenFile2.TabIndex = 1;
            this.btnOpenFile2.Text = "打开文件2";
            this.btnOpenFile2.UseVisualStyleBackColor = true;
            this.btnOpenFile2.Click += new System.EventHandler(this.btnOpenFile2_Click);

            // btnCompare
            this.btnCompare.Location = new System.Drawing.Point(230, 10);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(100, 25);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "开始对比";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(340, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblFile1Path
            this.lblFile1Path.AutoSize = true;
            this.lblFile1Path.Location = new System.Drawing.Point(10, 45);
            this.lblFile1Path.Name = "lblFile1Path";
            this.lblFile1Path.Size = new System.Drawing.Size(77, 12);
            this.lblFile1Path.TabIndex = 4;
            this.lblFile1Path.Text = "文件1: 未加载";

            // lblFile2Path
            this.lblFile2Path.AutoSize = true;
            this.lblFile2Path.Location = new System.Drawing.Point(500, 45);
            this.lblFile2Path.Name = "lblFile2Path";
            this.lblFile2Path.Size = new System.Drawing.Size(77, 12);
            this.lblFile2Path.TabIndex = 5;
            this.lblFile2Path.Text = "文件2: 未加载";

            // mainSplitContainer
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 80);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;

            // mainSplitContainer.Panel1
            this.mainSplitContainer.Panel1.Controls.Add(this.topSplitContainer);

            // mainSplitContainer.Panel2
            this.mainSplitContainer.Panel2.Controls.Add(this.lblResult);
            this.mainSplitContainer.Panel2.Controls.Add(this.rtxtDiffResult);

            this.mainSplitContainer.Size = new System.Drawing.Size(1200, 600);
            this.mainSplitContainer.SplitterDistance = 300;
            this.mainSplitContainer.TabIndex = 1;

            // topSplitContainer
            this.topSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.topSplitContainer.Name = "topSplitContainer";

            // topSplitContainer.Panel1
            this.topSplitContainer.Panel1.Controls.Add(this.lblFile1);
            this.topSplitContainer.Panel1.Controls.Add(this.txtFile1);

            // topSplitContainer.Panel2
            this.topSplitContainer.Panel2.Controls.Add(this.lblFile2);
            this.topSplitContainer.Panel2.Controls.Add(this.txtFile2);

            this.topSplitContainer.Size = new System.Drawing.Size(1200, 300);
            this.topSplitContainer.SplitterDistance = 600;
            this.topSplitContainer.TabIndex = 0;

            // lblFile1
            this.lblFile1.AutoSize = true;
            this.lblFile1.Location = new System.Drawing.Point(10, 5);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(65, 12);
            this.lblFile1.TabIndex = 0;
            this.lblFile1.Text = "文件1内容:";

            // txtFile1
            this.txtFile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile1.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtFile1.Location = new System.Drawing.Point(0, 0);
            this.txtFile1.Multiline = true;
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFile1.Size = new System.Drawing.Size(600, 300);
            this.txtFile1.TabIndex = 1;
            this.txtFile1.WordWrap = false;

            // lblFile2
            this.lblFile2.AutoSize = true;
            this.lblFile2.Location = new System.Drawing.Point(10, 5);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(65, 12);
            this.lblFile2.TabIndex = 2;
            this.lblFile2.Text = "文件2内容:";

            // txtFile2
            this.txtFile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile2.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtFile2.Location = new System.Drawing.Point(0, 0);
            this.txtFile2.Multiline = true;
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFile2.Size = new System.Drawing.Size(600, 300);
            this.txtFile2.TabIndex = 3;
            this.txtFile2.WordWrap = false;

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(10, 5);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(65, 12);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "对比结果:";

            // rtxtDiffResult
            this.rtxtDiffResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtDiffResult.Font = new System.Drawing.Font("Courier New", 9F);
            this.rtxtDiffResult.Location = new System.Drawing.Point(0, 0);
            this.rtxtDiffResult.Name = "rtxtDiffResult";
            this.rtxtDiffResult.ReadOnly = true;
            this.rtxtDiffResult.Size = new System.Drawing.Size(1200, 300);
            this.rtxtDiffResult.TabIndex = 1;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.pnlTop);
            this.Name = "MainForm";
            this.Text = "DiffPlex 文件差异对比工具";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.topSplitContainer.Panel1.ResumeLayout(false);
            this.topSplitContainer.Panel1.PerformLayout();
            this.topSplitContainer.Panel2.ResumeLayout(false);
            this.topSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topSplitContainer)).EndInit();
            this.topSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
