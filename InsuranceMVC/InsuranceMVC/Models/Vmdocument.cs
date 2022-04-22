using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceMVC.Models
{
    public class Vmdocument
    {
        documents doc =new documents();
        public documents _doc
        {
        set {doc= value;}
        get {return doc;}
        }
        List<documents> listdocuments =new List<documents>();
        public List<documents> _listdocuments
        {
            set{listdocuments = value;}
             get {return listdocuments;}
        }
        List<apply_on> applyon = new List<apply_on>();
        public List<apply_on> _list_applyon
        {
            set{applyon = value;} 
            get {return applyon;}
        }
        
        
        List<listClasses> classid = new List<listClasses>();
        public List<listClasses> _list_classid
        {
            set{classid = value;} 
            get{ return classid;}
        }
    }
    }
