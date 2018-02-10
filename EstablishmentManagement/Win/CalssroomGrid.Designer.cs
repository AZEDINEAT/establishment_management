namespace TrainningIS.EstablishmentMS.Win
{
    partial class CalssroomGrid
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.classroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classroomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataSource = typeof(TrainningIS.EstablishmentMS.Entities.Classroom);
            // 
            // classroomDataGridView
            // 
            this.classroomDataGridView.AutoGenerateColumns = false;
            this.classroomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classroomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.classroomDataGridView.DataSource = this.classroomBindingSource;
            this.classroomDataGridView.Location = new System.Drawing.Point(35, 31);
            this.classroomDataGridView.Name = "classroomDataGridView";
            this.classroomDataGridView.Size = new System.Drawing.Size(300, 220);
            this.classroomDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // CalssroomGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.classroomDataGridView);
            this.Name = "CalssroomGrid";
            this.Size = new System.Drawing.Size(355, 271);
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource classroomBindingSource;
        private System.Windows.Forms.DataGridView classroomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
