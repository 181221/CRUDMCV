//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace CRUDMCV.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class ValidString : ValidationAttribute
    {
        readonly string _mask;

        public string Mask
        {
            get { return _mask; }
        }

        public ValidString(string mask)
        {
            _mask = mask;
        }


        public override bool IsValid(object value)
        {
            string inputString = "value";
            int numValue;
            return Int32.TryParse(inputString, out numValue);
        }
        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture,
                ErrorMessageString, name, this.Mask);
        }
    }


    public partial class Person
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "the {0} must be of type character")]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public string Income { get; set; }
        [Required]
        [ValidString("The field takes a type of char as input")]
        [StringLength(50, ErrorMessage = "the {0} must be of type character")]
        public string Partner { get; set; }
    }
}
