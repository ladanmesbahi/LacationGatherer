using System.ComponentModel.DataAnnotations;

namespace LacationGatherer.Shared.Infrastructue.Validators
{
    public class DecimalMinValueAttribute : ValidationAttribute
    {
        private readonly decimal _minValue;

        public DecimalMinValueAttribute(int minValue)
        {
            _minValue = minValue;
        }

        public override bool IsValid(object value)
        {
            return (decimal)value > _minValue;
        }
    }
}
