using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

    public class userMasterBAL
    {
        userMasterDAL userMasterDAL = new userMasterDAL();

        public bool insertPasscode(int passcode)
        {
            try
            {
                return userMasterDAL.insertPasscode(passcode);
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }

        public bool checkValidEmailToResetPassword(userMasterBO userMasterBO)
        {
            try
            {

                return userMasterDAL.checkValidEmailToResetPassword(userMasterBO);
               // return true;
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }

        public Int64 getGuid(userMasterBO userMasterBO)
        {
            try
            {

                return (userMasterDAL.getGuid(userMasterBO));
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }

        public string[] checkUser(userMasterBO userMasterBO)
        {
            try
            {
                return (userMasterDAL.checkUser(userMasterBO));
            }
            catch
            {
                throw;
            }
            finally{

            }

            

        }
        public Int16 getSocialNetworkId(string socialType)
        {

            try
            {
                return userMasterDAL.getSocialNetworkId(socialType);
            }
            catch
            {
                throw;
            }
            finally
            {

            }


        }
        public string insertUser(userMasterBO userMasterBO)
        {

            try
            {
              
                return (userMasterDAL.insertUser(userMasterBO));
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
