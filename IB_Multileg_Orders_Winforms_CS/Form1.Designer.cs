namespace IB_Multileg_Orders_Winforms_CS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbUnderlyingSymbol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRetrieveSeries = new System.Windows.Forms.Button();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgOptionsSeries = new System.Windows.Forms.DataGridView();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrikePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbContractIDLeg1 = new System.Windows.Forms.TextBox();
            this.tbContractIDLeg2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlaceOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbOrderStatus = new System.Windows.Forms.ListBox();
            this.lbErrors = new System.Windows.Forms.ListBox();
            this.axTws1 = new AxTWSLib.AxTws();
            ((System.ComponentModel.ISupportInitialize)(this.dgOptionsSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTws1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUnderlyingSymbol
            // 
            this.tbUnderlyingSymbol.Location = new System.Drawing.Point(120, 60);
            this.tbUnderlyingSymbol.Name = "tbUnderlyingSymbol";
            this.tbUnderlyingSymbol.Size = new System.Drawing.Size(100, 22);
            this.tbUnderlyingSymbol.TabIndex = 0;
            this.tbUnderlyingSymbol.Text = "MSFT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Underlying Symbol";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 12);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 25);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRetrieveSeries
            // 
            this.btnRetrieveSeries.Location = new System.Drawing.Point(120, 12);
            this.btnRetrieveSeries.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnRetrieveSeries.Name = "btnRetrieveSeries";
            this.btnRetrieveSeries.Size = new System.Drawing.Size(75, 25);
            this.btnRetrieveSeries.TabIndex = 2;
            this.btnRetrieveSeries.Text = "Retrieve";
            this.btnRetrieveSeries.UseVisualStyleBackColor = true;
            this.btnRetrieveSeries.Click += new System.EventHandler(this.btnRetrieveSeries_Click);
            // 
            // tbOrderId
            // 
            this.tbOrderId.Location = new System.Drawing.Point(15, 60);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(75, 22);
            this.tbOrderId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgOptionsSeries
            // 
            this.dgOptionsSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOptionsSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractID,
            this.Symbol,
            this.Expiration,
            this.StrikePrice,
            this.Rights});
            this.dgOptionsSeries.Location = new System.Drawing.Point(15, 107);
            this.dgOptionsSeries.Name = "dgOptionsSeries";
            this.dgOptionsSeries.RowTemplate.Height = 24;
            this.dgOptionsSeries.Size = new System.Drawing.Size(551, 150);
            this.dgOptionsSeries.TabIndex = 3;
            this.dgOptionsSeries.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOptionsSeries_CellContentDoubleClick);
            // 
            // ContractID
            // 
            this.ContractID.HeaderText = "ContractID";
            this.ContractID.Name = "ContractID";
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // Expiration
            // 
            this.Expiration.HeaderText = "Expiration";
            this.Expiration.Name = "Expiration";
            // 
            // StrikePrice
            // 
            this.StrikePrice.HeaderText = "Strike Price";
            this.StrikePrice.Name = "StrikePrice";
            // 
            // Rights
            // 
            this.Rights.HeaderText = "Rights";
            this.Rights.Name = "Rights";
            // 
            // tbContractIDLeg1
            // 
            this.tbContractIDLeg1.Location = new System.Drawing.Point(256, 60);
            this.tbContractIDLeg1.Name = "tbContractIDLeg1";
            this.tbContractIDLeg1.Size = new System.Drawing.Size(100, 22);
            this.tbContractIDLeg1.TabIndex = 0;
            // 
            // tbContractIDLeg2
            // 
            this.tbContractIDLeg2.Location = new System.Drawing.Point(362, 60);
            this.tbContractIDLeg2.Name = "tbContractIDLeg2";
            this.tbContractIDLeg2.Size = new System.Drawing.Size(100, 22);
            this.tbContractIDLeg2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ConID Leg 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ConID Leg 2";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbPlaceOrder
            // 
            this.tbPlaceOrder.Location = new System.Drawing.Point(256, 12);
            this.tbPlaceOrder.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbPlaceOrder.Name = "tbPlaceOrder";
            this.tbPlaceOrder.Size = new System.Drawing.Size(100, 25);
            this.tbPlaceOrder.TabIndex = 2;
            this.tbPlaceOrder.Text = "Place Order";
            this.tbPlaceOrder.UseVisualStyleBackColor = true;
            this.tbPlaceOrder.Click += new System.EventHandler(this.tbPlaceOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Order Status";
            // 
            // lbOrderStatus
            // 
            this.lbOrderStatus.FormattingEnabled = true;
            this.lbOrderStatus.ItemHeight = 16;
            this.lbOrderStatus.Location = new System.Drawing.Point(15, 287);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(551, 68);
            this.lbOrderStatus.TabIndex = 5;
            // 
            // lbErrors
            // 
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.HorizontalScrollbar = true;
            this.lbErrors.ItemHeight = 16;
            this.lbErrors.Location = new System.Drawing.Point(15, 361);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(551, 68);
            this.lbErrors.TabIndex = 5;
            // 
            // axTws1
            // 
            this.axTws1.Enabled = true;
            this.axTws1.Location = new System.Drawing.Point(451, 7);
            this.axTws1.Name = "axTws1";
            this.axTws1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTws1.OcxState")));
            this.axTws1.Size = new System.Drawing.Size(115, 30);
            this.axTws1.TabIndex = 4;
            this.axTws1.nextValidId += new AxTWSLib._DTwsEvents_nextValidIdEventHandler(this.axTws1_nextValidId);
            this.axTws1.errMsg += new AxTWSLib._DTwsEvents_errMsgEventHandler(this.axTws1_errMsg);
            this.axTws1.orderStatus += new AxTWSLib._DTwsEvents_orderStatusEventHandler(this.axTws1_orderStatus);
            this.axTws1.contractDetails += new AxTWSLib._DTwsEvents_contractDetailsEventHandler(this.axTws1_contractDetails);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 441);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.lbOrderStatus);
            this.Controls.Add(this.axTws1);
            this.Controls.Add(this.dgOptionsSeries);
            this.Controls.Add(this.tbPlaceOrder);
            this.Controls.Add(this.btnRetrieveSeries);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrderId);
            this.Controls.Add(this.tbContractIDLeg2);
            this.Controls.Add(this.tbContractIDLeg1);
            this.Controls.Add(this.tbUnderlyingSymbol);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgOptionsSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTws1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUnderlyingSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRetrieveSeries;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgOptionsSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiration;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrikePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rights;
        private AxTWSLib.AxTws axTws1;
        private System.Windows.Forms.TextBox tbContractIDLeg1;
        private System.Windows.Forms.TextBox tbContractIDLeg2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tbPlaceOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbOrderStatus;
        private System.Windows.Forms.ListBox lbErrors;
    }
}

