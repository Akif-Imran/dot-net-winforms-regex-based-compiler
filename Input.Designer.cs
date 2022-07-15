
namespace CompilerProject
{
  partial class Input
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
	 this.lbl_Input = new System.Windows.Forms.Label();
	 this.tb_Input = new System.Windows.Forms.TextBox();
	 this.btn_Enter = new System.Windows.Forms.Button();
	 this.SuspendLayout();
	 // 
	 // lbl_Input
	 // 
	 this.lbl_Input.AutoSize = true;
	 this.lbl_Input.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.lbl_Input.Location = new System.Drawing.Point(12, 16);
	 this.lbl_Input.Name = "lbl_Input";
	 this.lbl_Input.Size = new System.Drawing.Size(80, 17);
	 this.lbl_Input.TabIndex = 0;
	 this.lbl_Input.Text = "Enter Value :";
	 // 
	 // tb_Input
	 // 
	 this.tb_Input.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.tb_Input.Location = new System.Drawing.Point(98, 12);
	 this.tb_Input.Name = "tb_Input";
	 this.tb_Input.Size = new System.Drawing.Size(141, 25);
	 this.tb_Input.TabIndex = 1;
	 // 
	 // btn_Enter
	 // 
	 this.btn_Enter.AutoSize = true;
	 this.btn_Enter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	 this.btn_Enter.Location = new System.Drawing.Point(15, 43);
	 this.btn_Enter.Name = "btn_Enter";
	 this.btn_Enter.Size = new System.Drawing.Size(224, 27);
	 this.btn_Enter.TabIndex = 2;
	 this.btn_Enter.Text = "Enter";
	 this.btn_Enter.UseVisualStyleBackColor = true;
	 this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
	 // 
	 // Input
	 // 
	 this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	 this.ClientSize = new System.Drawing.Size(251, 82);
	 this.Controls.Add(this.btn_Enter);
	 this.Controls.Add(this.tb_Input);
	 this.Controls.Add(this.lbl_Input);
	 this.Name = "Input";
	 this.Text = "Input";
	 this.ResumeLayout(false);
	 this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_Input;
    private System.Windows.Forms.TextBox tb_Input;
    private System.Windows.Forms.Button btn_Enter;
  }
}