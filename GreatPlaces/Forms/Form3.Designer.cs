namespace GreatPlaces.Forms
{
    partial class Form3
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
            System.Windows.Forms.Label travel_idLabel;
            System.Windows.Forms.Label place_idLabel;
            System.Windows.Forms.Label tourist_idLabel;
            System.Windows.Forms.Label travel_dateLabel;
            System.Windows.Forms.Label travel_priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.great_PlacesDataSet3 = new GreatPlaces.Great_PlacesDataSet3();
            this.travelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelTableAdapter = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TravelTableAdapter();
            this.tableAdapterManager = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TableAdapterManager();
            this.travelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.travelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.travel_idTextBox = new System.Windows.Forms.TextBox();
            this.place_idTextBox = new System.Windows.Forms.TextBox();
            this.tourist_idTextBox = new System.Windows.Forms.TextBox();
            this.travel_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.travel_priceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            travel_idLabel = new System.Windows.Forms.Label();
            place_idLabel = new System.Windows.Forms.Label();
            tourist_idLabel = new System.Windows.Forms.Label();
            travel_dateLabel = new System.Windows.Forms.Label();
            travel_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingNavigator)).BeginInit();
            this.travelBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // travel_idLabel
            // 
            travel_idLabel.AutoSize = true;
            travel_idLabel.Location = new System.Drawing.Point(254, 141);
            travel_idLabel.Name = "travel_idLabel";
            travel_idLabel.Size = new System.Drawing.Size(57, 16);
            travel_idLabel.TabIndex = 1;
            travel_idLabel.Text = "travel id:";
            // 
            // place_idLabel
            // 
            place_idLabel.AutoSize = true;
            place_idLabel.Location = new System.Drawing.Point(254, 169);
            place_idLabel.Name = "place_idLabel";
            place_idLabel.Size = new System.Drawing.Size(58, 16);
            place_idLabel.TabIndex = 3;
            place_idLabel.Text = "place id:";
            // 
            // tourist_idLabel
            // 
            tourist_idLabel.AutoSize = true;
            tourist_idLabel.Location = new System.Drawing.Point(254, 197);
            tourist_idLabel.Name = "tourist_idLabel";
            tourist_idLabel.Size = new System.Drawing.Size(59, 16);
            tourist_idLabel.TabIndex = 5;
            tourist_idLabel.Text = "tourist id:";
            // 
            // travel_dateLabel
            // 
            travel_dateLabel.AutoSize = true;
            travel_dateLabel.Location = new System.Drawing.Point(254, 226);
            travel_dateLabel.Name = "travel_dateLabel";
            travel_dateLabel.Size = new System.Drawing.Size(73, 16);
            travel_dateLabel.TabIndex = 7;
            travel_dateLabel.Text = "travel date:";
            // 
            // travel_priceLabel
            // 
            travel_priceLabel.AutoSize = true;
            travel_priceLabel.Location = new System.Drawing.Point(254, 253);
            travel_priceLabel.Name = "travel_priceLabel";
            travel_priceLabel.Size = new System.Drawing.Size(76, 16);
            travel_priceLabel.TabIndex = 9;
            travel_priceLabel.Text = "travel price:";
            // 
            // great_PlacesDataSet3
            // 
            this.great_PlacesDataSet3.DataSetName = "Great_PlacesDataSet3";
            this.great_PlacesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // travelBindingSource
            // 
            this.travelBindingSource.DataMember = "Travel";
            this.travelBindingSource.DataSource = this.great_PlacesDataSet3;
            // 
            // travelTableAdapter
            // 
            this.travelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Place_RegionTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.TouristTableAdapter = null;
            this.tableAdapterManager.TourPlaceTableAdapter = null;
            this.tableAdapterManager.TourTableAdapter = null;
            this.tableAdapterManager.TravelTableAdapter = this.travelTableAdapter;
            this.tableAdapterManager.UpdateOrder = GreatPlaces.Great_PlacesDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // travelBindingNavigator
            // 
            this.travelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.travelBindingNavigator.BindingSource = this.travelBindingSource;
            this.travelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.travelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.travelBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.travelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.travelBindingNavigatorSaveItem});
            this.travelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.travelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.travelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.travelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.travelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.travelBindingNavigator.Name = "travelBindingNavigator";
            this.travelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.travelBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.travelBindingNavigator.TabIndex = 0;
            this.travelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // travelBindingNavigatorSaveItem
            // 
            this.travelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.travelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("travelBindingNavigatorSaveItem.Image")));
            this.travelBindingNavigatorSaveItem.Name = "travelBindingNavigatorSaveItem";
            this.travelBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.travelBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.travelBindingNavigatorSaveItem.Click += new System.EventHandler(this.travelBindingNavigatorSaveItem_Click_2);
            // 
            // travel_idTextBox
            // 
            this.travel_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelBindingSource, "travel_id", true));
            this.travel_idTextBox.Location = new System.Drawing.Point(336, 138);
            this.travel_idTextBox.Name = "travel_idTextBox";
            this.travel_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.travel_idTextBox.TabIndex = 2;
            // 
            // place_idTextBox
            // 
            this.place_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelBindingSource, "place_id", true));
            this.place_idTextBox.Location = new System.Drawing.Point(336, 166);
            this.place_idTextBox.Name = "place_idTextBox";
            this.place_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.place_idTextBox.TabIndex = 4;
            // 
            // tourist_idTextBox
            // 
            this.tourist_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelBindingSource, "tourist_id", true));
            this.tourist_idTextBox.Location = new System.Drawing.Point(336, 194);
            this.tourist_idTextBox.Name = "tourist_idTextBox";
            this.tourist_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.tourist_idTextBox.TabIndex = 6;
            // 
            // travel_dateDateTimePicker
            // 
            this.travel_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.travelBindingSource, "travel_date", true));
            this.travel_dateDateTimePicker.Location = new System.Drawing.Point(336, 222);
            this.travel_dateDateTimePicker.Name = "travel_dateDateTimePicker";
            this.travel_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.travel_dateDateTimePicker.TabIndex = 8;
            // 
            // travel_priceTextBox
            // 
            this.travel_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelBindingSource, "travel_price", true));
            this.travel_priceTextBox.Location = new System.Drawing.Point(336, 250);
            this.travel_priceTextBox.Name = "travel_priceTextBox";
            this.travel_priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.travel_priceTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 105);
            this.button1.TabIndex = 11;
            this.button1.Text = "Змінити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(travel_idLabel);
            this.Controls.Add(this.travel_idTextBox);
            this.Controls.Add(place_idLabel);
            this.Controls.Add(this.place_idTextBox);
            this.Controls.Add(tourist_idLabel);
            this.Controls.Add(this.tourist_idTextBox);
            this.Controls.Add(travel_dateLabel);
            this.Controls.Add(this.travel_dateDateTimePicker);
            this.Controls.Add(travel_priceLabel);
            this.Controls.Add(this.travel_priceTextBox);
            this.Controls.Add(this.travelBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.фо_Load);
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingNavigator)).EndInit();
            this.travelBindingNavigator.ResumeLayout(false);
            this.travelBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Great_PlacesDataSet3 great_PlacesDataSet3;
        private System.Windows.Forms.BindingSource travelBindingSource;
        private Great_PlacesDataSet3TableAdapters.TravelTableAdapter travelTableAdapter;
        private Great_PlacesDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator travelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton travelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox travel_idTextBox;
        private System.Windows.Forms.TextBox place_idTextBox;
        private System.Windows.Forms.TextBox tourist_idTextBox;
        private System.Windows.Forms.DateTimePicker travel_dateDateTimePicker;
        private System.Windows.Forms.TextBox travel_priceTextBox;
        private System.Windows.Forms.Button button1;
    }
}