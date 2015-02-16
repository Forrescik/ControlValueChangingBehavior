using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBehaviorsViewModel
{
	public class MainVindowViewModel : ViewModelBase
	{	
		private bool _myCheckBoxControl;

		public bool MyCheckBoxControl
		{
			get { return _myCheckBoxControl; }
			set
			{
				if (_myCheckBoxControl == value)
					return;
				_myCheckBoxControl = value;
				OnPropertyChanged("MyCheckBoxControl");
			}
		}

		private string _myTextBoxControl;

		public string MyTextBoxControl
		{
			get { return _myTextBoxControl; }
			set
			{
				if (_myTextBoxControl == value)
					return;
				_myTextBoxControl = value;
				OnPropertyChanged("MyTextBoxControl");
			}
		}

		private string _systemTextBox;

		public string SystemTextBox
		{
			get { return _systemTextBox; }
			set
			{
				if (_systemTextBox == value)
					return;
				_systemTextBox = value;
				OnPropertyChanged("SystemTextBox");
			}
		}

		private RelayCommand _editControlCommand;

		public RelayCommand EditControlCommand
		{
			get
			{
				if (_editControlCommand == null)
				{
					_editControlCommand = new RelayCommand(e =>
					{
						                                       
					}, o => AllowChanging);
				}
				return _editControlCommand;
			}
		}		

		private List<string> _comboBoxList;

		public List<string> ComboBoxList
		{
			get { return _comboBoxList; }
			set
			{
				if (_comboBoxList == value)
					return;
				_comboBoxList = value;
				OnPropertyChanged("ComboBoxList");
			}
		}

		public MainVindowViewModel()
		{
			ComboBoxList = new List<string> {"1", "2", "3", "4", "5"};
		}
	}
}
