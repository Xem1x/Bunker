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
        static List<string> gender_list  = new List<string>{ "Чоловік", "Жінка" };

        static List<string> bio_pregnant_women = new List<string> { "Вагітна", "", "", "", "", "", "" };
        static List<string> bio_sexual_char = new List<string> { "Асексуальний", "", "" };
        static Player_Generator()
        {
            
            
        }
        static public string GenerateBioChacteristics()
        {
            Random random = new Random();
            var age = random.Next(18,85);
            var gender_random = random.Next(gender_list.Count());
            var gender = gender_list[gender_random];
            var pregnancy = "";
            if (gender.ToString() == "Жінка")
            {
                var pregnancy_random = random.Next(gender_list.Count());
                pregnancy = bio_pregnant_women[pregnancy_random];
                
            }
            if(pregnancy == "")
            {
                var sexual_random = random.Next(bio_sexual_char.Count());
                var sexual = bio_pregnant_women[sexual_random];
                
            }
            return age.ToString() + " " + gender + " ";
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
            request = "Select Job from Char";
            var temp = GenerateCharacteristic();
            GlobalVar.alreadyAssignedCharactr.Add(temp);
            return temp;
        }


        static public string GetHealth()
        {
            request = "Select Health from Char";
            return GenerateCharacteristic();
        }


        static public string GetPhobia()
        {
            request = "Select Phobia from Char";
            return GenerateCharacteristic();
        }


        static public string GetHobby()
        {
            request = "Select Hobby from Char";
            return GenerateCharacteristic();
        }


        static public string GetAdditionalInfo()
        {
            request = "Select Additional_info from Char";
            return GenerateCharacteristic();
        }


        static public string GetKnowledge()
        {
            request = "Select Knowledge from Char";
            return GenerateCharacteristic();
        }


        static public string GetLuggage()
        {
            request = "Select Backpack from Char";
            return GenerateCharacteristic();
        }

    }
}