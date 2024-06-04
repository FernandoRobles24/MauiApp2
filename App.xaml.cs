namespace MauiApp2
{
    public partial class App : Application
    {
        static Controllers.PersonasController dbperson;

        public static Controllers.PersonasController DataBase
        {
            get 
            { 
                if(dbperson == null)
                {
                    dbperson = new Controllers.PersonasController();
                }
                return dbperson;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.PageListPerson());
        }
    }
}
