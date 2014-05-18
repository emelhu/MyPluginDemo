using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;
using System.IO; 

using MyPluginInterface;                        // from MyPluginInterface.DLL - ADD REFERENCE !!!
                      

// NONE using MyPluginClasses !!!   This DLL will be binded dinamically.

namespace MyPluginDemo
{
  public partial class myPluginHostForm : Form
  {
    private bool started = false;

    public myPluginHostForm()
    {
      InitializeComponent();
    }

    private void OperateButton_Click(object sender, EventArgs e)
    {
      IMyPluginInterface myOperation = GetInterface();

      if (myOperation == null)
      {
        resultViewLabel.Text = "!!! invalid plugin class !!!";
      }
      else
      {
        int op1 = 0;
        int op2 = 0;

        try
        {
          op1 = int.Parse(Operand1TextBox.Text);
          op2 = int.Parse(Operand2TextBox.Text);

          resultViewLabel.Text = myOperation.Operation(op1, op2).ToString();
        }
        catch
        {
          resultViewLabel.Text = "!!! invalid operand !!!";
        }      
      }
    }

    private void Operand1TextBox_TextChanged(object sender, EventArgs e)
    {
      ClearInfos();
    } 

    private IMyPluginInterface GetInterface()
    {
      int ix = operationListBox.SelectedIndex;

      if (ix < 0)
      {
        return null;
      }

      //

      string[] names = { "Add", "Multiply", "Maximum"};         // names of classes in plugin

      Assembly           ifAss  = Assembly.LoadFile(Path.GetFullPath(@".\MyPluginClasses.DLL"));      
      Type               ifType = ifAss.GetType("MyPluginClasses." + names[ix]);
      IMyPluginInterface ifRet  = Activator.CreateInstance(ifType) as IMyPluginInterface;

      return ifRet;
    }

    private void operationListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      OperateButton.Enabled = true;
      ClearInfos();
    }

    private void myPluginHostForm_Load(object sender, EventArgs e)
    {
      operationListBox.SelectedIndex = 0;
      started = true;
    }

    private void ClearInfos()
    {
      if (started)
      {
        resultViewLabel.Text = "";
        messageLabel.Text    = "";
      }
    }
  }
}
