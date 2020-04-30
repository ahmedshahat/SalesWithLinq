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
    public partial class Frm_StoreList : DevExpress.XtraEditors.XtraForm
    {
        public Frm_StoreList()
        {
            InitializeComponent();
        }

        void RefreshData()
        {
            var db = new DAL.DBDataContext();
            gridControl1.DataSource = db.Stores;

        }

        private void Frm_StoreList_Load(object sender, EventArgs e)
        {
            RefreshData();
            gridView1.OptionsBehavior.Editable = false; // عدم السماح بالتعديل 
            gridView1.Columns["StoreID"].Visible = false; //اخفاء حقل id
            gridView1.Columns["StoreName"].Caption = "اسم المخزن";




        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;

            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("StoreID"));

            Frm_Stores frm = new Frm_Stores(id);

            frm.ShowDialog();

            RefreshData();


        }

        private void btn_Update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Stores frm = new Frm_Stores();

            frm.ShowDialog();

            RefreshData();

            //Close();

        }

        private void gridView1_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            if (e.RowHandle % 1 == 0)
            {

                e.RowHeight = 30;

            }

        }
    }
}