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
    public partial class frm_Drawer : frm_Master
    {
        DAL.Drawer drawer; 
        public frm_Drawer()
        {
            InitializeComponent();
            New();
           
        }

        public override void New()
        {
            drawer = new DAL.Drawer();
            base.New();
        }

        public override void GetData()
        {
            Txt_Name.Text = drawer.TreasyryName; 
            base.GetData();
        
        }

        public override void Save()
        {
            if(Txt_Name.Text.Trim() == string.Empty)
            {
                Txt_Name.ErrorText = "يجب ادخال اسم الخزنة ";
                return;
            }

            var db = new DAL.DBDataContext();

            DAL.Account account;
            if (drawer.TreasyryID == 0)
            {
                account = new DAL.Account();

                db.Drawers.InsertOnSubmit(drawer);
                db.Accounts.InsertOnSubmit(account);

            }
            else
            {
                db.Drawers.Attach(drawer);
                account = db.Accounts.Single(s => s.ID == drawer.AcoountID);

            }
            SetData();
            account.Name = drawer.TreasyryName;
            db.SubmitChanges();
            drawer.AcoountID = account.ID;
            db.SubmitChanges();


            base.Save();
        }

        public override void SetData()
        {
            drawer.TreasyryName = Txt_Name.Text;
            base.SetData();
        }
        private void frm_Drawer_Load(object sender, EventArgs e)
        {
            

        }

    
    }
}
