using System;

namespace BLL
{
    [Serializable]
    public class House : Residential
    {
        string type;

        public House()
        {

        }

        public House(string type)
        {

        }

        public override string GetBuildingType()
        {
            type = "House";
            return type;
        }

        public override void SetTypeOfBuilding(string type)
        {
            this.type = type;
        }
    }
}