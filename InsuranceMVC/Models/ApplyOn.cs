using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceMVC.Models
{
    public class ApplyOn
    {
        int apply_id;
        string apply_name;
        public int _class_id
        {
            set { apply_id = value; }
            get { return apply_id; }
        }
        public string _name
        {
            set { apply_name = value; }
            get { return apply_name; }
        }
    }
}