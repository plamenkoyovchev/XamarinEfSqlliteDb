using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TestEFSqLiteOnXamarin.Persistance;
using TestEFSqLiteOnXamarin.Persistance.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestEFSqLiteOnXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        private readonly DatabaseContext dbContext;
        private List<Person> persons;

        public MainPage()
        {
            InitializeComponent();

            dbContext = DbConnection.Instance.DbContext;
            persons = new List<Person>();
            
            GetPersons();
        }

        private void GetPersons()
        {
            persons = dbContext.Persons
                               .Include(x => x.Address)
                               .ToList();
        }
    }
}