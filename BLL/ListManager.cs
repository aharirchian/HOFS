using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ListManager<T> : IListManager<T>
    {
        private List<T> main_list;
        private List<T> sub_list;
        /// <summary>
        /// Constructor for List Manager
        /// </summary>
        public ListManager()
        {
            main_list = new List<T>();
            sub_list = new List<T>();
        }

        public int Count => throw new NotImplementedException();
        /// <summary>
        /// Metod to add item in the list from RealStateManager
        /// </summary>
        /// <param name="aType"></param>
        /// <returns></returns>
        public bool Add(T aType)
        {
            main_list.Add(aType);
            return true;
        }
        /// <summary>
        /// Metod for load binary file 
        /// </summary>
        /// <param name="fileName"></param>
        public void BinaryDeSerialize(string fileName)
        {
            main_list = DataController.Load<List<T>>(fileName);
        }
        /// <summary>
        /// Metod for save binary file
        /// </summary>
        /// <param name="fileName"></param>
        public void BinarySerialize(string fileName)
        {
            DataController.Save(main_list, fileName);
        }
        /// <summary>
        /// metod to change an item in main list with selected index
        /// </summary>
        /// <param name="aType"></param>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public bool ChangeAt(T aType, int anIndex)
        {
            main_list[anIndex] = aType;
            return true;
        }
        /// <summary>
        /// Not Implemented
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete all items in main list
        /// </summary>
        public void DeleteAll()
        {
            main_list.Clear();
        }
        /// <summary>
        /// Delete a specific item in the list with selected index
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public bool DeleteAt(int anIndex)
        {
            main_list.RemoveAt(anIndex);
            return true;
        }
        /// <summary>
        /// Take an item from main list with specific item
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public T GetAt(int anIndex)
        {
            return main_list[anIndex];
        }
        /// <summary>
        /// Take an item from main list
        /// </summary>
        /// <returns></returns>
        public T GetAt()
        {
            int index = main_list.Count;
            return main_list[index - 1];
        }

        public string[] ToStringArray()
        {
            throw new NotImplementedException();
        }

        public List<string> ToStringList()
        {
            throw new NotImplementedException();
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get list of searched file or main list that user has searched or want total main list.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<T> GetListFromManager(string list)
        {
            if (list == "Search")
            {

                return sub_list;
            }
            else
            {
                return main_list;
            }
        }

        /// <summary>
        /// Find a number of items in the main list
        /// </summary>
        /// <param name="listName"></param>
        /// <returns></returns>
        public int SizeOfList(string listName)
        {
            if (listName == "mainList")
            {
                return main_list.Count;
            }
            else
            {
                return sub_list.Count;
            }
        }
        /// <summary>
        /// Add items to the sublist that show the searched items from user
        /// </summary>
        /// <param name="aType"></param>
        public void AddToSubList(T aType)
        {
            sub_list.Add(aType);

        }
        /// <summary>
        /// Clean the sublist for using for the next time
        /// </summary>
        public void DeleteSubList()
        {
            sub_list.Clear();
        }

        public void SetList(List<T> t)
        {
            main_list = t;
        }
    }
}
