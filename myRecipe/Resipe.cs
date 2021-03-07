using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myRecipe
{
    class Resipe
    {
        public string Name { get; set; }
        public string calories { get; set; }
        public string preparation_time { get; set; }
        public string Ingredients { get; set; }
        public string Difficulty { get; set; }
        public string[] resipes { get;set ;}

        public Resipe(string name, string calories, string preparation_time, string ingredients, string difficulty)
        {
            Name = name;
            this.calories = calories;
            this.preparation_time = preparation_time;
            Ingredients = ingredients;
            Difficulty = difficulty;
        }

        public Resipe()
        {
            this.resipes = resipes;

        }
        public void Insert(string s1)
        {
            List<string> resipe = new List<string>();
            resipe.Add(s1.ToString());
            
           
        }

        public override string ToString()
        {
            string user = $"name:{Name}\ncalories:{calories}\npreparation time:{preparation_time}\nIngredients:\n{Ingredients}\nDifficulty:{Difficulty};\n\n";
            return user;
        }
    }
}
