using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieBuilder
{
    internal interface ICookieBuilder
    {
        string FlourType { get; }
        string SugarType { get; }
        string ChocolateType { get; }
    }
}
