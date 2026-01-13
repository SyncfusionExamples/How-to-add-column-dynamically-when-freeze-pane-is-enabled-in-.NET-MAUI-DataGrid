using Syncfusion.Maui.DataGrid;

namespace SfDataGridExample
{
    public partial class MainPage : ContentPage
    {
        private bool _dynamicColumnsVisible = true;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnToggleColumnsClicked(object sender, EventArgs e)
        {
            _dynamicColumnsVisible = !_dynamicColumnsVisible;

            foreach (var col in dataGrid.Columns)
            {

                if (col.MappingName == "Quantity" || col.MappingName == "UnitPrice" || col.MappingName == "Discount" ||
                    col.MappingName == "OrderDate" || col.MappingName == "Category" || col.MappingName == "Supplier" ||
                    col.MappingName == "IsDelivered" || col.MappingName == "DeliveryDate" || col.MappingName == "PaymentMethod" ||
                    col.MappingName == "ShippingCost" || col.MappingName == "TrackingNumber" || col.MappingName == "WarehouseLocation" ||
                    col.MappingName == "SalesPerson" || col.MappingName == "Notes")
                {
                    col.Visible = _dynamicColumnsVisible;
                }
            }

            DataGridReflectionHelper.InvokeRefreshHorizontalScrollBar(dataGrid, isResizingColumns: true);
        }
    }
}
