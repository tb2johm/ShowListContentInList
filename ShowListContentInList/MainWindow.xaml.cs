using System.Collections.Generic;
using System.Dynamic;
using System.Windows;

namespace ShowListContentInList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class VM
    {
        public List<dynamic> ObjectList { get; set; }

        public VM()
        {
            ObjectList = new List<dynamic>();

            var ex = new ExpandoObject();
            var dict = (IDictionary<string, object>) ex;
            dict["test1"] = "markus";
            dict["test2"] = "anders";
            ObjectList.Add(ex);
            
            dict["test1"] = "arvid";
            dict["test2"] = "erik";
            ObjectList.Add(ex);


        }
    }
}
