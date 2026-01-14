namespace License_Plates
{
    partial class Edit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.transmissionCombo = new System.Windows.Forms.ComboBox();
            this.styleCombo = new System.Windows.Forms.ComboBox();
            this.ownedCombo = new System.Windows.Forms.ComboBox();
            this.colourCombo = new System.Windows.Forms.ComboBox();
            this.makeCombo = new System.Windows.Forms.ComboBox();
            this.model = new System.Windows.Forms.TextBox();
            this.submodel = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.plate = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 207);
            this.dataGridView1.TabIndex = 1;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.LightCoral;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(686, 398);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(102, 40);
            this.close.TabIndex = 4;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.MediumAquamarine;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(566, 398);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 40);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(281, 256);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(91, 21);
            this.typeCombo.TabIndex = 6;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged_1);
            // 
            // transmissionCombo
            // 
            this.transmissionCombo.FormattingEnabled = true;
            this.transmissionCombo.Location = new System.Drawing.Point(281, 323);
            this.transmissionCombo.Name = "transmissionCombo";
            this.transmissionCombo.Size = new System.Drawing.Size(91, 21);
            this.transmissionCombo.TabIndex = 7;
            // 
            // styleCombo
            // 
            this.styleCombo.FormattingEnabled = true;
            this.styleCombo.Location = new System.Drawing.Point(427, 323);
            this.styleCombo.Name = "styleCombo";
            this.styleCombo.Size = new System.Drawing.Size(123, 21);
            this.styleCombo.TabIndex = 8;
            // 
            // ownedCombo
            // 
            this.ownedCombo.FormattingEnabled = true;
            this.ownedCombo.Location = new System.Drawing.Point(28, 398);
            this.ownedCombo.Name = "ownedCombo";
            this.ownedCombo.Size = new System.Drawing.Size(81, 21);
            this.ownedCombo.TabIndex = 9;
            // 
            // colourCombo
            // 
            this.colourCombo.FormattingEnabled = true;
            this.colourCombo.Location = new System.Drawing.Point(636, 324);
            this.colourCombo.Name = "colourCombo";
            this.colourCombo.Size = new System.Drawing.Size(114, 21);
            this.colourCombo.TabIndex = 10;
            // 
            // makeCombo
            // 
            this.makeCombo.FormattingEnabled = true;
            this.makeCombo.Location = new System.Drawing.Point(427, 255);
            this.makeCombo.Name = "makeCombo";
            this.makeCombo.Size = new System.Drawing.Size(123, 21);
            this.makeCombo.TabIndex = 11;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(636, 255);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(114, 20);
            this.model.TabIndex = 13;
            // 
            // submodel
            // 
            this.submodel.Location = new System.Drawing.Point(28, 324);
            this.submodel.Name = "submodel";
            this.submodel.Size = new System.Drawing.Size(88, 20);
            this.submodel.TabIndex = 14;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(164, 324);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(62, 20);
            this.size.TabIndex = 15;
            // 
            // plate
            // 
            this.plate.Location = new System.Drawing.Point(28, 257);
            this.plate.Name = "plate";
            this.plate.Size = new System.Drawing.Size(88, 20);
            this.plate.TabIndex = 16;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(164, 255);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(62, 20);
            this.year.TabIndex = 17;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.year);
            this.Controls.Add(this.plate);
            this.Controls.Add(this.size);
            this.Controls.Add(this.submodel);
            this.Controls.Add(this.model);
            this.Controls.Add(this.makeCombo);
            this.Controls.Add(this.colourCombo);
            this.Controls.Add(this.ownedCombo);
            this.Controls.Add(this.styleCombo);
            this.Controls.Add(this.transmissionCombo);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.save);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.ComboBox transmissionCombo;
        private System.Windows.Forms.ComboBox styleCombo;
        private System.Windows.Forms.ComboBox ownedCombo;
        private System.Windows.Forms.ComboBox colourCombo;
        private System.Windows.Forms.ComboBox makeCombo;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox submodel;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox plate;
        private System.Windows.Forms.NumericUpDown year;
    }
}