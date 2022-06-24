using System;
using ShopBaseballBats.Models;

namespace ShopBaseballBats.Data
{
    public class BaseballBatsRepository
    {
        private static BaseballBat[] _baseballBat = new BaseballBat[]
        {
            new BaseballBat()
            {
                Id = 1,
                BatBrand = "Louisville Slugger",
                DescriptionHtml = "<p>Swing for the fences.</p>",
                BatModels = new BatModel[]
               {

                        new BatModel() {Name = "Meta", Length = 33, Weight = 22},
                        new BatModel() {Name = "Meta", Length = 32, Weight = 22},
                        new BatModel() {Name = "LXT", Length = 33, Weight = 22},
                        new BatModel() {Name = "LXT", Length = 32, Weight = 22},
                        new BatModel() {Name = "Xeno", Length = 33, Weight = 22},
                        new BatModel() {Name = "Xeno", Length = 32, Weight = 22},

               }
            },

            new BaseballBat()
            {
                Id = 2,
                BatBrand = "Easton",
                DescriptionHtml = "<p>Ghost it.</p>",
                BatModels = new BatModel[]
               {

                        new BatModel() {Name = "Ghost", Length = 33, Weight = 22},
                        new BatModel() {Name = "Ghost", Length = 32, Weight = 22},
                       
               }
            },
            new BaseballBat()
            {
                Id= 3,
                BatBrand = "Rawlings",
                DescriptionHtml = "<p>You have a new Mantra.</p>",
                BatModels = new BatModel[]
               {

                        new BatModel() {Name = "Mantra", Length = 33, Weight = 22},
                        new BatModel() {Name = "Mantra", Length = 32, Weight = 22},
                        
               }
            }



    };

            public BaseballBat[] GetBaseballBats()
        {
            return _baseballBat;
        }
            public BaseballBat GetBaseballBats(int id)
        {
            BaseballBat? baseballBatsToReturn = null;

            foreach (var baseballBats in _baseballBat)
            {
                if (baseballBats.Id == id)
                {  
                    baseballBatsToReturn = baseballBats; 
                    break;
                }
            }
            return baseballBatsToReturn;
        }
    }
}
