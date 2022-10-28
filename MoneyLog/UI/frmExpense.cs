using MoneyLog.BLL;
using MoneyLog.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyLog.UI
{
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Add code to hide this form
            this.Hide();
        }

        categoriesDAL cdal = new categoriesDAL();
        expenseBLL p = new expenseBLL();
        expenseDAL pdal = new expenseDAL();
        
        private void frmExpense_Load(object sender, EventArgs e)
        {
            //Creating Data Table to hold the categories from Database
            DataTable categoriesDT = cdal.Select();
            //Specify DataSource for Category ComboBox
            cmbCategory.DataSource = categoriesDT;
            //Specify Display Member and Value Member for Combobox
            cmbCategory.DisplayMember = "category";
            cmbCategory.ValueMember = "category";

            //Load all the records in Data Grid View
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get All the Values from expense Form
            p.type = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.amount = Decimal.Parse(txtAmount.Text);          
            p.added_date = DateTime.Now;


            //Create Boolean variable to check if the product is added successfully or not
            bool success = pdal.Insert(p);
            //if the product is added successfully then the value of success will be true else it will be false
            if(success==true)
            {
                //Product Inserted Successfully
                MessageBox.Show("Record Added Successfully");
                //Calling the Clear Method
                Clear();
                //Refreshing Data Grid View
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Failed to Add New product
                MessageBox.Show("Failed to Add New Record");
            }
        }
        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtAmount.Text = "";
            txtSearch.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Create integer variable to know which product was clicked
            int rowIndex = e.RowIndex;
            //Display the Value on Respective TextBoxes
            txtID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtAmount.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the Values from UI or Expense Form
            p.id = int.Parse(txtID.Text);
            p.type = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.amount = Decimal.Parse(txtAmount.Text);
            p.added_date = DateTime.Now;


            //Create a boolean variable to check if the product is updated or not
            bool success = pdal.Update(p);
            //If the prouct is updated successfully then the value of success will be true else it will be false
            if(success==true)
            {
                //Product updated Successfully
                MessageBox.Show("Record Successfully Updated");
                Clear();
                //REfresh the Data Grid View
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Failed to Update Product
                MessageBox.Show("Failed to Update Record");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //GEt the ID of the product to be deleted
            p.id = int.Parse(txtID.Text);

            //Create Bool VAriable to Check if the product is deleted or not
            bool success = pdal.Delete(p);

            //If prouct is deleted successfully then the value of success will true else it will be false
            if(success==true)
            {
                //Product Successfuly Deleted
                MessageBox.Show("Record successfully deleted.");
                Clear();
                //Refresh Data Grid View
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Failed to Delete Product
                MessageBox.Show("Failed to Delete Record.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Keywordss from Form
            string keywords = txtSearch.Text;

            if(keywords!=null)
            {
                //Search the products
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Display All the products
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }
    }
}
