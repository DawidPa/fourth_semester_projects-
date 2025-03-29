using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Web;


namespace WpfDatabaseScript2022
{


    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();


        }
        //ComboBox Województwa
        private void comboBoxWojewodztwa_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {
            if (comboBoxWojewodztwa.SelectedValue == null)


            {
                return;
            }

            //Pobieranie wartości z combobox i usunięcie niepotrzebnego tekst
            string selectedWoj = comboBoxWojewodztwa.SelectedValue.ToString().Replace("System.Windows.Controls.ComboBoxItem: ", "");

            //Łączenie z bazą danych
            string connectionString = "SERVER=127.0.0.1;UID=root;PASSWORD=;DATABASE=testdatabase;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            //Zapytanie do bazy danych
            string query = "SELECT nazwa_miejsca, lokalizacja FROM lokalizacja WHERE wojewodztwa = @woj";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@woj", selectedWoj);

            //Otwarcie połączenia
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd); //most pomiędzy programem a bazą danych

            //Pobranie rekordów z bazy danych i wyświetlenie ich w ListView
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable); //wypełnia dane do tabeli
            listView.ItemsSource = dataTable.DefaultView;
            listView.DisplayMemberPath = "nazwa_miejsca"; // ustawiamy nazwę kolumny, którą chcemy wyświetlić

            connection.Close();

            //Wyświetlanie województw w mapie google
            webBrowser.Navigate(new Uri("https://www.google.com/maps/place/" + "Województwo " + selectedWoj));

            //Zmiana zawartości combobox miasta w zależności od wybranego wojwództwa
            switch (selectedWoj)
            {
                case "Opolskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Nysa", "Opole", "Głuchołazy", "Kędzierzyn-Koźle", "Brzeg", "Kluczbork", "Głogówek", "Namysłów", "Krapkowice", "Olesno", "Strzelce Opolskie" };
                    break;
                case "Slaskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Katowice", "Bielsko-Biała", "Gliwice", "Tychy", "Rybnik", "Bytom" };
                    break;
                case "Mazowieckie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Warszawa", "Radom", "Płock", "Ciechanów", "Ostrołęka", "Siedlce" };
                    break;
                case "Malopolskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Oświęcim", "Wieliczka", "Zakopane" };
                    break;
                case "Podkarpackie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Ustrzyki Górne", "Majdan", "Łańcut" };
                    break;
                case "Lubeskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Dęblin", "Kazimierz Dolny", "Trzcianki" };
                    break;
                case "Swietokrzyskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Chęciny", "Ujazd", "Krajno-Zagórze", "Kielce" };
                    break;
                case "Lodzkie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Łódź"};
                    break;
                case "Dolnoslaskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Kłodzko", "Wrocław", "Kletno"};
                    break;
                case "Wielkopolskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Wolsztny", "Licheń Stary", "Poznań" };
                    break;
                case "Lubuskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Świebodzin", "Nowa Sól", "Mużaków" };
                    break;
                case "Podlaskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Białystok", "Białowieża", "Tykocin" };
                    break;
                case "Kujawsko-pomorskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Biskupin", "Kruszwica", "Bydgoszcz" };
                    break;
                case "Warmińsko-Mazurskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Giżycko", "Gierłoż", "Stańczyki" };
                    break;
                case "Pomorskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Gdańsk", "Sopot", "Gdynia", "Malbork" };
                    break;
                case "Zachodniopomorskie":
                    comboBoxMiasta.ItemsSource = new List<string> { "Trzęsacz", "Międzyzdroje", "Szczecin" };
                    break;



                default:
                    comboBoxMiasta.ItemsSource = null;
                    break;
            }


        }

        //ComboBox Miasta
        private void comboBoxMiasta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxMiasta.SelectedValue == null)
            {
                return;
            }
            string selectedMiasto = comboBoxMiasta.SelectedValue.ToString().Replace("System.Windows.Controls.ComboBoxItem: ", "");


            //Łączenie z bazą danych
            string connectionString = "SERVER=127.0.0.1;UID=root;PASSWORD=;DATABASE=testdatabase;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            //Zapytanie do bazy danych
            string query = "SELECT nazwa_miejsca, lokalizacja FROM lokalizacja WHERE miasta = @miasto";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@miasto", selectedMiasto);


            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            listView.ItemsSource = dataTable.DefaultView;
            listView.DisplayMemberPath = "nazwa_miejsca"; // ustawiamy nazwę kolumny, którą chcemy wyświetlić

            connection.Close();



            webBrowser.Navigate(new Uri("https://www.google.com/maps/place/" + selectedMiasto));



        }


        //Lista Podwójne kliknięcie na wybór
        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (listView.SelectedItem != null)
            {
                //Przypisywanie zaznaczonego wiersza do zmiennej
                DataRowView row = (DataRowView)listView.SelectedItem;

                
                string lokalizacja = row["lokalizacja"].ToString(); //pobieranie lokalizacja z bazy danych i przypisanie jej do zmienej lokalizacja
                webBrowser.Navigate(new Uri("https://www.google.com/maps/place/" + HttpUtility.UrlEncode(lokalizacja)));

            }
        }


        //Dodawanie miejsca do bazy danych przez użytkownika
        public void addButton_Click(object sender, RoutedEventArgs e)
        {
            string wojewodztwo = WojTextBox.Text;
            string miasto = MiastoTextBox.Text.ToLower();
            string nazwaMiasta = NazwaMiejscaTextBox.Text;
            string opisMiejsca = OpisMiejscaTextBox.Text;
            string lokalizacja = LokalizacjaTextBox.Text;

            List<string> validWojewodztwa = new List<string> { "dolnośląskie", "kujawsko-pomorskie", "lubelskie", "lubuskie", 
                "łódzkie", "małopolskie", "mazowieckie", "opolskie", "podkarpackie", "podlaskie", "pomorskie", "śląskie",
                "świętokrzyskie", "warmińsko-mazurskie", "wielkopolskie", "zachodniopomorskie" };

            if (validWojewodztwa.Contains(wojewodztwo.ToLower()))
            {
                if (miasto == "" || nazwaMiasta == "" || opisMiejsca == "" || lokalizacja == "")
                {
                    MessageBox.Show("Musisz podać wszystkie dane");
                }
                else
                {

                    string connectionString = "SERVER=127.0.0.1;UID=root;PASSWORD=;DATABASE=testdatabase;";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string miastoCapitalized = miasto.Substring(0, 1).ToUpper() + miasto.Substring(1);
                    string query = $"INSERT INTO lokalizacja (wojewodztwa, miasta, nazwa_miejsca, opis_miejsca, lokalizacja) VALUES ('{wojewodztwo.ToLower()}', " +
                        $"'{miastoCapitalized}', '{nazwaMiasta}', '{opisMiejsca}', '{lokalizacja}')";


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie dodano wartości do bazy danych");
                    connection.Close();

                    WojTextBox.Text = "";
                    MiastoTextBox.Text = "";
                    NazwaMiejscaTextBox.Text = "";
                    OpisMiejscaTextBox.Text = "";
                    LokalizacjaTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Nie istnieje takie Województwo");
            }





        }


    }
}
