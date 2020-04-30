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
    public partial class Frm_CompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        public Frm_CompanyInfo()
        {
            InitializeComponent();
            this.Load += Frm_CompanyInfo_Load;
        }

        //---------- Class OOP 

        private void Save()
        {
            if (Txt_Name.Text == "")
            {
                Txt_Name.ErrorText = "يجب ادخال اسم الشركة اولا ";
                return;
            }

            DAL.DBDataContext db = new DAL.DBDataContext();
            DAL.CompanyInfo info = db.CompanyInfos.FirstOrDefault();

            if(info == null)
            {
                info = new DAL.CompanyInfo();
                db.CompanyInfos.InsertOnSubmit(info);
            }
            //-------------- البيانات هاتجيبها منين 
            info.CompanyName = Txt_Name.Text;
            info.CompanyMobile = Txt_Mobile.Text;
            info.CompanyPhone = Txt_Phone.Text;
            info.CompanyAddress = Txt_Address.Text;
            
            db.SubmitChanges();
            XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تم حفظ البيانات  بنجاح", "رسالة تأكيد ", MessageBoxButtons.OK, MessageBoxIcon.Information);
         


        }

        private void GetData()
        {
            DAL.DBDataContext db = new DAL.DBDataContext();
            DAL.CompanyInfo info = db.CompanyInfos.FirstOrDefault();
            if (info == null)
                return;
            Txt_Name.Text = info.CompanyName;
            Txt_Mobile.Text = info.CompanyMobile;
            Txt_Phone.Text = info.CompanyPhone;
            Txt_Address.Text = info.CompanyAddress;

        }

        //---------- End Class OOP


        private void Frm_CompanyInfo_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void Btn_Save1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }
    }
}