using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class Commercial : Building
    {
        private string category = "Commercial";
        private string legal;
        private string type;

        public Commercial()
        {

        }
        public override string GetCategory() {
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
            this.type = type;

        }

        public new virtual string GetBuildingType() { return type; }

    }
}
