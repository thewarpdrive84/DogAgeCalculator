using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DogAgeCalculator.Models
{
    public class Dog
    {
        // imperial units (pounds)
        const double SmallLimit = 20;
        const double MediumLimit = 50;

        // conversion factors from dog to human age
        const double ConvertSmall = 4;
        const double ConvertMedium = 6;
        const double ConvertLarge = 8;

        [Required]
        [Display(Name = "Weight in Pounds")]
        [Range(1, 400, ErrorMessage = "Pounds must be between 1 and 400")]
        public double WeightPounds { get; set; }

        [Required]
        [Display(Name = "Age in Years")]
        [Range(1, 30, ErrorMessage = "Age must be between 1 and 30")]
        public double AgeYears { get; set; }

        // calculate equivalent Human Age
        [Display(Name = "so your dog's human age is")]
        public double AgeValue
        {
            get
            {
                // do conversions to human years
                if (WeightPounds <= SmallLimit)
                {
                    double dogHumanAge = AgeYears * ConvertSmall;
                    return dogHumanAge;
                }
                else if (WeightPounds <= MediumLimit)
                {
                    double dogHumanAge = AgeYears * ConvertMedium;
                    return dogHumanAge;
                }
                else
                {
                    double dogHumanAge = AgeYears * ConvertLarge;
                    return dogHumanAge;
                }
            }
        }

        // show size category
        [Display(Name ="Your dog is ")]
        public string SizeCategory
        {
            get
            {
                if (WeightPounds <= SmallLimit)
                {
                    return "small,";
                }
                else if (WeightPounds <= MediumLimit)
                {
                    return "medium,";
                }
                else
                {
                    return "large,";
                }
            }
        }
    }
}