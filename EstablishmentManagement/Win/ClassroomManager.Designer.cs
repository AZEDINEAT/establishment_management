namespace TrainningIS.EstablishmentMS.Win
{
    partial class ClassroomManager
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
            this.calssroomGrid1 = new TrainningIS.EstablishmentMS.Win.CalssroomGrid();
            this.SuspendLayout();
            // 
            // calssroomGrid1
            // 
            this.calssroomGrid1.Location = new System.Drawing.Point(46, 147);
            this.calssroomGrid1.Name = "calssroomGrid1";
            this.calssroomGrid1.Size = new System.Drawing.Size(355, 271);
            this.calssroomGrid1.TabIndex = 0;
            // 
            // ClassroomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calssroomGrid1);
            this.Name = "ClassroomManager";
            this.Size = new System.Drawing.Size(740, 432);
            this.ResumeLayout(false);

        }

        #endregion

        private CalssroomGrid calssroomGrid1;
    }
}
