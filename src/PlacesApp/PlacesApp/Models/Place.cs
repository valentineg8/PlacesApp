using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PlacesApp.Models
{
    public class Place : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsPopular { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsTrending { get; set; }
        public string IdAnimation { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
    }
}
