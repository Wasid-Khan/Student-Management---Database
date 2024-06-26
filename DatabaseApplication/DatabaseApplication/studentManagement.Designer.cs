
namespace DatabaseApplication
{
    partial class studentManagement
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
            this.bt_DeleteFromListBoxView = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_addNewRecord = new System.Windows.Forms.Button();
            this.tb_Nationality = new System.Windows.Forms.TextBox();
            this.tb_Country = new System.Windows.Forms.TextBox();
            this.tb_State = new System.Windows.Forms.TextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.tb_Ln = new System.Windows.Forms.TextBox();
            this.tb_Fn = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_DeleteFromListBoxView
            // 
            this.bt_DeleteFromListBoxView.Location = new System.Drawing.Point(169, 326);
            this.bt_DeleteFromListBoxView.Name = "bt_DeleteFromListBoxView";
            this.bt_DeleteFromListBoxView.Size = new System.Drawing.Size(113, 46);
            this.bt_DeleteFromListBoxView.TabIndex = 23;
            this.bt_DeleteFromListBoxView.Text = "Remove From View";
            this.bt_DeleteFromListBoxView.UseVisualStyleBackColor = true;
            this.bt_DeleteFromListBoxView.Click += new System.EventHandler(this.bt_DeleteFromListBoxView_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(423, 274);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(116, 46);
            this.bt_Clear.TabIndex = 22;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(304, 274);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(113, 46);
            this.bt_Delete.TabIndex = 21;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(423, 222);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(116, 46);
            this.bt_Update.TabIndex = 20;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_addNewRecord
            // 
            this.bt_addNewRecord.Location = new System.Drawing.Point(304, 222);
            this.bt_addNewRecord.Name = "bt_addNewRecord";
            this.bt_addNewRecord.Size = new System.Drawing.Size(113, 46);
            this.bt_addNewRecord.TabIndex = 19;
            this.bt_addNewRecord.Text = "Add New Record";
            this.bt_addNewRecord.UseVisualStyleBackColor = true;
            this.bt_addNewRecord.Click += new System.EventHandler(this.bt_addNewRecord_Click);
            // 
            // tb_Nationality
            // 
            this.tb_Nationality.Location = new System.Drawing.Point(304, 184);
            this.tb_Nationality.Name = "tb_Nationality";
            this.tb_Nationality.Size = new System.Drawing.Size(235, 20);
            this.tb_Nationality.TabIndex = 18;
            this.tb_Nationality.Text = "Nationality";
            // 
            // tb_Country
            // 
            this.tb_Country.Location = new System.Drawing.Point(304, 158);
            this.tb_Country.Name = "tb_Country";
            this.tb_Country.Size = new System.Drawing.Size(235, 20);
            this.tb_Country.TabIndex = 17;
            this.tb_Country.Text = "Country";
            // 
            // tb_State
            // 
            this.tb_State.Location = new System.Drawing.Point(304, 132);
            this.tb_State.Name = "tb_State";
            this.tb_State.Size = new System.Drawing.Size(235, 20);
            this.tb_State.TabIndex = 16;
            this.tb_State.Text = "State";
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(304, 106);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(235, 20);
            this.tb_City.TabIndex = 15;
            this.tb_City.Text = "City";
            // 
            // tb_Ln
            // 
            this.tb_Ln.Location = new System.Drawing.Point(304, 80);
            this.tb_Ln.Name = "tb_Ln";
            this.tb_Ln.Size = new System.Drawing.Size(235, 20);
            this.tb_Ln.TabIndex = 14;
            this.tb_Ln.Text = "Last Name Here ";
            // 
            // tb_Fn
            // 
            this.tb_Fn.Location = new System.Drawing.Point(304, 54);
            this.tb_Fn.Name = "tb_Fn";
            this.tb_Fn.Size = new System.Drawing.Size(235, 20);
            this.tb_Fn.TabIndex = 13;
            this.tb_Fn.Text = "First Name Here ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(157, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 264);
            this.listBox1.TabIndex = 12;
            // 
            // studentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_DeleteFromListBoxView);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_addNewRecord);
            this.Controls.Add(this.tb_Nationality);
            this.Controls.Add(this.tb_Country);
            this.Controls.Add(this.tb_State);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.tb_Ln);
            this.Controls.Add(this.tb_Fn);
            this.Controls.Add(this.listBox1);
            this.Name = "studentManagement";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_DeleteFromListBoxView;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_addNewRecord;
        private System.Windows.Forms.TextBox tb_Nationality;
        private System.Windows.Forms.TextBox tb_Country;
        private System.Windows.Forms.TextBox tb_State;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.TextBox tb_Ln;
        private System.Windows.Forms.TextBox tb_Fn;
        private System.Windows.Forms.ListBox listBox1;
    }
}

