using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BLL
{
    [Serializable]
    public class Building : AEstate
    {
        private Residential residential;
        private Commercial commercial;
        private Shop shop;
        private WareHouse wareHouse;
        private House house;
        private Villa villa;
        private Apartmant apartmant;
        private TownHouse townHouse;
        private string category;
        private string type;
        private string legal;
        public int Id;
        private Image image;
        Address address;

        public Building()
        {

        }
        public Building(string category, string type, string legal)
        {
            this.category = category;
            this.type = type;
            this.legal = legal;

        }

        public Building(Commercial commercial, Shop shop, string legal)
        {
            this.commercial = commercial;
            this.shop = shop;
            this.legal = legal;
        }

        public Building(Commercial commercial, WareHouse wareHouse, string legal)
        {
            this.commercial = commercial;
            this.wareHouse = wareHouse;
            this.legal = legal;

        }

        public Building(Residential residential, House house, string legal)
        {
            this.residential = residential;
            this.house = house;
            this.legal = legal;

        }

        public Building(Residential residential, Apartmant apartmant, string legal)
        {
            this.residential = residential;
            this.apartmant = apartmant;
            this.legal = legal;

        }

        public Building(Residential residential, Villa villa, string legal)
        {
            this.residential = residential;
            this.villa = villa;
            this.legal = legal;

        }

        public Building(Residential residential, TownHouse townHouse, string legal)
        {
            this.residential = residential;
            this.townHouse = townHouse;
            this.legal = legal;

        }


        public Building BuildingMaker()
        {
            if (category == "Commercial" && type == "shops")
            {
                return new Building(new Commercial(), new Shop(),legal);
            }

            if (category == "Commercial" && type == "warehouse")
            {
                return new Building(new Commercial(), new WareHouse(), legal);
            }

            if (category == "Residential" && type == "houses")
            {
                return new Building(new Residential(), new House(), legal);
            }

            if (category == "Residential" && type == "villas")
            {
                return new Building(new Residential(), new Villa(), legal);
            }

            if (category == "Residential" && type == "apartments")
            {
                return new Building(new Residential(), new Apartmant(), legal);
            }

            if (category == "Residential" && type == "townhouses")
            {
                return new Building(new Residential(), new TownHouse(), legal);
            }

            return null;
            
        }

        public string GetBuildingCategory()
        {
            return category;
        }

        public string GetBuildingType()
        {
            return type;
        }

        public override string GetLegal()
        {
            return legal;
        }




        public override void SetCategory(string category)
        {
            this.category = category;
        }

        public override void SetType(string type)
        {
            this.type = type;
        }

        public override void SetLegal(string legal)
        {
            this.legal=legal;
        }
    }
}

