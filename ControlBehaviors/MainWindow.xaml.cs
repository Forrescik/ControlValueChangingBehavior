using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlBehaviors
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void EditValueChangingBehavior_OnStateChangingEvent(object sender, RoutedEventArgs routedEventArgs)
		{
			var dataContext = DataContext as MainVindowViewModel;
			if (dataContext != null)
			{
				routedEventArgs.Handled = !dataContext.AllowChanging;
			}
		}
	}
}
