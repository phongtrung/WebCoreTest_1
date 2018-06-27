using System;
using System.Collections.Generic;
using System.Text;
using WebCoreTest_1.Data.Enums;

namespace WebCoreTest_1.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
