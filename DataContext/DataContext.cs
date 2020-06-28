using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPP.Models.EntityModel;

namespace WebAPP.DataContext
{
    #region EFError While Create DB 
    /*
      1)Code First Error while Enable-Migrations
       solution
       1)Put the connectionStrings element is after the configSections element.
       2)Put the startup element after the connectionStrings element.

       <?xml version="1.0" encoding="utf-8"?>
        <configuration>
          <configSections>
                <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=4.3.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
          </configSections>
          <connectionStrings>
                <add name="SchedulingContext" connectionString="Data Source=XXX\SQL2008R2DEV;Initial Catalog=YYY;Persist Security Info=True;User ID=sa;Password=XXX"   providerName="System.Data.SqlClient"/>
          </connectionStrings>
          <startup>
               <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5" />
         </startup>       
        </configuration>

        Stackoverflow Link
         https://stackoverflow.com/questions/17585611/the-type-initializer-for-system-data-entity-internal-appconfig-threw-an-except

    */
    #endregion

    public class DataContext: DbContext
    {
        public DataContext() : base("DBConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}