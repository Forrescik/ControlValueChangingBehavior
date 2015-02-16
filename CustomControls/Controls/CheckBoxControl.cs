using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CustomControls
{
	public class CheckBoxControl : CheckBox, IEditValueChanging
	{
		public event RoutedEventHandler EditValueChanging
		{
			add { AddHandler(PreviewMouseLeftButtonDownEvent, value); }
			remove { RemoveHandler(PreviewMouseLeftButtonDownEvent, value); }
		}
	}
}
