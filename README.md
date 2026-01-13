# How to add column dynamically when freeze pane is enabled in .NET MAUI DataGrid

This article shows how to add column dynamically when freeze pane is enabled in Syncfusion [.NET MAUI DataGrid](https://help.syncfusion.com/maui/datagrid/overview) (`SfDataGrid`). It demonstrates how a user can add column dynamically by setting the visibility to `true`. Similarly user can also remove the column dynamically by setting the visibility to `false`.

## Xaml
```
<ContentPage.BindingContext>
    <local:OrderInfoRepository x:Name="viewModel" />
</ContentPage.BindingContext>

<ContentPage.Content>
    <Grid RowDefinitions="Auto,*">
        <HorizontalStackLayout Grid.Row="0" Spacing="10" Margin="10">
            <Button Text="Visibility" Clicked="OnToggleColumnsClicked" />
        </HorizontalStackLayout>

        <syncfusion:SfDataGrid Grid.Row="1"
                               x:Name="dataGrid"
                               AutoGenerateColumnsMode="None"
                               FrozenColumnCount="4"
                               ItemsSource="{Binding OrderInfoCollection}">

            <syncfusion:SfDataGrid.Columns>
                <syncfusion:DataGridNumericColumn HeaderText="Order ID" Format="0" MappingName="OrderID"/>
                <syncfusion:DataGridTextColumn HeaderText="Customer ID" MappingName="CustomerID" />
                <syncfusion:DataGridTextColumn HeaderText="Ship Country" MappingName="ShipCountry" />
                <syncfusion:DataGridTextColumn HeaderText="Customer" MappingName="Customer" />
                <syncfusion:DataGridTextColumn HeaderText="Ship City" MappingName="ShipCity" />
                <syncfusion:DataGridTextColumn HeaderText="Product Name" MappingName="ProductName" />
                <syncfusion:DataGridNumericColumn  HeaderText="Quantity" MappingName="Quantity" />
                <syncfusion:DataGridNumericColumn HeaderText="Unit Price" MappingName="UnitPrice" Format="C2" />
                <syncfusion:DataGridNumericColumn HeaderText="Discount" MappingName="Discount" Format="P0"/>
                <syncfusion:DataGridDateColumn HeaderText="Order Date" MappingName="OrderDate"/>
                <syncfusion:DataGridTextColumn HeaderText="Category" MappingName="Category" />
                <syncfusion:DataGridTextColumn HeaderText="Supplier" MappingName="Supplier" />
                <syncfusion:DataGridCheckBoxColumn HeaderText="Delivered" MappingName="IsDelivered" />
                <syncfusion:DataGridDateColumn HeaderText="Delivery Date" MappingName="DeliveryDate" />
                <syncfusion:DataGridTextColumn HeaderText="Payment Method" MappingName="PaymentMethod" />
                <syncfusion:DataGridNumericColumn HeaderText="Shipping Cost" MappingName="ShippingCost" Format="C2" />
                <syncfusion:DataGridTextColumn HeaderText="Tracking #" MappingName="TrackingNumber" />
                <syncfusion:DataGridTextColumn HeaderText="Warehouse" MappingName="WarehouseLocation" />
                <syncfusion:DataGridTextColumn HeaderText="Sales Person" MappingName="SalesPerson" />
                <syncfusion:DataGridTextColumn HeaderText="Notes" MappingName="Notes" />
            </syncfusion:SfDataGrid.Columns>

        </syncfusion:SfDataGrid>
    </Grid>
</ContentPage.Content>
```

## Xaml.cs
```
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
```

## DataGridReflectionHelper.cs
```
public static class DataGridReflectionHelper
{
    public static void InvokeRefreshHorizontalScrollBar(SfDataGrid dataGrid, bool isResizingColumns = false)
    {
        if (dataGrid == null)
        {
            throw new ArgumentNullException(nameof(dataGrid), "dataGrid cannot be null.");
        }

        Type sourceType = dataGrid.GetType();

        MethodInfo? methodInfo = sourceType.GetMethod("RefreshHorizontalScrollBar",
            BindingFlags.NonPublic | BindingFlags.Instance);

        if (methodInfo == null)
        {
            throw new MissingMethodException("RefreshHorizontalScrollBar method not found.");
        }

        methodInfo.Invoke(dataGrid, new object[] { isResizingColumns });
    }
}
```

### ScreenShot

Here is the expected output when executing the sample:

<img alt="Add Column Dynamically when freeze pane is enabled" src="Images\SfDataGridExample.gif"/>

View sample in [GitHub](https://github.com/SyncfusionExamples/How-to-add-column-dynamically-when-freeze-pane-is-enabled-in-.NET-MAUI-DataGrid)

 Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

### Conclusion
I hope you enjoyed learning about How to implement select all checkbox column in SfDataGrid.

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums),[Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!