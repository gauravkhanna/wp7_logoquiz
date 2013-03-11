using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.Data.Linq;
using System.Data.Linq.Mapping;
using Microsoft.Phone.Data.Linq.Mapping;

namespace logoquiz2
{
    public class Class1
    {
        public static logos_each[] logo;
        public static MyDataContext db;
        public static void initialize(int n)
        {
            logo = new logos_each[n];
            string[] newnull= {""};
            for (int i = 0; i < n; i++)
            {
                logo[i] = new logos_each();

                logo[i].check = 0;
                logo[i].mains ="";
                logo[i].answer = newnull;
                logo[i].hints = newnull;
                logo[i].throaway = "";
                logo[i].more = "";
            }
        }

        public static void getdatabase()
        {
            db = new MyDataContext("isostore:/DataBS.sdf");
            if (!db.DatabaseExists())
                db.CreateDatabase();
            updatedb();
        }

        public static void updatedb()
        {
            for(int i=0;i<2;i++)
            {
                Ans_check myData = new Ans_check()
                {
                    cId = i,
                    check=0
                };
            db.MyTaskItems.InsertOnSubmit(myData);
            db.SubmitChanges();
            }
        }

        public static void updatedb(int i,int s)
        {
            
            Ans_check myData = new Ans_check();
            var q = from b in db.MyTaskItems
                    where b.check == i
                    select b;
            foreach (MyTask taskItem in q)
            {
                db.MyTaskItems.DeleteOnSubmit(taskItem);
            }
            db.SubmitChanges();
            db.MyTaskItems.InsertOnSubmit(myData);
            db.SubmitChanges();
            Ans_check myData2 = new Ans_check()
            {
                cId=i,
                check=s
            };


            db.MyTaskItems.InsertOnSubmit(myData2);
            db.SubmitChanges();
        }
        public static void setlogo(int i, string m, string[] a, string[] h, string t, string mo)
        {
            logo[i].mains= m;
            logo[i].answer = a;
            logo[i].hints = h;
            logo[i].throaway = t;
            logo[i].more = mo;
        }
    }
}
