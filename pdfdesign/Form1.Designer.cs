namespace pdfdesign
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pdfViewerShape = new PdfiumViewer.PdfViewer();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "LiveData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LiveData_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Print_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "ZoomOut";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "SaveAs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pdfViewerShape
            // 
            this.pdfViewerShape.AllowDrop = true;
            this.pdfViewerShape.AutoSize = true;
            this.pdfViewerShape.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.pdfViewerShape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdfViewerShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerShape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pdfViewerShape.Location = new System.Drawing.Point(3, 16);
            this.pdfViewerShape.Name = "pdfViewerShape";
            this.pdfViewerShape.ShowToolbar = false;
            this.pdfViewerShape.Size = new System.Drawing.Size(785, 400);
            this.pdfViewerShape.TabIndex = 2;
            this.pdfViewerShape.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitBest;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "ZoomIn";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pdfViewerShape);
            this.groupBox2.Location = new System.Drawing.Point(131, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 419);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PDF Live";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private PdfiumViewer.PdfViewer pdfViewerShape;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

