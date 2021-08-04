
namespace TeknikServis.Formlar
{
    partial class FormFaturaKalemleriListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturaKalemleriListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtFaturaId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtSiraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSeri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 125);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1846, 956);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Honeydew;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtFaturaId);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.txtSiraNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSeri);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1846, 130);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Fatura Kalem  Arama";
            // 
            // txtFaturaId
            // 
            this.txtFaturaId.Location = new System.Drawing.Point(171, 67);
            this.txtFaturaId.Name = "txtFaturaId";
            this.txtFaturaId.Size = new System.Drawing.Size(338, 40);
            this.txtFaturaId.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(144, 33);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = " Fatura Id:";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(1576, 63);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(209, 46);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(1123, 67);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(338, 40);
            this.txtSiraNo.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1000, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 33);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Sıra No :";
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(620, 67);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(338, 40);
            this.txtSeri.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(543, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 33);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Seri :";
            // 
            // FormFaturaKalemleriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 1079);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormFaturaKalemleriListesi";
            this.Text = "FormFaturaKalemleriListesi";
            this.Load += new System.EventHandler(this.FormFaturaKalemleriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtFaturaId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtSiraNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSeri;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}