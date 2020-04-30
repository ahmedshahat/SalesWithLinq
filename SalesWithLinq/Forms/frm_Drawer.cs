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
                
                db.Drawers.InsertOnSubmit(drawer);

            }
            else
            {
                db.Drawers.Attach(drawer);

            }
               
      
                

            SetData();
            db.SubmitChanges(); 
            base.Save();
        }
    private void frm_Drawer_Load(object sender, EventArgs e)
        {
            

        }

    
    }
}
