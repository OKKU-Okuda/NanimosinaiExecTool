using System.ComponentModel;

namespace NanimosinaiExecTool;

partial class SubProgress
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        progressBar1 = new System.Windows.Forms.ProgressBar();
        textBox1 = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // progressBar1
        // 
        progressBar1.Location = new System.Drawing.Point(12, 12);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new System.Drawing.Size(406, 23);
        progressBar1.TabIndex = 0;
        // 
        // textBox1
        // 
        textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
        textBox1.Location = new System.Drawing.Point(0, 41);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new System.Drawing.Size(442, 37);
        textBox1.TabIndex = 1;
        // 
        // SubProgress
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(442, 78);
        ControlBox = false;
        Controls.Add(textBox1);
        Controls.Add(progressBar1);
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "SubProgress";
        Load += SubProgress_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.ProgressBar progressBar1;

    #endregion
}