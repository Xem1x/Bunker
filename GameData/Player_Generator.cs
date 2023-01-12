using BUNKER.GameData;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace BUNKER.GameData
{
    
    public class Player_Generator : SQLClient
    {
        /// 
        /// 
        /// 
        // add proper columns in DB requests
        /// 
        /// 
        /// 
        
        static Player_Generator()
        {
            
            
        }
        static protected string GenerateRandomFromList(List<string> res_list)
        {
            Random random = new Random();
            int random_element = random.Next(res_list.Count());
            return res_list[random_element];
        }
        static protected string GenerateCharacteristic()
        {
            InitSqlRequest();
            var res_list = GetResults();
            var temp = res_list.Where(i => !GlobalVar.alreadyAssignedCharactr.Any(e => i.Contains(e)));
            res_list = temp.ToList();
            return GenerateRandomFromList(res_list);
        }


        static public string GetJob()
        {
            request = "Select Characteristics_1 from Test_table";
            var temp = GenerateCharacteristic();
            GlobalVar.alreadyAssignedCharactr.Add(temp);
            return temp;
        }


        static public string GetHealth()
        {
            request = "Select Characteristics_1 from Test_table";
            return GenerateCharacteristic();
        }


        static public string GetPhobia()
        {
            request = "Select Characteristics_1 from Test_table";
            return GenerateCharacteristic();
        }


        static public string GetHobby()
        {
            request = "Select Characteristics_1 from Test_table";
            return GenerateCharacteristic();
        }


        static public string GetAdditionalInfo()
        {
            request = "Select Characteristics_1 from Test_table";
            return GenerateCharacteristic();
        }


        static public string GetKnowledge()
        {
            request = "Select Characteristics_1 from Test_table";
            return GenerateCharacteristic();
        }


        static public string GetLuggage()
        {
            request = "Select Characteristics_1 from Test_table";
            return GenerateCharacteristic();
        }

    }
}