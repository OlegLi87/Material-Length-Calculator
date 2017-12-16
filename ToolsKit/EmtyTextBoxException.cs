using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsKit
{
    class EmtyTextBoxException : Exception
    {
        new public string Message
        {
            get { return "!!! לא כל השדות מכילות מידע"; }
        }
    }
}
