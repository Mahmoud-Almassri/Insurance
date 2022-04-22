using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceMVC.Models
{
    public class MultipleSubmit : ActionNameSelectorAttribute
    {
        string z;
        public string _z
        { set { z = value; } get { return z; } }
        public override bool IsValidName(ControllerContext controllerContext, string actionName, System.Reflection.MethodInfo methodInfo)
        {
            var c = controllerContext.Controller.ValueProvider.GetValue(_z);
            if (z != null)
            { return true; }
            else
            { return false; }

        }
    }
}