using System.Windows;
using System.Windows.Controls;

namespace Semantix.Sdl.MultiSelectComboBox.Controls
{
	public sealed class ContentItemsControl : ItemsControl
	{
		protected override DependencyObject GetContainerForItemOverride()
		{
			return new ContentControl();
		}
	}
}
