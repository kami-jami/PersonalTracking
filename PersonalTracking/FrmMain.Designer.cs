namespace PersonalTracking
{
    partial class FrmMain
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnPermission = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEmployee.Location = new System.Drawing.Point(634, 31);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(200, 176);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "کارمند";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnTask
            // 
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTask.Location = new System.Drawing.Point(405, 31);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(200, 176);
            this.btnTask.TabIndex = 1;
            this.btnTask.Text = "وظایف";
            this.btnTask.UseVisualStyleBackColor = true;
            // 
            // btnSalary
            // 
            this.btnSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSalary.Location = new System.Drawing.Point(171, 31);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(200, 176);
            this.btnSalary.TabIndex = 2;
            this.btnSalary.Text = "حقوق";
            this.btnSalary.UseVisualStyleBackColor = true;
            // 
            // btnPermission
            // 
            this.btnPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPermission.Location = new System.Drawing.Point(634, 236);
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.Size = new System.Drawing.Size(200, 176);
            this.btnPermission.TabIndex = 3;
            this.btnPermission.Text = "دسترسی";
            this.btnPermission.UseVisualStyleBackColor = true;
            // 
            // btnDepartment
            // 
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDepartment.Location = new System.Drawing.Point(405, 236);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(200, 176);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "بخش ها";
            this.btnDepartment.UseVisualStyleBackColor = true;
            // 
            // btnPosition
            // 
            this.btnPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPosition.Location = new System.Drawing.Point(171, 236);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(200, 176);
            this.btnPosition.TabIndex = 5;
            this.btnPosition.Text = "سمت ها";
            this.btnPosition.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 31);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(129, 176);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "قطع ارتباط";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Location = new System.Drawing.Point(12, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 176);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnPermission);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEmployee);
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "رهگیری کارمندان";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnPermission;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
    }
}