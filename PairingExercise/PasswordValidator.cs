using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PairingExercise
{
    public class PasswordValidator : IPasswordValidator
    {
        public int MinimumLength => throw new NotImplementedException();

        public bool MixedCaseRequired => throw new NotImplementedException();

        public bool NumericCharacterRequired => throw new NotImplementedException();

        public ValidationResult Validate(string password)
        {
        }
    }
}
