using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerProject
{
  public partial class Input : Form
  {
    public string Value { get; private set; }

    public Input()
    {
      InitializeComponent();
    }

    private void btn_Enter_Click(object sender, EventArgs e)
    {
      if (tb_Input.Text == string.Empty)
      {
        MessageBox.Show("Value cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      Value = tb_Input.Text;
      Close();
    }
  }
}