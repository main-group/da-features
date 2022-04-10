namespace da_features
{
    partial class FrmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.kstv = new AdminControls.KeSachThuVien();
            this.keSachBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.keSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_DB_DA_FEATURES = new da_features.DataSet_DB_DA_FEATURES();
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
            this.keSachBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.keSachDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keSachTableAdapter = new da_features.DataSet_DB_DA_FEATURESTableAdapters.KeSachTableAdapter();
            this.tableAdapterManager = new da_features.DataSet_DB_DA_FEATURESTableAdapters.TableAdapterManager();
            this.fpnlDSKeSach = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.keSachBindingNavigator)).BeginInit();
            this.keSachBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DB_DA_FEATURES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keSachDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(223, 72);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(12, 72);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(205, 22);
            this.txtTenSach.TabIndex = 2;
            // 
            // kstv
            // 
            this.kstv.BackColor = System.Drawing.Color.LightBlue;
            this.kstv.Location = new System.Drawing.Point(12, 131);
            this.kstv.Name = "kstv";
            this.kstv.Size = new System.Drawing.Size(286, 434);
            this.kstv.TabIndex = 0;
            // 
            // keSachBindingNavigator
            // 
            this.keSachBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.keSachBindingNavigator.BindingSource = this.keSachBindingSource;
            this.keSachBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.keSachBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.keSachBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.keSachBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.keSachBindingNavigatorSaveItem});
            this.keSachBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.keSachBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.keSachBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.keSachBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.keSachBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.keSachBindingNavigator.Name = "keSachBindingNavigator";
            this.keSachBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.keSachBindingNavigator.Size = new System.Drawing.Size(1456, 27);
            this.keSachBindingNavigator.TabIndex = 3;
            this.keSachBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // keSachBindingSource
            // 
            this.keSachBindingSource.DataMember = "KeSach";
            this.keSachBindingSource.DataSource = this.dataSet_DB_DA_FEATURES;
            // 
            // dataSet_DB_DA_FEATURES
            // 
            this.dataSet_DB_DA_FEATURES.DataSetName = "DataSet_DB_DA_FEATURES";
            this.dataSet_DB_DA_FEATURES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // keSachBindingNavigatorSaveItem
            // 
            this.keSachBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.keSachBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("keSachBindingNavigatorSaveItem.Image")));
            this.keSachBindingNavigatorSaveItem.Name = "keSachBindingNavigatorSaveItem";
            this.keSachBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.keSachBindingNavigatorSaveItem.Text = "Save Data";
            this.keSachBindingNavigatorSaveItem.Click += new System.EventHandler(this.keSachBindingNavigatorSaveItem_Click);
            // 
            // keSachDataGridView
            // 
            this.keSachDataGridView.AutoGenerateColumns = false;
            this.keSachDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keSachDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.keSachDataGridView.DataSource = this.keSachBindingSource;
            this.keSachDataGridView.Location = new System.Drawing.Point(12, 582);
            this.keSachDataGridView.Name = "keSachDataGridView";
            this.keSachDataGridView.RowTemplate.Height = 24;
            this.keSachDataGridView.Size = new System.Drawing.Size(261, 80);
            this.keSachDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKeSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKeSach";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKeSach";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenKeSach";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // keSachTableAdapter
            // 
            this.keSachTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KeSachTableAdapter = this.keSachTableAdapter;
            this.tableAdapterManager.SachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = da_features.DataSet_DB_DA_FEATURESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ViTriSachTableAdapter = null;
            // 
            // fpnlDSKeSach
            // 
            this.fpnlDSKeSach.Location = new System.Drawing.Point(304, 72);
            this.fpnlDSKeSach.Name = "fpnlDSKeSach";
            this.fpnlDSKeSach.Size = new System.Drawing.Size(1140, 662);
            this.fpnlDSKeSach.TabIndex = 5;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 746);
            this.Controls.Add(this.fpnlDSKeSach);
            this.Controls.Add(this.keSachDataGridView);
            this.Controls.Add(this.keSachBindingNavigator);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.kstv);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keSachBindingNavigator)).EndInit();
            this.keSachBindingNavigator.ResumeLayout(false);
            this.keSachBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DB_DA_FEATURES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keSachDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdminControls.KeSachThuVien kstv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenSach;
        private DataSet_DB_DA_FEATURES dataSet_DB_DA_FEATURES;
        private System.Windows.Forms.BindingSource keSachBindingSource;
        private DataSet_DB_DA_FEATURESTableAdapters.KeSachTableAdapter keSachTableAdapter;
        private DataSet_DB_DA_FEATURESTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator keSachBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton keSachBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView keSachDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.FlowLayoutPanel fpnlDSKeSach;

    }
}