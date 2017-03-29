namespace Prog2
{
    partial class RegForm
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
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.findRegTimeBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.RegLbl = new System.Windows.Forms.Label();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.standingGrpBox = new System.Windows.Forms.GroupBox();
            this.freshBtn = new System.Windows.Forms.RadioButton();
            this.sophBtn = new System.Windows.Forms.RadioButton();
            this.juniorBtn = new System.Windows.Forms.RadioButton();
            this.seniorBtn = new System.Windows.Forms.RadioButton();
            this.standingGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(135, 29);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 1;
            // 
            // findRegTimeBtn
            // 
            this.findRegTimeBtn.Location = new System.Drawing.Point(74, 146);
            this.findRegTimeBtn.Name = "findRegTimeBtn";
            this.findRegTimeBtn.Size = new System.Drawing.Size(99, 23);
            this.findRegTimeBtn.TabIndex = 2;
            this.findRegTimeBtn.Text = "Find Reg. Time";
            this.findRegTimeBtn.UseVisualStyleBackColor = true;
            this.findRegTimeBtn.Click += new System.EventHandler(this.findRegTimeBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(132, 13);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 13);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Last name:";
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Location = new System.Drawing.Point(47, 172);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(154, 13);
            this.RegLbl.TabIndex = 5;
            this.RegLbl.Text = "The earliest you may register is:";
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.AutoSize = true;
            this.dateTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl.Location = new System.Drawing.Point(47, 185);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(0, 13);
            this.dateTimeLbl.TabIndex = 6;
            // 
            // standingGrpBox
            // 
            this.standingGrpBox.Controls.Add(this.freshBtn);
            this.standingGrpBox.Controls.Add(this.sophBtn);
            this.standingGrpBox.Controls.Add(this.juniorBtn);
            this.standingGrpBox.Controls.Add(this.seniorBtn);
            this.standingGrpBox.Location = new System.Drawing.Point(13, 13);
            this.standingGrpBox.Name = "standingGrpBox";
            this.standingGrpBox.Size = new System.Drawing.Size(102, 117);
            this.standingGrpBox.TabIndex = 0;
            this.standingGrpBox.TabStop = false;
            this.standingGrpBox.Text = "Class Standing";
            // 
            // freshBtn
            // 
            this.freshBtn.AutoSize = true;
            this.freshBtn.Location = new System.Drawing.Point(6, 89);
            this.freshBtn.Name = "freshBtn";
            this.freshBtn.Size = new System.Drawing.Size(71, 17);
            this.freshBtn.TabIndex = 3;
            this.freshBtn.Text = "Freshman";
            this.freshBtn.UseVisualStyleBackColor = true;
            // 
            // sophBtn
            // 
            this.sophBtn.AutoSize = true;
            this.sophBtn.Location = new System.Drawing.Point(7, 66);
            this.sophBtn.Name = "sophBtn";
            this.sophBtn.Size = new System.Drawing.Size(79, 17);
            this.sophBtn.TabIndex = 2;
            this.sophBtn.Text = "Sophomore";
            this.sophBtn.UseVisualStyleBackColor = true;
            // 
            // juniorBtn
            // 
            this.juniorBtn.AutoSize = true;
            this.juniorBtn.Location = new System.Drawing.Point(7, 43);
            this.juniorBtn.Name = "juniorBtn";
            this.juniorBtn.Size = new System.Drawing.Size(53, 17);
            this.juniorBtn.TabIndex = 1;
            this.juniorBtn.Text = "Junior";
            this.juniorBtn.UseVisualStyleBackColor = true;
            // 
            // seniorBtn
            // 
            this.seniorBtn.AutoSize = true;
            this.seniorBtn.Checked = true;
            this.seniorBtn.Location = new System.Drawing.Point(7, 20);
            this.seniorBtn.Name = "seniorBtn";
            this.seniorBtn.Size = new System.Drawing.Size(55, 17);
            this.seniorBtn.TabIndex = 0;
            this.seniorBtn.TabStop = true;
            this.seniorBtn.Text = "Senior";
            this.seniorBtn.UseVisualStyleBackColor = true;
            // 
            // RegForm
            // 
            this.AcceptButton = this.findRegTimeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 209);
            this.Controls.Add(this.standingGrpBox);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.findRegTimeBtn);
            this.Controls.Add(this.lastNameTxt);
            this.Name = "RegForm";
            this.Text = "Program 2";
            this.standingGrpBox.ResumeLayout(false);
            this.standingGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Button findRegTimeBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Label dateTimeLbl;
        private System.Windows.Forms.GroupBox standingGrpBox;
        private System.Windows.Forms.RadioButton freshBtn;
        private System.Windows.Forms.RadioButton sophBtn;
        private System.Windows.Forms.RadioButton juniorBtn;
        private System.Windows.Forms.RadioButton seniorBtn;
    }
}

