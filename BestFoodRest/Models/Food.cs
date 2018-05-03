using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BestFoodRest;
using System;
using Microsoft.AspNetCore.Mvc;

namespace BestFoodRest
{
    public class Food
    {
        private int _id;
        private string _type;

        public Food(int Id = 0, string Type)
        {
            _id = Id;
            _type = Type;

        }

        public int GetId()
        {
          return _id;
        }

        public string GetType()
        {
          return _type;
        }
    }
}
