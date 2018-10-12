using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// This class provide the Address for every item of building
    /// </summary>
    [Serializable]
    public  class Address
    {
        string country;
        string city;
        string street;
        string zipCode;

        /// <summary>
        /// Constructors 
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        public Address(string country,string city,string street,string zipCode)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.zipCode = zipCode;
        }
        /// <summary>
        /// Metod to get a country from selected item
        /// </summary>
        /// <returns></returns>
        public string GetCountry() {return country; }
        /// <summary>
        /// Metod to get a city from selected item
        /// </summary>
        /// <returns></returns>
        public string GetCity() { return city;  }
        /// <summary>
        /// Metod to get a street from selected item
        /// </summary>
        /// <returns></returns>
        public string GetStreet() { return street; }
        /// <summary>
        /// Metod to get a ZipCode from selected item
        /// </summary>
        /// <returns></returns>
        public string GetZipCode() { return zipCode; }
        /// <summary>
        /// Metod to set a country from selected item
        /// </summary>
        /// <param name="country"></param>
        public void SetCountry(string country)
        { this.country = country;  }

        /// <summary>
        /// Metod to set a country from selected item
        /// </summary>
        /// <param name="city"></param>
        public void SetCity(string city)
        { this.city = city; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="zipCode"></param>
        public void SetZipCode(string zipCode)
        { this.zipCode = zipCode; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="street"></param>
        public void SetStreet(string street)
        { this.street = street; }
    
}
}
