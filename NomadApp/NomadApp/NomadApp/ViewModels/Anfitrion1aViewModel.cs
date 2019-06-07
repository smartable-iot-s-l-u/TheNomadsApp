namespace NomadApp.ViewModels
{
    using Newtonsoft.Json;
    using NomadApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Reflection;
    using System.Text;

    public class Anfitrion1aViewModel : BaseViewModel
    {
        public class MainPageViewModel
        {
            private ObservableCollection<Anfitrion1aModel> imageNodeInfo;


            public MainPageViewModel()
            {

                GenerateSource();

            }

            public ObservableCollection<Anfitrion1aModel> ImageNodeInfo
            {
                get { return imageNodeInfo; }
                set { this.imageNodeInfo = value; }
            }




            private void GenerateSource()
            {
                var nodeImageInfo = new ObservableCollection<Anfitrion1aModel>();

                Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;

                // var assembly = typeof(HomePageViewModel).GetTypeInfo().Assembly;
                Stream stream = assembly.GetManifestResourceStream("NomadApp.MetaData.jsconfig1.json");

                using (var reader = new System.IO.StreamReader(stream))
                {
                    var json = reader.ReadToEnd();

                    List<Anfitrion1aModel> mylist = JsonConvert.DeserializeObject<List<Anfitrion1aModel>>(json);
                    ImageNodeInfo = new ObservableCollection<Anfitrion1aModel>(mylist);

                }



            }
        }

    }
}
  