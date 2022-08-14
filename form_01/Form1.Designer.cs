namespace form_01;

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
        this.action = new System.Windows.Forms.Button();
        this.actionAsync = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // action
        //
        this.action.Location = new System.Drawing.Point(92, 62);
        this.action.Name = "action";
        this.action.Size = new System.Drawing.Size(75, 23);
        this.action.TabIndex = 0;
        this.action.Text = "実行";
        this.action.UseVisualStyleBackColor = true;
        this.action.Click += new System.EventHandler(this.action_Click);
        //
        // actionAsync
        //
        this.actionAsync.Location = new System.Drawing.Point(92+100, 62);
        this.actionAsync.Name = "actionAsync";
        this.actionAsync.Size = new System.Drawing.Size(75+20, 23);
        this.actionAsync.TabIndex = 0;
        this.actionAsync.Text = "非同期実行";
        this.actionAsync.UseVisualStyleBackColor = true;
        this.actionAsync.Click += new System.EventHandler(this.action_ClickAsync);
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.action);
        this.Controls.Add(this.actionAsync);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Form1";
        this.ResumeLayout(false);

    }

    #endregion

    private Button action;
    private Button actionAsync;
}
