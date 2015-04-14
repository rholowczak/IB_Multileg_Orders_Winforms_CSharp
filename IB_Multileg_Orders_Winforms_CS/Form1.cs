using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB_Multileg_Orders_Winforms_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Connect to TWS
            axTws1.connect("", 7496, 0);
        }

        private void axTws1_nextValidId(object sender, AxTWSLib._DTwsEvents_nextValidIdEvent e)
        {
            // Set to the next available order id
            tbOrderId.Text = e.id.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Request a new ID
            axTws1.reqIds(1);
        }

        private void btnRetrieveSeries_Click(object sender, EventArgs e)
        {
            // Retrieve all of the contracts that match this underlying
            // Clear out the Data grid
            dgOptionsSeries.Rows.Clear();
            dgOptionsSeries.Refresh();
            // Create the contract object
            TWSLib.IContract optionSeries = axTws1.createContract();
            // Check the underlying symbol only
            optionSeries.symbol = tbUnderlyingSymbol.Text;
            optionSeries.secType = "OPT";
            // Request all of the series on this underlying
            axTws1.reqContractDetailsEx(1, optionSeries);
            lbErrors.Items.Add("Request Made");
        }

        private void axTws1_contractDetails(object sender, AxTWSLib._DTwsEvents_contractDetailsEvent e)
        {
            // Report all of the contract details in response to 
            // reqContractDetailsEX
            // This method will be called one time per contract
            // e.conId - ContractID
            // GridViewRowInfo rowInfo = dgOptionsSeries.Rows.AddNew();
            dgOptionsSeries.Rows.Add(e.conId, e.symbol, e.expiry, e.strike, e.right);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgOptionsSeries_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Double click on a cell. ContractID is in column 0
            if (e.ColumnIndex == 0)
            {
                // See which Leg is empty
                if (tbContractIDLeg1.Text == String.Empty)
                {
                    tbContractIDLeg1.Text = dgOptionsSeries.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else
                {
                    tbContractIDLeg2.Text = dgOptionsSeries.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            } // End if Click in the ContractID Column
        }

        private void tbPlaceOrder_Click(object sender, EventArgs e)
        {
            // Place a combo order
            // At this point the two contract identifiers will be in text boxes
            // tbContractIDLeg1.Text and tbContractIDLeg2.Text
            // Create a list of Combo Legs
            TWSLib.IComboLegList cllComboOrderLegs = axTws1.createComboLegList();

            // Create Leg 1 of the order
            MyComboLeg clLeg1 = new MyComboLeg();
            
            // Create Leg 2 of the order
            MyComboLeg clLeg2 = new MyComboLeg();

            // Create the master order
            TWSLib.IOrder ordMasterOrder = axTws1.createOrder();

            // Create the master contract that will hold the legs
            TWSLib.IContract cMasterContract = axTws1.createContract();

            // Fill in the Combo Leg information for Leg 1
            clLeg1 = (MyComboLeg)cllComboOrderLegs.Add();
            clLeg1.conId = Convert.ToInt32(tbContractIDLeg1.Text);
            clLeg1.ratio = 1;
            clLeg1.action = "BUY";
            clLeg1.exchange = "SMART";
            // Add to the list of combo legs
            // This does not work either:
            // cllComboOrderLegs.Add(clLeg1);
            
            // Fill in the Combo Leg information for Leg 2
            clLeg2 = (MyComboLeg)cllComboOrderLegs.Add();
            clLeg2.conId = Convert.ToInt32(tbContractIDLeg2.Text);
            clLeg2.ratio = 1;
            clLeg2.action = "BUY";
            clLeg2.exchange = "SMART";
            // Add to the list of combo legs
            // This does not work:
            // cllComboOrderLegs.Add(clLeg2);
            

            // Fill in the master contract
            cMasterContract.symbol = tbUnderlyingSymbol.Text;
            cMasterContract.secType = "BAG";
            cMasterContract.exchange = "SMART";
            cMasterContract.currency = "USD";
            cMasterContract.comboLegs = cllComboOrderLegs;

            // Fill in the Master Order
            ordMasterOrder.action = "BUY";
            ordMasterOrder.totalQuantity = 1;
            ordMasterOrder.orderType = "MKT";

            // Place the order
            axTws1.placeOrderEx(Convert.ToInt32(tbOrderId.Text), cMasterContract, ordMasterOrder);

        }

        private void axTws1_orderStatus(object sender, AxTWSLib._DTwsEvents_orderStatusEvent e)
        {
            // Update the order status fields
            // e.id
            // e.parentId
            string strOrderStatus;
            strOrderStatus = e.id + " " + e.parentId + " " + e.status +
                " " + e.filled + " " + e.lastFillPrice;
            // Add to list box
            lbOrderStatus.Items.Add(strOrderStatus);
        }

        private void axTws1_errMsg(object sender, AxTWSLib._DTwsEvents_errMsgEvent e)
        {
            lbErrors.Items.Add(e.errorCode + " " + e.errorMsg);
        }
    } // end Form class

    // My attempt to build a wrapper class around the IComboLeg Interface
    public class MyComboLeg : TWSLib.IComboLeg
    {
        public string action { get; set; }
        public int conId { get; set; }
        public string designatedLocation { get; set; }
        public string exchange { get; set; }
        public int exemptCode { get; set; }
        public int openClose { get; set; }
        public int ratio { get; set; }
        public int shortSaleSlot { get; set; }
    } // end     public class MyComboLeg 
} // end namespace
