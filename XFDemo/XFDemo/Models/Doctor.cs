using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace XFDemo.Models
{
    public class Doctor:INotifyPropertyChanged
    {
        private string _name;

        public string Name {
            get => _name;

            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));


                //if (PropertyChanged!= null)
                //{
                //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                //}

                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Title { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public string Image { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
