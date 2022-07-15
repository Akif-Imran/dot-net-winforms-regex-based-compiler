using System;
using System.Collections;
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
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    // //private static readonly Regex VarIntDecleration = new Regex(@"^(int)\s+(?<varialbeName>[a-zA-z_]\w*)\s*=?\s*\d*;$");
    // private static readonly Regex VarIntDecleration =
    //   new Regex(@"^(num)\s+(?<variableName>[a-zA-z_]\w*)(\s*=\s*(?<variableValue>\d+))?;$");
    //
    // private static readonly Regex VarIntAssignment =
    //   new Regex(@"^(?<variableName>[a-zA-z_]\w*)\s*=\s*(?<variableValue>\d+);$");
    //
    // //dictionary containing variable names and their values for int datatype.
    // private static readonly Dictionary<string, int> IntegerTable = new Dictionary<string, int>();
    //
    // //a list of variable names keeping track of already initialized variables.
    // private static readonly List<string> initializedVariables = new List<string>();
    //
    //
    // private void btn_Compile_Click(object sender, EventArgs e)
    // {
    //   ClearCompile();
    //   bool syntaxResult = SyntaxChecker(rtb_Code);
    //   if (syntaxResult) rtb_Errors.Text += "Build Successful\r\n";
    // }
    //
    // private void ClearCompile()
    // {
    //   rtb_Errors.Text = string.Empty;
    //   rtb_CompilationResult.Text = string.Empty;
    // }
    //
    // private void btn_Reset_Click(object sender, EventArgs e)
    // {
    //   Clear();
    // }
    //
    // private void Clear()
    // {
    //   rtb_Code.Text = string.Empty;
    //   rtb_Errors.Text = string.Empty;
    //   rtb_CompilationResult.Text = string.Empty;
    //   IntegerTable.Clear();
    //   initializedVariables.Clear();
    // }
    //
    // //method that handles all syntax verification related to int
    // private bool VarIntSyntax(string line, int lineNo)
    // {
    //   bool isBeginDeclared = VarIntDecleration.IsMatch(line);
    //   bool isBeginAssigned = VarIntAssignment.IsMatch(line);
    //   if (isBeginDeclared)
    //   {
    //     Match match = VarIntDecleration.Match(line);
    //     string name = match.Groups["variableName"].Value;
    //     string value = match.Groups["variableValue"].Value;
    //     if (value == string.Empty)
    //     {
    //       IntegerTable[name] = 0;
    //     }
    //     else
    //     {
    //       IntegerTable[name] = int.Parse(value);
    //     }
    //
    //     initializedVariables.Add(match.Groups["variableName"].Value);
    //   }
    //
    //   //check if value is being assigned
    //   if (isBeginAssigned)
    //   {
    //     Match match = VarIntAssignment.Match(line);
    //     //check if variable is declared before value is assigned
    //     if (initializedVariables.Contains(match.Groups["variableName"].Value))
    //     {
    //       IntegerTable[match.Groups["variableName"].Value] = int.Parse(match.Groups["variableValue"].Value);
    //     }
    //     else
    //     {
    //       rtb_Errors.Text += $"Varible not initialized before assignment at line {lineNo}\r\n";
    //     }
    //   }
    //
    //   if (isBeginAssigned == false && isBeginDeclared == false)
    //   {
    //     rtb_Errors.Text += $"Incorrect syntax at line {lineNo}\r\n";
    //   }
    //
    //   return isBeginAssigned || isBeginDeclared;
    // }
    //
    // private bool SyntaxChecker(RichTextBox code)
    // {
    //   var lines = code.Lines;
    //   bool result = true;
    //   for (int i = 0; i < lines.Length; i++)
    //   {
    //     //check for int datatype
    //     result = VarIntSyntax(lines[i], i + 1);
    //     //if syntax for int fails return false
    //     if (!result) return false;
    //   }
    //
    //   return true;
    // }

    private void btn_InputOutputForm_Click(object sender, EventArgs e)
    {
      InputOutput inputOutput = new InputOutput();
      inputOutput.ShowDialog();
    }

    private void btn_Conditionals_Click(object sender, EventArgs e)
    {
      Conditionals conditionalsForms = new Conditionals();
      conditionalsForms.ShowDialog();
    }
  }
}