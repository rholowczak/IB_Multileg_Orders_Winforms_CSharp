# IB_Multileg_Orders_Winforms_CSharp
Interactive Brokers TWS API using ActiveX. Programming Multileg Orders in a Windows Form using C# (CSharp)
This is a very rough attempt to create multi-leg orders (Combo Orders) in Interactive Brokers using the TWS API.
To operate:
a) Run the application and click the Connect button to connect to TWS (localhost port 7468)
b) Type in a ticker symbol and then click Retrieve button to fetch all of the option series on that underlying. The grid shoudl fill up.
c) Click on two different contract ID's. They will fill up the last two text boxes with the contract ID's for the two legs of the order
d) Click the Place Order button to place the order

Still working out the C# interface to the COM object's IComboLeg interface. Something is not quite right there so the order will not get submitted in this version

