using System;

namespace BLL
{
    [Serializable]
    public class WareHouse : Commercial
    {
        string type;

        public WareHouse()
        {

        }

        public WareHouse(string type)
        {

        }

        public override string GetBuildingType()
        {
            type = "WareHouse";
            return type;
        }

        public override void SetTypeOfBuilding(string type)
        {
            this.type = type;
        }
    }
}
