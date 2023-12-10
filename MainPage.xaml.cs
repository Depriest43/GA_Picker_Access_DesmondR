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
        private void OnButtonAddNameClicked(object sender, EventArgs e)
        {
            string newName = editorAddName.Text;
            if (!string.IsNullOrWhiteSpace(newName))
            {
                namesList.Add(newName);

                myPicker.ItemsSource = null;
                myPicker.ItemsSource = namesList;
            }

            private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
            {
                int selectedIndex = myPicker.SelectedIndex;
                string chosenName = namesList[selectedIndex];
                if (!string.IsNullOrWhiteSpace(chosenName))
                {
                    labelDisplayChosenNameHere.Text = "You have chosen the name: " + chosenName;
                }
            }

                public MainPage()
    {
        InitializeComponent();

        myPicker.ItemsSource = namesList;
    }//main 

}//class
     }//namespace
