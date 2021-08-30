using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phase1
{
    public partial class Form1 : Form
    {
        public class IfBrackets
        {
            public int OpenedB = 0, OpenedBP;
            public int ClosedB = 0, ClosedBP;
            public int IfPos;
        }
        public class MyData
        {
            public string Data;
            public string DataType;
            public int NumberOfLine;
        }

        public class Myline1
        {
            public string Identifer;
            public string Variable;
            public int Flag;
            public string SemiColon;
            public string EqualOperation;
            public List<Cumulative> Cum = new List<Cumulative>();
            public bool Check;
            public string Messege;
        }

        public class Cumulative
        {
            public string Variable;
            public int Number;
            public string Symbol;
        }

        bool isWorking = false;

        List<Myline1> Lines = new List<Myline1>();

        public static Form2 F2 = new Form2();

        int Flag = 0;
        int IfFlag = 0;
        int NumberOfLines = 1;

        Myline1 pnn = new Myline1();
        IfBrackets pbb = new IfBrackets();

        List<MyData> Identifiers = new List<MyData>();
        List<MyData> Symbols = new List<MyData>();
        List<MyData> ReservedWords = new List<MyData>();
        List<MyData> Variables = new List<MyData>();

        List<IfBrackets> CheckIfB = new List<IfBrackets>();

        List<MyData> IdentifiedVariables = new List<MyData>();

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            F2 = new Form2();
            Identifier();
            Symbol();
            ReservedWord();
        }

        void Identifier()
        {
            MyData pnn = new MyData();
            pnn.Data = "int";
            pnn.DataType = "Integer";
            Identifiers.Add(pnn);

            pnn = new MyData();
            pnn.Data = "float";
            pnn.DataType = "Float";
            Identifiers.Add(pnn);

            pnn = new MyData();
            pnn.Data = "string";
            pnn.DataType = "String";
            Identifiers.Add(pnn);

            pnn = new MyData();
            pnn.Data = "double";
            pnn.DataType = "Double";
            Identifiers.Add(pnn);

            pnn = new MyData();
            pnn.Data = "bool";
            pnn.DataType = "Boolen-Bool";
            Identifiers.Add(pnn);

            pnn = new MyData();
            pnn.Data = "char";
            pnn.DataType = "Character";
            Identifiers.Add(pnn);
        }

        void Symbol()
        {
            MyData pnn = new MyData();
            pnn.Data = "+";
            pnn.DataType = "Sum Operator";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "-";
            pnn.DataType = "Difference Operator";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "/";
            pnn.DataType = "Division Operator";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "*";
            pnn.DataType = "Multiplication Operator";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "(";
            pnn.DataType = "Open Bracket";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = ")";
            pnn.DataType = "Close Bracket";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "{";
            pnn.DataType = "Open Curly Bracket";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "}";
            pnn.DataType = "Close Curly Bracket";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = ",";
            pnn.DataType = "Comma";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = ";";
            pnn.DataType = "Semicolon";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "&&";
            pnn.DataType = "And";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "||";
            pnn.DataType = "or";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "<";
            pnn.DataType = "Less Than";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = ">";
            pnn.DataType = "Greater Than";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "=";
            pnn.DataType = "Equal";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "!";
            pnn.DataType = "Not";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "++";
            pnn.DataType = "Plus 1";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "--";
            pnn.DataType = "Minus 1";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "==";
            pnn.DataType = "Equal Equal";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "!=";
            pnn.DataType = "Not Equal";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = ">=";
            pnn.DataType = "Greater Than Or Equal";
            Symbols.Add(pnn);

            pnn = new MyData();
            pnn.Data = "<=";
            pnn.DataType = "Smaller Than Or Equal";
            Symbols.Add(pnn);
        }

        void ReservedWord()
        {
            MyData pnn = new MyData();
            pnn.Data = "for";
            pnn.DataType = "For Loop";
            ReservedWords.Add(pnn);

            pnn = new MyData();
            pnn.Data = "while";
            pnn.DataType = "While Loop";
            ReservedWords.Add(pnn);

            pnn = new MyData();
            pnn.Data = "if";
            pnn.DataType = "If Condition";
            ReservedWords.Add(pnn);

            pnn = new MyData();
            pnn.Data = "do";
            pnn.DataType = "Do";
            ReservedWords.Add(pnn);

            pnn = new MyData();
            pnn.Data = "return";
            pnn.DataType = "Return From Function";
            ReservedWords.Add(pnn);

            pnn = new MyData();
            pnn.Data = "break";
            pnn.DataType = "Break The Loop";
            ReservedWords.Add(pnn);

            pnn = new MyData();
            pnn.Data = "continue";
            pnn.DataType = "Continue";
            ReservedWords.Add(pnn);

            pnn = new MyData();
            pnn.Data = "end";
            pnn.DataType = "End";
            ReservedWords.Add(pnn);
        }

        void Check(String[] UserString, int NumberOfLines)
        {
            int i = 0;
            for (int cc = 0; cc < UserString.Length; cc++)
            {
                int FlagCheck = 0;
                String Term = UserString[cc];
                for (i = 0; i < Identifiers.Count && FlagCheck == 0; i++)
                {
                    if (Term == Identifiers[i].Data)
                    {
                        F2.VariableBox.Text += Term + " ----> " + Identifiers[i].DataType + "\r\n";
                        FlagCheck = 1;
                        break;
                    }
                }

                for (i = 0; i < Symbols.Count && FlagCheck == 0; i++)
                {
                    if (Term == Symbols[i].Data)
                    {
                        F2.VariableBox.Text += Term + " ----> " + Symbols[i].DataType + "\r\n";
                        FlagCheck = 1;
                        if (Term == ";")
                        {
                            F2.VariableBox.Text += "\r\n";
                        }
                        break;
                    }
                }

                for (i = 0; i < ReservedWords.Count && FlagCheck == 0; i++)
                {
                    if (Term == ReservedWords[i].Data)
                    {
                        F2.VariableBox.Text += Term + " ----> " + ReservedWords[i].DataType + "\r\n";
                        FlagCheck = 1;
                        break;
                    }
                }

                if (FlagCheck == 0)
                {
                    F2.VariableBox.Text += Term + " ----> " + "Variable" + "\r\n";
                    FlagCheck = 1;
                }
            }
        }

        void CheckSymantic(string[] UserString, int NumberOfLines, int PosOfStringLine)
        {
            int i = 0;
            Flag = 0;
            for (i = 0; i < UserString.Length; i++)
            {
                if (Flag == 4)
                {
                    int o = 0;
                    for (o = 0; o < Symbols.Count; o++)
                    {
                        if (UserString[i] == Symbols[o].Data)
                        {
                            Cumulative AddCum = new Cumulative();
                            AddCum.Symbol = UserString[i];
                            pnn.Cum.Add(AddCum);
                            break;
                        }
                    }
                    if (o == Symbols.Count)
                    {
                        //error
                        pnn.Check = false;
                    }
                    else if (UserString[i] == ";")
                    {
                        pnn.Check = true;
                        Lines.Add(pnn);
                    }
                    else
                    {
                        if (i == UserString.Length - 1)
                        {
                            pnn.Check = false;
                            pnn.Messege = "Another Variable and Missing SemiColon";
                            Lines.Add(pnn);
                        }
                        Flag = 3;
                        i++;
                    }
                }
                if (Flag == 3)
                {
                    int VarCheck;
                    bool isNumeric = int.TryParse(UserString[i], out VarCheck);
                    if (isNumeric == true)
                    {
                        Cumulative AddCum = new Cumulative();
                        AddCum.Number = VarCheck;
                        pnn.Cum.Add(AddCum);
                    }
                    else
                    {
                        Cumulative AddCum = new Cumulative();
                        AddCum.Variable = UserString[i];
                        pnn.Cum.Add(AddCum);
                        int w = 0;
                        int Checker = 0;
                        if (IdentifiedVariables.Count > 0)
                        {
                            for (w = 0; w < IdentifiedVariables.Count; w++)
                            {
                                if (IdentifiedVariables[w].Data == UserString[i])
                                {
                                    Checker = 1;
                                    break;
                                }
                            }
                        }
                        if (Checker == 0)
                        {
                            MyData kk = new MyData();
                            kk.Data = UserString[i];
                            kk.DataType = null;
                            kk.NumberOfLine = PosOfStringLine;
                            IdentifiedVariables.Add(kk);
                        }
                    }
                    if (i == UserString.Length - 1)
                    {
                        pnn.Check = false;
                        pnn.Messege = "Missing SemiColon";
                        Lines.Add(pnn);
                    }
                    Flag = 4;
                }

                if (Flag == 2)
                {
                    if (UserString[i] == ";")
                    {
                        pnn.Flag = 1;
                        pnn.SemiColon = ";";
                        pnn.Check = true;
                        Lines.Add(pnn);
                    }
                    else if (UserString[i] == "=")
                    {
                        pnn.Flag = 2;
                        Flag = 3;
                        if (i == UserString.Length - 1)
                        {
                            pnn.Check = false;
                            pnn.Messege = "Missing Variable & SemiColon";
                            Lines.Add(pnn);
                        }
                    }
                    else
                    {
                        //error
                        pnn.Check = false;
                        Lines.Add(pnn);
                    }
                }

                if (Flag == 1)
                {
                    pnn.Variable = UserString[i];
                    int Checker = 0;
                    int w = 0;
                    if (IdentifiedVariables.Count > 0)
                    {
                        for (w = 0; w < IdentifiedVariables.Count; w++)
                        {
                            if (IdentifiedVariables[w].Data == UserString[i])
                            {
                                Checker = 1;
                                break;
                            }
                        }
                    }
                    if (Checker == 0)
                    {
                        MyData kk = new MyData();
                        kk.Data = UserString[i];
                        kk.DataType = Identifiers[i-1].Data;
                        kk.NumberOfLine = PosOfStringLine;
                        IdentifiedVariables.Add(kk);
                    }

                    if (i == UserString.Length - 1)
                    {
                        pnn.Check = false;
                        pnn.Messege = "Missing SemiColon";
                        Lines.Add(pnn);
                    }
                    Flag = 2;
                }
                int u = 0;
                for (u = 0; u < Identifiers.Count && Flag == 0; u++)
                {
                    if (UserString[i] == Identifiers[u].Data)
                    {
                        pnn.Identifer = Identifiers[u].DataType;
                        Flag = 1;
                        break;
                    }
                }

                if (Flag == 0)
                {
                    Flag = 1;
                    if (Flag == 1)
                    {
                        pnn.Variable = UserString[i];
                        int Checker = 0;
                        int w = 0;
                        if (IdentifiedVariables.Count > 0)
                        {
                            for (w = 0; w < IdentifiedVariables.Count; w++)
                            {
                                if (IdentifiedVariables[w].Data == UserString[i])
                                {
                                    Checker = 1;
                                    break;
                                }
                            }
                        }
                        if (Checker == 0)
                        {
                            MyData kk = new MyData();
                            kk.Data = UserString[i];
                            kk.DataType = null;
                            kk.NumberOfLine = PosOfStringLine;
                            IdentifiedVariables.Add(kk);
                        }

                        if (i == UserString.Length - 1)
                        {
                            pnn.Check = false;
                            pnn.Messege = "Missing SemiColon";
                            Lines.Add(pnn);
                            break;
                        }
                        Flag = 2;
                    }
                }
            }
        }

        void CheckIf(string[] UserString, int NumberOfLines, int PosOfStringLine)
        {
            int i = 0;
            IfFlag = 0;
            for (i = 2; i < UserString.Length; i++)
            {
                if (IfFlag == 3 && (UserString[i] != "&&" && UserString[i] != "||"))
                {
                    pnn.Check = false;
                    pnn.Messege = "Missing Connector";
                    Lines.Add(pnn);
                    break;
                }
                else if (IfFlag == 3)
                {
                    if (i + 1 == UserString.Length)
                    {
                        pnn.Check = false;
                        pnn.Messege = "error Connector without another Condition";
                        Lines.Add(pnn);
                        break;
                    }
                    else
                    {
                        IfFlag = 0;
                        i++;
                    }
                }

                if (IfFlag == 1 && (UserString[i] != "==" && UserString[i] != "!=" && UserString[i] != ">=" && UserString[i] != "<=" && UserString[i] != ">" && UserString[i] != "<"))
                {
                    pnn.Check = false;
                    pnn.Messege = "Missing Variables Connector";
                    Lines.Add(pnn);
                    break;
                }
                else if (IfFlag == 1)
                {
                    if (i + 1 == UserString.Length)
                    {
                        pnn.Check = false;
                        pnn.Messege = "Missing Variable & )";
                        Lines.Add(pnn);
                        break;
                    }
                    else
                    {
                        IfFlag = 2;
                        i++;
                    }
                }

                if ((IfFlag == 0 || IfFlag == 2) && (UserString[i] == "==" || UserString[i] == "!=" || UserString[i] == ">=" || UserString[i] == "<=" || UserString[i] == ">" || UserString[i] == "<"))
                {
                    pnn.Check = false;
                    pnn.Messege = "Missing Variable";
                    Lines.Add(pnn);
                    break;
                }
                else if (IfFlag == 0 || IfFlag == 2) 
                {
                   IfFlag++;
                    if ( IfFlag == 1 )
                    {
                        if (i + 1 == UserString.Length)
                        {
                            pnn.Check = false;
                            pnn.Messege = "Missing Variable & Variables Connector & )";
                            Lines.Add(pnn);
                            break;
                        }
                    }
                   if (IfFlag == 3)
                   {
                       if (i + 1 == UserString.Length)
                       {
                           pnn.Check = false;
                           pnn.Messege = "Missing if Closed Bracket ')'";
                           Lines.Add(pnn);
                           break;
                       }
                       else
                       {
                           if (UserString[i + 1] == ")")
                           {
                               pnn.Check = true;
                               Lines.Add(pnn);
                               break;
                           }
                       }
                   }
                }
            }
        }

        void CheckType()
        {
            pnn = new Myline1();
            Lines = new List<Myline1>();
            IdentifiedVariables = new List<MyData>();
            for (int i = 0 ; i < CodeBox.Lines.Length ; i++)
            {
                string[] UserString = CodeBox.Lines[i].Split(' ');
                Check(UserString, NumberOfLines);
                pnn = new Myline1();
                if (UserString[0] == "if")
                {
                    pbb = new IfBrackets();
                    pbb.IfPos = i;
                    if ( UserString.Length > 1)
                    {
                        if (UserString[1] == "(")
                        {
                            CheckIf(UserString, NumberOfLines, i);
                            if (pnn.Check == false)
                            {
                                break;
                            }
                            pnn = new Myline1();
                            if (1 + i < CodeBox.Lines.Length)
                            {
                                string[] mycheck = CodeBox.Lines[i + 1].Split(' ');
                                if (mycheck[0] == "{" && mycheck.Length == 1)
                                {
                                    pbb.OpenedB = 1;
                                    pbb.OpenedBP = i;
                                    CheckIfB.Add(pbb);
                                    pnn.Check = true;
                                    Lines.Add(pnn);
                                    i++;
                                }
                                else
                                {
                                    pnn.Messege = "Missing If Opened Brackets '{'";
                                    pnn.Check = false;
                                    Lines.Add(pnn);
                                    break;
                                }
                            }
                            else
                            {
                                pnn.Messege = "Missing If Opened Brackets '{' & If Closed Brackets '}'";
                                pnn.Check = false;
                                Lines.Add(pnn);
                            }
                        }
                    }
                    else
                    {
                        pnn.Check = false;
                        pnn.Messege = "Missing if Open Bracket '('";
                        Lines.Add(pnn);
                        break;
                    }
                }
                else
                {
                    if (UserString[0] == "}" && UserString.Length == 1)
                    {
                        for (int we = 0; we < CheckIfB.Count; we++)
                        {
                            if (CheckIfB[we].ClosedB == 0)
                            {
                                CheckIfB[we].ClosedB = 1;
                                CheckIfB[we].ClosedBP = i;
                                break;
                            }
                        }
                        pnn.Check = true;
                        Lines.Add(pnn);
                        i++;
                    }
                    else
                    {
                        CheckSymantic(UserString, NumberOfLines, i);
                    }
                    if (pnn.Check == false)
                    {
                        break;
                    }
                }
                pnn = new Myline1();
            }
            if (CheckIfB.Count > 0)
            {
                for (int we = 0; we < CheckIfB.Count; we++)
                {
                    if (CheckIfB[we].ClosedB == 0)
                    {
                        pnn = new Myline1();
                        pnn.Check = false;
                        pnn.Messege = "Missing Closed Bracket Of If at "+ (CheckIfB[we].IfPos + 1);
                        Lines.Add(pnn);
                    }
                }
            }
            for (int j = 0; j < Lines.Count; j++)
            {
                if (IdentifiedVariables.Count > 0)
                {
                    for (int hh = 0; hh < IdentifiedVariables.Count; hh++)
                    {
                        if (IdentifiedVariables[hh].DataType == null && IdentifiedVariables[hh].NumberOfLine == j)
                        {
                            if (Lines[j].Messege == null)
                            {
                                Lines[j].Messege = "This variable is not Declared:  " + IdentifiedVariables[hh].Data;
                                Lines[j].Check = false;
                            }
                            else
                            {
                                Lines[j].Messege += " And This variable is not Declared:  " + IdentifiedVariables[hh].Data;
                                Lines[j].Check = false;
                            }
                        }
                    }
                }
                F2.RunBox.Text += "Number of line :" + (j+1) + " Check: " + Lines[j].Check + "   Error is : "+ Lines[j].Messege + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isWorking == false)
            {
                isWorking = true;
                CheckType();
                F2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isWorking == true)
            {
                isWorking = false;
                F2.RunBox.Text = "";
                F2.VariableBox.Text = "";
                F2.Hide();
            }
        }
    }
}
