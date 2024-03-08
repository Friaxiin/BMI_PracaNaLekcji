using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace BMI_PracaNaLekcji
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultsPage : ContentPage
    {
        public List<BMIResult> Results = DataFile.LoadTxt();
        public ResultsPage()
        {
            InitializeComponent();
            //Load();
            BMIList.ItemsSource = Results;
        }
        public void Load()
        {
            string path = App.DbPath;

            if (File.Exists(path))
            {
                string serializedResults = File.ReadAllText(path);

                List<BMIResult> results = JsonConvert.DeserializeObject<List<BMIResult>>(serializedResults);

                BMIList.ItemsSource = results;
            }
        }

        private void DeleteBMI(object sender, EventArgs e)
        {
            BMIResult selectedItem = (BMIResult)BMIList.SelectedItem;
            //List<BMIResult> results = DataFile.LoadTxt();
            DataFile.DeleteLine(Results, selectedItem);
        }

        private void Back(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}