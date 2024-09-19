using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace schedule
{
    partial class Schedule
    {
        //משתני המחלקה

        //רשימת מורות
        static Dictionary<string,Teacher> teachers=new Dictionary<string,Teacher>();
        //רשימת כיתות 
        static Dictionary<string,Class> classes=new Dictionary<string, Class>();
        //רשימת מקצועות
        static List<Subject> subjects=new List<Subject>();
        //רשימת מערכת כיתה
        List<ClassSchedule> cs=new List<ClassSchedule>();

        static Dictionary<string, ConTeacherHours> conTH = new Dictionary<string, ConTeacherHours>();

        static Dictionary<string, ConTeacherMax> conTM = new Dictionary<string, ConTeacherMax>();

        static Dictionary<string, ConSubject> conS = new Dictionary<string, ConSubject>();

        static Dictionary<string, ConSubjectPossibility> conSP = new Dictionary<string, ConSubjectPossibility>();

        static Dictionary<string, ConSubjectNoPossibility> conSNP = new Dictionary<string, ConSubjectNoPossibility>();
        static Dictionary<string,List<Inlay>> classInlays=new Dictionary<string,List<Inlay>>();


        //form ראשי
        public MainForm mainForm = new MainForm();
        public Examination exa = new Examination();
        
        public Schedule()
        {    //פונקציות איתחול דף ראשי ומילוי המשתנים       
            exa.bothFull += proper;
            mainForm.finish += load_final;
            create();
            write_to_json();
            read_from_json();
            createButtonClass();
        }

        private void load_final(Button b)
        {
            string s = JsonSerializer.Serialize(classInlays);
            File.WriteAllText("..\\..\\..\\files\\Inlays.json", s);
            DataGridView data = new DataGridView();
            mainForm.Controls.Add(data);
            data.DataSource = classInlays;
        }

        //יצירת כפתורי כיתה ע"פ רשימת הכיתות
        private void createButtonClass()
        {
            foreach (var item in classes)
            {
                ButtonClass b = new ButtonClass();
                b.Text = item.Value.Name;
                b.Click+= showScheduleClass;
                mainForm.Controls.Add(b);
            }
        }

        //יצירת טופס מערכת עבור כל כיתה
        private void showScheduleClass(object b, EventArgs e)
        {
            ClassSchedule s = new ClassSchedule();
            s.Text = "כיתה "+((Button)b).Text;
            cs.Add(s);           
            s.Show();           
            create_label_requrment((Button)b, s);
            create_button_inlay((Button)b, s);
        }

        //יצירת תגיות הדרישות לכל כיתה
        private void create_label_requrment(Button b, ClassSchedule s)
        {
            int top = 90;
            foreach (var item in classes[b.Text])
            {                
                    ((Requirment)item).MyTop = top;
                    ((Requirment)item).replace();
                    ((Requirment)item).Click += sendRequirment;
                    ((Requirment)item).DoubleClick += moveBack;
                    s.Controls.Add((Requirment)item);
                for (int i = 2; i <= ((Requirment)item).Num; i++)
                {
                    Requirment r = new Requirment((Requirment)item);
                    r.Click += sendRequirment;
                    r.DoubleClick += moveBack;
                    s.Controls.Add(r);
                }
                    top += 50;
            }
        }        

        //יצירת טבלת השיבוץ לכיתה
        private void create_button_inlay(Button b,ClassSchedule s)
        {
            int max = 0;           
            int top = 100, left = 750;
            int day = 0;
            classInlays[b.Text]=new List<Inlay>();
            foreach (var i in classes[b.Text].days)
            {
                if (i > max)
                    max = i;
                if (day != 0)
                    addTagday(left, day, s);
                for (int j = 1; j <= i; j++)
                {
                    Inlay y = new Inlay();
                    y.Day=day;
                    y.Hour = j;
                    y.ClassName = b.Text;
                    y.Top = top;
                    y.Left = left;
                    top += 55;
                    s.Controls.Add(y);
                    y.Click += sendInlay;
                    classInlays[b.Text].Add(y);
                }
                left -= 95; top = 100; day++;
            }
            add_tag_hour(max,s);
        }       
        //הוספת תגית שעה לטבלת המערכת
        private void add_tag_hour(int max,ClassSchedule s)
        {
            
            for (int i = 1; i <= max; i++)
            {
                Label l = new Label();
                l.Text = (i + 7) + ":00";
                stayle_label(l);
                s.Controls.Add(l);
                l.Left = 750;
                l.Top = 100 + 55 * (i-1);
            }
        }

        //עיצוב התגיות
        private  void stayle_label(Label l)
        {
            l.Width = 90;
            l.Height = 50;
            l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            l.BackColor = System.Drawing.Color.LightSalmon;
        }

        //יצירת תוית יום לטבלת המערכת
        private void addTagday(int left,int day,ClassSchedule s)
        {
            Label l = new Label();
            
            switch (day)
            {
                case 1:
                    l.Text = (DayOfWeek.Sunday).ToString();
                    break;
                case 2:
                    l.Text = (DayOfWeek.Monday).ToString();
                    break;
                case 3:
                    l.Text = (DayOfWeek.Tuesday).ToString();
                    break;
                case 4:
                    l.Text = (DayOfWeek.Wednesday).ToString();
                    break;
                case 5:
                    l.Text = (DayOfWeek.Thursday).ToString();
                    break;
                case 6:
                    l.Text = (DayOfWeek.Friday).ToString();
                    break;                              
            }            
            l.Top = 45;
            l.Left = left;            
            s.Controls.Add(l);
            stayle_label(l);
        }
    }
}
