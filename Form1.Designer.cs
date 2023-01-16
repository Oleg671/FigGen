
namespace Zatmenie
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rectal = new System.Windows.Forms.NumericUpDown();
            this.Ellay = new System.Windows.Forms.NumericUpDown();
            this.emigrant = new System.Windows.Forms.NumericUpDown();
            this.Info = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rectal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ellay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emigrant)).BeginInit();
            this.SuspendLayout();
            // 
            // Rectal
            // 
            this.Rectal.Location = new System.Drawing.Point(0, 0);
            this.Rectal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rectal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rectal.Name = "Rectal";
            this.Rectal.Size = new System.Drawing.Size(120, 22);
            this.Rectal.TabIndex = 0;
            this.Rectal.ValueChanged += new System.EventHandler(this.Rectal_ValueChanged);
            // 
            // Ellay
            // 
            this.Ellay.Location = new System.Drawing.Point(0, 28);
            this.Ellay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ellay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Ellay.Name = "Ellay";
            this.Ellay.Size = new System.Drawing.Size(120, 22);
            this.Ellay.TabIndex = 1;
            this.Ellay.ValueChanged += new System.EventHandler(this.Ellay_ValueChanged);
            // 
            // emigrant
            // 
            this.emigrant.Location = new System.Drawing.Point(0, 57);
            this.emigrant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emigrant.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.emigrant.Name = "emigrant";
            this.emigrant.Size = new System.Drawing.Size(120, 22);
            this.emigrant.TabIndex = 2;
            this.emigrant.ValueChanged += new System.EventHandler(this.emigrant_ValueChanged);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(12, 147);
            this.Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(77, 28);
            this.Info.TabIndex = 3;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 83);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(77, 28);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(12, 115);
            this.Load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(77, 28);
            this.Load.TabIndex = 5;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.emigrant);
            this.Controls.Add(this.Ellay);
            this.Controls.Add(this.Rectal);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Rectal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ellay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emigrant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Rectal;
        private System.Windows.Forms.NumericUpDown Ellay;
        private System.Windows.Forms.NumericUpDown emigrant;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
    }
}

