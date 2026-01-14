using Syncfusion.Maui.DataGrid;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SfDataGridExample
{
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
}
