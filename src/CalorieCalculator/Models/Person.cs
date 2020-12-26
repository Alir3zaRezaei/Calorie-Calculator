using System.ComponentModel.DataAnnotations;
using Enums;


namespace Models   
{
   public class Person
   {

        [Required(ErrorMessage = "واردکردن مقدار وزن الزامیست")]
        public double weight {get; set;}

        [Required(ErrorMessage = "واردکردن مقدار قد الزامیست")]
        public double height {get; set;}       
        
        [Required(ErrorMessage = "واردکردن مقدار سن الزامیست")]
        [Range(0, 130, ErrorMessage = "مقدار سن نامعتبر است")]
        public double age {get; set;}

        public GenderType gender {get; set;}
        
        public ActivityLevel activityLevel {get; set;}
   }

}