namespace FamilyDay2020_Display
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Display = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Axis = new System.Windows.Forms.Panel();
            this.panel_Axis1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_X = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Y = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_U = new System.Windows.Forms.Label();
            this.lbl_OK = new System.Windows.Forms.Label();
            this.lbl_L = new System.Windows.Forms.Label();
            this.lbl_R = new System.Windows.Forms.Label();
            this.lbl_D = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Display.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_Right, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel_Display);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 410);
            this.panel1.TabIndex = 0;
            // 
            // panel_Display
            // 
            this.panel_Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Display.Controls.Add(this.pictureBox1);
            this.panel_Display.Controls.Add(this.panel2);
            this.panel_Display.Controls.Add(this.panel_Axis);
            this.panel_Display.Controls.Add(this.panel_Axis1);
            this.panel_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Display.Location = new System.Drawing.Point(0, 0);
            this.panel_Display.Name = "panel_Display";
            this.panel_Display.Size = new System.Drawing.Size(604, 373);
            this.panel_Display.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(199, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 355);
            this.panel2.TabIndex = 0;
            // 
            // panel_Axis
            // 
            this.panel_Axis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Axis.BackColor = System.Drawing.Color.LightGray;
            this.panel_Axis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Axis.Location = new System.Drawing.Point(3, 305);
            this.panel_Axis.Name = "panel_Axis";
            this.panel_Axis.Size = new System.Drawing.Size(580, 32);
            this.panel_Axis.TabIndex = 2;
            // 
            // panel_Axis1
            // 
            this.panel_Axis1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Axis1.BackColor = System.Drawing.Color.LightGray;
            this.panel_Axis1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Axis1.Location = new System.Drawing.Point(3, 33);
            this.panel_Axis1.Name = "panel_Axis1";
            this.panel_Axis1.Size = new System.Drawing.Size(580, 32);
            this.panel_Axis1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_X,
            this.toolStripStatusLabel2,
            this.lbl_Y});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(604, 33);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 27);
            this.toolStripStatusLabel1.Text = "  X:";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = false;
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(80, 27);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 27);
            this.toolStripStatusLabel2.Text = "Y:";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = false;
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(80, 27);
            // 
            // panel_Right
            // 
            this.panel_Right.Controls.Add(this.tableLayoutPanel2);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Right.Location = new System.Drawing.Point(628, 20);
            this.panel_Right.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(152, 410);
            this.panel_Right.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FamilyDay2020_Display.Properties.Resources.P_副本;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(147, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::FamilyDay2020_Display.Properties.Resources.Control1;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_U, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_OK, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_L, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_R, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_D, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 210);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(152, 200);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_U
            // 
            this.lbl_U.BackColor = System.Drawing.Color.Transparent;
            this.lbl_U.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_U.Location = new System.Drawing.Point(53, 0);
            this.lbl_U.Name = "lbl_U";
            this.lbl_U.Size = new System.Drawing.Size(44, 66);
            this.lbl_U.TabIndex = 0;
            this.lbl_U.Click += new System.EventHandler(this.lbl_U_Click);
            // 
            // lbl_OK
            // 
            this.lbl_OK.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_OK.Location = new System.Drawing.Point(53, 66);
            this.lbl_OK.Name = "lbl_OK";
            this.lbl_OK.Size = new System.Drawing.Size(44, 66);
            this.lbl_OK.TabIndex = 1;
            this.lbl_OK.Text = " ";
            this.lbl_OK.Click += new System.EventHandler(this.lbl_OK_Click);
            // 
            // lbl_L
            // 
            this.lbl_L.BackColor = System.Drawing.Color.Transparent;
            this.lbl_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_L.Location = new System.Drawing.Point(3, 66);
            this.lbl_L.Name = "lbl_L";
            this.lbl_L.Size = new System.Drawing.Size(44, 66);
            this.lbl_L.TabIndex = 2;
            this.lbl_L.Text = " ";
            this.lbl_L.Click += new System.EventHandler(this.lbl_L_Click);
            // 
            // lbl_R
            // 
            this.lbl_R.BackColor = System.Drawing.Color.Transparent;
            this.lbl_R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_R.Location = new System.Drawing.Point(103, 66);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(46, 66);
            this.lbl_R.TabIndex = 3;
            this.lbl_R.Text = " ";
            this.lbl_R.Click += new System.EventHandler(this.lbl_R_Click);
            // 
            // lbl_D
            // 
            this.lbl_D.BackColor = System.Drawing.Color.Transparent;
            this.lbl_D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_D.Location = new System.Drawing.Point(53, 132);
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(44, 68);
            this.lbl_D.TabIndex = 4;
            this.lbl_D.Text = " ";
            this.lbl_D.Click += new System.EventHandler(this.lbl_D_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Display.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_X;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Y;
        private System.Windows.Forms.Panel panel_Display;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_U;
        private System.Windows.Forms.Label lbl_OK;
        private System.Windows.Forms.Label lbl_L;
        private System.Windows.Forms.Label lbl_R;
        private System.Windows.Forms.Label lbl_D;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Axis;
        private System.Windows.Forms.Panel panel_Axis1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

