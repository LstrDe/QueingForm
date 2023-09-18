using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
namespace QueingForm
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            //Timer timer = new Timer();
          //  timer.Interval = (1 * 1000);
          //  timer.Tick += new EventHandler(timer1_tick);
          //  timer.Start();
        }

        Boolean openform = false;
        CustomerView vustomerview = new CustomerView();
        FormCollection Allform = Application.OpenForms;
        Form OpendForm = new Form();   
        private void bntRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        public delegate void Passcontrol(object sender);
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
        }

        private void bntNext_Click(object sender, EventArgs e)
        {

        }
    }
}
