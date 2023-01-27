namespace PairingExercise
{
    partial class SetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSetPassword = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelMinChars = new System.Windows.Forms.Label();
            this.labelMixedCase = new System.Windows.Forms.Label();
            this.labelNumeric = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetPassword
            // 
            this.buttonSetPassword.Location = new System.Drawing.Point(159, 38);
            this.buttonSetPassword.Name = "buttonSetPassword";
            this.buttonSetPassword.Size = new System.Drawing.Size(124, 23);
            this.buttonSetPassword.TabIndex = 0;
            this.buttonSetPassword.Text = "Set Password";
            this.buttonSetPassword.UseVisualStyleBackColor = true;
            this.buttonSetPassword.Click += new System.EventHandler(this.OnButtonSetPasswordClick);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 12);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(271, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelMinChars
            // 
            this.labelMinChars.AutoSize = true;
            this.labelMinChars.Location = new System.Drawing.Point(13, 85);
            this.labelMinChars.Name = "labelMinChars";
            this.labelMinChars.Size = new System.Drawing.Size(171, 13);
            this.labelMinChars.TabIndex = 3;
            this.labelMinChars.Text = "Minimum of {0} characters required";
            // 
            // labelMixedCase
            // 
            this.labelMixedCase.AutoSize = true;
            this.labelMixedCase.Location = new System.Drawing.Point(13, 98);
            this.labelMixedCase.Name = "labelMixedCase";
            this.labelMixedCase.Size = new System.Drawing.Size(234, 13);
            this.labelMixedCase.TabIndex = 4;
            this.labelMixedCase.Text = "At least one lower and one uppercase character";
            // 
            // labelAlphaNumeric
            // 
            this.labelNumeric.AutoSize = true;
            this.labelNumeric.Location = new System.Drawing.Point(13, 111);
            this.labelNumeric.Name = "labelNumeric";
            this.labelNumeric.Size = new System.Drawing.Size(153, 13);
            this.labelNumeric.TabIndex = 5;
            this.labelNumeric.Text = "A numeric character is required";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Requirements";
            // 
            // SetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 142);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNumeric);
            this.Controls.Add(this.labelMixedCase);
            this.Controls.Add(this.labelMinChars);
            this.Controls.Add(this.buttonSetPassword);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetPasswordForm";
            this.Text = "Set A New Password";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelNumeric;
        private System.Windows.Forms.Label labelMixedCase;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelMinChars;
    }
}

