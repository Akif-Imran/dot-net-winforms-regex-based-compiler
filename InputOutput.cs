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
using org.matheval;

namespace CompilerProject
{
  public partial class InputOutput : Form
  {
    private static readonly Regex[] expressions =
	 new Regex[]
	 {
        //0 => output
        new Regex("^out\\(\"(?<value>.*)\"(?:\\s*\\+\\s*(?<variableName>[a-zA-Z_]\\w*))?\\);$"),
        //1 => integer decleration and initialization
        new Regex(@"^(?<dataType>num)\s+(?<variableName>[a-zA-z_]\w*)(\s*=\s*(?<variableValue>\d+))?;$"),
        //2 =>integer assignment
        new Regex("^(?<variableName>[a-zA-z_]\\w*)\\s*=\\s*(?<variableValue>(?:\\d+|\"(?:.*)\"));$"),
        //3 => output(variable);
        new Regex("^out\\((?<variableName>[a-zA-Z_]\\w*)?\\);$"),
        //4 => string decleration and initialization
        new Regex("^(?<dataType>str)\\s+(?<variableName>[a-zA-z_]\\w*)(?:\\s*=\\s*\"(?<variableValue>.*)\")?;$"),
        //5 => arithematic expressions
        new Regex(
		"^(?<variableName>[a-zA-z_]\\w*)\\s*=\\s*(?<expression>(?:\\d+|(?:[a-zA-z_]\\w*))(\\s*[+\\-*/]\\s*(?:\\d+|(?:[a-zA-z_]\\w*)))+);$"),
        //6 input
        new Regex("^in\\((?<variableName>[a-zA-Z_]\\w*)?\\);$"),
        //7 if condition
        new Regex(
		"^whenever\\((?<condition>(?:\\d+|(?:[a-zA-z_]\\w*))\\s*(==|!=|>|<|>=|<=)\\s*(?:\\d+|(?:[a-zA-z_]\\w*)))\\){$"),
        // 8 for loop
        new Regex(
		"^during\\((?<initialization>(?<dataType>num)\\s+(?<variableName>[a-zA-z_]\\w*)\\s*=\\s*(?<variableValue>\\d+);)\\s*(?<condition>(?:\\d+|(?:[a-zA-z_]\\w*))\\s*(==|!=|>|<|>=|<=)\\s*(?:\\d+|(?:[a-zA-z_]\\w*)));\\s*(?<assignment>\\k<variableName>\\s*=\\s*(?<expression>(?:\\d+|(?:[a-zA-z_]\\w*))(\\s*[+\\-*/]\\s*(?:\\d+|(?:[a-zA-z_]\\w*)))?))\\){$")
	 };

    private static readonly Dictionary<string, int> IntegerTable = new Dictionary<string, int>();
    private static readonly Dictionary<string, string> TextTable = new Dictionary<string, string>();
    private static readonly Dictionary<string, string> CreatedVariables = new Dictionary<string, string>();
    private bool exit = false;

    public InputOutput()
    {
	 InitializeComponent();
    }

    private void btn_Compile_Click(object sender, EventArgs e)
    {
	 try
	 {
	   ClearCompile();
	   ProcessLines(rtb_Code);
	 }
	 catch (Exception ex)
	 {
	   Console.WriteLine(ex.Message);
	 }
    }

    private void ProcessLines(RichTextBox code)
    {
	 string[] lines = code.Lines;
	 //where
	 for (int i = 0; i < lines.Length; i++)
	 {
	   bool match = false;
	   for (int j = 0; j < expressions.Length && !match; j++)
	   {
		if (!expressions[j].IsMatch(lines[i])) continue;
		match = true;
		switch (j)
		{
		  //output line matched
		  case 0:
		    string text = GenerateText(lines[i]);
		    OutputToConsole(text);
		    break;
		  case 1:
		    IntegerDeclareAndOrInitialize(lines[i]);
		    break;
		  case 2:
		    HandleAssignment(lines[i]);
		    break;
		  case 3:
		    string textValue = GenerateVariableValueText(lines[i]);
		    OutputToConsole(textValue);
		    break;
		  case 4:
		    TextDeclareAndOrInitialize(lines[i]);
		    break;
		  case 5:
		    EvaluateExpression(lines[i]);
		    break;
		  case 6:
		    HandleInput(lines[i]);
		    break;
		  case 7:
		    i = HandleConditionals(lines, lines[i], i);
		    break;
		  case 8:
		    i = HandleForLoop(lines, lines[i], i);
		    break;
		}

		if (exit)
		{
		  ThrowError($"Incorrect Syntax at line {i + 1}");
		  return;
		}
	   }

	   if (!match)
	   {
		ThrowError($"Incorrect Syntax at line {i + 1}");
	   }

	   //EvaluateAndProcessLine(lines[i], i);
	 }
    }

    public int EvaluateAndProcessLine(string[] lines, string line, int lineNo)
    {
	 bool match = false;
	 for (int j = 0; j < expressions.Length; j++)
	 {
	   if (!expressions[j].IsMatch(line)) continue;
	   match = true;
	   switch (j)
	   {
		//output line matched
		case 0:
		  string text = GenerateText(line);
		  OutputToConsole(text);
		  break;
		case 1:
		  IntegerDeclareAndOrInitialize(line);
		  break;
		case 2:
		  HandleAssignment(line);
		  break;
		case 3:
		  string textValue = GenerateVariableValueText(line);
		  OutputToConsole(textValue);
		  break;
		case 4:
		  TextDeclareAndOrInitialize(line);
		  break;
		case 5:
		  EvaluateExpression(line);
		  break;
		case 6:
		  HandleInput(line);
		  break;
		case 7:
		  lineNo = HandleConditionals(lines, line, lineNo);
		  break;
		case 8:
		  lineNo = HandleForLoop(lines, line, lineNo);
		  break;
	   }

	   if (exit)
	   {
		ThrowError($"Incorrect Syntax at line {lineNo + 1}");
		return lineNo;
	   }
	 }

	 if (!match)
	 {
	   ThrowError($"Incorrect Syntax at line {lineNo + 1}");
	 }

	 return lineNo;
    }

    private int HandleForLoop(string[] lines, string line, int lineNo)
    {
	 Match match = expressions[8].Match(line);
	 string init = match.Groups["initialization"].Value;
	 IntegerDeclareAndOrInitialize(init);
	 string name = match.Groups["variableName"].Value;
	 string assign = match.Groups["assignment"].Value + ";";
	 string condition = match.Groups["condition"].Value;
	 for (int i = int.Parse(GetVariable(name)); EvaluateCondition(condition); EvaluateExpression(assign))
	 {
	   for (int j = lineNo + 1; j < lines.Length; j++)
	   {
		if (!lines[j].Equals("}"))
		{
		  j = EvaluateAndProcessLine(lines, lines[j], j);
		  continue;
		}
	   }
	 }

	 for (int j = lineNo + 1; j < lines.Length; j++)
	 {
	   if (lines[j].Equals("}"))
	   {
		lineNo = j;
		break;
	   }
	 }

	 return lineNo;
    }

    private bool EvaluateCondition(string condition)
    {
	 Expression exp = new Expression($"IF({condition},pass,fail)");
	 foreach (string variable in exp.getVariables())
	 {
	   switch (variable)
	   {
		case "pass":
		  exp.Bind("pass", true);
		  continue;
		case "fail":
		  exp.Bind("fail", false);
		  continue;
		default:
		  exp.Bind(variable, int.Parse(GetVariable(variable)));
		  break;
	   }
	 }

	 Boolean conditionResult = exp.Eval<Boolean>();
	 return conditionResult;
    }

    private int HandleConditionals(string[] lines, string line, int lineNo)
    {
	 Match match = expressions[7].Match(line);
	 string condition = match.Groups["condition"].Value;
	 Expression exp = new Expression(condition);
	 foreach (var variable in exp.getVariables())
	 {
	   exp.Bind(variable, int.Parse(GetVariable(variable)));
	 }

	 Boolean conditionResult = exp.Eval<Boolean>();
	 bool continueLoop = true;
	 for (int i = lineNo + 1; i < lines.Length && continueLoop; i++)
	 {
	   if (conditionResult)
	   {
		//if (!(lines[i].Equals("}otherwise{")) && !expressions[7].IsMatch(lines[i]))
		if (!lines[i].Equals("}otherwise{"))
		{
		  i = EvaluateAndProcessLine(lines, lines[i], i);
		  //added this
		  lineNo = i;
		  continue;
		}

		for (int j = i + 1; j < lines.Length; j++)
		{
		  if (lines[j].Equals("}"))
		  {
		    i = j;
		    lineNo = i;
		    break;
		  }
		}
	   }
	   else
	   {
		while (!lines[i].Equals("}otherwise{"))
		{
		  i++;
		}

		for (int j = i + 1; j < lines.Length; j++)
		{
		  if (!lines[j].Equals("}"))
		  {
		    // rtb_CompilationResult.Text += "else body beign executed\r\n";
		    EvaluateAndProcessLine(lines, lines[j], j);
		    continue;
		  }

		  i = j + 1;
		  lineNo = i;
		  continueLoop = false;
		  break;
		}
	   }
	 }

	 return lineNo;
    }

    private void HandleInput(string line)
    {
	 Match match = expressions[6].Match(line);
	 string name = match.Groups["variableName"].Value;
	 if (!CreatedVariables.ContainsKey(name))
	 {
	   ThrowError($"Variable named {name} has not been created!");
	   exit = true;
	   return;
	 }

	 Input inputForm = new Input();
	 inputForm.ShowDialog();
	 string value = inputForm.Value;
	 UpdateVariable(name, value);
    }

    private void EvaluateExpression(string line)
    {
	 Match match = expressions[5].Match(line);
	 string name = match.Groups["variableName"].Value;
	 string exp = match.Groups["expression"].Value;
	 Expression arithematicExpression = new Expression(exp);
	 foreach (string variable in arithematicExpression.getVariables())
	 {
	   string value = GetVariable(variable);
	   if (value == string.Empty) return;
	   arithematicExpression.Bind(variable, int.Parse(value));
	 }

	 int calculatedValue = (int)arithematicExpression.Eval<Decimal>();
	 UpdateVariable(name, calculatedValue.ToString());
    }

    private void HandleAssignment(string line)
    {
	 Match match = expressions[2].Match(line);
	 string name = match.Groups["variableName"].Value;
	 if (!CreatedVariables.ContainsKey(name))
	 {
	   ThrowError($"Variable named {name} has not been created!");
	   exit = true;
	   return;
	 }

	 string value = match.Groups["variableValue"].Value;
	 string actualDataType = CreatedVariables[name];
	 string assignedDataType = value.Contains("\"") ? "str" : "num";
	 if (!actualDataType.Equals(assignedDataType))
	 {
	   ThrowError($"Incompatible Data type assigned");
	   exit = true;
	   return;
	 }

	 switch (actualDataType)
	 {
	   case "str":
		TextTable[name] = value;
		break;
	   case "num":
		IntegerTable[name] = int.Parse(value);
		break;
	 }
    }

    private void TextDeclareAndOrInitialize(string line)
    {
	 Match match = expressions[4].Match(line);
	 string name = match.Groups["variableName"].Value;
	 string value = match.Groups["variableValue"].Value;
	 string dataType = match.Groups["dataType"].Value;
	 AddVariable(name, value, dataType);
    }

    private void IntegerDeclareAndOrInitialize(string line)
    {
	 Match match = expressions[1].Match(line);
	 string name = match.Groups["variableName"].Value;
	 string value = match.Groups["variableValue"].Value;
	 string dataType = match.Groups["dataType"].Value;
	 AddVariable(name, value, dataType);
    }

    private string GenerateText(string line)
    {
	 Match match = expressions[0].Match(line);
	 string hardCodedValue = match.Groups["value"].Value;
	 string variable = match.Groups["variableName"].Value;
	 if (variable == string.Empty)
	 {
	   return hardCodedValue;
	 }

	 return hardCodedValue += GetVariable(variable);
    }

    private string GenerateVariableValueText(string line)
    {
	 Match match = expressions[3].Match(line);
	 string name = match.Groups["variableName"].Value;
	 return GetVariable(name);
    }

    private string GetVariable(string name)
    {
	 if (IntegerTable.ContainsKey(name))
	 {
	   return IntegerTable[name].ToString();
	 }

	 if (TextTable.ContainsKey(name))
	 {
	   return TextTable[name];
	 }

	 if (CreatedVariables.ContainsKey(name))
	 {
	   ThrowError($"variable named {name} has not been initialized.");
	   exit = true;
	 }
	 else
	 {
	   ThrowError($"variable named {name} does not exist.");
	   exit = true;
	 }

	 return string.Empty;
    }

    private void UpdateVariable(string name, string value)
    {
	 if (IntegerTable.ContainsKey(name))
	 {
	   IntegerTable[name] = int.Parse(value);
	 }

	 else if (TextTable.ContainsKey(name))
	 {
	   TextTable[name] = value;
	 }

	 else if (CreatedVariables.ContainsKey(name))
	 {
	   string datatype = CreatedVariables[name];
	   if (datatype.Equals("num", StringComparison.CurrentCultureIgnoreCase))
	   {
		try
		{
		  IntegerTable[name] = int.Parse(value);
		}
		catch (Exception ex)
		{
		  ThrowError("Incorrect value given");
		  exit = true;
		  return;
		}
	   }
	   else if (datatype.Equals("str", StringComparison.CurrentCultureIgnoreCase))
	   {
		TextTable[name] = value;
	   }
	 }
	 else
	 {
	   ThrowError($"variable named {name} does not exist.");
	 }
    }

    private void AddVariable(string name, string value, string dataType)
    {
	 if (value == string.Empty)
	 {
	   CreatedVariables[name] = dataType;
	 }
	 else
	 {
	   switch (dataType)
	   {
		case "num":
		  IntegerTable[name] = int.Parse(value);
		  CreatedVariables[name] = dataType;
		  break;
		case "str":
		  TextTable[name] = value;
		  CreatedVariables[name] = dataType;
		  break;
	   }
	 }
    }

    private void OutputToConsole(string text)
    {
	 rtb_CompilationResult.Text += $"{text}\r\n";
    }

    private void ThrowError(string message)
    {
	 rtb_Errors.Text += $"{message}\r\n";
    }

    private void Clear()
    {
	 rtb_Code.Text = string.Empty;
	 ClearCompile();
    }

    private void ClearCompile()
    {
	 rtb_Errors.Text = string.Empty;
	 rtb_CompilationResult.Text = string.Empty;
	 IntegerTable.Clear();
	 TextTable.Clear();
	 CreatedVariables.Clear();
	 exit = false;
    }

    private void btn_Reset_Click(object sender, EventArgs e)
    {
	 Clear();
    }
  }
}