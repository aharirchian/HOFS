using System;

namespace BLL
{
    [Serializable]
    public class Apartmant : Residential
    {
        string type;

        public Apartmant()
        {

        }

        public Apartmant(string type)
        {

        }

        public override string GetBuildingType()
        {
            type = "Apartmant";
            return type;
        }

        public override void SetTypeOfBuilding(string type)
        {
            this.type = type;
        }
    }
}