using System;
using System.Windows.Forms;

namespace PairingExercise
{
    public partial class SetPasswordForm : Form
    {
        private readonly IPasswordValidator _validator;
        
        public SetPasswordForm()
        {
            InitializeComponent();

            _validator = new PasswordValidator();

            InitialiseLabels();
        }

        private void InitialiseLabels()
        {
            labelMinChars.Text = "A minimum of " + "_validator.MinimumLength" + " characters";
            labelMixedCase.Visible = _validator.MixedCaseRequired;
            labelNumeric.Visible = _validator.NumericCharacterRequired;
        }


        private void OnButtonSetPasswordClick(object sender, EventArgs e)
        {
            IPasswordValidator validator = new PasswordValidator();
            
            errorProvider.Clear();
            if (validator.Validate(textBoxPassword.Text) != ValidationResult.Valid)
            {
                errorProvider.SetError(textBoxPassword, "The password was invalid.");
            }
        }
    }
}
