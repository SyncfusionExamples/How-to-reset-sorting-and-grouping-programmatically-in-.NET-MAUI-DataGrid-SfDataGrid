using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
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

}
