using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsKit
{
    class LargeNumberException : Exception
    {
        new public string Message
        {
            get { return string.Format("{0} : המספר המותר המקסימלי הינו", 9999); }
        }
    }
}
