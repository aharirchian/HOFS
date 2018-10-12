
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    /// <summary>
    /// Class DataController manage Save and Load Binary file of list 
    /// </summary>
    public class DataController
    {
        /// <summary>
        /// Metod to Save binary file to locale path
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="fileName"></param>
        public static void Save(Object obj, string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, obj);

            }
        }

        /// <summary>
        /// Method to load a binary file to the program
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>

        public static T Load<T>(string fileName)
        {

            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();

                return (T)bin.Deserialize(stream);
                ;

            }
        }
    }
}
    
