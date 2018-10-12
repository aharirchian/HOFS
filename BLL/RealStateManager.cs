using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL

{
    /// <summary>
    /// This class generate  the specific ID for every items and the have control to add and edit item  
    /// </summary>
    public class RealStateManager : ListManager<AEstate>
    {
        int ID = 10000;
        private Building building;
       

        public RealStateManager()
        {
            
        }
       /// <summary>
       /// Add item to the main list in list manager
       /// </summary>
       /// <param name="category"></param>
       /// <param name="type"></param>
       /// <param name="legal"></param>
       /// <param name="address"></param>
       /// <param name="image"></param>
        public void AddItem( string category, string type, string legal, Address address, Image image)
        {
            building = new Building(category, type,legal);
            AEstate estate = new AEstate(ID, building, address, image);
            Add(estate);
            ID++;      
        }
         /// <summary>
         /// Save Edited item from main list in list manager
         /// </summary>
         /// <param name="index"></param>
         /// <param name="id"></param>
         /// <param name="category"></param>
         /// <param name="type"></param>
         /// <param name="legal"></param>
         /// <param name="address"></param>
         /// <param name="image"></param>
        public void SaveEditedItem(int index, int id,string category, string type, string legal, Address address, Image image)
        {
            AEstate estate = new AEstate(id, new Building(category,type,legal), address, image);
            ChangeAt(estate, index);
            
        }

     /// <summary>
     /// Get specific list if is this list is specific searched list from user or main list
     /// </summary>
     /// <param name="list"></param>
     /// <returns></returns>
        public List<AEstate> GetList(string list) {  return GetListFromManager(list);  }

    
        public int GetId()
        {
            return ID;
        }

        /// <summary>
        /// Add the searched item to sublist in list manager
        /// </summary>
        /// <param name="text"></param>
        public void FindEstate(string text)
        {
            
            for (int i = 0; i <= SizeOfList("mainList") -1; i++)
            {
                if ( GetAt(i).GetTypeEstate() == text)
                {
                    AddToSubList(GetAt(i));
                }
            }
        }

       
    }
}
