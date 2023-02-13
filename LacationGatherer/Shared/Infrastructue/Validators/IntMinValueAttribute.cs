using System.ComponentModel.DataAnnotations;

namespace LacationGatherer.Shared.Infrastructue.Validators
{
    internal class IntMinValueAttribute : ValidationAttribute
    {
        private readonly int _value;

        public IntMinValueAttribute(int value)
        {
            _value = value;
        }
        public override bool IsValid(object value)
        {
            return (int)value > _value;
        }
    }
}
