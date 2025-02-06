namespace NanimosinaiExecTool;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        progressBar1 = new System.Windows.Forms.ProgressBar();
        MainProgressText = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // progressBar1
        // 
        progressBar1.Location = new System.Drawing.Point(12, 57);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new System.Drawing.Size(395, 23);
        progressBar1.TabIndex = 0;
        // 
        // MainProgressText
        // 
        MainProgressText.AutoSize = true;
        MainProgressText.Location = new System.Drawing.Point(12, 25);
        MainProgressText.Name = "MainProgressText";
        MainProgressText.Size = new System.Drawing.Size(0, 15);
        MainProgressText.TabIndex = 2;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(12, 99);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 3;
        button1.Text = "Exec";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(444, 203);
        Controls.Add(button1);
        Controls.Add(MainProgressText);
        Controls.Add(progressBar1);
        ShowIcon = false;
        Text = "Command Executor";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label MainProgressText;

    private System.Windows.Forms.ProgressBar progressBar1;

    #endregion
}