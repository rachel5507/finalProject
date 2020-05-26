using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public static class GraphicArtistDB
    {
        public int GetGra(string id)
        {
            using (DatabaseAdsEntities db = new DatabaseAdsEntities())
            {
                var q1 = (from p in db.GraphicArtists
                          where p.GraphicArtistTz==id
                          select p.SumOfRights);
                return  Convert.ToInt32(q1);
            }
        }
    }
}
