using app_diario.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_diario
{
    public partial class App : Application
    {
        static NotaDatabase Database;

        //criando uma conexao com o dtbase
        public static NotaDatabase Database
        {
            get
            {
                if (Database == null)
                {
                    Database = new NotaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), 'Notas.db3'));
                }
                return Database;

            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
