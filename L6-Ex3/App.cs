using Terminal.Gui;

namespace L6_Ex3
{
    public static class App
    {


        public static void SetupView(View mainVIew)
        {
            Label testLabel = new Label("Test Thing")
            {
                X = 1,
                Y = 1,
                Width = 20,
                Height = 1
            };            
            
            mainVIew.Add(testLabel);
        }
    }
}