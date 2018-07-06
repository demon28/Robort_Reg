namespace Robort_Reg
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
            this.btn_jiami = new System.Windows.Forms.Button();
            this.btn_jiemi = new System.Windows.Forms.Button();
            this.tb_jiami = new System.Windows.Forms.TextBox();
            this.tb_jiemi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_jiami
            // 
            this.btn_jiami.Location = new System.Drawing.Point(238, 127);
            this.btn_jiami.Name = "btn_jiami";
            this.btn_jiami.Size = new System.Drawing.Size(75, 23);
            this.btn_jiami.TabIndex = 0;
            this.btn_jiami.Text = "加 密";
            this.btn_jiami.UseVisualStyleBackColor = true;
            this.btn_jiami.Click += new System.EventHandler(this.btn_jiami_Click);
            // 
            // btn_jiemi
            // 
            this.btn_jiemi.Location = new System.Drawing.Point(22, 127);
            this.btn_jiemi.Name = "btn_jiemi";
            this.btn_jiemi.Size = new System.Drawing.Size(75, 23);
            this.btn_jiemi.TabIndex = 1;
            this.btn_jiemi.Text = "解 密";
            this.btn_jiemi.UseVisualStyleBackColor = true;
            this.btn_jiemi.Click += new System.EventHandler(this.btn_jiemi_Click);
            // 
            // tb_jiami
            // 
            this.tb_jiami.Location = new System.Drawing.Point(12, 12);
            this.tb_jiami.Multiline = true;
            this.tb_jiami.Name = "tb_jiami";
            this.tb_jiami.Size = new System.Drawing.Size(309, 99);
            this.tb_jiami.TabIndex = 2;
            // 
            // tb_jiemi
            // 
            this.tb_jiemi.Location = new System.Drawing.Point(12, 179);
            this.tb_jiemi.Multiline = true;
            this.tb_jiemi.Name = "tb_jiemi";
            this.tb_jiemi.Size = new System.Drawing.Size(309, 99);
            this.tb_jiemi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 323);
            this.Controls.Add(this.tb_jiemi);
            this.Controls.Add(this.tb_jiami);
            this.Controls.Add(this.btn_jiemi);
            this.Controls.Add(this.btn_jiami);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jiami;
        private System.Windows.Forms.Button btn_jiemi;
        private System.Windows.Forms.TextBox tb_jiami;
        private System.Windows.Forms.TextBox tb_jiemi;
    }
}

