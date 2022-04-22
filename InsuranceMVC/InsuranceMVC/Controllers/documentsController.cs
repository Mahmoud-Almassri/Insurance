using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InsuranceMVC.Models;
using System.Data.OracleClient;
using System.Data;


namespace InsuranceMVC.Controllers
{
    public class documentsController : Controller
    {
        //
        // GET: /documents/
        public ActionResult Frmdocuments()
        {
            return View("Frmdocuments");
        }



        public List<listClasses> _class_id ()
        {
           
              OracleConnection con = new OracleConnection();
              con.ConnectionString = "datasource = xe ; integratedsecurity=false;user=isurance_2;password=insurane_2";
              OracleCommand cmd = new OracleCommand();
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "DBPK_SETUP.fill_class";
              cmd.Connection = con;
              OracleParameter id = cmd.Parameters.Add("p_y  ", OracleType.Number);
              id.Direction = ParameterDirection.Output;
              id.Value = Convert.ToInt32(Request.Form["listsearchclass"]);
              OracleParameter name = cmd.Parameters.Add("p_y  ", OracleType.VarChar);
              name.Direction = ParameterDirection.Output;
              name.Value = Request.Form["listsearchclass"];
              con.Open();
               List<listClasses> doc=new List<listClasses>();
              OracleDataReader _R = cmd.ExecuteReader();
              while(_R.Read())              {
              { 

                  listClasses document=new listClasses();
                  document._class_id=Convert.ToInt32(_R["id"]);
                  document._name=_R["name"].ToString();
              }
              
              con.Close();
             
             
              return doc ;
        }
        public List<apply_on> _apply_on()
        {

            OracleConnection con = new OracleConnection();
            con.ConnectionString = "datasource = xe ; integratedsecurity=false;user=isurance_2;password=insurane_2";
            OracleCommand cmd = new OracleCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DBPK_SETUP.fill_class";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            OracleParameter value = cmd.Parameters.Add("value", OracleType.Number);
            value.Direction = ParameterDirection.Output;
            value.Value = Convert.ToInt32(Request.Form["listsearchapply_on"]);
            OracleParameter name = cmd.Parameters.Add("name", OracleType.VarChar);
            name.Direction = ParameterDirection.Output;
            name.Value = Request.Form["listsearchapply_on"];
            return;
        }
       
        [MultipleSubmit(_z = "save")]
        public ActionResult Savedata()
        {
            OracleConnection con = new OracleConnection();
            return View();
        }

        [MultipleSubmit(_z = "Update")]
        public ActionResult Updatedata()
        {
            return View();
        }

        [MultipleSubmit(_z = "Search")]
        public ActionResult Searchdata()
        {
            return View();
        }     


	}
}