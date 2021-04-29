
namespace WorkForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWorkName = new System.Windows.Forms.Label();
            this.txtBoxWorkName = new System.Windows.Forms.TextBox();
            this.txtWorkAddr = new System.Windows.Forms.Label();
            this.txtWorkPhone = new System.Windows.Forms.Label();
            this.txtBoxWorkAddr = new System.Windows.Forms.TextBox();
            this.txtBoxWorkPhone = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.txtWorkTwitter = new System.Windows.Forms.Label();
            this.txtBoxWorkTwitter = new System.Windows.Forms.TextBox();
            this.txtWorkOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWorkName
            // 
            this.txtWorkName.AutoSize = true;
            this.txtWorkName.Location = new System.Drawing.Point(54, 51);
            this.txtWorkName.Name = "txtWorkName";
            this.txtWorkName.Size = new System.Drawing.Size(87, 20);
            this.txtWorkName.TabIndex = 0;
            this.txtWorkName.Text = "Work Name";
            this.txtWorkName.Click += new System.EventHandler(this.txtWorkName_Click);
            // 
            // txtBoxWorkName
            // 
            this.txtBoxWorkName.Location = new System.Drawing.Point(203, 48);
            this.txtBoxWorkName.Name = "txtBoxWorkName";
            this.txtBoxWorkName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxWorkName.TabIndex = 1;
            // 
            // txtWorkAddr
            // 
            this.txtWorkAddr.AutoSize = true;
            this.txtWorkAddr.Location = new System.Drawing.Point(54, 120);
            this.txtWorkAddr.Name = "txtWorkAddr";
            this.txtWorkAddr.Size = new System.Drawing.Size(100, 20);
            this.txtWorkAddr.TabIndex = 2;
            this.txtWorkAddr.Text = "Work Address";
            this.txtWorkAddr.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.AutoSize = true;
            this.txtWorkPhone.Location = new System.Drawing.Point(54, 191);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(88, 20);
            this.txtWorkPhone.TabIndex = 3;
            this.txtWorkPhone.Text = "Work Phone";
            this.txtWorkPhone.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxWorkAddr
            // 
            this.txtBoxWorkAddr.Location = new System.Drawing.Point(203, 120);
            this.txtBoxWorkAddr.Name = "txtBoxWorkAddr";
            this.txtBoxWorkAddr.Size = new System.Drawing.Size(125, 27);
            this.txtBoxWorkAddr.TabIndex = 4;
            // 
            // txtBoxWorkPhone
            // 
            this.txtBoxWorkPhone.Location = new System.Drawing.Point(203, 188);
            this.txtBoxWorkPhone.Name = "txtBoxWorkPhone";
            this.txtBoxWorkPhone.Size = new System.Drawing.Size(125, 27);
            this.txtBoxWorkPhone.TabIndex = 5;
            this.txtBoxWorkPhone.TextChanged += new System.EventHandler(this.txtBoxWorkPhone_TextChanged);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(101, 356);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(156, 29);
            this.testButton.TabIndex = 6;
            this.testButton.Text = "Push To Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // txtWorkTwitter
            // 
            this.txtWorkTwitter.AutoSize = true;
            this.txtWorkTwitter.Location = new System.Drawing.Point(54, 263);
            this.txtWorkTwitter.Name = "txtWorkTwitter";
            this.txtWorkTwitter.Size = new System.Drawing.Size(98, 20);
            this.txtWorkTwitter.TabIndex = 7;
            this.txtWorkTwitter.Text = "Twitter Name";
            this.txtWorkTwitter.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxWorkTwitter
            // 
            this.txtBoxWorkTwitter.Location = new System.Drawing.Point(203, 263);
            this.txtBoxWorkTwitter.Name = "txtBoxWorkTwitter";
            this.txtBoxWorkTwitter.Size = new System.Drawing.Size(125, 27);
            this.txtBoxWorkTwitter.TabIndex = 8;
            // 
            // txtWorkOutputLabel
            // 
            this.txtWorkOutputLabel.AutoSize = true;
            this.txtWorkOutputLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWorkOutputLabel.Location = new System.Drawing.Point(506, 159);
            this.txtWorkOutputLabel.Name = "txtWorkOutputLabel";
            this.txtWorkOutputLabel.Size = new System.Drawing.Size(97, 41);
            this.txtWorkOutputLabel.TabIndex = 9;
            this.txtWorkOutputLabel.Text = "label1";
            this.txtWorkOutputLabel.Click += new System.EventHandler(this.txtWorkOutputLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWorkOutputLabel);
            this.Controls.Add(this.txtBoxWorkTwitter);
            this.Controls.Add(this.txtWorkTwitter);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.txtBoxWorkPhone);
            this.Controls.Add(this.txtBoxWorkAddr);
            this.Controls.Add(this.txtWorkPhone);
            this.Controls.Add(this.txtWorkAddr);
            this.Controls.Add(this.txtBoxWorkName);
            this.Controls.Add(this.txtWorkName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtWorkName;
        private System.Windows.Forms.TextBox txtBoxWorkName;
        private System.Windows.Forms.Label txtWorkAddr;
        private System.Windows.Forms.Label txtWorkPhone;
        private System.Windows.Forms.TextBox txtBoxWorkAddr;
        private System.Windows.Forms.TextBox txtBoxWorkPhone;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label txtWorkTwitter;
        private System.Windows.Forms.TextBox txtBoxWorkTwitter;
        private System.Windows.Forms.Label txtWorkOutputLabel;
    }
}

