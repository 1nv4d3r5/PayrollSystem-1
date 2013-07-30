using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace PayrollSystem
{
    class Additionals
    {
        public void BindGrid(DataGridView dg, List<UnRegisteredUser> unregisteredUser)
        {
            dg.AutoGenerateColumns = false;
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewTextBoxColumn colUserID = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "UserID",
                HeaderText = "UserID",
                DataPropertyName = "UserID",
                Width = 100
            };
            dg.Columns.Add(colUserID);
            var filenamesList = new BindingList<UnRegisteredUser>(unregisteredUser.ToList());
            dg.DataSource = filenamesList;

        }
    }
}
