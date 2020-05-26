using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class Templates//תבניות
    {
        public int TemplateKod { get; set; }//קוד תבנית
        public string TopPlace { get; set; }//מיקום מלמעלה
        public string RightPlace { get; set; }//מיקום מצד ימין
        public string WidthTemplate { get; set; }//רוחב תבנית
        public string HeightTemplate { get; set; }//אורך תבנית
        public int PageTemplate { get; set; }//רוחב תבנית
        //public int OrdersClientTz { get; set; }


    }
}
