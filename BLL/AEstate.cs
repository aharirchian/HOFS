using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace BLL
{
    [Serializable]
    public class AEstate : IEstate
    {
        
        private int id;
        private Image image;
        private Address address;
        private Building building;
        

        public AEstate()
        {
        }

            public AEstate(int id, Building building, Address address, Image image)
        {

            this.address = address;
            this.id = id;
            this.image = image;
            this.building = building;
        }


        public virtual string GetCategory() { return building.GetBuildingCategory(); }
        public virtual string GetLegal() { return building.GetLegal(); }
        public virtual string GetTypeEstate() { return building.GetBuildingType(); }
        public string GetCountry() { return address.GetCountry(); }
        public string GetCity() { return address.GetCity(); }
        public string GetStreet() { return address.GetStreet(); }
        public string GetZipCode() { return address.GetZipCode(); }
        public Image GetImage() { return image; }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>

        public virtual void SetCategory(string category)
        {
            building.SetCategory(category);
        }

        public virtual void SetType(string type)
        {
            building.SetType(type);
        }

        public virtual void SetLegal(string legal)
        {
            building.SetLegal(legal);
        }

        
        public void SetCountry(string country) { this.address.SetCountry(country); }
        public void SetCity(string city) { this.address.SetCity(city); }
        public void SetStreet(string street) { this.address.SetStreet(street); }

        public void SetZipCode(string zipeCode)
        {
            this.address.SetZipCode(zipeCode);
        }

        public void SetImage(Image image)
        {
            this.image = image;
        }


    }
}
