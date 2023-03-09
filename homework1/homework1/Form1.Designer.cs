namespace homework1
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
            this.arrayInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.task1tip = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.task1 = new System.Windows.Forms.Label();
            this.task2 = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.TextBox();
            this.down = new System.Windows.Forms.TextBox();
            this.upboundaryLable = new System.Windows.Forms.Label();
            this.lowboundaryLabel = new System.Windows.Forms.Label();
            this.prime = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrayInput
            // 
            this.arrayInput.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.arrayInput.Location = new System.Drawing.Point(397, 156);
            this.arrayInput.Margin = new System.Windows.Forms.Padding(4);
            this.arrayInput.Name = "arrayInput";
            this.arrayInput.Size = new System.Drawing.Size(609, 45);
            this.arrayInput.TabIndex = 0;
            this.arrayInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 1;
            // 
            // task1tip
            // 
            this.task1tip.AutoSize = true;
            this.task1tip.Font = new System.Drawing.Font("幼圆", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.task1tip.Location = new System.Drawing.Point(149, 161);
            this.task1tip.Name = "task1tip";
            this.task1tip.Size = new System.Drawing.Size(241, 38);
            this.task1tip.TabIndex = 2;
            this.task1tip.Text = "请输入整数数组：";
            this.task1tip.UseCompatibleTextRendering = true;
            this.task1tip.Click += new System.EventHandler(this.label2_Click);
            // 
            // max
            // 
            this.max.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.max.Location = new System.Drawing.Point(180, 244);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(132, 45);
            this.max.TabIndex = 6;
            this.max.Text = "计算最大值";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.min.Location = new System.Drawing.Point(399, 244);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(132, 45);
            this.min.TabIndex = 7;
            this.min.Text = "计算最小值";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sum.Location = new System.Drawing.Point(831, 244);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(132, 45);
            this.sum.TabIndex = 9;
            this.sum.Text = "计算元素和";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // task1
            // 
            this.task1.AutoSize = true;
            this.task1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.task1.Location = new System.Drawing.Point(144, 83);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(732, 27);
            this.task1.TabIndex = 10;
            this.task1.Text = "编程求一个整数数组的最大值，最小值，平均值和所有数组元素的和";
            this.task1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // task2
            // 
            this.task2.AutoSize = true;
            this.task2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.task2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.task2.Location = new System.Drawing.Point(157, 466);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(618, 54);
            this.task2.TabIndex = 11;
            this.task2.Text = "编写程序，接受用户输入的两个数据为上、下限，然后10\r\n个一行输出上、下限之间的所有素数";
            this.task2.Click += new System.EventHandler(this.label4_Click);
            // 
            // up
            // 
            this.up.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.up.Location = new System.Drawing.Point(247, 565);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(135, 39);
            this.up.TabIndex = 12;
            this.up.TextChanged += new System.EventHandler(this.up_TextChanged);
            // 
            // down
            // 
            this.down.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.down.Location = new System.Drawing.Point(528, 565);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(135, 39);
            this.down.TabIndex = 13;
            this.down.TextChanged += new System.EventHandler(this.down_TextChanged);
            // 
            // upboundaryLable
            // 
            this.upboundaryLable.AutoSize = true;
            this.upboundaryLable.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.upboundaryLable.Location = new System.Drawing.Point(157, 568);
            this.upboundaryLable.Name = "upboundaryLable";
            this.upboundaryLable.Size = new System.Drawing.Size(84, 27);
            this.upboundaryLable.TabIndex = 14;
            this.upboundaryLable.Text = "上限：";
            // 
            // lowboundaryLabel
            // 
            this.lowboundaryLabel.AutoSize = true;
            this.lowboundaryLabel.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lowboundaryLabel.Location = new System.Drawing.Point(438, 568);
            this.lowboundaryLabel.Name = "lowboundaryLabel";
            this.lowboundaryLabel.Size = new System.Drawing.Size(84, 27);
            this.lowboundaryLabel.TabIndex = 15;
            this.lowboundaryLabel.Text = "下限：";
            // 
            // prime
            // 
            this.prime.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prime.Location = new System.Drawing.Point(750, 554);
            this.prime.Name = "prime";
            this.prime.Size = new System.Drawing.Size(198, 54);
            this.prime.TabIndex = 16;
            this.prime.Text = "输出素数";
            this.prime.UseVisualStyleBackColor = true;
            this.prime.Click += new System.EventHandler(this.prime_Click);
            // 
            // average
            // 
            this.average.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.average.Location = new System.Drawing.Point(619, 244);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(132, 45);
            this.average.TabIndex = 17;
            this.average.Text = "计算平均值";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.average_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1208, 868);
            this.Controls.Add(this.average);
            this.Controls.Add(this.prime);
            this.Controls.Add(this.lowboundaryLabel);
            this.Controls.Add(this.upboundaryLable);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.task1tip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrayInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label task1tip;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Label task1;
        private System.Windows.Forms.Label task2;
        private System.Windows.Forms.TextBox up;
        private System.Windows.Forms.TextBox down;
        private System.Windows.Forms.Label upboundaryLable;
        private System.Windows.Forms.Label lowboundaryLabel;
        private System.Windows.Forms.Button prime;
        private System.Windows.Forms.Button average;
    }
}

