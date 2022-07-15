using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.matheval;

namespace CompilerProject
{
  public partial class Conditionals : Form
  {
    Regex r = new Regex(
      "^whenever\\((?<condition>(?:\\d+|(?:[a-zA-z_]\\w*))\\s*(==|!=|>|<|>=|<=)\\s*(?:\\d+|(?:[a-zA-z_]\\w*)))\\){$");

    public Conditionals()
    {
      InitializeComponent();
    }

    private void btn_Compile_Click(object sender, EventArgs e)
    {
      string[] lines = rtb_Code.Lines;
      for (int i = 0; i < lines.Length; i++)
      {
        if (r.IsMatch(lines[0]))
        {
          //i++;
          Match match = r.Match(lines[0]);
          string condition = match.Groups["condition"].Value;
          Expression exp = new Expression(condition);
          Boolean result = exp.Eval<Boolean>();
          if (result)
          {
            //if body begin executed
            if (!lines[i].Equals("}") && !r.IsMatch(lines[i]))
            {
              rtb_CompilationResult.Text += "if Code is beign executed\r\n";
              continue;
            }

            for (int j = i + 1; j < lines.Length; j++)
            {
              if (lines[j].Equals("}"))
              {
                i = j;
                break;
              }
            }
          }
          else
          {
            while (!lines[i].Equals("else{"))
            {
              i++;
            }

            for (int j = i + 1; j < lines.Length; j++)
            {
              if (!lines[j].Equals("}"))
              {
                rtb_CompilationResult.Text += "else body beign executed\r\n";
                continue;
              }

              i = j + 1;
              break;
            }
          }
        }
      }
    }
  }
}