namespace ERP_Integration
{
    partial class ErpGui
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.lblQueries = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cbOptions2 = new System.Windows.Forms.ComboBox();
            this.lblMetaData = new System.Windows.Forms.Label();
            this.gbQueries = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.lblError = new System.Windows.Forms.Label();
            this.gbEditContent = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.gbQueries.SuspendLayout();
            this.gbEditContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(86, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Ta bort";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(167, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Uppdatera";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(7, 136);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Lägg till";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Location = new System.Drawing.Point(20, 224);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(335, 21);
            this.cbOptions.TabIndex = 3;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // lblQueries
            // 
            this.lblQueries.AutoSize = true;
            this.lblQueries.Location = new System.Drawing.Point(16, 208);
            this.lblQueries.Name = "lblQueries";
            this.lblQueries.Size = new System.Drawing.Size(53, 13);
            this.lblQueries.TabIndex = 4;
            this.lblQueries.Text = "Välj query";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(7, 110);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(335, 20);
            this.txtBoxLastName.TabIndex = 6;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(7, 71);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(335, 20);
            this.txtBoxName.TabIndex = 7;
            // 
            // txtBoxNo
            // 
            this.txtBoxNo.Location = new System.Drawing.Point(7, 32);
            this.txtBoxNo.Name = "txtBoxNo";
            this.txtBoxNo.Size = new System.Drawing.Size(335, 20);
            this.txtBoxNo.TabIndex = 8;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(4, 16);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(100, 13);
            this.lblNo.TabIndex = 9;
            this.lblNo.Text = "Anställningsnummer";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Namn";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(4, 94);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Efternamn";
            // 
            // cbOptions2
            // 
            this.cbOptions2.FormattingEnabled = true;
            this.cbOptions2.Location = new System.Drawing.Point(20, 264);
            this.cbOptions2.Name = "cbOptions2";
            this.cbOptions2.Size = new System.Drawing.Size(335, 21);
            this.cbOptions2.TabIndex = 12;
            this.cbOptions2.SelectedIndexChanged += new System.EventHandler(this.cbOptions2_SelectedIndexChanged_1);
            // 
            // lblMetaData
            // 
            this.lblMetaData.AutoSize = true;
            this.lblMetaData.Location = new System.Drawing.Point(16, 248);
            this.lblMetaData.Name = "lblMetaData";
            this.lblMetaData.Size = new System.Drawing.Size(85, 13);
            this.lblMetaData.TabIndex = 13;
            this.lblMetaData.Text = "Hämta metadata";
            // 
            // gbQueries
            // 
            this.gbQueries.Controls.Add(this.listView);
            this.gbQueries.Controls.Add(this.lblError);
            this.gbQueries.Controls.Add(this.gbEditContent);
            this.gbQueries.Controls.Add(this.cbOptions);
            this.gbQueries.Controls.Add(this.lblQueries);
            this.gbQueries.Controls.Add(this.cbOptions2);
            this.gbQueries.Controls.Add(this.lblMetaData);
            this.gbQueries.Location = new System.Drawing.Point(12, 12);
            this.gbQueries.Name = "gbQueries";
            this.gbQueries.Size = new System.Drawing.Size(1005, 560);
            this.gbQueries.TabIndex = 16;
            this.gbQueries.TabStop = false;
            // 
            // listView
            // 
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(383, 34);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(594, 520);
            this.listView.TabIndex = 18;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(16, 541);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 17;
            // 
            // gbEditContent
            // 
            this.gbEditContent.Controls.Add(this.btnShowAll);
            this.gbEditContent.Controls.Add(this.lblNo);
            this.gbEditContent.Controls.Add(this.txtBoxNo);
            this.gbEditContent.Controls.Add(this.btnInsert);
            this.gbEditContent.Controls.Add(this.lblName);
            this.gbEditContent.Controls.Add(this.btnUpdate);
            this.gbEditContent.Controls.Add(this.btnDelete);
            this.gbEditContent.Controls.Add(this.txtBoxName);
            this.gbEditContent.Controls.Add(this.lblLastName);
            this.gbEditContent.Controls.Add(this.txtBoxLastName);
            this.gbEditContent.Location = new System.Drawing.Point(12, 18);
            this.gbEditContent.Name = "gbEditContent";
            this.gbEditContent.Size = new System.Drawing.Size(350, 169);
            this.gbEditContent.TabIndex = 16;
            this.gbEditContent.TabStop = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(245, 136);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(95, 23);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Text = "Visa anställda";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // ErpGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 584);
            this.Controls.Add(this.gbQueries);
            this.Name = "ErpGui";
            this.Text = "ERP Integration";
            this.gbQueries.ResumeLayout(false);
            this.gbQueries.PerformLayout();
            this.gbEditContent.ResumeLayout(false);
            this.gbEditContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Label lblQueries;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox cbOptions2;
        private System.Windows.Forms.Label lblMetaData;
        private System.Windows.Forms.GroupBox gbQueries;
        private System.Windows.Forms.GroupBox gbEditContent;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnShowAll;
    }
}

