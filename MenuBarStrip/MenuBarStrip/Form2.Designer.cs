namespace MenuBarStrip
{
partial class Form2
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.SuspendLayout();
        // Form2
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.LightCoral; // Pink/Coral color
        this.ClientSize = new System.Drawing.Size(400, 300);
        this.Name = "Form2";
        this.Text = "Form2";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized; // Fills the parent space
        this.ResumeLayout(false);
    }
}
}