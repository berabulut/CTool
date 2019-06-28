namespace Cryptography_Tool
{
    partial class CTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTool));
            this.encrypt_Button = new System.Windows.Forms.Button();
            this.decrypted_Text = new System.Windows.Forms.RichTextBox();
            this.encrypted_Text = new System.Windows.Forms.RichTextBox();
            this.decrypt_Button = new System.Windows.Forms.Button();
            this.input_Alphabet = new System.Windows.Forms.TextBox();
            this.alphabetLabel = new System.Windows.Forms.Label();
            this.inputKey = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encrypt_Button
            // 
            this.encrypt_Button.Location = new System.Drawing.Point(543, 245);
            this.encrypt_Button.Name = "encrypt_Button";
            this.encrypt_Button.Size = new System.Drawing.Size(101, 38);
            this.encrypt_Button.TabIndex = 0;
            this.encrypt_Button.Text = "ENCRYPT";
            this.encrypt_Button.UseVisualStyleBackColor = true;
            this.encrypt_Button.Click += new System.EventHandler(this.encrypt_Button_Click);
            // 
            // decrypted_Text
            // 
            this.decrypted_Text.BackColor = System.Drawing.SystemColors.HighlightText;
            this.decrypted_Text.Location = new System.Drawing.Point(49, 35);
            this.decrypted_Text.Name = "decrypted_Text";
            this.decrypted_Text.Size = new System.Drawing.Size(476, 248);
            this.decrypted_Text.TabIndex = 1;
            this.decrypted_Text.Text = "";
            this.decrypted_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decrypted_Text_KeyPress);
            // 
            // encrypted_Text
            // 
            this.encrypted_Text.Location = new System.Drawing.Point(49, 299);
            this.encrypted_Text.Name = "encrypted_Text";
            this.encrypted_Text.Size = new System.Drawing.Size(476, 248);
            this.encrypted_Text.TabIndex = 2;
            this.encrypted_Text.Text = "";
            this.encrypted_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Encrypted_Text_KeyPress);
            // 
            // decrypt_Button
            // 
            this.decrypt_Button.Location = new System.Drawing.Point(543, 509);
            this.decrypt_Button.Name = "decrypt_Button";
            this.decrypt_Button.Size = new System.Drawing.Size(101, 38);
            this.decrypt_Button.TabIndex = 3;
            this.decrypt_Button.Text = "DECRYPT";
            this.decrypt_Button.UseVisualStyleBackColor = true;
            this.decrypt_Button.Click += new System.EventHandler(this.decrypt_Button_Click);
            // 
            // input_Alphabet
            // 
            this.input_Alphabet.Location = new System.Drawing.Point(709, 69);
            this.input_Alphabet.Name = "input_Alphabet";
            this.input_Alphabet.Size = new System.Drawing.Size(354, 22);
            this.input_Alphabet.TabIndex = 4;
            this.input_Alphabet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_Alphabet_KeyPress);
            // 
            // alphabetLabel
            // 
            this.alphabetLabel.AutoSize = true;
            this.alphabetLabel.BackColor = System.Drawing.Color.Transparent;
            this.alphabetLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alphabetLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.alphabetLabel.Location = new System.Drawing.Point(822, 42);
            this.alphabetLabel.Name = "alphabetLabel";
            this.alphabetLabel.Size = new System.Drawing.Size(103, 24);
            this.alphabetLabel.TabIndex = 5;
            this.alphabetLabel.Text = "ALPHABET";
            // 
            // inputKey
            // 
            this.inputKey.Location = new System.Drawing.Point(825, 165);
            this.inputKey.Name = "inputKey";
            this.inputKey.Size = new System.Drawing.Size(100, 22);
            this.inputKey.TabIndex = 6;
            this.inputKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputKey_KeyPress);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.KeyLabel.Location = new System.Drawing.Point(855, 138);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(43, 24);
            this.KeyLabel.TabIndex = 7;
            this.KeyLabel.Text = "KEY";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.warning.Location = new System.Drawing.Point(780, 509);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(332, 20);
            this.warning.TabIndex = 8;
            this.warning.Text = "*You can only enter number and letter!";
            this.warning.Visible = false;
            // 
            // CTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1196, 579);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.inputKey);
            this.Controls.Add(this.alphabetLabel);
            this.Controls.Add(this.input_Alphabet);
            this.Controls.Add(this.decrypt_Button);
            this.Controls.Add(this.encrypted_Text);
            this.Controls.Add(this.decrypted_Text);
            this.Controls.Add(this.encrypt_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CTool";
            this.Text = "Cryptography Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt_Button;
        private System.Windows.Forms.RichTextBox decrypted_Text;
        private System.Windows.Forms.RichTextBox encrypted_Text;
        private System.Windows.Forms.Button decrypt_Button;
        private System.Windows.Forms.TextBox input_Alphabet;
        private System.Windows.Forms.Label alphabetLabel;
        private System.Windows.Forms.TextBox inputKey;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label warning;
    }
}

