namespace TapTempo
{
  partial class fmMain
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
      this.bnTap = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // bnTap
      // 
      this.bnTap.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.bnTap.Location = new System.Drawing.Point(12, 12);
      this.bnTap.Name = "bnTap";
      this.bnTap.Size = new System.Drawing.Size(135, 135);
      this.bnTap.TabIndex = 0;
      this.bnTap.Text = "TAP";
      this.bnTap.UseVisualStyleBackColor = true;
      // 
      // fmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(466, 310);
      this.Controls.Add(this.bnTap);
      this.Name = "fmMain";
      this.Text = "Tap Tempo";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button bnTap;
  }
}

