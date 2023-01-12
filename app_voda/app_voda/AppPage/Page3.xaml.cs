using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using Xamarin.Essentials;

namespace app_voda.AppPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();


            var position1 = new Position(43.11330025691613, 131.9111354846298);
            var position2 = new Position(43.112152172582086, 131.91257221346532);
            var position3 = new Position(43.11162663149367, 131.91478245579452);
            var position4 = new Position(43.11393570322693, 131.90922062695904);
            var position5 = new Position(43.11335170375017, 131.91040635579435);
            var position6 = new Position(43.11322594334628, 131.91168271161683);
            var position7 = new Position(43.1125921469672, 131.91230572695892);
            var position8 = new Position(43.11223946215011, 131.91334274145188);
            var position9 = new Position(43.112246188256, 131.9137862951558);
            var position10 = new Position(43.11197955930538, 131.9147989706347);
            var position11= new Position(43.11229690422295, 131.91605309947016);
            var position12= new Position(43.113384624625944, 131.91171889812335);
            var position13 = new Position(43.11455968819956, 131.90915516741407);
            var position14= new Position(43.111896285842285, 131.91743429459157);
            var position15= new Position(43.08132664250351, 131.84841820524093);
            var position16 = new Position(43.08155915292323, 131.848105564279);
            var position17 = new Position(43.09282956592205, 131.86031344045207);
            var position18 = new Position(43.09269791551665, 131.8596029541454);
            var position19 = new Position(43.09253253949235, 131.85884456155458);
            var position20 = new Position(43.09468401128513, 131.85833996225074);

            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = position1,
                Label = "Дальзаводская 1, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Дальзаводская 2, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Дальзаводская 4, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Дальзаводская 5, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00"

            };

            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Дальзаводская 13, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin6 = new Pin
            {
                Type = PinType.Place,
                Position = position6,
                Label = "Дальзаводская 17, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin7 = new Pin
            {
                Type = PinType.Place,
                Position = position7,
                Label = "Дальзаводская 21, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin8 = new Pin
            {
                Type = PinType.Place,
                Position = position8,
                Label = "Дальзаводская 23, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin9 = new Pin
            {
                Type = PinType.Place,
                Position = position9,
                Label = "Дальзаводская 25, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin10 = new Pin
            {
                Type = PinType.Place,
                Position = position10,
                Label = "Дальзаводская 27, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin11 = new Pin
            {
                Type = PinType.Place,
                Position = position11,
                Label = "Дальзаводская 31, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin12 = new Pin
            {
                Type = PinType.Place,
                Position = position12,
                Label = "Металлистов 17, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00 "

            };

            var pin13 = new Pin
            {
                Type = PinType.Place,
                Position = position13,
                Label = "Светланская 78, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00"

            };

            var pin14 = new Pin
            {
                Type = PinType.Place,
                Position = position14,
                Label = "Светланская 106, Плановые ремонтные работы",
                Address = "Сроки работ: 03.06.2021 09:00 - 03.06.2021 18:00"

            };

            var pin15 = new Pin
            {
                Type = PinType.Place,
                Position = position15,
                Label = "Парусная 7, Плановые ремонтные работ",
                Address = "Сроки работ: 02.06.2021 03:00 - 02.06.2021 23:45 "

            };

            var pin16 = new Pin
            {
                Type = PinType.Place,
                Position = position16,
                Label = "Парусная 12, Плановые ремонтные работ",
                Address = "Сроки работ: 02.06.2021 03:00 - 02.06.2021 23:45 "

            };

            var pin17 = new Pin
            {
                Type = PinType.Place,
                Position = position17,
                Label = "Перекопский пер.3, Плановые ремонтные работ",
                Address = "Сроки работ: 02.06.2021 03:00 - 02.06.2021 23:45 "

            };

            var pin18 = new Pin
            {
                Type = PinType.Place,
                Position = position18,
                Label = "Перекопский пер.5, Плановые ремонтные работ",
                Address = "Сроки работ: 02.06.2021 03:00 - 02.06.2021 23:45 "

            };

            var pin19 = new Pin
            {
                Type = PinType.Place,
                Position = position19,
                Label = "Перекопский пер.7, Плановые ремонтные работ",
                Address = "Сроки работ: 02.06.2021 03:00 - 02.06.2021 23:45 "

            };

            var pin20 = new Pin
            {
                Type = PinType.Place,
                Position = position20,
                Label = "Севастопольская 18",
                Address = "Сроки работ: 02.06.2021 03:00 - 02.06.2021 23:45 "

            };

            map.Pins.Add(pin1);
            map.Pins.Add(pin2);
            map.Pins.Add(pin3);
            map.Pins.Add(pin4);
            map.Pins.Add(pin5);
            map.Pins.Add(pin6);
            map.Pins.Add(pin7);
            map.Pins.Add(pin8);
            map.Pins.Add(pin9);
            map.Pins.Add(pin10);
            map.Pins.Add(pin11);
            map.Pins.Add(pin12);
            map.Pins.Add(pin13);
            map.Pins.Add(pin14);
            map.Pins.Add(pin15);
            map.Pins.Add(pin16);
            map.Pins.Add(pin17);
            map.Pins.Add(pin18);
            map.Pins.Add(pin19);
            map.Pins.Add(pin20);

        }
    }
}