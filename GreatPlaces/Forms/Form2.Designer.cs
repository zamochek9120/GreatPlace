namespace GreatPlaces
{
    partial class Form2
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
            this.great_PlacesDataSet3 = new GreatPlaces.Great_PlacesDataSet3();
            this.placeTableAdapter = new GreatPlaces.Great_PlacesDataSet3TableAdapters.PlaceTableAdapter();
            this.travelTableAdapter = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TravelTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.travelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.touristidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traveldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // great_PlacesDataSet3
            // 
            this.great_PlacesDataSet3.DataSetName = "Great_PlacesDataSet3";
            this.great_PlacesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // travelTableAdapter
            // 
            this.travelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.travelidDataGridViewTextBoxColumn,
            this.placeidDataGridViewTextBoxColumn,
            this.touristidDataGridViewTextBoxColumn,
            this.traveldateDataGridViewTextBoxColumn,
            this.travelpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.travelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // travelidDataGridViewTextBoxColumn
            // 
            this.travelidDataGridViewTextBoxColumn.DataPropertyName = "travel_id";
            this.travelidDataGridViewTextBoxColumn.HeaderText = "travel_id";
            this.travelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.travelidDataGridViewTextBoxColumn.Name = "travelidDataGridViewTextBoxColumn";
            this.travelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeidDataGridViewTextBoxColumn
            // 
            this.placeidDataGridViewTextBoxColumn.DataPropertyName = "place_id";
            this.placeidDataGridViewTextBoxColumn.HeaderText = "place_id";
            this.placeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placeidDataGridViewTextBoxColumn.Name = "placeidDataGridViewTextBoxColumn";
            this.placeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // touristidDataGridViewTextBoxColumn
            // 
            this.touristidDataGridViewTextBoxColumn.DataPropertyName = "tourist_id";
            this.touristidDataGridViewTextBoxColumn.HeaderText = "tourist_id";
            this.touristidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.touristidDataGridViewTextBoxColumn.Name = "touristidDataGridViewTextBoxColumn";
            this.touristidDataGridViewTextBoxColumn.Width = 125;
            // 
            // traveldateDataGridViewTextBoxColumn
            // 
            this.traveldateDataGridViewTextBoxColumn.DataPropertyName = "travel_date";
            this.traveldateDataGridViewTextBoxColumn.HeaderText = "travel_date";
            this.traveldateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traveldateDataGridViewTextBoxColumn.Name = "traveldateDataGridViewTextBoxColumn";
            this.traveldateDataGridViewTextBoxColumn.Width = 125;
            // 
            // travelpriceDataGridViewTextBoxColumn
            // 
            this.travelpriceDataGridViewTextBoxColumn.DataPropertyName = "travel_price";
            this.travelpriceDataGridViewTextBoxColumn.HeaderText = "travel_price";
            this.travelpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.travelpriceDataGridViewTextBoxColumn.Name = "travelpriceDataGridViewTextBoxColumn";
            this.travelpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // travelBindingSource
            // 
            this.travelBindingSource.DataMember = "Travel";
            this.travelBindingSource.DataSource = this.great_PlacesDataSet3;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Place";
            this.placeBindingSource.DataSource = this.great_PlacesDataSet3;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Place_RegionTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.TouristTableAdapter = null;
            this.tableAdapterManager.TravelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GreatPlaces.Great_PlacesDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Great_PlacesDataSet3 great_PlacesDataSet3;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private Great_PlacesDataSet3TableAdapters.PlaceTableAdapter placeTableAdapter;
        private Great_PlacesDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private Great_PlacesDataSet3TableAdapters.TravelTableAdapter travelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource travelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn touristidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traveldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelpriceDataGridViewTextBoxColumn;
    }
}