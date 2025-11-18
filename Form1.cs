namespace OrderPipeline
{
    public partial class Form1 : Form
    {
        // Custom event declarations for Task 1
        public event EventHandler<ShipEventArgs>? OrderCreated;
        public event EventHandler<ShipEventArgs>? OrderRejected;
        public event EventHandler<ShipEventArgs>? OrderConfirmed;
        
        // Custom event declaration for Task 2
        public event EventHandler<ShipEventArgs>? OrderShipped;

        private string customerName = "";
        private int quantity = 0;
        private bool isOrderConfirmed = false; // Boolean flag to track order status

        public Form1()
        {
            InitializeComponent();
            
            // Subscribe to events - Task 1
            OrderCreated += ValidateOrder;
            OrderCreated += DisplayOrderInfo;
            OrderRejected += ShowRejection;
            OrderConfirmed += ShowConfirmation;
            
            // Subscribe to events - Task 2
            OrderShipped += ShowDispatch;

            // Set default ComboBox selection
            cmbProduct.SelectedIndex = 0;
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            customerName = txtCustomerName.Text;
            quantity = (int)numQuantity.Value;
            string product = cmbProduct.SelectedItem?.ToString() ?? "";
            bool express = chkExpress.Checked;

            // Raise OrderCreated event
            OnOrderCreated(new ShipEventArgs(product, express));
        }

        private void btnShipOrder_Click(object sender, EventArgs e)
        {
            // Check if previous order was confirmed
            if (!isOrderConfirmed)
            {
                MessageBox.Show(
                    "Please process and confirm an order first before shipping!",
                    "Order Not Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string product = cmbProduct.SelectedItem?.ToString() ?? "";
            bool express = chkExpress.Checked;

            // Raise OrderShipped event
            OnOrderShipped(new ShipEventArgs(product, express));
        }

        private void chkExpress_CheckedChanged(object sender, EventArgs e)
        {
            // Dynamic subscriber management based on checkbox state
            if (chkExpress.Checked)
            {
                // Add NotifyCourier subscriber when express is checked
                OrderShipped += NotifyCourier;
            }
            else
            {
                // Remove NotifyCourier subscriber when express is unchecked
                OrderShipped -= NotifyCourier;
            }
        }

        // Event raising methods
        protected virtual void OnOrderCreated(ShipEventArgs e)
        {
            OrderCreated?.Invoke(this, e);
        }

        protected virtual void OnOrderRejected(ShipEventArgs e)
        {
            OrderRejected?.Invoke(this, e);
        }

        protected virtual void OnOrderConfirmed(ShipEventArgs e)
        {
            OrderConfirmed?.Invoke(this, e);
        }

        protected virtual void OnOrderShipped(ShipEventArgs e)
        {
            OrderShipped?.Invoke(this, e);
        }

        // Event subscribers - Task 1
        private void ValidateOrder(object? sender, ShipEventArgs e)
        {
            lblStatus.Text = "Validated";

            if (quantity > 0)
            {
                // Valid order - chain to OrderConfirmed event
                OnOrderConfirmed(e);
            }
            else
            {
                // Invalid order - chain to OrderRejected event
                OnOrderRejected(e);
            }
        }

        private void DisplayOrderInfo(object? sender, ShipEventArgs e)
        {
            string expressInfo = e.Express ? "Express" : "Standard";
            MessageBox.Show(
                $"Order Summary:\n\n" +
                $"Customer: {customerName}\n" +
                $"Product: {e.Product}\n" +
                $"Quantity: {quantity}\n" +
                $"Shipping: {expressInfo}",
                "Order Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ShowRejection(object? sender, ShipEventArgs e)
        {
            lblStatus.Text = "Order Invalid - Please retry";
            isOrderConfirmed = false;
        }

        private void ShowConfirmation(object? sender, ShipEventArgs e)
        {
            lblStatus.Text = $"Order Processed Successfully for {customerName}";
            isOrderConfirmed = true; // Set flag to true when order is confirmed
        }

        // Event subscribers - Task 2
        private void ShowDispatch(object? sender, ShipEventArgs e)
        {
            lblStatus.Text = $"Product dispatched: {e.Product}";
        }

        private void NotifyCourier(object? sender, ShipEventArgs e)
        {
            // This method is only called when Express checkbox is checked
            if (e.Express)
            {
                MessageBox.Show(
                    "Express delivery initiated!",
                    "Courier Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
