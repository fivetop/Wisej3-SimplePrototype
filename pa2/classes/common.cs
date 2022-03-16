using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace pa.classes
{
    #region // convertor, 유틸리티 오브젝트 카피 
    [ValueConversion(typeof(ItemsPresenter), typeof(Orientation))]
    public class ItemsPanelOrientationConverter : IValueConverter
    {
        // Returns 'Horizontal' for root TreeViewItems 
        // and 'Vertical' for all other items.
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            // The 'value' argument should reference 
            // an ItemsPresenter.
            ItemsPresenter itemsPresenter = value as ItemsPresenter;
            if (itemsPresenter == null)
                return Binding.DoNothing;

            // The ItemsPresenter's templated parent 
            // should be a TreeViewItem.
            TreeViewItem item = itemsPresenter.TemplatedParent as TreeViewItem;
            if (item == null)
                return Binding.DoNothing;

            // If the item is contained in a TreeView then it is
            // a root item.  Otherwise it is contained in another
            // TreeViewItem, in which case it is not a root.
            bool isRoot =
                ItemsControl.ItemsControlFromItemContainer(item) is TreeView;

            // The children of root items are layed out
            // in a horizontal row.  The grandchild items 
            // (i.e. cities) are layed out vertically.
            return isRoot ? Orientation.Horizontal : Orientation.Vertical;
            // isRoot ? Orientation.Vertical : Orientation.Horizontal;
            //isRoot? Orientation.Horizontal : Orientation.Vertical;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Cannot convert back.");
        }

    }

    // 오브젝트 딥 카피 처리용 
    public static class ObjectCopier
    {
        /// <span class="code-SummaryComment"><summary></span>
        /// Perform a deep Copy of the object.
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><typeparam name="T">The type of object being copied.</typeparam></span>
        /// <span class="code-SummaryComment"><param name="source">The object instance to copy.</param></span>
        /// <span class="code-SummaryComment"><returns>The copied object.</returns></span>
        public static T Clone<T>(T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            // Don't serialize a null object, simply return the default for that object
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }

    #endregion

}
