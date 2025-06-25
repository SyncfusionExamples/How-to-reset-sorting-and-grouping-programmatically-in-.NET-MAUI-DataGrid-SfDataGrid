# How to reset sorting and grouping in .NET MAUI DataGrid SfDataGrid?
This article shows how to reset sorting and grouping in Syncfusion [.NET MAUI DataGrid](https://help.syncfusion.com/maui/datagrid/overview) (`SfDataGrid`). It demonstrates how a user can cancel sorting and return to its original state programmatically. Similarly, grouping can also be reset programmatically.

## Xaml
```
<ContentPage.BindingContext>
    <local:ViewModel  />
</ContentPage.BindingContext>
<Grid ColumnDefinitions="*,200" ColumnSpacing="5" Padding="10">
    <VerticalStackLayout HorizontalOptions="Center" Grid.Column="1" VerticalOptions="Center" Spacing="10">
        <Button Text="Allow Sorting"
                Clicked="Button_Clicked"
                WidthRequest="150"/>
        <Button Text="Clear Sorting"
                Clicked="Button_Clicked_1"
                WidthRequest="150"/>
        <Button Text="Allow Grouping"
                Clicked="Button_Clicked_2"
                WidthRequest="150"/>
        <Button Text="Clear Grouping"
                Clicked="Button_Clicked_3"
                WidthRequest="150"/>
    </VerticalStackLayout>
    <syncfusion:SfDataGrid x:Name="datagrid"
                           Grid.Column="0"
                           ColumnWidthMode="Fill"
                           ItemsSource="{Binding OrderList}">
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridNumericColumn MappingName="OrderID" HeaderText="Order ID"/>
            <syncfusion:DataGridTextColumn MappingName="CustomerID" HeaderText="Customer ID"/>
            <syncfusion:DataGridDateColumn MappingName="ShippingDate" HeaderText="Order Date"/>
            <syncfusion:DataGridNumericColumn MappingName="SupplierID" HeaderText="Supplier ID"/>
            <syncfusion:DataGridTextColumn MappingName="ShipCity" HeaderText="Shipping City"/>
            <syncfusion:DataGridTextColumn MappingName="ShipCountry" HeaderText="Shipping Country"/>
            <syncfusion:DataGridNumericColumn MappingName="Freight" HeaderText="Freight"/>
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
</Grid>
</ContentPage.Content>
```

## Xaml.cs
```
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        datagrid.SortingMode = Syncfusion.Maui.DataGrid.DataGridSortingMode.Multiple;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        datagrid.SortColumnDescriptions.Clear();
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        datagrid.GroupingMode = Syncfusion.Maui.DataGrid.GroupingMode.Multiple;
        datagrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
        {
            ColumnName = "ShipCountry",
        });
        datagrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
        {
            ColumnName = "ShipCity",
        });
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        datagrid.GroupColumnDescriptions.Clear();
    }
}
```

### ScreenShot

Here is the expected output when executing the sample:

#### Sorting

<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjQyMzAwIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.PHG6_nN9qmCkMpo3S_Fwk9Vh3nYUJR4xVxUmCGz2His" height = 396/>

#### Grouping

<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjQyMjk5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.Ry0vtZWWfNxlyvUn4-mDkjTnRYOOSuA_gm5bz-QcTvs" height = 396/>

View sample in [GitHub](https://github.com/SyncfusionExamples/How-to-reset-sorting-and-grouping-programmatically-in-.NET-MAUI-DataGrid-SfDataGrid)

 Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

### Conclusion
I hope you enjoyed learning about How to implement select all checkbox column in SfDataGrid.

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums),[Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!