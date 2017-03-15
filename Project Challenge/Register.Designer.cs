namespace DrivingPXL
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.domainComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.rePwdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstnTextBox = new System.Windows.Forms.TextBox();
            this.lastnTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.returnLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sendingLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.errorUserExists = new System.Windows.Forms.ErrorProvider(this.components);
            this.pwdMismatch = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFieldEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.postalCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorFormat = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorUserExists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdMismatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFieldEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFormat)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(344, 117);
            this.emailTextBox.MaxLength = 40;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(149, 23);
            this.emailTextBox.TabIndex = 0;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(194, 117);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(94, 19);
            this.emailLbl.TabIndex = 1;
            this.emailLbl.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(492, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "@";
            // 
            // domainComboBox
            // 
            this.domainComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "hotmail.com",
            "live.com",
            "outlook.com",
            "gmail.com",
            "yahoo.com",
            "icloud.com",
            "pxl.be",
            "student.pxl.be"});
            this.domainComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.domainComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.domainComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainComboBox.FormattingEnabled = true;
            this.domainComboBox.Items.AddRange(new object[] {
            "hotmail.com",
            "live.com",
            "outlook.com",
            "gmail.com",
            "yahoo.com",
            "icloud.com",
            "pxl.be",
            "student.pxl.be"});
            this.domainComboBox.Location = new System.Drawing.Point(514, 117);
            this.domainComboBox.MaxLength = 15;
            this.domainComboBox.Name = "domainComboBox";
            this.domainComboBox.Size = new System.Drawing.Size(112, 23);
            this.domainComboBox.TabIndex = 1;
            this.domainComboBox.Text = "student.pxl.be";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Re-enter password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTextBox.Location = new System.Drawing.Point(344, 162);
            this.pwdTextBox.MaxLength = 20;
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(282, 23);
            this.pwdTextBox.TabIndex = 2;
            this.pwdTextBox.UseSystemPasswordChar = true;
            // 
            // rePwdTextBox
            // 
            this.rePwdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePwdTextBox.Location = new System.Drawing.Point(344, 207);
            this.rePwdTextBox.MaxLength = 20;
            this.rePwdTextBox.Name = "rePwdTextBox";
            this.rePwdTextBox.Size = new System.Drawing.Size(282, 23);
            this.rePwdTextBox.TabIndex = 3;
            this.rePwdTextBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(194, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "First name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last name";
            // 
            // firstnTextBox
            // 
            this.firstnTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnTextBox.Location = new System.Drawing.Point(344, 252);
            this.firstnTextBox.MaxLength = 20;
            this.firstnTextBox.Name = "firstnTextBox";
            this.firstnTextBox.Size = new System.Drawing.Size(282, 23);
            this.firstnTextBox.TabIndex = 4;
            // 
            // lastnTextBox
            // 
            this.lastnTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnTextBox.Location = new System.Drawing.Point(344, 297);
            this.lastnTextBox.MaxLength = 20;
            this.lastnTextBox.Name = "lastnTextBox";
            this.lastnTextBox.Size = new System.Drawing.Size(282, 23);
            this.lastnTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(194, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Country/region";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(194, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Postal Code";
            // 
            // countryComboBox
            // 
            this.countryComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Akrotiri",
            "Albanië",
            "Algerije",
            "Amerikaanse Maagdeneilanden",
            "Amerikaans-Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua en Barbuda",
            "Arctic Ocean",
            "Argentinië",
            "Armenië",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Australië",
            "Azerbeidzjan",
            "Bahama\'s",
            "Bahrein",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "België",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivië",
            "Bosnië-Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brazilië",
            "British Indian Ocean Territory",
            "Britse Maagdeneilanden",
            "Brunei",
            "Bulgarije",
            "Burkina Faso",
            "Burundi",
            "Cambodja",
            "Canada",
            "Caymaneilanden",
            "Centraal-Afrikaanse Republiek",
            "Chili",
            "China",
            "Christmas Island",
            "Clipperton Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoren (Unie)",
            "Congo (Democratische Republiek)",
            "Congo (Volksrepubliek)",
            "Cook",
            "Coral Sea Islands",
            "Costa Rica",
            "Cuba",
            "Cyprus",
            "Denemarken",
            "Dhekelia",
            "Djibouti",
            "Dominica",
            "Dominicaanse Republiek",
            "Duitsland",
            "Ecuador",
            "Egypte",
            "El Salvador",
            "Equatoriaal-Guinea",
            "Eritrea",
            "Estland",
            "Ethiopië",
            "European Union",
            "Falkland",
            "Faroe Islands",
            "Fiji",
            "Filipijnen",
            "Finland",
            "Frankrijk",
            "Frans-Polynesië",
            "French Southern and Antarctic Lands",
            "Gabon",
            "Gambia",
            "Gaza Strip",
            "Georgië",
            "Ghana",
            "Gibraltar",
            "Grenada",
            "Griekenland",
            "Groenland",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinee-Bissau",
            "Guyana",
            "Haïti",
            "Heard Island and McDonald Islands",
            "Heilige Stoel",
            "Honduras",
            "Hongarije",
            "Hongkong",
            "Ierland",
            "IJsland",
            "India",
            "Indian Ocean",
            "Indonesië",
            "Irak",
            "Iran",
            "Isle of Man",
            "Israël",
            "Italië",
            "Ivoorkust",
            "Jamaica",
            "Jan Mayen",
            "Japan",
            "Jemen",
            "Jersey",
            "Jordanië",
            "Kaapverdië",
            "Kameroen",
            "Kazachstan",
            "Kenia",
            "Kirgizstan",
            "Kiribati",
            "Koeweit",
            "Kroatië",
            "Laos",
            "Lesotho",
            "Letland",
            "Libanon",
            "Liberia",
            "Libië",
            "Liechtenstein",
            "Litouwen",
            "Luxemburg",
            "Macao",
            "Macedonië",
            "Madagaskar",
            "Malawi",
            "Maldiven",
            "Maleisië",
            "Mali",
            "Malta",
            "Marokko",
            "Marshall Islands",
            "Mauritanië",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldavië",
            "Monaco",
            "Mongolië",
            "Montenegro",
            "Montserrat",
            "Mozambique",
            "Myanmar",
            "Namibië",
            "Nauru",
            "Navassa Island",
            "Nederland",
            "Nederlandse Antillen",
            "Nepal",
            "Ngwane",
            "Nicaragua",
            "Nieuw-Caledonië",
            "Nieuw-Zeeland",
            "Niger",
            "Nigeria",
            "Niue",
            "Noordelijke Marianen",
            "Noord-Korea",
            "Noorwegen",
            "Norfolk Island",
            "Oekraïne",
            "Oezbekistan",
            "Oman",
            "Oostenrijk",
            "Pacific Ocean",
            "Pakistan",
            "Palau",
            "Panama",
            "Papoea-Nieuw-Guinea",
            "Paracel Islands",
            "Paraguay",
            "Peru",
            "Pitcairn",
            "Polen",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Roemenië",
            "Rusland",
            "Rwanda",
            "Saint Helena",
            "Saint Lucia",
            "Saint Vincent en de Grenadines",
            "Saint-Pierre en Miquelon",
            "Salomon",
            "Samoa",
            "San Marino",
            "São Tomé en Principe",
            "Saudi-Arabië",
            "Senegal",
            "Servië",
            "Seychellen",
            "Sierra Leone",
            "Singapore",
            "Sint-Kitts en Nevis",
            "Slovenië",
            "Slowakije",
            "Soedan",
            "Somalië",
            "South Georgia and the South Sandwich Islands",
            "Southern Ocean",
            "Spanje",
            "Spratly Islands",
            "Sri Lanka",
            "Suriname",
            "Svalbard",
            "Syrië",
            "Tadzjikistan",
            "Taiwan",
            "Tanzania",
            "Thailand",
            "Timor Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad en Tobago",
            "Tsjaad",
            "Tsjechië",
            "Tunesië",
            "Turkije",
            "Turkmenistan",
            "Turks-en Caicoseilanden",
            "Tuvalu",
            "Uganda",
            "Uruguay",
            "Vanuatu",
            "Venezuela",
            "Verenigd Koninkrijk",
            "Verenigde Arabische Emiraten",
            "Verenigde Staten van Amerika",
            "Vietnam",
            "Wake Island",
            "Wallis en Futuna",
            "Wereld",
            "West Bank",
            "Westelijke Sahara",
            "Zambia",
            "Zimbabwe",
            "Zuid-Afrika",
            "Zuid-Korea",
            "Zweden",
            "Zwitserland"});
            this.countryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.countryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.countryComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Akrotiri",
            "Albanië",
            "Algerije",
            "Amerikaanse Maagdeneilanden",
            "Amerikaans-Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua en Barbuda",
            "Arctic Ocean",
            "Argentinië",
            "Armenië",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Australië",
            "Azerbeidzjan",
            "Bahama\'s",
            "Bahrein",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "België",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivië",
            "Bosnië-Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brazilië",
            "British Indian Ocean Territory",
            "Britse Maagdeneilanden",
            "Brunei",
            "Bulgarije",
            "Burkina Faso",
            "Burundi",
            "Cambodja",
            "Canada",
            "Caymaneilanden",
            "Centraal-Afrikaanse Republiek",
            "Chili",
            "China",
            "Christmas Island",
            "Clipperton Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoren (Unie)",
            "Congo (Democratische Republiek)",
            "Congo (Volksrepubliek)",
            "Cook",
            "Coral Sea Islands",
            "Costa Rica",
            "Cuba",
            "Cyprus",
            "Denemarken",
            "Dhekelia",
            "Djibouti",
            "Dominica",
            "Dominicaanse Republiek",
            "Duitsland",
            "Ecuador",
            "Egypte",
            "El Salvador",
            "Equatoriaal-Guinea",
            "Eritrea",
            "Estland",
            "Ethiopië",
            "European Union",
            "Falkland",
            "Faroe Islands",
            "Fiji",
            "Filipijnen",
            "Finland",
            "Frankrijk",
            "Frans-Polynesië",
            "French Southern and Antarctic Lands",
            "Gabon",
            "Gambia",
            "Gaza Strip",
            "Georgië",
            "Ghana",
            "Gibraltar",
            "Grenada",
            "Griekenland",
            "Groenland",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinee-Bissau",
            "Guyana",
            "Haïti",
            "Heard Island and McDonald Islands",
            "Heilige Stoel",
            "Honduras",
            "Hongarije",
            "Hongkong",
            "Ierland",
            "IJsland",
            "India",
            "Indian Ocean",
            "Indonesië",
            "Irak",
            "Iran",
            "Isle of Man",
            "Israël",
            "Italië",
            "Ivoorkust",
            "Jamaica",
            "Jan Mayen",
            "Japan",
            "Jemen",
            "Jersey",
            "Jordanië",
            "Kaapverdië",
            "Kameroen",
            "Kazachstan",
            "Kenia",
            "Kirgizstan",
            "Kiribati",
            "Koeweit",
            "Kroatië",
            "Laos",
            "Lesotho",
            "Letland",
            "Libanon",
            "Liberia",
            "Libië",
            "Liechtenstein",
            "Litouwen",
            "Luxemburg",
            "Macao",
            "Macedonië",
            "Madagaskar",
            "Malawi",
            "Maldiven",
            "Maleisië",
            "Mali",
            "Malta",
            "Marokko",
            "Marshall Islands",
            "Mauritanië",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldavië",
            "Monaco",
            "Mongolië",
            "Montenegro",
            "Montserrat",
            "Mozambique",
            "Myanmar",
            "Namibië",
            "Nauru",
            "Navassa Island",
            "Nederland",
            "Nederlandse Antillen",
            "Nepal",
            "Ngwane",
            "Nicaragua",
            "Nieuw-Caledonië",
            "Nieuw-Zeeland",
            "Niger",
            "Nigeria",
            "Niue",
            "Noordelijke Marianen",
            "Noord-Korea",
            "Noorwegen",
            "Norfolk Island",
            "Oekraïne",
            "Oezbekistan",
            "Oman",
            "Oostenrijk",
            "Pacific Ocean",
            "Pakistan",
            "Palau",
            "Panama",
            "Papoea-Nieuw-Guinea",
            "Paracel Islands",
            "Paraguay",
            "Peru",
            "Pitcairn",
            "Polen",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Roemenië",
            "Rusland",
            "Rwanda",
            "Saint Helena",
            "Saint Lucia",
            "Saint Vincent en de Grenadines",
            "Saint-Pierre en Miquelon",
            "Salomon",
            "Samoa",
            "San Marino",
            "São Tomé en Principe",
            "Saudi-Arabië",
            "Senegal",
            "Servië",
            "Seychellen",
            "Sierra Leone",
            "Singapore",
            "Sint-Kitts en Nevis",
            "Slovenië",
            "Slowakije",
            "Soedan",
            "Somalië",
            "South Georgia and the South Sandwich Islands",
            "Southern Ocean",
            "Spanje",
            "Spratly Islands",
            "Sri Lanka",
            "Suriname",
            "Svalbard",
            "Syrië",
            "Tadzjikistan",
            "Taiwan",
            "Tanzania",
            "Thailand",
            "Timor Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad en Tobago",
            "Tsjaad",
            "Tsjechië",
            "Tunesië",
            "Turkije",
            "Turkmenistan",
            "Turks-en Caicoseilanden",
            "Tuvalu",
            "Uganda",
            "Uruguay",
            "Vanuatu",
            "Venezuela",
            "Verenigd Koninkrijk",
            "Verenigde Arabische Emiraten",
            "Verenigde Staten van Amerika",
            "Vietnam",
            "Wake Island",
            "Wallis en Futuna",
            "Wereld",
            "West Bank",
            "Westelijke Sahara",
            "Zambia",
            "Zimbabwe",
            "Zuid-Afrika",
            "Zuid-Korea",
            "Zweden",
            "Zwitserland"});
            this.countryComboBox.Location = new System.Drawing.Point(344, 385);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(282, 23);
            this.countryComboBox.TabIndex = 7;
            this.countryComboBox.Text = "België";
            // 
            // returnLabel
            // 
            this.returnLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.returnLabel.ForeColor = System.Drawing.Color.White;
            this.returnLabel.Image = ((System.Drawing.Image)(resources.GetObject("returnLabel.Image")));
            this.returnLabel.Location = new System.Drawing.Point(158, 56);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(30, 30);
            this.returnLabel.TabIndex = 17;
            this.returnLabel.Click += new System.EventHandler(this.returnLbl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(190, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sign up for a new user account";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderSize = 2;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(563, 489);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(90, 32);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextBtn_Click);
            this.nextButton.MouseLeave += new System.EventHandler(this.nextBtn_MouseLeave);
            this.nextButton.MouseHover += new System.EventHandler(this.nextBtn_MouseHover);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(670, 489);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 32);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelBtn_Click);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelBtn_MouseLeave);
            this.cancelButton.MouseHover += new System.EventHandler(this.cancelBtn_MouseHover);
            // 
            // sendingLabel
            // 
            this.sendingLabel.AutoSize = true;
            this.sendingLabel.BackColor = System.Drawing.Color.Transparent;
            this.sendingLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sendingLabel.ForeColor = System.Drawing.Color.White;
            this.sendingLabel.Location = new System.Drawing.Point(468, 494);
            this.sendingLabel.Name = "sendingLabel";
            this.sendingLabel.Size = new System.Drawing.Size(85, 19);
            this.sendingLabel.TabIndex = 21;
            this.sendingLabel.Text = "Please wait...";
            this.sendingLabel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(194, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Birth Date";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.Location = new System.Drawing.Point(344, 341);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(282, 23);
            this.birthDatePicker.TabIndex = 6;
            this.birthDatePicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // errorUserExists
            // 
            this.errorUserExists.ContainerControl = this;
            this.errorUserExists.Icon = ((System.Drawing.Icon)(resources.GetObject("errorUserExists.Icon")));
            // 
            // pwdMismatch
            // 
            this.pwdMismatch.ContainerControl = this;
            this.pwdMismatch.Icon = ((System.Drawing.Icon)(resources.GetObject("pwdMismatch.Icon")));
            // 
            // errorFieldEmpty
            // 
            this.errorFieldEmpty.ContainerControl = this;
            this.errorFieldEmpty.Icon = ((System.Drawing.Icon)(resources.GetObject("errorFieldEmpty.Icon")));
            // 
            // postalCodeMaskedTextBox
            // 
            this.postalCodeMaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeMaskedTextBox.Location = new System.Drawing.Point(344, 430);
            this.postalCodeMaskedTextBox.Mask = "00000";
            this.postalCodeMaskedTextBox.Name = "postalCodeMaskedTextBox";
            this.postalCodeMaskedTextBox.PromptChar = ' ';
            this.postalCodeMaskedTextBox.Size = new System.Drawing.Size(282, 23);
            this.postalCodeMaskedTextBox.TabIndex = 8;
            this.postalCodeMaskedTextBox.Click += new System.EventHandler(this.postalCodeMaskedTextBox_Click);
            // 
            // errorFormat
            // 
            this.errorFormat.ContainerControl = this;
            this.errorFormat.Icon = ((System.Drawing.Icon)(resources.GetObject("errorFormat.Icon")));
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.postalCodeMaskedTextBox);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sendingLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastnTextBox);
            this.Controls.Add(this.firstnTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rePwdTextBox);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.domainComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.emailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(821, 559);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.errorUserExists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdMismatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFieldEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFormat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox domainComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.TextBox rePwdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstnTextBox;
        private System.Windows.Forms.TextBox lastnTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label sendingLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.ErrorProvider errorUserExists;
        private System.Windows.Forms.ErrorProvider pwdMismatch;
        private System.Windows.Forms.ErrorProvider errorFieldEmpty;
        private System.Windows.Forms.MaskedTextBox postalCodeMaskedTextBox;
        private System.Windows.Forms.ErrorProvider errorFormat;
    }
}