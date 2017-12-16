using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsKit
{
    class SmallerThanZeroException : Exception
    {
        new public string Message
        {
            get { return "!!! הכנסת מספר ששווה או קטן מאפס"; }
        }         
    }   
}
