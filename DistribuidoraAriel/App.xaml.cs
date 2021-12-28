using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DistribuidoraAriel.Services;
using System.IO;

namespace DistribuidoraAriel
{
    public partial class App : Application
    {
        static ServicesDistribuidora db;
        public static ServicesDistribuidora Db
        {
            get
            {
                if (db == null)
                {
                    var pth = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    db = new ServicesDistribuidora(Path.Combine(pth, "DistribuidoraAreil.db3"));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
