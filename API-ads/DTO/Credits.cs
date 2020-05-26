using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Credits//זיכויים
    {
        public int CreditKod { get; set; }//קוד הזיכוי  
        public int Sum { get; set; }//סכום הזיכוי  
        public DateTime TargetDate { get; set; }//תאריך אחרון למימוש הזיכוי 
        public bool IsImplemented { get; set; }//?האם מומש הזיכוי
    }
}
