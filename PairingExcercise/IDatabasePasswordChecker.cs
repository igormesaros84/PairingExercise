using System;

namespace PairingExercise
{
    public interface IDatabasePasswordChecker
    {
        bool DoesNewPasswordMatchPreviousPasswords(string newPassword);
    }
}
