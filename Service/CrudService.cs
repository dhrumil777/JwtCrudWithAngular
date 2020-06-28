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