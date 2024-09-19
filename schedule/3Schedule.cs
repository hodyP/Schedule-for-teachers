using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace schedule
{
    partial class Schedule
    {
        private void sendInlay(object sender, EventArgs e)
        {
            exa.insert_inlay((Inlay)sender);
        }
        private void sendRequirment(object sender, EventArgs e)
        {
            exa.insert_requirment((Requirment)sender);
        }
        private void moveBack(object sender, EventArgs e)
        {
            change((Requirment)sender);
            ((Requirment)sender).Left = ((Requirment)sender).myLeft;
            ((Requirment)sender).Top = ((Requirment)sender).MyTop;
        }
        private void proper(Examination e)
        {
            if (check(e))
            {
                Insert(e);
                if (e.requirment.Left != e.requirment.myLeft)
                    change(e.requirment);
                e.inlay.Teacher = e.requirment.TeacherName;
                e.inlay.Subject = e.requirment.SubjectName;
                e.requirment.Left = e.inlay.Left;
                e.requirment.Top = e.inlay.Top;                                
            }
            exa.inlay = null;
            exa.requirment = null;   
        }

        private void change(Requirment r)
        {
            int x = r.Left;
            int y = r.Top;
            foreach (var item in classInlays[r.ClassName])
            {
                if(item.Left==x && item.Top==y)
                {
                    item.Teacher = null;
                    item.Subject = null;
                    Examination e1 = new Examination()
                    { inlay = item, requirment = r };
                    delete(e1);
                }
            }
            
        }

        private void Insert(Examination e)
        {
            (teachers[e.requirment.TeacherName])[e.inlay.Day, e.inlay.Hour] =false;
                        
            if (conTM.ContainsKey(e.requirment.TeacherName))
            {
                conTM[e.requirment.TeacherName].insert(e);
            }
            if (conS.ContainsKey(e.requirment.SubjectName))
            {
                conS[e.requirment.SubjectName].insert(e);
            }
        }

        private bool check(Examination e)
        {
           if( (teachers[e.requirment.TeacherName])[e.inlay.Day,e.inlay.Hour]==false)
            {
                MessageBox.Show(e.requirment.TeacherName + " already teach at this lesson");
                return false;
            }
            if (conTH.ContainsKey(e.requirment.TeacherName))
            {
                if (conTH[e.requirment.TeacherName].check(e) == false)
                    return false;
            }
            if (conTM.ContainsKey(e.requirment.TeacherName))
            {
                if (conTM[e.requirment.TeacherName].check(e) == false)
                    return false;
            }
            if (conS.ContainsKey(e.requirment.SubjectName))
            {
                if (conS[e.requirment.SubjectName].check(e) == false)
                    return false;
            }
            if (conSP.ContainsKey(e.requirment.SubjectName))
            {
                if (conSP[e.requirment.SubjectName].check(e) == false)
                    return false;
            }
            if (conSNP.ContainsKey(e.requirment.SubjectName))
            {
                if (conSNP[e.requirment.SubjectName].check(e) == false)
                    return false;
            }
            return true;
        }
        private void delete(Examination e)
        {
            (teachers[e.requirment.TeacherName])[e.inlay.Day, e.inlay.Hour] = true;
           
            if (conTM.ContainsKey(e.requirment.TeacherName))
            {
                conTM[e.requirment.TeacherName].delete(e);
            }
            if (conS.ContainsKey(e.requirment.SubjectName))
            {
                conS[e.requirment.SubjectName].delete(e);
            }
        }
    }
}
