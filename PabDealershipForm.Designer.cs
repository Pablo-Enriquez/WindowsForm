namespace PabDealership.Views
{
    partial class PabDealershipForm
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
            panel1 = new Panel();
            bttnSave = new Button();
            nudYear = new NumericUpDown();
            txtModel = new TextBox();
            txtMake = new TextBox();
            lblModel = new Label();
            lbl = new Label();
            lblMake = new Label();
            lblYear = new Label();
            bttnExit = new Button();
            txtCarDescription = new TextBox();
            lblSelect = new Label();
            cbxCar = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bttnSave);
            panel1.Controls.Add(nudYear);
            panel1.Controls.Add(txtModel);
            panel1.Controls.Add(txtMake);
            panel1.Controls.Add(lblModel);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(lblMake);
            panel1.Controls.Add(lblYear);
            panel1.Location = new Point(21, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 315);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // bttnSave
            // 
            bttnSave.Location = new Point(81, 221);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(98, 23);
            bttnSave.TabIndex = 17;
            bttnSave.Text = "Save";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(81, 87);
            nudYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(140, 23);
            nudYear.TabIndex = 16;
            nudYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // txtModel
            // 
            txtModel.Location = new Point(81, 116);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(140, 23);
            txtModel.TabIndex = 15;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(81, 150);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(141, 23);
            txtMake.TabIndex = 14;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(7, 158);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 12;
            lblModel.Text = "Model";
            lblModel.Click += lblModel_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(16, 91);
            lbl.Name = "lbl";
            lbl.Size = new Size(32, 15);
            lbl.TabIndex = 11;
            lbl.Text = "Year:";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(9, 124);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(39, 15);
            lblMake.TabIndex = 10;
            lblMake.Text = "Make:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(129, 55);
            lblYear.MaximumSize = new Size(25, 25);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(25, 15);
            lblYear.TabIndex = 9;
            lblYear.Text = "Car";
            lblYear.Click += lblYear_Click;
            // 
            // bttnExit
            // 
            bttnExit.Location = new Point(344, 378);
            bttnExit.Name = "bttnExit";
            bttnExit.Size = new Size(75, 23);
            bttnExit.TabIndex = 10;
            bttnExit.Text = "Exit";
            bttnExit.UseVisualStyleBackColor = true;
            bttnExit.Click += bttnExit_Click;
            // 
            // txtCarDescription
            // 
            txtCarDescription.Location = new Point(424, 114);
            txtCarDescription.Multiline = true;
            txtCarDescription.Name = "txtCarDescription";
            txtCarDescription.Size = new Size(202, 236);
            txtCarDescription.TabIndex = 11;
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Location = new Point(424, 50);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(68, 15);
            lblSelect.TabIndex = 12;
            lblSelect.Text = "Select a Car";
            // 
            // cbxCar
            // 
            cbxCar.FormattingEnabled = true;
            cbxCar.Location = new Point(498, 47);
            cbxCar.Name = "cbxCar";
            cbxCar.Size = new Size(121, 23);
            cbxCar.TabIndex = 13;
            cbxCar.SelectedIndexChanged += cbxCar_SelectedIndexChanged;
            // 
            // PabDealershipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxCar);
            Controls.Add(lblSelect);
            Controls.Add(txtCarDescription);
            Controls.Add(bttnExit);
            Controls.Add(panel1);
            Name = "PabDealershipForm";
            Text = "PabDealershipForm";
            Load += PabDealershipForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button bttnSave;
        private NumericUpDown nudYear;
        private TextBox txtModel;
        private TextBox txtMake;
        private Label lblModel;
        private Label lbl;
        private Label lblMake;
        private Label lblYear;
        private Button bttnExit;
        private TextBox txtCarDescription;
        private Label lblSelect;
        private ComboBox cbxCar;
    }
}