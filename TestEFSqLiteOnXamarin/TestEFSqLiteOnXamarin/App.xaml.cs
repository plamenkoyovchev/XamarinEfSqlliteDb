using System;
using Xamarin.Forms;
using TestEFSqLiteOnXamarin.Views;
using Xamarin.Forms.Xaml;
using TestEFSqLiteOnXamarin.Persistance;
using Microsoft.EntityFrameworkCore;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TestEFSqLiteOnXamarin
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();
            InitializeDatabase();
            
			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        private void InitializeDatabase()
        {
            SQLitePCL.Batteries.Init();
            using(var db = DbConnection.Instance.DbContext)
            {
                db.Database.EnsureCreated();
                db.Database.Migrate();
            }
        }
	}
}
