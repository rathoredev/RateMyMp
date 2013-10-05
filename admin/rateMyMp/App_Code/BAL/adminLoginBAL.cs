using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



    public class adminLoginBAL
    {
        adminLoginDAL AdminLoginDAL = new adminLoginDAL();
        
        public bool AdminLoginCheck(adminLoginBO AdminLoginBO)
        {
            try
            {
                return AdminLoginDAL.AdminLoginCheck(AdminLoginBO);
            }
            catch
            {
                throw;
            }
            finally
            { 

            }
        }


        public void ChangePassword(adminLoginBO AdminLoginBO)
        {
            try
            {
                AdminLoginDAL.ChangePassword(AdminLoginBO);
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }
    }
