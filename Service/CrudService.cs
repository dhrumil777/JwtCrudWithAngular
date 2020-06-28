using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPP.Models;

namespace WebAPP.Service
{
    public class CrudService
    {        
        public CrudService()
        {

        }

        public List<EmployeeVM> GetData()
        {
            List<EmployeeVM> Emplst = new List<EmployeeVM>();
            try
            {
                
            }
            catch(Exception ex)
            {
                //Return the inner exception on ui
                //store the logs
                //Email Send 
            }


            return Emplst;
        }

        public EmployeeVM GetDataById(int Id)
        {
            EmployeeVM Emp = new EmployeeVM();
            try
            {

            }
            catch (Exception ex)
            {
                //Return the inner exception on ui
                //store the logs
                //Email Send 
            }
            return Emp;
        }

        public bool PostData(EmployeeVM Emp)
        {
            //Save Data Sigle EF Call
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                //Return the inner exception on ui
                //store the logs
                //Email Send 
            }
            return false;
        }

        public bool DeleteData(int Id)
        {
            //EmployeeVM Emp = new EmployeeVM();
            try
            {
                //using (var db = new Model.TSContext())
                //{
                //    {
                //        var inv = db.Invoices.Include(s => s.Files).FirstOrDefault(s => s.InvoiceID == id);
                //        if (inv != null)
                //        {

                //            db.Entry(inv).State = System.Data.EntityState.Deleted;
                //            db.SaveChanges();
                //            return Json(new ViewModel.JsonResponse() { Status = "ok", Message = "Invoice Deleted.!" });
                //        }
                //        else
                //        {
                //            return Json(new ViewModel.JsonResponse() { Status = "error", Message = "Selected Invoice could not be found.!" });
                //        }
                //    }
                //}
                return true;
            }
            catch (Exception ex)
            {
                //Return the inner exception on ui
                //store the logs
                //Email Send 
            }
            return false;
        }

    }
}