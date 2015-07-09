using System;
using System.Collections.Generic;
using System.Text;

namespace Body_Mass_and_Fitness
{
    class BmiCalc
    {
        public double weight { get; set; }
        public double height { get; set; }

        public BmiCalc(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
        }


        public double calcBMI()
        {
            double bmi = 0.0;

            bmi = (weight) / (height * height);

            return bmi;
        }

        public string getWeightLevel()
        {
            string weightLevel = "";
            double bmi = calcBMI();


            if (bmi < 18.5) { weightLevel = "You are Under Weight :/"; }
            if (bmi >= 18.5 && bmi <= 24.9) { weightLevel = "You're weight balance is Normal :)"; }
            if (bmi >= 25.0 && bmi <= 29.9) { weightLevel = "You're OVERWEIGHT!!!! :("; }
            if (bmi >= 30.0) { weightLevel = "You're Obese!!! Reduce excessive weight and stay healthy! :("; }
                

            return weightLevel;
        }
        
    }
}
