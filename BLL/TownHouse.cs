using System;

namespace BLL
{
    [Serializable]
    public class TownHouse : Residential
    {
        string type;

        public TownHouse()
        {

        }

        public TownHouse(string type)
        {

        }

        public override string GetBuildingType()
        {
            type = "TownHouse";
            return type;
        }

        public override void SetTypeOfBuilding(string type)
        {
            this.type = type;
        }
    }
}