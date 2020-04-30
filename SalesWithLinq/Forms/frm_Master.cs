using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SalesWithLinq.Forms
{
    public partial class frm_Master : DevExpress.XtraEditors.XtraForm
    {
        public frm_Master()
        {
            InitializeComponent();
        }

        public virtual void Save()
        {
            MessageBox.Show("تم حفظ البيانات بنجاح   ");

        }
        public virtual void New()
        {
            GetData();

        }
        public virtual void Delete()
        {

        }


        public virtual void GetData()
        {
            MessageBox.Show("تم جلب البيانات بنجاح  ");

        }

        public virtual void SetData()
        {

        }

        private void frm_Master_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();

        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }

        private void frm_Master_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Save();
            }
            if(e.KeyCode == Keys.F2)
            {
                New();
            }
            if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }

        }
    }
}