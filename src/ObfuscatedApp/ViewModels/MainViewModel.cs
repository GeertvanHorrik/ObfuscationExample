namespace ObfuscatedApp.ViewModels
{
    using Catel.MVVM;
    using System.Threading.Tasks;

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            FirstName = "John";
            LastName = "Doe";
        }

        public override string Title { get { return "Welcome to Obfuscated App"; } }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }
    }
}
