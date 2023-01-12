using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;


namespace app_voda.AppPage
{
    public class placemodel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<places> Places;

        public ObservableCollection<places> places
        {
            get { return Places; }
            set
            {
                Places = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("places"));
            }
        }
        

        public placemodel()
        {
            places = new ObservableCollection<places>();
            addData();
        }

        private void addData()
        {
            places.Add(new places
            {
                id = 0,
                description = "Отслеживайте отключения на карте",
                imgsrc = "map.png",
            });

            places.Add(new places
            {
                id = 1,
                description = "Подавайте информацию об отключении",
                imgsrc = "otkl.png",
            });

            places.Add(new places
            {
                id = 2,
                description = "Получайте информацию об отключении",
                imgsrc = "disconect.png",
            });

            places.Add(new places
            {
                id = 3,
                description = "Отправляйте показания счетчиков",
                imgsrc = "schet.png",
            });
        }

    }
}
