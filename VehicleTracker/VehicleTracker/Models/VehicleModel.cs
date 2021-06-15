using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VehicleTracker.Models
{
    public class VehicleModel : IDataErrorInfo, INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; } = 1990;
        public int Mileage { get; set; } = 0;
        public string Color { get; set; }

        private string error { get; set; }
        private string makeError { get; set; }
        private string modelError { get; set; }
        private string colorError { get; set; }

        private bool isEnabled = false;

        public string MakeError
        {
            get
            {
                return makeError;
            }
            set
            {
                if (makeError != value)
                {
                    makeError = value;
                    OnPropertyChanged("MakeError");
                }
            }
        }

        public string ModelError
        {
            get
            {
                return modelError;
            }
            set
            {
                if (modelError != value)
                {
                    modelError = value;
                    OnPropertyChanged("ModelError");
                }
            }
        }

        public string ColorError
        {
            get
            {
                return colorError;
            }
            set
            {
                if (colorError != value)
                {
                    colorError = value;
                    OnPropertyChanged("ColorError");
                }
            }
        }

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

        // INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // IDataErrorInfo interface
        public string Error
        {
            get
            {
                return error;
            }
            set
            {
                if (error != value)
                {
                    error = value;
                    OnPropertyChanged("Error");
                }
            }
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Make":
                        {
                            MakeError = "";

                            if (string.IsNullOrEmpty(Make))
                            {
                                MakeError = "Make cannot be empty.";
                            }

                            Error = MakeError + ModelError + ColorError;
                            IsEnabled = string.IsNullOrEmpty(Error);
                            return MakeError;
                        }
                    case "Model":
                        {
                            ModelError = "";

                            if (string.IsNullOrEmpty(Model))
                            {
                                ModelError = "Model cannot be empty.";
                            }

                            Error = MakeError + ModelError + ColorError;
                            IsEnabled = string.IsNullOrEmpty(Error);
                            return ModelError;
                        }
                    case "Color":
                        {
                            ColorError = "";

                            if (string.IsNullOrEmpty(Color))
                            {
                                ColorError = "Color cannot be empty.";
                            }

                            Error = MakeError + ModelError + ColorError;
                            IsEnabled = string.IsNullOrEmpty(Error);
                            return ColorError;
                        }
                }

                return Error;
            }
        }

        public VehicleRepository.VehicleModel ToRepositoryModel()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<VehicleModel, VehicleRepository.VehicleModel>());
            var mapper = config.CreateMapper();
            return mapper.Map<VehicleRepository.VehicleModel>(this);
        }

        public static VehicleModel ToModel(VehicleRepository.VehicleModel repositoryModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<VehicleRepository.VehicleModel, VehicleModel>());
            var mapper = config.CreateMapper();
            return mapper.Map<VehicleModel>(repositoryModel);
        }

        public VehicleModel Clone()
        {
            return (VehicleModel)this.MemberwiseClone();
        }
    }
}
