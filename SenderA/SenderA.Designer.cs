namespace SenderA
{
    partial class SenderA
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
            this.buttonB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(324, 262);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(109, 23);
            this.buttonB.TabIndex = 0;
            this.buttonB.Text = "send to B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonB_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 25);
            this.textBox1.TabIndex = 1;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(324, 319);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(109, 23);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "send to C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonC_MouseClick);
            // 
            // SenderA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonB);
            this.Name = "SenderA";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonC;
    }
}

