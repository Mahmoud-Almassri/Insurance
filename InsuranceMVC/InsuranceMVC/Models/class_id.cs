using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceMVC.Models
{
    public class listClasses
    {

        int class_id;
        string class_name;
        public int _class_id
        {
            set { _class_id = value; }
            get { return _class_id; }
        }
        public string _name
        {
            set { class_name = value; }
            get { return class_name; }
        }
    }
}