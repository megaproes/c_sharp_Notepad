
using System;

namespace SimpleNotepad
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filestrip = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.Font = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filestrip,
            this.Format});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "File";
            // 
            // filestrip
            // 
            this.filestrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save,
            this.SaveAs});
            this.filestrip.Name = "filestrip";
            this.filestrip.Size = new System.Drawing.Size(37, 20);
            this.filestrip.Text = "File";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(123, 22);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.NewClick);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(123, 22);
            this.Open.Text = "Open...";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(123, 22);
            this.SaveAs.Text = "Save As...";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrap,
            this.Font,
            this.ColorStrip});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(57, 20);
            this.Format.Text = "Format";
            // 
            // WordWrap
            // 
            this.WordWrap.Name = "WordWrap";
            this.WordWrap.Size = new System.Drawing.Size(132, 22);
            this.WordWrap.Text = "Word wrap";
            // 
            // Font
            // 
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(132, 22);
            this.Font.Text = "Font";
            // 
            // ColorStrip
            // 
            this.ColorStrip.Name = "ColorStrip";
            this.ColorStrip.Size = new System.Drawing.Size(132, 22);
            this.ColorStrip.Text = "Color";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(824, 414);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       











        #endregion

        protected System.Windows.Forms.SaveFileDialog saveFileDialog1;
        protected System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem filestrip;
        protected System.Windows.Forms.ToolStripMenuItem New;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        protected System.Windows.Forms.ToolStripMenuItem Open;
        protected System.Windows.Forms.ToolStripMenuItem Save;
        protected System.Windows.Forms.ToolStripMenuItem SaveAs;
        protected System.Windows.Forms.ToolStripMenuItem Format;
        protected System.Windows.Forms.ToolStripMenuItem WordWrap;
        protected System.Windows.Forms.ToolStripMenuItem Font;
        protected System.Windows.Forms.ToolStripMenuItem ColorStrip;
        protected System.Windows.Forms.TextBox textBox1;
    }
}

