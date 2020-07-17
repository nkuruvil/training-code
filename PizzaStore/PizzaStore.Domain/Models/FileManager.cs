using System.IO;
using System.Xml.Serialization;

namespace PizzaStore.Domain.Models
{
    public class FileManager
    {

        // Serialization: Transfer of data
        private const string _path = @"data/pizza_store.xml";
        public Order Read()
        {
            // open file with read permission
            var reader = new StreamReader(_path);
            var xml = new XmlSerializer(typeof(Order));

            return xml.Deserialize(reader) as Order;

        }

        public void Write(Order orders)
        {
            //create a file
            //open file w write permission
            //load content to write
            //convert content to xml
            //write content to file
            //close the file

            var writer = new StreamWriter(_path);
            var xml = new XmlSerializer(typeof(Order));

            xml.Serialize(writer, orders);
        }
    }
}