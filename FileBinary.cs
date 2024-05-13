//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Xml.Serialization;
//using System.IO;
//using System.Runtime.Serialization;
//namespace BasicCSharp
//{
//    [Serializable]
//    internal class Student : ISerializable
//    {
//        public int Age { get; set; }
//        public string Name { get; set; }
//        public Student(SerializationInfo info, StreamingContext context)
//        {
//            Name = (string)info.GetValue("kai", typeof(string));
//            Age = (int)info.GetValue("kai1", typeof(int));
//        }
//        public Student(int _age, string _name)
//        {
//            Age = _age;
//            Name = _name;
//        }
//        public override string ToString()
//        {
//            return Name + Age.ToString();
//        }
//        static void Main()
//        {
//            Student sd = new Student(20, "Mai Van Tien");
//            Stream fs = File.Open("test.bat", FileMode.Create);
//            BinaryFormatter bf = new BinaryFormatter();
//            bf.Serialize(fs, sd);
//            fs.Close();

//            sd = null;
//            fs = File.Open("test.bat", FileMode.Open);
//            bf = new BinaryFormatter();
//            sd = (Student)bf.Deserialize(fs);
//            fs.Close();
//            Console.WriteLine(sd);
//            Console.ReadKey(false);
//        }

//        public void GetObjectData(SerializationInfo info, StreamingContext context)
//        {
//            info.AddValue("kai", Name);
//            info.AddValue("kai1", Age);
//        }

//    }
//}
