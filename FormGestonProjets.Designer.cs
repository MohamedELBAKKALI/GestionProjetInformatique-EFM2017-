namespace GestionProjetInformatique
{
    partial class FormGestonProjets
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
            System.Windows.Forms.Label date_finLabel;
            System.Windows.Forms.Label date_projetLabel;
            System.Windows.Forms.Label nom_projetLabel;
            System.Windows.Forms.Label num_projetLabel;
            this.date_finDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_projetDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nom_projetTextBox = new System.Windows.Forms.TextBox();
            this.num_projetTextBox = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrivie = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            date_finLabel = new System.Windows.Forms.Label();
            date_projetLabel = new System.Windows.Forms.Label();
            nom_projetLabel = new System.Windows.Forms.Label();
            num_projetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_finLabel
            // 
            date_finLabel.AutoSize = true;
            date_finLabel.Location = new System.Drawing.Point(56, 49);
            date_finLabel.Name = "date_finLabel";
            date_finLabel.Size = new System.Drawing.Size(45, 13);
            date_finLabel.TabIndex = 1;
            date_finLabel.Text = "date fin:";
            // 
            // date_finDateTimePicker
            // 
            this.date_finDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projetBindingSource, "date_fin", true));
            this.date_finDateTimePicker.Location = new System.Drawing.Point(122, 45);
            this.date_finDateTimePicker.Name = "date_finDateTimePicker";
            this.date_finDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_finDateTimePicker.TabIndex = 2;
            // 
            // date_projetLabel
            // 
            date_projetLabel.AutoSize = true;
            date_projetLabel.Location = new System.Drawing.Point(56, 75);
            date_projetLabel.Name = "date_projetLabel";
            date_projetLabel.Size = new System.Drawing.Size(60, 13);
            date_projetLabel.TabIndex = 3;
            date_projetLabel.Text = "date projet:";
            // 
            // date_projetDateTimePicker
            // 
            this.date_projetDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projetBindingSource, "date_projet", true));
            this.date_projetDateTimePicker.Location = new System.Drawing.Point(122, 71);
            this.date_projetDateTimePicker.Name = "date_projetDateTimePicker";
            this.date_projetDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_projetDateTimePicker.TabIndex = 4;
            // 
            // nom_projetLabel
            // 
            nom_projetLabel.AutoSize = true;
            nom_projetLabel.Location = new System.Drawing.Point(56, 100);
            nom_projetLabel.Name = "nom_projetLabel";
            nom_projetLabel.Size = new System.Drawing.Size(59, 13);
            nom_projetLabel.TabIndex = 5;
            nom_projetLabel.Text = "nom projet:";
            // 
            // nom_projetTextBox
            // 
            this.nom_projetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetBindingSource, "nom_projet", true));
            this.nom_projetTextBox.Location = new System.Drawing.Point(122, 97);
            this.nom_projetTextBox.Name = "nom_projetTextBox";
            this.nom_projetTextBox.Size = new System.Drawing.Size(200, 20);
            this.nom_projetTextBox.TabIndex = 6;
            // 
            // num_projetLabel
            // 
            num_projetLabel.AutoSize = true;
            num_projetLabel.Location = new System.Drawing.Point(56, 126);
            num_projetLabel.Name = "num_projetLabel";
            num_projetLabel.Size = new System.Drawing.Size(59, 13);
            num_projetLabel.TabIndex = 7;
            num_projetLabel.Text = "num projet:";
            // 
            // num_projetTextBox
            // 
            this.num_projetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetBindingSource, "num_projet", true));
            this.num_projetTextBox.Location = new System.Drawing.Point(122, 123);
            this.num_projetTextBox.Name = "num_projetTextBox";
            this.num_projetTextBox.Size = new System.Drawing.Size(200, 20);
            this.num_projetTextBox.TabIndex = 8;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(268, 184);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 21;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(187, 184);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrivie
            // 
            this.btnPrivie.Location = new System.Drawing.Point(106, 184);
            this.btnPrivie.Name = "btnPrivie";
            this.btnPrivie.Size = new System.Drawing.Size(75, 23);
            this.btnPrivie.TabIndex = 19;
            this.btnPrivie.Text = "Privieus";
            this.btnPrivie.UseVisualStyleBackColor = true;
            this.btnPrivie.Click += new System.EventHandler(this.btnPrivie_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(25, 184);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 18;
            this.btnFirst.Text = "Firs";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(338, 143);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 26;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(338, 114);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 25;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(338, 84);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 24;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(338, 55);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 23;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(338, 26);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 22;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataSource = typeof(GestionProjetInformatique.Projet);
            // 
            // FormGestonProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 295);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrivie);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(date_finLabel);
            this.Controls.Add(this.date_finDateTimePicker);
            this.Controls.Add(date_projetLabel);
            this.Controls.Add(this.date_projetDateTimePicker);
            this.Controls.Add(nom_projetLabel);
            this.Controls.Add(this.nom_projetTextBox);
            this.Controls.Add(num_projetLabel);
            this.Controls.Add(this.num_projetTextBox);
            this.Name = "FormGestonProjets";
            this.Text = "FormGestonProjets";
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource projetBindingSource;
        private System.Windows.Forms.DateTimePicker date_finDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_projetDateTimePicker;
        private System.Windows.Forms.TextBox nom_projetTextBox;
        private System.Windows.Forms.TextBox num_projetTextBox;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrivie;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnNouveau;
    }
}