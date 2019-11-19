using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class UpdateClassForm : Form
    {
        private ClassManagement Business;
        private int ClassId;
        public UpdateClassForm(int id)
        {
            InitializeComponent();
            this.Business = new ClassManagement();
            this.ClassId = id;
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
            this.Load += UpdateClassForm_Load;
        }

        void UpdateClassForm_Load(object sender, EventArgs e)
        {
            var @class = this.Business.GetClass(this.ClassId);
            this.txtName.Text = @class.Name;
            this.txtxDescription.Text = @class.Description;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var description = this.txtxDescription.Text;
            this.Business.EditClass(this.ClassId, name, description);
            MessageBox.Show("Update class successfuly");
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
