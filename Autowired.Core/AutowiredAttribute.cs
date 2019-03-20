using System;
using System.Collections.Generic;
using System.Text;

namespace Autowired.Core
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class AutowiredAttribute : Attribute
    {
    }
}
