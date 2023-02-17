namespace GreatPlaces
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.touristBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.great_PlacesDataSet3 = new GreatPlaces.Great_PlacesDataSet3();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.touristTableAdapter = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TouristTableAdapter();
            this.touristTableAdapter1 = new GreatPlaces.Great_PlacesDataSetTableAdapters.TouristTableAdapter();
            this.touristTableAdapter2 = new GreatPlaces.Great_PlacesDataSet1TableAdapters.TouristTableAdapter();
            this.great_PlacesDataSet1 = new GreatPlaces.Great_PlacesDataSet1();
            this.travelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelTableAdapter = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TravelTableAdapter();
            this.placeTableAdapter = new GreatPlaces.Great_PlacesDataSet3TableAdapters.PlaceTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.travelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.touristBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Турист";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Місце подорожі";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.touristBindingSource;
            this.comboBox1.DisplayMember = "tourist_surname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // touristBindingSource
            // 
            this.touristBindingSource.DataMember = "Tourist";
            this.touristBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.great_PlacesDataSet3;
            this.bindingSource1.Position = 0;
            // 
            // great_PlacesDataSet3
            // 
            this.great_PlacesDataSet3.DataSetName = "Great_PlacesDataSet3";
            this.great_PlacesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Place";
            this.placeBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Tourist";
            this.bindingSource2.DataSource = this.great_PlacesDataSet3;
            // 
            // touristTableAdapter
            // 
            this.touristTableAdapter.ClearBeforeFill = true;
            // 
            // touristTableAdapter1
            // 
            this.touristTableAdapter1.ClearBeforeFill = true;
            // 
            // touristTableAdapter2
            // 
            this.touristTableAdapter2.ClearBeforeFill = true;
            // 
            // great_PlacesDataSet1
            // 
            this.great_PlacesDataSet1.DataSetName = "Great_PlacesDataSet1";
            this.great_PlacesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // travelBindingSource
            // 
            this.travelBindingSource.DataMember = "Travel";
            this.travelBindingSource.DataSource = this.bindingSource1;
            // 
            // travelTableAdapter
            // 
            this.travelTableAdapter.ClearBeforeFill = true;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 93);
            this.button1.TabIndex = 9;
            this.button1.Text = "Змінити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.placeBindingSource;
            this.comboBox2.DisplayMember = "place_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(205, 219);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(346, 24);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "place_name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ціна";
            // 
            // travelBindingSource1
            // 
            this.travelBindingSource1.DataMember = "Travel";
            this.travelBindingSource1.DataSource = this.great_PlacesDataSet3;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Place_RegionTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = this.placeTableAdapter;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.TouristTableAdapter = this.touristTableAdapter;
            this.tableAdapterManager.TravelTableAdapter = this.travelTableAdapter;
            this.tableAdapterManager.UpdateOrder = GreatPlaces.Great_PlacesDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Оцінка";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 22);
            this.textBox2.TabIndex = 15;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.touristBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Great_PlacesDataSet3 great_PlacesDataSet3;
        private System.Windows.Forms.BindingSource bindingSource2;
        private Great_PlacesDataSet3TableAdapters.TouristTableAdapter touristTableAdapter;
        private Great_PlacesDataSetTableAdapters.TouristTableAdapter touristTableAdapter1;
        private Great_PlacesDataSet1TableAdapters.TouristTableAdapter touristTableAdapter2;
        private Great_PlacesDataSet1 great_PlacesDataSet1;
        private System.Windows.Forms.BindingSource travelBindingSource;
        private Great_PlacesDataSet3TableAdapters.TravelTableAdapter travelTableAdapter;
        private System.Windows.Forms.BindingSource touristBindingSource;
        private Great_PlacesDataSet3TableAdapters.PlaceTableAdapter placeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource travelBindingSource1;
        private Great_PlacesDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.BindingSource placeBindingSource;
    }
}