using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Management_System__BFM1_
{
    public static class SearchFor
    {
        /// <summary>
        /// Returns the index of found Product in a DataGridView such as partsgrid or productsgrid; returns -1 if no match is found.
        /// </summary>
        /// <param name="part"></param>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static int PartInDataGridView(Product part, DataGridView dataGridView)
        {
            var foundIndex = -1;
            var id = part.PartID;
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString() == id.ToString())
                    {
                        // row.Selected = true;
                        foundIndex = row.Index;
                    }
                }
            }
            catch (Exception excp)
            {
                System.Windows.Forms.MessageBox.Show(excp.Message);
                foundIndex = - 1;
            }
            return foundIndex;
        }
    }
}
