//using System;
//using System.IO;
//using System.Runtime.Serialization;
//using System.Xml.Serialization;

////XML Syntax : <key> value </key>
//public class clsPerson : ISerializable
//{
//    public string FirstName;
//    public string MI;
//    public string LastName;
//    public clsPerson() { }
//    public clsPerson(SerializationInfo info, StreamingContext context) 
//    {
//        FirstName= (string) info.GetValue("Name", typeof(string));
//        MI = (string)info.GetValue("Name", typeof(string));
//        LastName = (string)info.GetValue("Name", typeof(string));
//    }

//    public void GetObjectData(SerializationInfo info, StreamingContext context)
//    {
//        info.AddValue("FirstName", FirstName);
//        info.AddValue("MI", MI);
//        info.AddValue("LastName", LastName);
//    }
//    public override string ToString()
//    {
//        return FirstName + " " + MI + " "+ LastName;
//    }
//}

//class class1
//{
//    static void Main(string[] args)
//    {
//        clsPerson p = new clsPerson();
//        p.FirstName = "Jeff";
//        p.MI = "A";
//        p.LastName = "Price";
//        XmlSerializer x = new XmlSerializer(p.GetType());
//        FileStream fs = new FileStream("mvt.xml",FileMode.Create);
//        x.Serialize(fs, p);
//        fs.Close();
//        p = null;
//        fs = new FileStream("mvt.xml", FileMode.Open);
//        p = (clsPerson) x.Deserialize(fs);
//        fs.Close();
//        Console.WriteLine(p);
//        Console.ReadLine();
//    }
//}