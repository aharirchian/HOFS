using System;

namespace BLL
{
    [Serializable]
    public class Villa : Residential
    {
        string type;

        public Villa()
        {

        }

        public Villa(string type)
        {

        }

        public override string GetBuildingType()
        {
            type = "Villa";
            return type;
        }

        public override void SetTypeOfBuilding(string type)
        {
            this.type = type;
        }
    }
}