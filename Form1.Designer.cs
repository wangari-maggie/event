namespace EventApp;

partial class Form1 : Form  
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
        click = new Button();
        label1 = new Label();
        txtinput = new TextBox();
        SuspendLayout();
        // 
        // click
        // 
        click.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        click.BackColor = Color.FromArgb(128, 255, 255);
        click.Enabled = false;
        click.Location = new Point(51, 298);
        click.Name = "click";
        click.Size = new Size(225, 75);
        click.TabIndex = 0;
        click.Text = "button1";
        click.UseVisualStyleBackColor = false;
        click.Click += button1_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.BackColor = Color.Cyan;
        label1.Location = new Point(51, 48);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 1;
        label1.Text = "label1";
        label1.Click += label1_Click;
        // 
        // txtinput
        // 
        txtinput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtinput.BackColor = Color.FromArgb(0, 192, 192);
        txtinput.Location = new Point(51, 102);
        txtinput.Name = "txtinput";
        txtinput.Size = new Size(258, 27);
        txtinput.TabIndex = 2;
        txtinput.TextChanged += txtinput_TextChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(192, 0, 192);
        ClientSize = new Size(800, 450);
        Controls.Add(txtinput);
        Controls.Add(label1);
        Controls.Add(click);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button click;
    private Label label1;
    private TextBox txtinput;
}
