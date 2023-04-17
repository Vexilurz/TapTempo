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
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.sbInfo = new System.Windows.Forms.ToolStripStatusLabel();
      this.listLeft = new System.Windows.Forms.ListBox();
      this.statusStrip1.SuspendLayout();
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
      this.bnTap.Click += new System.EventHandler(this.bnTap_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbInfo});
      this.statusStrip1.Location = new System.Drawing.Point(0, 303);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(481, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // sbInfo
      // 
      this.sbInfo.Name = "sbInfo";
      this.sbInfo.Size = new System.Drawing.Size(39, 17);
      this.sbInfo.Text = "Ready";
      // 
      // listLeft
      // 
      this.listLeft.Dock = System.Windows.Forms.DockStyle.Right;
      this.listLeft.FormattingEnabled = true;
      this.listLeft.Location = new System.Drawing.Point(294, 0);
      this.listLeft.Name = "listLeft";
      this.listLeft.Size = new System.Drawing.Size(187, 303);
      this.listLeft.TabIndex = 2;
      // 
      // fmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(481, 325);
      this.Controls.Add(this.listLeft);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.bnTap);
      this.Name = "fmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tap Tempo";
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button bnTap;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel sbInfo;
    private System.Windows.Forms.ListBox listLeft;
  }
}

