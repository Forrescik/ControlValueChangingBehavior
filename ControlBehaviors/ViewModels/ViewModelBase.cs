using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControlBehaviors
{
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		private bool _allowChanging;

		public bool AllowChanging
		{
			get { return _allowChanging; }
			set
			{
				if (_allowChanging == value)
					return;
				_allowChanging = value;
				OnPropertyChanged("AllowChanging");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
