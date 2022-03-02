using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    [Serializable]
    internal class MyItemType :ISerializable
    {
        public MyItemType() { }
        private string _myvalue;
        public string Myvalue { get { return _myvalue; } set { _myvalue = value; } }
        //  Implement this method to serialize data.the method is called on serialization
        void ISerializable.GetObjectData(SerializationInfo info,StreamingContext context)
        {
            info.AddValue("props", _myvalue, typeof(string));

        }

        public MyItemType(SerializationInfo info, StreamingContext context)
        {
            _myvalue = (string)info.GetValue("props",typeof(string));
        }
    }
}
