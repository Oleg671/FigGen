
namespace Zatmenie
{
    partial class Izmen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xn = new System.Windows.Forms.NumericUpDown();
            this.yn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wn = new System.Windows.Forms.NumericUpDown();
            this.hn = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.xn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hn)).BeginInit();
            this.SuspendLayout();
            // 
            // xn
            // 
            this.xn.Location = new System.Drawing.Point(34, 335);
            this.xn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.xn.Name = "xn";
            this.xn.Size = new System.Drawing.Size(120, 22);
            this.xn.TabIndex = 1;
            this.xn.ValueChanged += new System.EventHandler(this.xn_ValueChanged);
            // 
            // yn
            // 
            this.yn.Location = new System.Drawing.Point(34, 363);
            this.yn.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.yn.Name = "yn";
            this.yn.Size = new System.Drawing.Size(120, 22);
            this.yn.TabIndex = 2;
            this.yn.ValueChanged += new System.EventHandler(this.yn_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Положение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Размер";
            // 
            // wn
            // 
            this.wn.Location = new System.Drawing.Point(224, 335);
            this.wn.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.wn.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wn.Name = "wn";
            this.wn.Size = new System.Drawing.Size(120, 22);
            this.wn.TabIndex = 7;
            this.wn.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wn.ValueChanged += new System.EventHandler(this.wn_ValueChanged);
            // 
            // hn
            // 
            this.hn.Location = new System.Drawing.Point(224, 366);
            this.hn.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.hn.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hn.Name = "hn";
            this.hn.Size = new System.Drawing.Size(120, 22);
            this.hn.TabIndex = 8;
            this.hn.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hn.ValueChanged += new System.EventHandler(this.hn_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "w:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "h:";
            // 
            // CB
            // 
            this.CB.Location = new System.Drawing.Point(65, 407);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(247, 41);
            this.CB.TabIndex = 11;
            this.CB.Text = "Цвет";
            this.CB.UseVisualStyleBackColor = true;
            this.CB.Click += new System.EventHandler(this.CB_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 300);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Izmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 478);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hn);
            this.Controls.Add(this.wn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yn);
            this.Controls.Add(this.xn);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(400, 525);
            this.MinimumSize = new System.Drawing.Size(400, 525);
            this.Name = "Izmen";
            this.Text = "Izmen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Izmen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.xn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown xn;
        private System.Windows.Forms.NumericUpDown yn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown wn;
        private System.Windows.Forms.NumericUpDown hn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CB;
        private System.Windows.Forms.Panel panel1;
    }
}