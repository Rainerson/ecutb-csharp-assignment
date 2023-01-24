
using C_Sharp_Project;

var menu = new C_Sharp_Project.Services.Menu();
menu.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";



while(true) { 
Console.Clear();
menu.WecomeMenu();
}