## Airplane Reservation System

This project is a Windows Forms application developed to manage airplane reservation operations. Users can select flight routes, make seat reservations, and view flight information.

### Technologies Used

- **.NET 6.0**: The main framework of the project.
- **Windows Forms**: For the user interface.
- **C#**: Programming language.
- **JSON**: Data storage format.

### Installation

1. **Clone the Repository:**
    ```sh
    git clone https://github.com/username/airplane_reservation.git
    cd airplane_reservation
    ```

2. **Install Required Packages:**
    ```sh
    dotnet restore
    ```

3. **Build and Run the Project:**
    ```sh
    dotnet run
    ```

### Usage

1. **Reservation Form:**
    - Enter Name, Surname, Gender, Disabled, and Elderly information.
    - Select the flight date and route.
    - Click the "Select Seat" button to choose a seat.

2. **Seat Selection:**
    - Click on the desired seat in the opened form.
    - The selected seat number and the remaining seat count will be displayed on the main form.

### Data Storage

- **Airplane Information**: Stored in the `ucak` class and saved in JSON format.
- **Reservation Information**: Stored in the `rezervasyon` class and saved in JSON format.
- **Seat Information**: Stored in the `koltuk` class and saved in JSON format.

### Important Code Snippets

- **Loading the Reservation Form:**
    
```csharp:rezervasyon.cs
        public rezervasyon()
        {
            InitializeComponent();

            cbCountry.Items.AddRange(new object[] { "Turkey", "USA", "Germany" });
            cbCountry2.Items.AddRange(new object[] { "Turkey", "USA", "Germany" });

            //new airplane models
            ucak ucak1 = new ucak();
            ucak1.model = "Boeing 737";
            ucak1.yolcuKapasitesi = 162;
            ucak1.seriNo = "abcd123456789";
            ucak1.bakımTarihi = "5/10/23";

            ucak ucak2 = new ucak();
            ucak2.model = "AIRBUS A330";
            ucak2.yolcuKapasitesi = 268;
            ucak2.bakımTarihi = "1/10/23";
            ucak2.seriNo = "73248758235abcd";
        }
```


- **Seat Selection:**
    
```csharp:koltuk.cs
        private void Click(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;  // Cast sender to determine which button was clicked.
            string seatNumber = selectedButton.Name.Replace("button_", "");  // Remove "button_" text to get the seat number.

            // Transfer seat number to the main form
            rezervasyon mainForm = (rezervasyon)Application.OpenForms["rezervasyon"];
            mainForm.label8.Text = seatNumber;
            mainForm.ucakYolcuKapasitesi--;
            mainForm.label11.Text = mainForm.ucakYolcuKapasitesi.ToString();

            this.Close();
```


- **Form Closing Operation:**
    
```csharp:rezervasyon.cs
        private void myForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Enable the button when the form closes
            button2.Enabled = true;
        }
```


### Contributing

1. **Fork and Clone:**
    ```sh
    git clone https://github.com/Enki013/airplane_reservation_json.git
    ```

2. **Create a New Branch:**
    ```sh
    git checkout -b new-feature
    ```

3. **Make Your Changes and Commit:**
    ```sh
    git commit -am 'Added new feature'
    ```

4. **Push Your Branch:**
    ```sh
    git push origin new-feature
    ```

5. **Create a Pull Request.**

### License

This project is licensed under the MIT License. For more information, see the `LICENSE` file.
