using System;
using Template.Infrastructure;
using System.Windows.Input;
using System.Diagnostics;

namespace Template.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        #region FIELDS

        ICommand m_LoadCommand;
        String m_Text;

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Command binding property
        /// </summary>
        public ICommand LoadCommand
        {
            get { return m_LoadCommand ?? (m_LoadCommand = new RelayCommand(this.ExecuteLoadCommand)); }
        }



        /// <summary>
        /// String property
        /// </summary>
        public String Text
        {
            get { return m_Text ?? (m_Text = "Hello World"); }
            set
            {
                m_Text = value;
                RaisePropertyChanged("Text");
            }
        }

        #endregion

        #region CONSTRUCTORS

        public MainWindowViewModel()
        {

        }

        #endregion 

        #region EXECUTE_COMMAND_METHODS
        private void ExecuteLoadCommand()
        {
            Debug.WriteLine("button pressed");
        }

        #endregion
    }
}
