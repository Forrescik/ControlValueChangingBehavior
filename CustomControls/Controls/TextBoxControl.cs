using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CustomControls
{
	public class TextBoxControl : TextBox, IEditValueChanging
	{
		public event RoutedEventHandler EditValueChanging
		{
			add { AddHandler(PreviewKeyDownEvent, value);}
			remove { RemoveHandler(PreviewKeyDownEvent, value); }
		}

		public TextBoxControl()
		{
		}
	}
}
