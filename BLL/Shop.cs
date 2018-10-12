using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class Shop : Commercial
    {
        string type;

        public Shop()
        {

        }

        public Shop(string type)
        {

        }

        public override string GetBuildingType()
        {
            type = "Shop";
            return type;
        }

        public override void SetTypeOfBuilding(string type)
        {
            this.type = type;
        }
    }
}
