using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PlacesApp.Models;

namespace PlacesApp.Utils
{
    public static class Data
    {
        public static ObservableCollection<Place> places = new ObservableCollection<Place> {

            new Place
                {
                    Image = "https://www.fodors.com/wp-content/uploads/2019/12/WinterBeachEscapes__HERO_shutterstock_1271867908.jpg",
                    Title = "Ocean at Algarve",
                    IsFeatured = true,
                    IsTrending = true,
                    SubTitle = "Enjoy view over the sky from your room",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Images = new List<string>
                    {
                        "https://www.aiglonmorzine.com/wp-content/uploads/2019/01/Annecy.jpg",
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Palais_de_l%27Isle_-_Annecy_6-9-2017_10-19-19.JPG/1200px-Palais_de_l%27Isle_-_Annecy_6-9-2017_10-19-19.JPG",
                        "https://img.theculturetrip.com/768x432/wp-content/uploads/2018/08/shutterstock_547692802.jpg"
                    }
                },
                new Place
                {
                    Image = "https://i2.wp.com/ilc.oey.mybluehost.me/wp-content/uploads/2020/02/family_treehouse_dominican_village.jpg?resize=1024%2C576&ssl=1",
                    Title = "Dominican Tree House Village",
                    IsPopular = true,
                    SubTitle = "Samana, Dominican Republic",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Images = new List<string>
                    {
                        "https://i0.wp.com/dominicantreehousevillage.com/wp-content/uploads/2020/02/IMG_7514_1.jpg?resize=1024%2C683&ssl=1",
                        "https://i2.wp.com/dominicantreehousevillage.com/wp-content/uploads/2019/12/IMG_7511_72px.jpg?resize=800%2C1200&ssl=1",
                        "https://i2.wp.com/dominicantreehousevillage.com/wp-content/uploads/2020/02/DSC_5035_1.jpg?resize=819%2C1024&ssl=1"
                    }


                },
                new Place
                {
                    Image = "https://images.trvl-media.com/hotels/30000000/29850000/29842500/29842432/2debbc87.jpg?impolicy=fcrop&w=1200&h=800&p=1&q=medium",
                    Title = "Mandarin Oriental Jumeira",
                    SubTitle = "Dubai's Jumeirah",
                    IsFeatured = false,
                    IsTrending = true,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Images = new List<string>
                    {
                        "https://images.trvl-media.com/hotels/30000000/29850000/29842500/29842432/007daf59.jpg?impolicy=fcrop&w=1200&h=800&p=1&q=medium",
                        "https://images.trvl-media.com/hotels/30000000/29850000/29842500/29842432/bdce79e8.jpg?impolicy=fcrop&w=1200&h=800&p=1&q=medium",
                        "https://images.trvl-media.com/hotels/30000000/29850000/29842500/29842432/71afef03.jpg?impolicy=fcrop&w=1200&h=800&p=1&q=medium"
                    }


                },
                new Place
                {
                    Image = "https://images.trvl-media.com/hotels/21000000/20650000/20643300/20643202/b4d5f067.jpg?impolicy=fcrop&w=1200&h=800&p=1&q=medium",
                    Title = "Bulgari Hotel & Resorts",
                    SubTitle = "Dubai's Jumeirah",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Images = new List<string>
                    {
                        "https://images.trvl-media.com/hotels/21000000/20650000/20643300/20643202/e5b6b220.jpg?impolicy=fcrop&w=1200&h=800&p=1&q=medium",
                        "https://images.trvl-media.com/hotels/21000000/20650000/20643300/20643202/5a6e566a.jpg?impolicy=fcrop&w=1200&h=800&p=1&q=medium",
                        "https://images.trvl-media.com/hotels/21000000/20650000/20643300/20643202/330ae047.jpg?impolicy=fcrop&w=1200&h=800&p=1&q=medium",
                        "https://images.trvl-media.com/hotels/21000000/20650000/20643300/20643202/e59e8184.jpg?impolicy=fcrop&w=1200&h=800&p=1&q=medium"
                    }


                },
                new Place
                {
                    Image = "https://cdn.galaxy.tf/thumb/sizeW1920/uploads/2s/cms_image/001/581/930/1581930687_5e4a58bf7be10-thumb.jpg",
                    IsPopular = true,
                    Title = "Impressive Resorts & Spas",
                    SubTitle = "Bávaro, Punta Cana, Dominican Republic.",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Images = new List<string>
                    {
                        "https://www.aiglonmorzine.com/wp-content/uploads/2019/01/Annecy.jpg",
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Palais_de_l%27Isle_-_Annecy_6-9-2017_10-19-19.JPG/1200px-Palais_de_l%27Isle_-_Annecy_6-9-2017_10-19-19.JPG",
                        "https://img.theculturetrip.com/768x432/wp-content/uploads/2018/08/shutterstock_547692802.jpg"
                    }
                },
                new Place
                {
                    Image = "https://media.cntraveler.com/photos/5d921b846168d9000af15c44/master/w_1200,c_limit/Tongabezi-&-Sindabezi_2019_IMG_0598-1.jpg",
                    Title = "Tongabezi & Sindabezi",
                    IsFeatured = true,
                    SubTitle = "Livingstone Way, Livingstone, Zambia.",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Images = new List<string>
                    {
                        "https://media.cntraveler.com/photos/5d921b84d19ce4000851d902/master/w_1200,c_limit/Tongabezi-&-Sindabezi_2019_IMG_5206-1.jpg",
                        "https://media.cntraveler.com/photos/5d921b846168d9000af15c45/master/w_1200,c_limit/Tongabezi-&-Sindabezi_2019_IMG_5408-1.jpg",
                        "https://media.cntraveler.com/photos/5d921b8537c3f70009b84f9d/master/w_1200,c_limit/Tongabezi-&-Sindabezi_2019_Tongabezi_March18-62.jpg"
                    }
                }
        };
    }
}
