using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPP.Models;
using WebAPP.Models.EntityModel;

namespace WebAPP.Service
{
    public class CrudService
    {
        WebAPP.DataContext.DataContext db;
        public CrudService()
        {
            db = new DataContext.DataContext();
        }

        public List<Employee> GetData()
        {
            List<Employee> Emplst = new List<Employee>();
            try
            {
                Emplst = db.Employees.ToList();
            }
            catch (Exception ex)
            {
                //Return the inner exception on ui
                //store the logs
                //Email Send 
            }


            return Emplst;
        }

        public Employee GetDataById(int Id)
        {
            Employee Emp = new Employee();
            try
            {
                Emp = db.Employees.FirstOrDefault(x => x.EmployeeId == Id);
            }
            catch (Exception ex)
            {
                //Return the inner exception on ui
                //store the logs
                //Email Send 
            }
            return Emp;
        }

        public bool PostData(Employee Emp)
        {
            //Save Data Sigle EF Call
            try
            {
                db.Employees.Add(Emp);
                db.SaveChanges();
                //using (var ctx = new Entity())
                //{

                //    Product prodObject = new Product
                //    {
                //        PId = //NEW ID,
                //        SalePrice = salePrice
                //    };

                //    Product_tax pTax = new Product_tax
                //    {
                //        pid = prodObject.PId,
                //        taxid = taxValue
                //    };

                //    ctx.product.AddObject(prodObject);
                //    ctx.Product_tax.AddObject(pTax);

                //    ctx.SaveChanges();
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

        public bool DeleteData(int Id)
        {
            try
            {
                Employee Emp = new Employee();
                Emp = db.Employees.FirstOrDefault(x=>x.EmployeeId == Id);
                db.Employees.Remove(Emp);
                db.SaveChanges();
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