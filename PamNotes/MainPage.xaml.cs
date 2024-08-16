

namespace PamNotes
{
    public partial class MainPage : ContentPage
    {

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Notes.txt");
        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(filePath))
            {
                EditorTx.Text = File.ReadAllText(filePath);

            }
            

        }

        private void SaveButton_Clicked(System.Object sender, System.EventArgs e)
        {

            string texto = EditorTx.Text;
            
            File.WriteAllText(filePath, texto);
            DisplayAlert("Sucesso", "Operação concluída", "Ok");
        }

        private void DeleteButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
                DisplayAlert("Operação concluida", "Arquivo foi apagado com sucesso!", "Ok");
            }
            else
            {
              DisplayAlert("Alerta", "Arquivo não encontrado", "Ok");
              
            }
           
        }

    }
}