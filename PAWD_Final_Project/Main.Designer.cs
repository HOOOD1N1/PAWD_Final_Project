
namespace PAWD_Final_Project
{
    partial class Main
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.projectsGridView = new System.Windows.Forms.DataGridView();
            this.chartBtn = new System.Windows.Forms.Button();
            this.projectsCountLabel = new System.Windows.Forms.Label();
            this.deadlineTime = new System.Windows.Forms.DateTimePicker();
            this.reminderTime = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.projectsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(13, 13);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(113, 17);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "[Your username]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add new project:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deadline:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reminder:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(293, 42);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(183, 22);
            this.nameTxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Action:";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(555, 33);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(233, 54);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "Add Project";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Remove Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // projectsGridView
            // 
            this.projectsGridView.AllowUserToAddRows = false;
            this.projectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsGridView.Location = new System.Drawing.Point(16, 151);
            this.projectsGridView.Name = "projectsGridView";
            this.projectsGridView.RowHeadersWidth = 51;
            this.projectsGridView.RowTemplate.Height = 24;
            this.projectsGridView.Size = new System.Drawing.Size(772, 215);
            this.projectsGridView.TabIndex = 11;
            // 
            // chartBtn
            // 
            this.chartBtn.Location = new System.Drawing.Point(16, 373);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(772, 65);
            this.chartBtn.TabIndex = 12;
            this.chartBtn.Text = "Show Weekly Report";
            this.chartBtn.UseVisualStyleBackColor = true;
            this.chartBtn.Click += new System.EventHandler(this.chartBtn_Click);
            // 
            // projectsCountLabel
            // 
            this.projectsCountLabel.AutoSize = true;
            this.projectsCountLabel.Location = new System.Drawing.Point(12, 52);
            this.projectsCountLabel.Name = "projectsCountLabel";
            this.projectsCountLabel.Size = new System.Drawing.Size(112, 17);
            this.projectsCountLabel.TabIndex = 26;
            this.projectsCountLabel.Text = "[Projects_Count]";
            // 
            // deadlineTime
            // 
            this.deadlineTime.Location = new System.Drawing.Point(293, 79);
            this.deadlineTime.Name = "deadlineTime";
            this.deadlineTime.Size = new System.Drawing.Size(200, 22);
            this.deadlineTime.TabIndex = 27;
            // 
            // reminderTime
            // 
            this.reminderTime.Location = new System.Drawing.Point(293, 113);
            this.reminderTime.Name = "reminderTime";
            this.reminderTime.Size = new System.Drawing.Size(200, 22);
            this.reminderTime.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reminderTime);
            this.Controls.Add(this.deadlineTime);
            this.Controls.Add(this.projectsCountLabel);
            this.Controls.Add(this.chartBtn);
            this.Controls.Add(this.projectsGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameLabel);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView projectsGridView;
        private System.Windows.Forms.Button chartBtn;
        private System.Windows.Forms.Label projectsCountLabel;
        private System.Windows.Forms.DateTimePicker deadlineTime;
        private System.Windows.Forms.DateTimePicker reminderTime;
        private System.Windows.Forms.Timer timer1;
    }
}