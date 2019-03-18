using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace nDeathTask.Models
{
    public class ParabolaCoefficients
    {
        [Required(ErrorMessage = "A coefficient required")]
        [Range(Double.MinValue, Double.MaxValue, ErrorMessage = "Invalid data")]
        public double ACoeff { get; set; }

        [Range(Double.MinValue, Double.MaxValue, ErrorMessage = "Invalid data")]
        public double BCoeff { get; set; }

        [Range(Double.MinValue, Double.MaxValue, ErrorMessage = "Invalid data")]
        public double CCoeff { get; set; }

        [Required(ErrorMessage = "Step required")]
        [Range(0.1, 10, ErrorMessage = "Step must be between 0.1 and 10")]
        public double Step { get; set; }

        [Required(ErrorMessage = "From required")]
        [Range(Double.MinValue, Double.MaxValue, ErrorMessage = "Invalid data")]
        public double LowerBorder { get; set; }

        [Required(ErrorMessage = "To required")]
        [Range(Double.MinValue, Double.MaxValue, ErrorMessage = "Invalid data")]
        public double UpperBorder { get; set; }
    }
}