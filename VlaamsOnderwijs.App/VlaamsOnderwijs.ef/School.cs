using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VlaamsOnderwijs.ef
{
    public class School : INotifyPropertyChanged
    {
        public School()
        {

        }

        public string description;
        public string _image;
        public Rating rating;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Principle { get; set; }
        public string Description
        {
            get { return description;  }
            set
            {
                description = value;
                RaisePropertyChanged("Description");
            }
        }

        public string Image { get; set; }
        public int NetId { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Net Net { get; set; }
        public Town Town { get; set; }

        public Rating Rating {

            get { return rating; }
            set
            {

                RaisePropertyChanged("Rating");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
