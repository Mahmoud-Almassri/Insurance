using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceMVC.Models
{
    public class VmDocuments
    {

        Documents doc =new Documents();
        public Documents _doc
        {
        set {doc= value;}
        get {return doc;}
        }
        
        List<ApplyOn> applyon = new List<ApplyOn>();
        public List<ApplyOn> _list_applyon
        {
            set{applyon = value;} 
            get {return applyon;}
        }
        
        
        List<Class_id> classid = new List<Class_id>();
        public List<Class_id> _list_classid
        {
            set{classid = value;} 
            get{ return classid;}
        }



        
    }
}