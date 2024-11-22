using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Для роботи з файлами
using System.IO.Compression; // Для створення архівів
using Newtonsoft.Json; // Для конвертації даних у JSON (потрібно підключити через NuGet)


namespace Magic_battle
{
    
    public partial class Login : Form
    {
        string name;
        string password;
        string jsonData;
        string fileName;
        string folderPath;

        public Login()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name = name_textBox.Text;
            password = password_textBox.Text;
            text_label.Visible = true;
            text_label.Text = "Вітаю " + name +" Ваш пароль: " + password;

            // 2. Створюємо об'єкт для збереження даних
            var saveData = new
            {
                Name = name,
                Password = password,
                HeroProperty = GlobalVariables.hero_property,
                Researches = GlobalVariables.researches,
                Points = GlobalVariables.points
            };

            // 3. Серіалізуємо об'єкт у JSON
            jsonData = JsonConvert.SerializeObject(saveData, Formatting.Indented);

            // 4. Зберігаємо JSON у файл
            string fileName = $"{name}_data.json"; // Ім'я файлу залежить від імені користувача
            File.WriteAllText(fileName, jsonData);

            // 5. Показуємо повідомлення про успіх
            text_label.Visible = true;
            text_label.Text = $"Дані успішно збережено у файлі {fileName}!";

            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = name_textBox.Text;
            password = password_textBox.Text;
            fileName = $"{name}_data.json"; // Ім'я файлу, яке хочемо прочитати
            if (File.Exists(fileName))
            {
                // 1. Читаємо JSON із файлу
                jsonData = File.ReadAllText(fileName);

                // 2. Десеріалізуємо дані у відповідний об'єкт
                var loadData = JsonConvert.DeserializeObject<dynamic>(jsonData);

                // 3. Відновлюємо дані в програмі
                name = loadData.Name;
                password = loadData.Password;
                GlobalVariables.hero_property = JsonConvert.DeserializeObject<List<hero_characteristics>>(loadData.HeroProperty.ToString());
                GlobalVariables.researches = JsonConvert.DeserializeObject<List<Researches>>(loadData.Researches.ToString());
                GlobalVariables.points = JsonConvert.DeserializeObject<List<points>>(loadData.Points.ToString());

                // 4. Показуємо повідомлення про успіх
                text_label.Visible = true;
                text_label.Text = "Дані успішно завантажено!";
            }
            else
            {
                text_label.Visible = true;
                text_label.Text = "Файл не знайдено!";
            }
        }
    }

        
    
    
}

