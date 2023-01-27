using System;
using System.Linq;

namespace PairingExercise
{
    public class PasswordValidator : IPasswordValidator
    {
        public int MinimumLength => throw new NotImplementedException();

        public bool MixedCaseRequired => throw new NotImplementedException();

        public bool NumericCharacterRequired => throw new NotImplementedException();

        public ValidationResult Validate(string password)
        {
            throw new NotImplementedException();
        }
    }
}
