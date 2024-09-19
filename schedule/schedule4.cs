using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace schedule
{
    partial class Schedule
    {
       public void write_to_json()
        {
            string s1 = JsonSerializer.Serialize(classes);
            File.WriteAllText("..\\..\\..\\files\\classes.json", s1);

            string s2 = JsonSerializer.Serialize(teachers);
            File.WriteAllText("..\\..\\..\\files\\teachers.json", s2);

            string s3 = JsonSerializer.Serialize(subjects);
            File.WriteAllText("..\\..\\..\\files\\subjects.json", s3);

            string s11 = JsonSerializer.Serialize(conTH);
            File.WriteAllText("..\\..\\..\\files\\conTH.json", s11);

            string s12 = JsonSerializer.Serialize(conTM);
            File.WriteAllText("..\\..\\..\\files\\conTM.json", s12);

            string s13 = JsonSerializer.Serialize(conS);
            File.WriteAllText("..\\..\\..\\files\\conS.json", s13);

            string s14 = JsonSerializer.Serialize(conSP);
            File.WriteAllText("..\\..\\..\\files\\conSP.json", s14);

            string s15 = JsonSerializer.Serialize(conSNP);
            File.WriteAllText("..\\..\\..\\files\\conSNP.json", s15);

        }
        public void read_from_json()
        {
            //string s1 = File.ReadAllText("..\\..\\..\\files\\classes.json");
            //classes = (Dictionary<string, Class>)JsonSerializer.Deserialize(s1, typeof(Dictionary<string, Class>));

            string s2 = File.ReadAllText("..\\..\\..\\files\\teachers.json");
            teachers = (Dictionary<string, Teacher>)JsonSerializer.Deserialize(s2, typeof(Dictionary<string, Teacher>));

            string s3 = File.ReadAllText("..\\..\\..\\files\\subjects.json");
            subjects = (List<Subject>)JsonSerializer.Deserialize(s3, typeof(List<Subject>));

            string s11 = File.ReadAllText("..\\..\\..\\files\\conTH.json");
            conTH = (Dictionary<string, ConTeacherHours>)JsonSerializer.Deserialize(s11, typeof(Dictionary<string, ConTeacherHours>));

            string s12 = File.ReadAllText("..\\..\\..\\files\\conTM.json");
            conTM = (Dictionary<string, ConTeacherMax>)JsonSerializer.Deserialize(s12, typeof(Dictionary<string, ConTeacherMax>));

            string s13 = File.ReadAllText("..\\..\\..\\files\\conS.json");
            conS = (Dictionary<string, ConSubject>)JsonSerializer.Deserialize(s13, typeof(Dictionary<string, ConSubject>));

            string s14 = File.ReadAllText("..\\..\\..\\files\\conSP.json");
            conSP = (Dictionary<string, ConSubjectPossibility>)JsonSerializer.Deserialize(s14, typeof(Dictionary<string, ConSubjectPossibility>));

            string s15 = File.ReadAllText("..\\..\\..\\files\\conSNP.json");
            conSNP = (Dictionary<string, ConSubjectNoPossibility>)JsonSerializer.Deserialize(s15, typeof(Dictionary<string, ConSubjectNoPossibility>));
        }
    }
}
