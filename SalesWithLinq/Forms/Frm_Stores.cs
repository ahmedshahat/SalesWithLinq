using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWithLinq.Forms
{
    public partial class Frm_Stores : XtraForm

    {
        DAL.Store store;

        public Frm_Stores()
        {
            InitializeComponent();
            New();
        }

        public Frm_Stores(int id)
        {
            InitializeComponent();
            var db = new DAL.DBDataContext();

            store = db.Stores.Where(s => s.StoreID == id).First();
            GetData();


        }

        private void save()
        {
            if (txt_Store.Text.Trim() == string.Empty)
            {
                txt_Store.ErrorText = "يجب ادخال اسم المخزن اولا ";

                return;
            }

            var db = new DAL.DBDataContext();
            // لو المخزن مش موجود 
            if(store.StoreID == 0)           
                db.Stores.InsertOnSubmit(store);
            //لو المخزن موجود اعمل تعديل 
            else
                db.Stores.Attach(store);
        


            SetData();
            db.SubmitChanges();
            XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تم حفظ البيانات  بنجاح", "رسالة تأكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SetData()
        {
            store.StoreName = txt_Store.Text;

        }

        private void GetData()
        {
            txt_Store.Text = store.StoreName;
        }

        void New()
        {
            store = new DAL.Store();
            GetData();


        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save();

        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // حذف المخزن 
            var db = new DAL.DBDataContext();
            if(MessageBox.Show( "هل تريد حذف مخزن " ,"تأكيد" , MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Stores.Attach(store);
                db.Stores.DeleteOnSubmit(store);
                db.SubmitChanges();
                //XtraMessageBox.Show("تم الحذف بنجاح ");
                MessageBox.Show("تم الحذف ينجاح ", "حذف");
                New();
            }
     

        }
    }
}
