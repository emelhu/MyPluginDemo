using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyPluginInterface;                       // from MyPluginInterface.DLL - ADD REFERENCE !!!

// It creates MyPluginClasses.DLL but you must copy it manually to target directory of EXE !!!

namespace MyPluginClasses
{
  public class Add : IMyPluginInterface
  {
    long IMyPluginInterface.Operation(int operand1, int operand2)
    {
      return (long)operand1 + (long)operand2;
    }
  }

  public class Multiply : IMyPluginInterface
  {
    long IMyPluginInterface.Operation(int operand1, int operand2)
    {
      return (long)operand1 * (long)operand2;
    }
  }

  public class Maximum : IMyPluginInterface
  {
    long IMyPluginInterface.Operation(int operand1, int operand2)
    {
      return Math.Max(operand1, operand2);
    }
  }
}
