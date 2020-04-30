namespace SalesWithLinq.Forms
{
    partial class frm_Drawer
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Txt_Namee = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Namee)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Txt_Name);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 27);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(509, 182);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(27, 28);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Properties.Appearance.Font = new System.Drawing.Font("Neo Sans Arabic", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.Properties.Appearance.Options.UseFont = true;
            this.Txt_Name.Size = new System.Drawing.Size(399, 22);
            this.Txt_Name.StyleController = this.layoutControl1;
            this.Txt_Name.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Txt_Namee});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(509, 182);
            this.Root.TextVisible = false;
            // 
            // Txt_Namee
            // 
            this.Txt_Namee.AppearanceItemCaption.Font = new System.Drawing.Font("Neo Sans Arabic", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Namee.AppearanceItemCaption.Options.UseFont = true;
            this.Txt_Namee.Control = this.Txt_Name;
            this.Txt_Namee.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.Txt_Namee.Location = new System.Drawing.Point(0, 0);
            this.Txt_Namee.Name = "Txt_Namee";
            this.Txt_Namee.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 18, 18);
            this.Txt_Namee.Size = new System.Drawing.Size(489, 162);
            this.Txt_Namee.Text = "اسم الخزنة";
            this.Txt_Namee.TextSize = new System.Drawing.Size(53, 16);
            // 
            // frm_Drawer
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 209);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Neo Sans Arabic", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Drawer";
            this.Text = "اضافة خزنة";
            this.Load += new System.EventHandler(this.frm_Drawer_Load);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Namee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit Txt_Name;
        private DevExpress.XtraLayout.LayoutControlItem Txt_Namee;
    }
}