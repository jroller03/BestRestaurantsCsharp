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

        public Food(string Type, int Id = 0)
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
