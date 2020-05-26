using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Orders//הזמנות
    {
     public int ClientTz { get; set; }//תז לקוח
     public int TemplateKod { get; set; }//קוד תבנית
     public DateTime StartDate { get; set; }//תאריך התחלה לפרסום
     public DateTime EndDate { get; set; }//תאריך סופי לפרסום
     public string Advertisement { get; set; }// מודעת הפרסומת שברצונו לפרסם


    }
}
