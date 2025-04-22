namespace ManipulationDates
{
    partial class FrmPrincipal
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDuree = new System.Windows.Forms.GroupBox();
            this.txtTotalSecondes = new System.Windows.Forms.TextBox();
            this.txtTotalMinutes = new System.Windows.Forms.TextBox();
            this.txtTotalHeures = new System.Windows.Forms.TextBox();
            this.txtTotalJours = new System.Windows.Forms.TextBox();
            this.txtSecondes = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtHeures = new System.Windows.Forms.TextBox();
            this.txtJours = new System.Windows.Forms.TextBox();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHres = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblJours = new System.Windows.Forms.Label();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblNombreDe = new System.Windows.Forms.Label();
            this.grpValeurSelectionnee = new System.Windows.Forms.GroupBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtHeureFormattee = new System.Windows.Forms.TextBox();
            this.txtDateFormattee = new System.Windows.Forms.TextBox();
            this.cboMoments = new System.Windows.Forms.ComboBox();
            this.grpDuree.SuspendLayout();
            this.grpValeurSelectionnee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDuree
            // 
            this.grpDuree.Controls.Add(this.txtTotalSecondes);
            this.grpDuree.Controls.Add(this.txtTotalMinutes);
            this.grpDuree.Controls.Add(this.txtTotalHeures);
            this.grpDuree.Controls.Add(this.txtTotalJours);
            this.grpDuree.Controls.Add(this.txtSecondes);
            this.grpDuree.Controls.Add(this.txtMinutes);
            this.grpDuree.Controls.Add(this.txtHeures);
            this.grpDuree.Controls.Add(this.txtJours);
            this.grpDuree.Controls.Add(this.dtpDateFin);
            this.grpDuree.Controls.Add(this.lblTotal);
            this.grpDuree.Controls.Add(this.lblHres);
            this.grpDuree.Controls.Add(this.lblSec);
            this.grpDuree.Controls.Add(this.lblMinute);
            this.grpDuree.Controls.Add(this.lblJours);
            this.grpDuree.Controls.Add(this.txtDateDebut);
            this.grpDuree.Controls.Add(this.lblDateFin);
            this.grpDuree.Controls.Add(this.lblDateDebut);
            this.grpDuree.Controls.Add(this.lblNombreDe);
            this.grpDuree.Location = new System.Drawing.Point(13, 147);
            this.grpDuree.Name = "grpDuree";
            this.grpDuree.Size = new System.Drawing.Size(440, 173);
            this.grpDuree.TabIndex = 4;
            this.grpDuree.TabStop = false;
            this.grpDuree.Text = "Calcul de durées entre 2 dates";
            // 
            // txtTotalSecondes
            // 
            this.txtTotalSecondes.Location = new System.Drawing.Point(340, 131);
            this.txtTotalSecondes.Name = "txtTotalSecondes";
            this.txtTotalSecondes.ReadOnly = true;
            this.txtTotalSecondes.Size = new System.Drawing.Size(80, 20);
            this.txtTotalSecondes.TabIndex = 37;
            this.txtTotalSecondes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalMinutes
            // 
            this.txtTotalMinutes.Location = new System.Drawing.Point(249, 131);
            this.txtTotalMinutes.Name = "txtTotalMinutes";
            this.txtTotalMinutes.ReadOnly = true;
            this.txtTotalMinutes.Size = new System.Drawing.Size(80, 20);
            this.txtTotalMinutes.TabIndex = 36;
            this.txtTotalMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalHeures
            // 
            this.txtTotalHeures.Location = new System.Drawing.Point(159, 131);
            this.txtTotalHeures.Name = "txtTotalHeures";
            this.txtTotalHeures.ReadOnly = true;
            this.txtTotalHeures.Size = new System.Drawing.Size(80, 20);
            this.txtTotalHeures.TabIndex = 35;
            this.txtTotalHeures.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalJours
            // 
            this.txtTotalJours.Location = new System.Drawing.Point(67, 131);
            this.txtTotalJours.Name = "txtTotalJours";
            this.txtTotalJours.ReadOnly = true;
            this.txtTotalJours.Size = new System.Drawing.Size(80, 20);
            this.txtTotalJours.TabIndex = 34;
            this.txtTotalJours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecondes
            // 
            this.txtSecondes.Location = new System.Drawing.Point(340, 101);
            this.txtSecondes.Name = "txtSecondes";
            this.txtSecondes.ReadOnly = true;
            this.txtSecondes.Size = new System.Drawing.Size(80, 20);
            this.txtSecondes.TabIndex = 33;
            this.txtSecondes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(249, 101);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.ReadOnly = true;
            this.txtMinutes.Size = new System.Drawing.Size(80, 20);
            this.txtMinutes.TabIndex = 32;
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHeures
            // 
            this.txtHeures.Location = new System.Drawing.Point(159, 101);
            this.txtHeures.Name = "txtHeures";
            this.txtHeures.ReadOnly = true;
            this.txtHeures.Size = new System.Drawing.Size(80, 20);
            this.txtHeures.TabIndex = 31;
            this.txtHeures.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtJours
            // 
            this.txtJours.Location = new System.Drawing.Point(67, 101);
            this.txtJours.Name = "txtJours";
            this.txtJours.ReadOnly = true;
            this.txtJours.Size = new System.Drawing.Size(80, 20);
            this.txtJours.TabIndex = 30;
            this.txtJours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFin.Location = new System.Drawing.Point(249, 47);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(178, 20);
            this.dtpDateFin.TabIndex = 5;
            this.dtpDateFin.ValueChanged += new System.EventHandler(this.dtpDateFin_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 13);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total en :";
            // 
            // lblHres
            // 
            this.lblHres.AutoSize = true;
            this.lblHres.Location = new System.Drawing.Point(158, 85);
            this.lblHres.Name = "lblHres";
            this.lblHres.Size = new System.Drawing.Size(39, 13);
            this.lblHres.TabIndex = 21;
            this.lblHres.Text = "heures";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(337, 85);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(53, 13);
            this.lblSec.TabIndex = 19;
            this.lblSec.Text = "secondes";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(254, 85);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(43, 13);
            this.lblMinute.TabIndex = 17;
            this.lblMinute.Text = "minutes";
            // 
            // lblJours
            // 
            this.lblJours.AutoSize = true;
            this.lblJours.Location = new System.Drawing.Point(66, 85);
            this.lblJours.Name = "lblJours";
            this.lblJours.Size = new System.Drawing.Size(29, 13);
            this.lblJours.TabIndex = 15;
            this.lblJours.Text = "jours";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateDebut.Location = new System.Drawing.Point(19, 47);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.ReadOnly = true;
            this.txtDateDebut.Size = new System.Drawing.Size(178, 20);
            this.txtDateDebut.TabIndex = 12;
            this.txtDateDebut.Text = "2012-01-01 00:00:00";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(246, 31);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(65, 13);
            this.lblDateFin.TabIndex = 7;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(14, 31);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(81, 13);
            this.lblDateDebut.TabIndex = 3;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // lblNombreDe
            // 
            this.lblNombreDe.AutoSize = true;
            this.lblNombreDe.Location = new System.Drawing.Point(9, 101);
            this.lblNombreDe.Name = "lblNombreDe";
            this.lblNombreDe.Size = new System.Drawing.Size(54, 13);
            this.lblNombreDe.TabIndex = 0;
            this.lblNombreDe.Text = "Nbre de  :";
            // 
            // grpValeurSelectionnee
            // 
            this.grpValeurSelectionnee.Controls.Add(this.lblHeure);
            this.grpValeurSelectionnee.Controls.Add(this.lblDate);
            this.grpValeurSelectionnee.Controls.Add(this.txtHeureFormattee);
            this.grpValeurSelectionnee.Controls.Add(this.txtDateFormattee);
            this.grpValeurSelectionnee.Controls.Add(this.cboMoments);
            this.grpValeurSelectionnee.Location = new System.Drawing.Point(12, 12);
            this.grpValeurSelectionnee.Name = "grpValeurSelectionnee";
            this.grpValeurSelectionnee.Size = new System.Drawing.Size(441, 118);
            this.grpValeurSelectionnee.TabIndex = 0;
            this.grpValeurSelectionnee.TabStop = false;
            this.grpValeurSelectionnee.Text = "Calcul avec des dates";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(246, 63);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(118, 13);
            this.lblHeure.TabIndex = 5;
            this.lblHeure.Text = "Heure/minute/seconde";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 63);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Année/mois/jour";
            // 
            // txtHeureFormattee
            // 
            this.txtHeureFormattee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeureFormattee.Location = new System.Drawing.Point(249, 79);
            this.txtHeureFormattee.Name = "txtHeureFormattee";
            this.txtHeureFormattee.ReadOnly = true;
            this.txtHeureFormattee.Size = new System.Drawing.Size(173, 20);
            this.txtHeureFormattee.TabIndex = 2;
            // 
            // txtDateFormattee
            // 
            this.txtDateFormattee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFormattee.Location = new System.Drawing.Point(19, 79);
            this.txtDateFormattee.Name = "txtDateFormattee";
            this.txtDateFormattee.ReadOnly = true;
            this.txtDateFormattee.Size = new System.Drawing.Size(178, 20);
            this.txtDateFormattee.TabIndex = 1;
            // 
            // cboMoments
            // 
            this.cboMoments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoments.FormattingEnabled = true;
            this.cboMoments.Items.AddRange(new object[] {
            "Maintenant",
            "Aujourd\'hui dans une heure",
            "Hier même heure",
            "Demain, une heure de plus",
            "Il y a 4 semaines (28 jours)",
            "Dans 2 mois",
            "Il y a 10 ans",
            "Dans 20 ans, même jour, même heure"});
            this.cboMoments.Location = new System.Drawing.Point(19, 35);
            this.cboMoments.Name = "cboMoments";
            this.cboMoments.Size = new System.Drawing.Size(404, 21);
            this.cboMoments.TabIndex = 0;
            this.cboMoments.SelectedIndexChanged += new System.EventHandler(this.cboMoments_SelectedIndexChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 334);
            this.Controls.Add(this.grpValeurSelectionnee);
            this.Controls.Add(this.grpDuree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipulation de dates ";
            this.grpDuree.ResumeLayout(false);
            this.grpDuree.PerformLayout();
            this.grpValeurSelectionnee.ResumeLayout(false);
            this.grpValeurSelectionnee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDuree;
        private System.Windows.Forms.Label lblNombreDe;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.GroupBox grpValeurSelectionnee;
        private System.Windows.Forms.ComboBox cboMoments;
        private System.Windows.Forms.TextBox txtDateFormattee;
        private System.Windows.Forms.TextBox txtHeureFormattee;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblJours;
        private System.Windows.Forms.Label lblHres;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.TextBox txtSecondes;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtHeures;
        private System.Windows.Forms.TextBox txtJours;
        private System.Windows.Forms.TextBox txtTotalSecondes;
        private System.Windows.Forms.TextBox txtTotalMinutes;
        private System.Windows.Forms.TextBox txtTotalHeures;
        private System.Windows.Forms.TextBox txtTotalJours;
    }
}

