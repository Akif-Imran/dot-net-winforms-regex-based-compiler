
namespace CompilerProject
{
  partial class Conditionals
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
	 this.btn_Compile = new System.Windows.Forms.Button();
	 this.rtb_Code = new System.Windows.Forms.RichTextBox();
	 this.rtb_CompilationResult = new System.Windows.Forms.RichTextBox();
	 this.SuspendLayout();
	 // 
	 // btn_Compile
	 // 
	 this.btn_Compile.Location = new System.Drawing.Point(382, 175);
	 this.btn_Compile.Name = "btn_Compile";
	 this.btn_Compile.Size = new System.Drawing.Size(75, 23);
	 this.btn_Compile.TabIndex = 0;
	 this.btn_Compile.Text = "Compile";
	 this.btn_Compile.UseVisualStyleBackColor = true;
	 this.btn_Compile.Click += new System.EventHandler(this.btn_Compile_Click);
	 // 
	 // rtb_Code
	 // 
	 this.rtb_Code.Location = new System.Drawing.Point(12, 12);
	 this.rtb_Code.Name = "rtb_Code";
	 this.rtb_Code.Size = new System.Drawing.Size(445, 157);
	 this.rtb_Code.TabIndex = 1;
	 this.rtb_Code.Text = "";
	 // 
	 // rtb_CompilationResult
	 // 
	 this.rtb_CompilationResult.Location = new System.Drawing.Point(12, 204);
	 this.rtb_CompilationResult.Name = "rtb_CompilationResult";
	 this.rtb_CompilationResult.Size = new System.Drawing.Size(445, 147);
	 this.rtb_CompilationResult.TabIndex = 2;
	 this.rtb_CompilationResult.Text = "";
	 // 
	 // Conditionals
	 // 
	 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	 this.ClientSize = new System.Drawing.Size(465, 363);
	 this.Controls.Add(this.rtb_CompilationResult);
	 this.Controls.Add(this.rtb_Code);
	 this.Controls.Add(this.btn_Compile);
	 this.Name = "Conditionals";
	 this.Text = "Conditionals";
	 this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_Compile;
    private System.Windows.Forms.RichTextBox rtb_Code;
    private System.Windows.Forms.RichTextBox rtb_CompilationResult;
  }
}