using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_House_Project.Models.Enums.v1
{
    public enum TitleV1
    {
        [System.Runtime.Serialization.EnumMemberAttribute(Value = "")]
        NotSet = 0,
        Mr = 1,
        Mrs = 2,
        Ms = 3,
        Miss = 4,
        Dr = 5,
        Adv = 7,
        Sir = 8,
        Hon = 9,
        Prof = 10,
        Rev = 11
    }
}
