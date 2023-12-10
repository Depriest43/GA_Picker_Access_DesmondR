namespace GA_Picker_Access_DesmondR
{ 
    public partial class MainPage : ContentPage
    {
    private List<string> namesList = new List<string>
            {
        "Gibson",
        "Fender",
        "Tekken",
        "Top Gun",
        "Mortal Kombat"
    };

    public MainPage()
    {
        InitializeComponent();

        myPicker.ItemsSource = namesList;
                    
    }//main 

}//class
     }//namespace
