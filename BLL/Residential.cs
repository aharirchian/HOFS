using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class Residential : Building
    {
        private string category = "Residential";
        private string legal;
        private string type;

        public Residential()
        {

        }
        public override string GetCategory()
        {
            return category;
        }
        public override void SetCategory(string category)
        {
            this.category = category;
        }

        public override void SetLegal(string legal)
        {
            this.legal = legal;
        }

        public virtual void SetTypeOfBuilding(string type)
        {

        }

        public new virtual string GetBuildingType() { return type; }
    }
}
