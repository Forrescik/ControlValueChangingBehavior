using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace CustomControls
{
	public delegate void StateChangingDelegate(object sender, RoutedEventArgs routedEventArgs);
	public class EditValueChangingBehavior : Behavior<UIElement>
	{
		public event StateChangingDelegate StateChangingEvent;
		protected override void OnAttached()
		{
			var obj = AssociatedObject as IEditValueChanging;
			if (obj != null)
			{
				obj.EditValueChanging += OnStateChangingEvent;
			}
		}		

		protected override void OnDetaching()
		{
			var obj = AssociatedObject as IEditValueChanging;
			if (obj != null)
			{
				obj.EditValueChanging -= OnStateChangingEvent;
			}
		}

		protected virtual void OnStateChangingEvent(object sender, RoutedEventArgs routedEventArgs)
		{
			var handler = StateChangingEvent;
			if (handler != null)
			{
				handler(sender, routedEventArgs);
			}
		}
	}
}
