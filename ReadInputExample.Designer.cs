
namespace CompilerProject
{
  partial class ReadInputExample
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
	 this.rtb_Code = new System.Windows.Forms.RichTextBox();
	 this.btn_Compile = new System.Windows.Forms.Button();
	 this.SuspendLayout();
	 // 
	 // rtb_Code
	 // 
	 this.rtb_Code.Location = new System.Drawing.Point(56, 32);
	 this.rtb_Code.Name = "rtb_Code";
	 this.rtb_Code.Size = new System.Drawing.Size(330, 150);
	 this.rtb_Code.TabIndex = 0;
	 this.rtb_Code.Text = "";
	 // 
	 // btn_Compile
	 // 
	 this.btn_Compile.Location = new System.Drawing.Point(311, 188);
	 this.btn_Compile.Name = "btn_Compile";
	 this.btn_Compile.Size = new System.Drawing.Size(75, 23);
	 this.btn_Compile.TabIndex = 1;
	 this.btn_Compile.Text = "Compile";
	 this.btn_Compile.UseVisualStyleBackColor = true;
	 this.btn_Compile.Click += new System.EventHandler(this.btn_Compile_Click);
	 // 
	 // ReadInputExample
	 // 
	 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	 this.ClientSize = new System.Drawing.Size(800, 450);
	 this.Controls.Add(this.btn_Compile);
	 this.Controls.Add(this.rtb_Code);
	 this.Name = "ReadInputExample";
	 this.Text = "ReadInputExample";
	 this.Load += new System.EventHandler(this.ReadInputExample_Load);
	 this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtb_Code;
    private System.Windows.Forms.Button btn_Compile;
  }
}