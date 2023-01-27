using System;

namespace PairingExercise
{
    public enum ValidationResult
    {
        Valid,
        Empty,
        InsufficientLength,
        InsufficientComplexity,
        SameAsOldPassword
    }

    public interface IPasswordValidator
    {
        ValidationResult Validate(string password);

        int MinimumLength { get; }
        bool MixedCaseRequired { get; }
        bool NumericCharacterRequired { get; }
    }
}
