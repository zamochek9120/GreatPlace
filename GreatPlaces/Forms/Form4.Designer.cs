namespace GreatPlaces
{
    partial class Form4
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
            System.Windows.Forms.Label tourist_idLabel;
            System.Windows.Forms.Label tourist_nameLabel;
            System.Windows.Forms.Label tourist_surnameLabel;
            System.Windows.Forms.Label tourist_middle_nameLabel;
            System.Windows.Forms.Label birth_yearLabel;
            System.Windows.Forms.Label genderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.touristBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.great_PlacesDataSet3 = new GreatPlaces.Great_PlacesDataSet3();
            this.travelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelTableAdapter = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TravelTableAdapter();
            this.tableAdapterManager = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TableAdapterManager();
            this.touristTableAdapter = new GreatPlaces.Great_PlacesDataSet3TableAdapters.TouristTableAdapter();
            this.tourist_idTextBox = new System.Windows.Forms.TextBox();
            this.tourist_nameTextBox = new System.Windows.Forms.TextBox();
            this.tourist_surnameTextBox = new System.Windows.Forms.TextBox();
            this.tourist_middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.birth_yearTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.travelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            tourist_idLabel = new System.Windows.Forms.Label();
            tourist_nameLabel = new System.Windows.Forms.Label();
            tourist_surnameLabel = new System.Windows.Forms.Label();
            tourist_middle_nameLabel = new System.Windows.Forms.Label();
            birth_yearLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.touristBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tourist_idLabel
            // 
            tourist_idLabel.AutoSize = true;
            tourist_idLabel.Location = new System.Drawing.Point(69, 50);
            tourist_idLabel.Name = "tourist_idLabel";
            tourist_idLabel.Size = new System.Drawing.Size(59, 16);
            tourist_idLabel.TabIndex = 11;
            tourist_idLabel.Text = "tourist id:";
            // 
            // tourist_nameLabel
            // 
            tourist_nameLabel.AutoSize = true;
            tourist_nameLabel.Location = new System.Drawing.Point(69, 96);
            tourist_nameLabel.Name = "tourist_nameLabel";
            tourist_nameLabel.Size = new System.Drawing.Size(82, 16);
            tourist_nameLabel.TabIndex = 13;
            tourist_nameLabel.Text = "tourist name:";
            // 
            // tourist_surnameLabel
            // 
            tourist_surnameLabel.AutoSize = true;
            tourist_surnameLabel.Location = new System.Drawing.Point(69, 139);
            tourist_surnameLabel.Name = "tourist_surnameLabel";
            tourist_surnameLabel.Size = new System.Drawing.Size(100, 16);
            tourist_surnameLabel.TabIndex = 15;
            tourist_surnameLabel.Text = "tourist surname:";
            // 
            // tourist_middle_nameLabel
            // 
            tourist_middle_nameLabel.AutoSize = true;
            tourist_middle_nameLabel.Location = new System.Drawing.Point(69, 192);
            tourist_middle_nameLabel.Name = "tourist_middle_nameLabel";
            tourist_middle_nameLabel.Size = new System.Drawing.Size(126, 16);
            tourist_middle_nameLabel.TabIndex = 17;
            tourist_middle_nameLabel.Text = "tourist middle name:";
            // 
            // birth_yearLabel
            // 
            birth_yearLabel.AutoSize = true;
            birth_yearLabel.Location = new System.Drawing.Point(69, 239);
            birth_yearLabel.Name = "birth_yearLabel";
            birth_yearLabel.Size = new System.Drawing.Size(65, 16);
            birth_yearLabel.TabIndex = 19;
            birth_yearLabel.Text = "birth year:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(75, 288);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(53, 16);
            genderLabel.TabIndex = 21;
            genderLabel.Text = "gender:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Змінити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // touristBindingSource
            // 
            this.touristBindingSource.DataMember = "Tourist";
            this.touristBindingSource.DataSource = this.great_PlacesDataSet3;
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
            // touristTableAdapter
            // 
            this.touristTableAdapter.ClearBeforeFill = true;
            // 
            // tourist_idTextBox
            // 
            this.tourist_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.touristBindingSource, "tourist_id", true));
            this.tourist_idTextBox.Location = new System.Drawing.Point(210, 50);
            this.tourist_idTextBox.Name = "tourist_idTextBox";
            this.tourist_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.tourist_idTextBox.TabIndex = 12;
            // 
            // tourist_nameTextBox
            // 
            this.tourist_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.touristBindingSource, "tourist_name", true));
            this.tourist_nameTextBox.Location = new System.Drawing.Point(210, 96);
            this.tourist_nameTextBox.Name = "tourist_nameTextBox";
            this.tourist_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.tourist_nameTextBox.TabIndex = 14;
            // 
            // tourist_surnameTextBox
            // 
            this.tourist_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.touristBindingSource, "tourist_surname", true));
            this.tourist_surnameTextBox.Location = new System.Drawing.Point(210, 139);
            this.tourist_surnameTextBox.Name = "tourist_surnameTextBox";
            this.tourist_surnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.tourist_surnameTextBox.TabIndex = 16;
            // 
            // tourist_middle_nameTextBox
            // 
            this.tourist_middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.touristBindingSource, "tourist_middle_name", true));
            this.tourist_middle_nameTextBox.Location = new System.Drawing.Point(210, 192);
            this.tourist_middle_nameTextBox.Name = "tourist_middle_nameTextBox";
            this.tourist_middle_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.tourist_middle_nameTextBox.TabIndex = 18;
            // 
            // birth_yearTextBox
            // 
            this.birth_yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.touristBindingSource, "birth_year", true));
            this.birth_yearTextBox.Location = new System.Drawing.Point(210, 233);
            this.birth_yearTextBox.Name = "birth_yearTextBox";
            this.birth_yearTextBox.Size = new System.Drawing.Size(100, 22);
            this.birth_yearTextBox.TabIndex = 20;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.touristBindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(210, 282);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 22);
            this.genderTextBox.TabIndex = 22;
            // 
            // travelBindingSource1
            // 
            this.travelBindingSource1.DataMember = "FK__Travel__tourist___182C9B23";
            this.travelBindingSource1.DataSource = this.touristBindingSource;
            // 
            // travelDataGridView
            // 
            this.travelDataGridView.AutoGenerateColumns = false;
            this.travelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.travelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.travelDataGridView.DataSource = this.travelBindingSource1;
            this.travelDataGridView.Location = new System.Drawing.Point(72, 336);
            this.travelDataGridView.Name = "travelDataGridView";
            this.travelDataGridView.RowHeadersWidth = 51;
            this.travelDataGridView.RowTemplate.Height = 24;
            this.travelDataGridView.Size = new System.Drawing.Size(753, 220);
            this.travelDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "travel_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "travel_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "place_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "place_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tourist_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "tourist_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "travel_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "travel_date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "travel_price";
            this.dataGridViewTextBoxColumn5.HeaderText = "travel_price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.touristBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(968, 27);
            this.bindingNavigator1.TabIndex = 23;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 728);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.travelDataGridView);
            this.Controls.Add(tourist_idLabel);
            this.Controls.Add(this.tourist_idTextBox);
            this.Controls.Add(tourist_nameLabel);
            this.Controls.Add(this.tourist_nameTextBox);
            this.Controls.Add(tourist_surnameLabel);
            this.Controls.Add(this.tourist_surnameTextBox);
            this.Controls.Add(tourist_middle_nameLabel);
            this.Controls.Add(this.tourist_middle_nameTextBox);
            this.Controls.Add(birth_yearLabel);
            this.Controls.Add(this.birth_yearTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.touristBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.great_PlacesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Great_PlacesDataSet3 great_PlacesDataSet3;
        private System.Windows.Forms.BindingSource travelBindingSource;
        private Great_PlacesDataSet3TableAdapters.TravelTableAdapter travelTableAdapter;
        private Great_PlacesDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource touristBindingSource;
        private Great_PlacesDataSet3TableAdapters.TouristTableAdapter touristTableAdapter;
        private System.Windows.Forms.TextBox tourist_idTextBox;
        private System.Windows.Forms.TextBox tourist_nameTextBox;
        private System.Windows.Forms.TextBox tourist_surnameTextBox;
        private System.Windows.Forms.TextBox tourist_middle_nameTextBox;
        private System.Windows.Forms.TextBox birth_yearTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.BindingSource travelBindingSource1;
        private System.Windows.Forms.DataGridView travelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
    }
}