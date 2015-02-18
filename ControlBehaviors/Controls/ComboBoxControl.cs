using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ControlBehaviors
{
	public class ComboBoxControl : ComboBox, IEditValueChanging
	{
		public event RoutedEventHandler EditValueChanging
		{
			add { AddHandler(PreviewMouseLeftButtonDownEvent, value); }
			remove { RemoveHandler(PreviewMouseLeftButtonDownEvent, value); }
		}
	}
}
