namespace Simon_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_1 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_0 = new System.Windows.Forms.PictureBox();
            this.pb_3 = new System.Windows.Forms.PictureBox();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.pb_2 = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.tb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_1
            // 
            this.tb_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_1.ColumnCount = 2;
            this.tb_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_1.Controls.Add(this.pb_0, 0, 0);
            this.tb_1.Controls.Add(this.pb_3, 1, 1);
            this.tb_1.Controls.Add(this.pb_1, 1, 0);
            this.tb_1.Controls.Add(this.pb_2, 0, 1);
            this.tb_1.Location = new System.Drawing.Point(43, 129);
            this.tb_1.Name = "tb_1";
            this.tb_1.RowCount = 2;
            this.tb_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_1.Size = new System.Drawing.Size(300, 284);
            this.tb_1.TabIndex = 0;
            // 
            // pb_0
            // 
            this.pb_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_0.Image = global::Simon_Project.Properties.Resources.R1;
            this.pb_0.Location = new System.Drawing.Point(3, 3);
            this.pb_0.Name = "pb_0";
            this.pb_0.Size = new System.Drawing.Size(144, 136);
            this.pb_0.TabIndex = 1;
            this.pb_0.TabStop = false;
            this.pb_0.Click += new System.EventHandler(this.pb_Click);
            this.pb_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_0_MouseDown);
            this.pb_0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_0_MouseUp);
            // 
            // pb_3
            // 
            this.pb_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_3.Image = global::Simon_Project.Properties.Resources.B2;
            this.pb_3.Location = new System.Drawing.Point(153, 145);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(144, 136);
            this.pb_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_3.TabIndex = 2;
            this.pb_3.TabStop = false;
            this.pb_3.Click += new System.EventHandler(this.pb_Click);
            this.pb_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_3_MouseDown);
            this.pb_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_3_MouseUp);
            // 
            // pb_1
            // 
            this.pb_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_1.Image")));
            this.pb_1.Location = new System.Drawing.Point(153, 3);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(144, 136);
            this.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_1.TabIndex = 0;
            this.pb_1.TabStop = false;
            this.pb_1.Click += new System.EventHandler(this.pb_Click);
            this.pb_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_1_MouseDown);
            this.pb_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_1_MouseUp);
            // 
            // pb_2
            // 
            this.pb_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_2.Image = global::Simon_Project.Properties.Resources.G1;
            this.pb_2.Location = new System.Drawing.Point(3, 145);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(144, 136);
            this.pb_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_2.TabIndex = 3;
            this.pb_2.TabStop = false;
            this.pb_2.Click += new System.EventHandler(this.pb_Click);
            this.pb_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_2_MouseDown);
            this.pb_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_2_MouseUp);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn.Location = new System.Drawing.Point(46, 40);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(141, 67);
            this.btn.TabIndex = 1;
            this.btn.Text = "Start";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_1.Location = new System.Drawing.Point(226, 57);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(117, 36);
            this.lb_1.TabIndex = 2;
            this.lb_1.Text = "Score:0";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_2.Location = new System.Drawing.Point(85, 438);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(177, 36);
            this.lb_2.TabIndex = 3;
            this.lb_2.Text = "High Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 497);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tb_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tb_1;
        private PictureBox pb_1;
        private PictureBox pb_0;
        private PictureBox pb_2;
        private PictureBox pb_3;
        private Button btn;
        private Label lb_1;
        private Label lb_2;
    }
}