using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace schedule
{
    partial class Schedule
    {
        private void create()
        {
            //מורות
            Teacher t1 = new Teacher();
            t1.Name = "רישי";
            teachers.Add(t1.Name, t1);

            Teacher t2 = new Teacher();
            t2.Name = "פילטובסקי";
            teachers.Add(t2.Name, t2);

            Teacher t3 = new Teacher();
            t3.Name = "וולמן";
            teachers.Add(t3.Name, t3);

            Teacher t4 = new Teacher();
            t4.Name = "יוספת";
            teachers.Add(t4.Name, t4);

            Teacher t5 = new Teacher();
            t5.Name = "גירגשוני";
            teachers.Add(t5.Name, t5);

            Teacher t6 = new Teacher();
            t6.Name = "חידקל";
            teachers.Add(t6.Name, t6);

            Teacher t7 = new Teacher();
            t7.Name = "בוטבול";
            teachers.Add(t7.Name, t7);

            //כיתות

            Class c1 = new Class();
            c1.Name = "ט";
            c1.days[1] = 6;
            c1.days[2] = 6;
            c1.days[3] = 5;
            c1.days[4] = 6;
            c1.days[5] = 7;
            c1.days[6] = 4;           
            classes[(c1.Name)] = c1;

            Class c2 = new Class();
            c2.Name = "י";
            c2.days[1] = 6;
            c2.days[2] = 6;
            c2.days[3] = 6;
            c2.days[4] = 6;
            c2.days[5] = 7;
            c2.days[6] = 3;
            classes[(c2.Name)] = c2;

            Class c3 = new Class();
            c3.Name = "יא";
            c3.days[1] = 5;
            c3.days[2] = 7;
            c3.days[3] = 7;
            c3.days[4] = 6;
            c3.days[5] = 7;
            c3.days[6] = 4;
            classes[(c3.Name)] = c3;

            Class c4 = new Class();
            c4.Name = "יב";
            c4.days[1] = 7;
            c4.days[2] = 6;
            c4.days[3] = 6;
            c4.days[4] = 7;
            c4.days[5] = 5;
            c4.days[6] = 3;
            classes[(c4.Name)] = c4;           

            //דרישות עבור כיתה 1
            Requirment r1 = new Requirment();
            r1.ClassName = c1.Name;
            r1.SubjectName = "ערבית";
            r1.TeacherName = "רישי";
            r1.Num = 3;
            r1.rename();
            c1.Add(r1);

            Requirment r2 = new Requirment();
            r2.ClassName = c1.Name;
            r2.SubjectName = "ניתוח חיי הכבשה";
            r2.TeacherName = "חידקל";
            r2.Num = 5;
            r2.rename();
            c1.Add(r2);

            Requirment r3 = new Requirment();
            r3.ClassName = c1.Name;
            r3.SubjectName = "כבישי ישראל";
            r3.TeacherName = "חידקל";
            r3.Num = 1;
            r3.rename();
            c3.Add(r3);

            Requirment r4 = new Requirment();
            r4.ClassName = c1.Name;
            r4.SubjectName = "מלחמת מוחות";
            r4.TeacherName = "יוספת";
            r4.Num = 6;
            r4.rename();
            c1.Add(r4);

            Requirment r5 = new Requirment();
            r5.ClassName = c1.Name;
            r5.SubjectName = "שורי הבר";
            r5.TeacherName = "פילטובסקי";
            r5.Num = 4;
            r5.rename();
            c1.Add(r5);

            Requirment r6 = new Requirment();
            r6.ClassName = c1.Name;
            r6.SubjectName = "NLP";
            r6.TeacherName = "וולמן";
            r6.Num = 3;
            r6.rename();
            c1.Add(r6);

            //דרישות עבור כיתה 2
            Requirment r7 = new Requirment();
            r7.ClassName = c2.Name;
            r7.SubjectName = "קציר החיטים";
            r7.TeacherName = "וולמן";
            r7.Num = 7;
            r7.rename();
            c2.Add(r7);

            Requirment r8 = new Requirment();
            r8.ClassName = c2.Name;
            r8.SubjectName = "מפת ארץ ישראל";
            r8.TeacherName = "גירגשוני";
            r8.Num = 2;
            r8.rename();
            c2.Add(r8);

            Requirment r9 = new Requirment();
            r9.ClassName = c2.Name;
            r9.SubjectName = "ניתוח חיי הכבשה";
            r9.TeacherName = "בוטבול";
            r9.Num = 5;
            r9.rename();
            c2.Add(r9);

            Requirment r10 = new Requirment();
            r10.ClassName = c2.Name;
            r10.SubjectName = "מלחמת מוחות";
            r10.TeacherName = "יוספת";
            r10.Num = 3;
            r10.rename();
            c2.Add(r10);

            Requirment r11 = new Requirment();
            r11.ClassName = c2.Name;
            r11.SubjectName = "זימרה";
            r11.TeacherName = "רישי";
            r11.Num = 5;
            r11.rename();
            c2.Add(r11);

            Requirment r12 = new Requirment();
            r12.ClassName = c2.Name;
            r12.SubjectName = "מודעות עצמית";
            r12.TeacherName = "פילטובסקי";
            r12.Num = 1;
            r12.rename();
            c2.Add(r12);

            Requirment r13 = new Requirment();
            r13.ClassName = c2.Name;
            r13.SubjectName = "כבישי ישראל";
            r13.TeacherName = "חידקל";
            r13.Num = 4;
            r13.rename();
            c2.Add(r13);

            //דרישות עבור כיתה 3
            Requirment r14 = new Requirment();
            r14.ClassName = c3.Name;
            r14.SubjectName = "עצות נגד עין הרע";
            r14.TeacherName = "בוטבול";
            r14.Num = 3;
            r14.rename();
            c3.Add(r14);

            Requirment r15 = new Requirment();
            r15.ClassName = c3.Name;
            r15.SubjectName = "זימרה";
            r15.TeacherName = "רישי";
            r15.Num = 3;
            r15.rename();
            c3.Add(r15);
            Requirment r16 = new Requirment();
            r16.ClassName = c3.Name;
            r16.SubjectName = "מלחמת מוחות";
            r16.TeacherName = "פילטובסקי";
            r16.Num = 6;
            r16.rename();
            c3.Add(r16);

            Requirment r17 = new Requirment();
            r17.ClassName = c3.Name;
            r17.SubjectName = "יסודות הבנין";
            r17.TeacherName = "בוטבול";
            r17.Num = 5;
            r17.rename();
            c3.Add(r17);

            Requirment r18 = new Requirment();
            r18.ClassName = c3.Name;
            r18.SubjectName = "שורי הבר";
            r18.TeacherName = "פילטובסקי";
            r18.Num = 3;
            r18.rename();
            c3.Add(r18);

            Requirment r19 = new Requirment();
            r19.ClassName = c3.Name;
            r19.SubjectName = "ניתוח חיי הכבשה";
            r19.TeacherName = "בוטבול";
            r19.Num = 6;
            r19.rename();
            c3.Add(r19);

            Requirment r20 = new Requirment();
            r20.ClassName = c3.Name;
            r20.SubjectName = "קסמים";
            r20.TeacherName = "גירגשוני";
            r20.Num = 1;
            r20.rename();
            c3.Add(r20);

            //דרישות עבור כיתה 4
            Requirment r21 = new Requirment();
            r21.ClassName = c4.Name;
            r21.SubjectName = "קסמים";
            r21.TeacherName = "רישי";
            r21.Num = 7;
            r21.rename();
            c4.Add(r21);

            Requirment r22 = new Requirment();
            r22.ClassName = c4.Name;
            r22.SubjectName = "מלחמת מוחות";
            r22.TeacherName = "וולמן";
            r22.Num = 4;
            r22.rename();
            c4.Add(r22);

            Requirment r23 = new Requirment();
            r23.ClassName = c4.Name;
            r23.SubjectName = "בדידות";
            r23.TeacherName = "חידקל";
            r23.Num = 4;
            r23.rename();
            c4.Add(r23);

            Requirment r24 = new Requirment();
            r24.ClassName = c4.Name;
            r24.SubjectName = "כבישי ארץ ישראל";
            r24.TeacherName = "חידקל";
            r24.Num = 4;
            r24.rename();
            c4.Add(r24);

            Requirment r25 = new Requirment();
            r25.ClassName = c4.Name;
            r25.SubjectName = "יוספון";
            r25.TeacherName = "יוספת";
            r25.Num = 1;
            r25.rename();
            c4.Add(r25);

            Requirment r26 = new Requirment();
            r26.ClassName = c4.Name;
            r26.SubjectName = "עיצות נגד עין הרע";
            r26.TeacherName = "בוטבול";
            r26.Num = 7;
            r26.rename();
            c4.Add(r26);

            Requirment r27 = new Requirment();
            r27.ClassName = c4.Name;
            r27.SubjectName = "NLP";
            r27.TeacherName = "יוספת";
            r27.Num = 4;
            r27.rename();
            c4.Add(r27);

            Requirment r28 = new Requirment();
            r28.ClassName = c4.Name;
            r28.SubjectName = "קציר החיטים";
            r28.TeacherName = "וולמן";
            r28.Num = 6;
            r28.rename();
            c4.Add(r28);

            //מקצועות
            Subject s1 = new Subject();
            s1.Name = "קציר החיטים";
            subjects.Add(s1);

            Subject s2 = new Subject();
            s2.Name = "ערבית";
            subjects.Add(s2);

            Subject s3 = new Subject();
            s3.Name = "ניתוח חיי הכבשה";
            subjects.Add(s3);

            Subject s4 = new Subject();
            s4.Name = "מלחמת מוחות";
            subjects.Add(s4);

            Subject s5 = new Subject();
            s5.Name = "שורי הבר";
            subjects.Add(s5);

            Subject s6 = new Subject();
            s6.Name = "NLP";
            subjects.Add(s6);

            Subject s7 = new Subject();
            s7.Name = "מפת ארץ ישראל";
            subjects.Add(s7);

            Subject s8 = new Subject();
            s8.Name = "זימרה";
            subjects.Add(s8);

            Subject s9 = new Subject();
            s9.Name = "מודעות עצמית";
            subjects.Add(s9);

            Subject s10 = new Subject();
            s10.Name = "עיצות נגד עין הרע";
            subjects.Add(s10);

            Subject s11 = new Subject();
            s11.Name = "יסודות הבנין";
            subjects.Add(s11);

            Subject s12 = new Subject();
            s12.Name = "קסמים";
            subjects.Add(s12);

            Subject s13 = new Subject();
            s13.Name = "בדידות";
            subjects.Add(s13);

            Subject s14 = new Subject();
            s14.Name = "יוספון";
            subjects.Add(s14);

            Subject s15 = new Subject();
            s15.Name = "כבישי ישראל";
            subjects.Add(s15);

            //אילוצים
            ConTeacherMax mm = new ConTeacherMax();
            mm.Max = 2;
            
            conTM["גירגשוני"]=mm ;

            ConTeacherHours h = new ConTeacherHours();
            bool[,] a ={ {false,false, false,false,false,false,false,false,false,false },
            {false, false, true,true,true,false,false,false,true,true },
            {false, true, true,true,true,false,false,true,true,true },
            {false, true, false,true,true,true,true,false,true,true },
            {false, true, true,true,true,false,false,false,true,true },
            {false, true, true,true,true,false,false,false,true,true },
            {false, false, true,true,true,false,false,false,true,true },};
            h.hours = a;
            h.name = "וולמן";
            conTH.Add("וולמן", h);

            ConSubjectPossibility p = new ConSubjectPossibility();
            p.name = "ניתוח חיי הכבשה";
            p.whenTeach.Add(1);
            p.whenTeach.Add(2);
            conSP.Add(p.name, p);

            ConSubjectNoPossibility pn = new ConSubjectNoPossibility();
            pn.name = "ערבית";
            pn.whenNotTeach.Add(7);
            pn.whenNotTeach.Add(8);
            pn.whenNotTeach.Add(9);
            conSNP.Add(p.name, pn);

            ConSubject c31 = new ConSubject();
            c31.Max = 2;
            c31.Name = "זימרה";            
            conS["זימרה"] = c31;           
        }
        private static void ReadJsonToList()
        {
            string ss1= JsonSerializer.Serialize(classes);
            File.WriteAllText("..\\..\\..\\files\\classes.json", ss1);
            string s1 = File.ReadAllText("..\\..\\..\\files\\classes.json");
            classes = (Dictionary<string,Class>)JsonSerializer.Deserialize(s1, typeof(Dictionary<string, Class>));


            string s2 = File.ReadAllText("..\\..\\..\\files\\teachers.json");
            teachers = (Dictionary<string,Teacher>)JsonSerializer.Deserialize(s2, typeof(Dictionary<string,Teacher>));
        }
    }
}
