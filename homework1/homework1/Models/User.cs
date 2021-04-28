using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace homework1.Models
{
    class User : IDataErrorInfo, INotifyPropertyChanged
    {
        private string name = string.Empty;
        private string password = string.Empty;
        private string inputError;
        private string nameError;
        private string pwError;
        private bool isEnabled;

        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    OnPropertyChanged("IsEnabled");
                }
            }
        }

        public string InputError
        {
            get
            {
                return inputError;
            }
            set
            {
                if (inputError != value)
                {
                    inputError = value;
                    OnPropertyChanged("InputError");
                }
            }
        }

        public string NameError
        {
            get
            {
                return nameError;
            }
            set
            {
                if (nameError != value)
                {
                    nameError = value;
                    OnPropertyChanged("NameError");
                }
            }
        }

        public string PwError
        {
            get
            {
                return pwError;
            }
            set
            {
                if (pwError != value)
                {
                    pwError = value;
                    OnPropertyChanged("PwError");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        // IDataErrorInfo interface
        public string Error
        {
            get
            {
                return InputError;
            }
        }

        // IDataErrorInfo interface
        // Called when ValidatesOnDataErrors=True
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Name":
                        {
                            if (string.IsNullOrEmpty(Name))
                            {
                                NameError = "Name cannot be empty. ";
                            }
                            else if (Name.Length > 12)
                            {
                                NameError = "Name cannot be longer than 12 characters. ";
                            }
                            else
                            {
                                NameError = "";
                            }
                            InputError = NameError + PwError;
                            IsEnabled = string.IsNullOrEmpty(InputError);
                            return NameError;
                        }
                    case "Password":
                        {
                            if (string.IsNullOrEmpty(Password))
                            {
                                PwError = "Password cannot be empty.";
                            }
                            else
                            {
                                PwError = "";
                            }
                            InputError = NameError + PwError;
                            IsEnabled = string.IsNullOrEmpty(InputError);
                            return PwError;
                        }
                }

                return InputError;
            }
        }

        // INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
