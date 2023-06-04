﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes
{
    public class FoodRepository
    {
        private DB _db;

        public FoodRepository(DB dB)
        {
            _db = dB;
        }

        public bool Insert(Food food)
        {
            try
            {
                _db.Foods.Add(food);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Food> GetByRestaurantID(int RestaurantID)
        {
            return _db.Foods.Where(f => f.Restaurant_Id == RestaurantID).ToList();
        }
        public Food GetById(int FoodID)
        {
            return _db.Foods.Find(FoodID);
        }
        public bool Delete(int FoodID)
        {
            try
            {
                var food = GetById(FoodID);
                Delete(food);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(Food food)
        {
            try
            {
                _db.Foods.Remove(food);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Food food)
        {
            var local = _db.Foods.FirstOrDefault(f => f.Id == food.Id);
            if (local != null)
            {

                local.Name = food.Name;
                local.Price = food.Price;
                local.Exist = food.Exist;

                _db.SaveChanges();

                return true;
            }
            return false;


        }
    }
}
