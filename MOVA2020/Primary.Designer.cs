﻿namespace MOVA2020
{
    partial class Primary
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvToimintaalueet = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.lblLisaaToimintaalueNimi = new System.Windows.Forms.Label();
            this.tbLisaaToimintaalueNimi = new System.Windows.Forms.TextBox();
            this.btnLisaatoimintaalue = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaalueet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dgvMokit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mökit";
            // 
            // dgvMokit
            // 
            this.dgvMokit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(456, 6);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.Size = new System.Drawing.Size(317, 383);
            this.dgvMokit.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLisaatoimintaalue);
            this.tabPage2.Controls.Add(this.tbLisaaToimintaalueNimi);
            this.tabPage2.Controls.Add(this.lblLisaaToimintaalueNimi);
            this.tabPage2.Controls.Add(this.dgvToimintaalueet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toimialueet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvToimintaalueet
            // 
            this.dgvToimintaalueet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToimintaalueet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToimintaalueet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvToimintaalueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToimintaalueet.Location = new System.Drawing.Point(456, 6);
            this.dgvToimintaalueet.Name = "dgvToimintaalueet";
            this.dgvToimintaalueet.RowHeadersVisible = false;
            this.dgvToimintaalueet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvToimintaalueet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToimintaalueet.ShowCellErrors = false;
            this.dgvToimintaalueet.ShowCellToolTips = false;
            this.dgvToimintaalueet.ShowEditingIcon = false;
            this.dgvToimintaalueet.ShowRowErrors = false;
            this.dgvToimintaalueet.Size = new System.Drawing.Size(317, 383);
            this.dgvToimintaalueet.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvVaraukset);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Varaukset";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(456, 6);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(317, 383);
            this.dgvVaraukset.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvAsiakkaat);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(779, 395);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Asiakkaat";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(456, 6);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.Size = new System.Drawing.Size(317, 383);
            this.dgvAsiakkaat.TabIndex = 0;
            // 
            // lblLisaaToimintaalueNimi
            // 
            this.lblLisaaToimintaalueNimi.AutoSize = true;
            this.lblLisaaToimintaalueNimi.Location = new System.Drawing.Point(-3, 6);
            this.lblLisaaToimintaalueNimi.Name = "lblLisaaToimintaalueNimi";
            this.lblLisaaToimintaalueNimi.Size = new System.Drawing.Size(27, 13);
            this.lblLisaaToimintaalueNimi.TabIndex = 2;
            this.lblLisaaToimintaalueNimi.Text = "Nimi";
            // 
            // tbLisaaToimintaalueNimi
            // 
            this.tbLisaaToimintaalueNimi.Location = new System.Drawing.Point(0, 22);
            this.tbLisaaToimintaalueNimi.Name = "tbLisaaToimintaalueNimi";
            this.tbLisaaToimintaalueNimi.Size = new System.Drawing.Size(111, 20);
            this.tbLisaaToimintaalueNimi.TabIndex = 3;
            // 
            // btnLisaatoimintaalue
            // 
            this.btnLisaatoimintaalue.Location = new System.Drawing.Point(0, 48);
            this.btnLisaatoimintaalue.Name = "btnLisaatoimintaalue";
            this.btnLisaatoimintaalue.Size = new System.Drawing.Size(111, 23);
            this.btnLisaatoimintaalue.TabIndex = 4;
            this.btnLisaatoimintaalue.Text = "Lisää toiminta-alue";
            this.btnLisaatoimintaalue.UseVisualStyleBackColor = true;
            this.btnLisaatoimintaalue.Click += new System.EventHandler(this.btnLisaatoimintaalue_Click);
            // 
            // Primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 445);
            this.Controls.Add(this.tabControl1);
            this.Name = "Primary";
            this.Text = "MOVA2020";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaalueet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.DataGridView dgvToimintaalueet;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.Button btnLisaatoimintaalue;
        private System.Windows.Forms.TextBox tbLisaaToimintaalueNimi;
        private System.Windows.Forms.Label lblLisaaToimintaalueNimi;
    }
}

