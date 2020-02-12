namespace Fractal
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
            this.components = new System.ComponentModel.Container();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSierpinski = new System.Windows.Forms.Button();
            this.btnBarnsley = new System.Windows.Forms.Button();
            this.tmrBarnsley = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(646, 563);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(691, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSierpinski
            // 
            this.btnSierpinski.Location = new System.Drawing.Point(691, 170);
            this.btnSierpinski.Name = "btnSierpinski";
            this.btnSierpinski.Size = new System.Drawing.Size(147, 40);
            this.btnSierpinski.TabIndex = 2;
            this.btnSierpinski.Text = "Sierpinski triangle";
            this.btnSierpinski.UseVisualStyleBackColor = true;
            this.btnSierpinski.Click += new System.EventHandler(this.btnSierpinskiTriangle_Click);
            // 
            // btnBarnsley
            // 
            this.btnBarnsley.Location = new System.Drawing.Point(691, 225);
            this.btnBarnsley.Name = "btnBarnsley";
            this.btnBarnsley.Size = new System.Drawing.Size(147, 40);
            this.btnBarnsley.TabIndex = 3;
            this.btnBarnsley.Text = "Barnsley fern";
            this.btnBarnsley.UseVisualStyleBackColor = true;
            this.btnBarnsley.Click += new System.EventHandler(this.btnBarnsleyfern_Click);
            // 
            // tmrBarnsley
            // 
            this.tmrBarnsley.Interval = 10;
            this.tmrBarnsley.Tick += new System.EventHandler(this.tmrBarnsley_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 587);
            this.Controls.Add(this.btnBarnsley);
            this.Controls.Add(this.btnSierpinski);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "Fractal Image";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSierpinski;
        private System.Windows.Forms.Button btnBarnsley;
        private System.Windows.Forms.Timer tmrBarnsley;
    }
}