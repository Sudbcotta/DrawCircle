namespace DrawCircle
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
            pnlPaint = new Panel();
            SuspendLayout();
            // 
            // pnlPaint
            // 
            pnlPaint.Location = new Point(14, 15);
            pnlPaint.Name = "pnlPaint";
            pnlPaint.Size = new Size(771, 419);
            pnlPaint.TabIndex = 0;
            pnlPaint.Paint += panel1_Paint;
            pnlPaint.MouseClick += pnlPaint_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPaint);
            Name = "Form1";
            Text = "DrawImage";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPaint;
    }
}