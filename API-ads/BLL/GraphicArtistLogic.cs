using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class GraphicArtistLogic
    {
        public DAL.GraphicArtistDB getgrafits(string id)
        {
            return DAL.GraphicArtistDB.GetGra(id);
        }
    }
}
