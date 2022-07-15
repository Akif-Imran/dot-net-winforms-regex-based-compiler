using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerProject
{
  public partial class ReadInputExample : Form
  {
    private static readonly Dictionary<string, int> integerTable = new Dictionary<string, int>();

    public ReadInputExample()
    {
      InitializeComponent();
    }

    private void btn_Compile_Click(object sender, EventArgs e)
    {
    }

    private void ReadInputExample_Load(object sender, EventArgs e)
    {
      integerTable.Add("akif", 0);
    }
  }
}