namespace Lesson2Assignment
{
    partial class frmL2Assignment
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
            this.btnShowMyContact = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCityState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowMyContact
            // 
            this.btnShowMyContact.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnShowMyContact.FlatAppearance.BorderSize = 10;
            this.btnShowMyContact.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowMyContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowMyContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowMyContact.Location = new System.Drawing.Point(101, 202);
            this.btnShowMyContact.Name = "btnShowMyContact";
            this.btnShowMyContact.Size = new System.Drawing.Size(157, 48);
            this.btnShowMyContact.TabIndex = 0;
            this.btnShowMyContact.Text = "Show";
            this.btnShowMyContact.UseVisualStyleBackColor = true;
            this.btnShowMyContact.Click += new System.EventHandler(this.btnShowMyContact_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatAppearance.BorderSize = 10;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(101, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 48);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.Info;
            this.lblName.Location = new System.Drawing.Point(98, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(605, 36);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblStreet
            // 
            this.lblStreet.BackColor = System.Drawing.SystemColors.Info;
            this.lblStreet.Location = new System.Drawing.Point(98, 69);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(605, 36);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Street";
            // 
            // lblCityState
            // 
            this.lblCityState.BackColor = System.Drawing.SystemColors.Info;
            this.lblCityState.Location = new System.Drawing.Point(98, 116);
            this.lblCityState.Name = "lblCityState";
            this.lblCityState.Size = new System.Drawing.Size(605, 36);
            this.lblCityState.TabIndex = 4;
            this.lblCityState.Text = "City, State";
            // 
            // frmL2Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCityState);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowMyContact);
            this.Name = "frmL2Assignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Contact Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMyContact;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCityState;
    }
}

