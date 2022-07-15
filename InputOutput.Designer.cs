
namespace CompilerProject
{
  partial class InputOutput
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
	 this.gb_Code = new System.Windows.Forms.GroupBox();
	 this.rtb_Code = new System.Windows.Forms.RichTextBox();
	 this.gb_CompilationResult = new System.Windows.Forms.GroupBox();
	 this.rtb_CompilationResult = new System.Windows.Forms.RichTextBox();
	 this.btn_Reset = new System.Windows.Forms.Button();
	 this.btn_Compile = new System.Windows.Forms.Button();
	 this.gb_Error = new System.Windows.Forms.GroupBox();
	 this.rtb_Errors = new System.Windows.Forms.RichTextBox();
	 this.gb_Code.SuspendLayout();
	 this.gb_CompilationResult.SuspendLayout();
	 this.gb_Error.SuspendLayout();
	 this.SuspendLayout();
	 // 
	 // gb_Code
	 // 
	 this.gb_Code.Controls.Add(this.rtb_Code);
	 this.gb_Code.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.gb_Code.Location = new System.Drawing.Point(12, 12);
	 this.gb_Code.Name = "gb_Code";
	 this.gb_Code.Size = new System.Drawing.Size(543, 292);
	 this.gb_Code.TabIndex = 6;
	 this.gb_Code.TabStop = false;
	 this.gb_Code.Text = "Code";
	 // 
	 // rtb_Code
	 // 
	 this.rtb_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
	 this.rtb_Code.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.rtb_Code.Location = new System.Drawing.Point(6, 24);
	 this.rtb_Code.Name = "rtb_Code";
	 this.rtb_Code.Size = new System.Drawing.Size(531, 262);
	 this.rtb_Code.TabIndex = 0;
	 this.rtb_Code.Text = "";
	 // 
	 // gb_CompilationResult
	 // 
	 this.gb_CompilationResult.BackColor = System.Drawing.SystemColors.Control;
	 this.gb_CompilationResult.Controls.Add(this.rtb_CompilationResult);
	 this.gb_CompilationResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.gb_CompilationResult.ForeColor = System.Drawing.Color.ForestGreen;
	 this.gb_CompilationResult.Location = new System.Drawing.Point(561, 12);
	 this.gb_CompilationResult.Name = "gb_CompilationResult";
	 this.gb_CompilationResult.Size = new System.Drawing.Size(227, 325);
	 this.gb_CompilationResult.TabIndex = 7;
	 this.gb_CompilationResult.TabStop = false;
	 this.gb_CompilationResult.Text = "Result";
	 // 
	 // rtb_CompilationResult
	 // 
	 this.rtb_CompilationResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
	 this.rtb_CompilationResult.Enabled = false;
	 this.rtb_CompilationResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.rtb_CompilationResult.Location = new System.Drawing.Point(6, 24);
	 this.rtb_CompilationResult.Name = "rtb_CompilationResult";
	 this.rtb_CompilationResult.Size = new System.Drawing.Size(215, 295);
	 this.rtb_CompilationResult.TabIndex = 1;
	 this.rtb_CompilationResult.Text = "";
	 // 
	 // btn_Reset
	 // 
	 this.btn_Reset.AutoSize = true;
	 this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.btn_Reset.Location = new System.Drawing.Point(337, 310);
	 this.btn_Reset.Name = "btn_Reset";
	 this.btn_Reset.Size = new System.Drawing.Size(106, 27);
	 this.btn_Reset.TabIndex = 10;
	 this.btn_Reset.Text = "Reset";
	 this.btn_Reset.UseVisualStyleBackColor = true;
	 this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
	 // 
	 // btn_Compile
	 // 
	 this.btn_Compile.AutoSize = true;
	 this.btn_Compile.BackColor = System.Drawing.SystemColors.ControlLight;
	 this.btn_Compile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
	 this.btn_Compile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.btn_Compile.ForeColor = System.Drawing.SystemColors.ControlText;
	 this.btn_Compile.Location = new System.Drawing.Point(449, 310);
	 this.btn_Compile.Name = "btn_Compile";
	 this.btn_Compile.Size = new System.Drawing.Size(106, 27);
	 this.btn_Compile.TabIndex = 9;
	 this.btn_Compile.Text = "Compile";
	 this.btn_Compile.UseVisualStyleBackColor = false;
	 this.btn_Compile.Click += new System.EventHandler(this.btn_Compile_Click);
	 // 
	 // gb_Error
	 // 
	 this.gb_Error.Controls.Add(this.rtb_Errors);
	 this.gb_Error.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.gb_Error.ForeColor = System.Drawing.Color.DarkRed;
	 this.gb_Error.Location = new System.Drawing.Point(12, 343);
	 this.gb_Error.Name = "gb_Error";
	 this.gb_Error.Size = new System.Drawing.Size(776, 157);
	 this.gb_Error.TabIndex = 8;
	 this.gb_Error.TabStop = false;
	 this.gb_Error.Text = "Error";
	 this.gb_Error.Visible = false;
	 // 
	 // rtb_Errors
	 // 
	 this.rtb_Errors.BorderStyle = System.Windows.Forms.BorderStyle.None;
	 this.rtb_Errors.Enabled = false;
	 this.rtb_Errors.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.rtb_Errors.ForeColor = System.Drawing.Color.DarkRed;
	 this.rtb_Errors.Location = new System.Drawing.Point(6, 24);
	 this.rtb_Errors.Name = "rtb_Errors";
	 this.rtb_Errors.Size = new System.Drawing.Size(764, 127);
	 this.rtb_Errors.TabIndex = 0;
	 this.rtb_Errors.Text = "";
	 // 
	 // InputOutput
	 // 
	 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	 this.ClientSize = new System.Drawing.Size(800, 344);
	 this.Controls.Add(this.gb_Code);
	 this.Controls.Add(this.gb_CompilationResult);
	 this.Controls.Add(this.btn_Reset);
	 this.Controls.Add(this.btn_Compile);
	 this.Controls.Add(this.gb_Error);
	 this.Name = "InputOutput";
	 this.Text = "InputOutput";
	 this.gb_Code.ResumeLayout(false);
	 this.gb_CompilationResult.ResumeLayout(false);
	 this.gb_Error.ResumeLayout(false);
	 this.ResumeLayout(false);
	 this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox gb_Code;
    private System.Windows.Forms.RichTextBox rtb_Code;
    private System.Windows.Forms.GroupBox gb_CompilationResult;
    private System.Windows.Forms.RichTextBox rtb_CompilationResult;
    private System.Windows.Forms.Button btn_Reset;
    private System.Windows.Forms.Button btn_Compile;
    private System.Windows.Forms.GroupBox gb_Error;
    private System.Windows.Forms.RichTextBox rtb_Errors;
  }
}