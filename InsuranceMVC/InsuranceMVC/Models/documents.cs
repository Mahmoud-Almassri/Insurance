using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceMVC.Models
{
    public class documents
    {
        public int _id { set; get; }
        public string _name { set; get; }
        public int _class_id { set; get; }
        public int _Apply_On { set; get; }
        public int _is_required { set; get; }
        public string _Created_By { set; get; }
        public string _Creation_Date { set; get; }
        public string _Modify_By { set; get; } 
        public string _Modification_Date { set; get; }

        
    }
}