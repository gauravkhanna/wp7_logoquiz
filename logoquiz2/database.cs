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
    [Table]
    public class Ans_check
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int cId { get; set; }
        [Column]
        public int check { get; set; }
        
    }
    public class MyDataContext : DataContext
    {
        public Table<Ans_check> MyTaskItems;
        public MyDataContext(string connection): base(connection)
        {
        }
    }
    
}
