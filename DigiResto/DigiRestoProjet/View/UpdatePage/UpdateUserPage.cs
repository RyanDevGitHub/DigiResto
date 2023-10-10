using DigiResto.Controller;
using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiRestoProjet.View
{
    public partial class UpdateUserPage : Form
    {
        private List<User>? users;

        public UpdateUserPage()
        {
            InitializeComponent();
            LoadUserUpdate();
        }

        void LoadUserUpdate()
        {
            List<User>? userList = UserController.Instance.LoadUserList();
            users = userList;

            tbUseNameUpdate.Text = UserController.UserUpdate.Name;

            if(UserController.UserUpdate.IsManager || UserController.UserUpdate.IsAdmin)
            {
                cbStatusUpdate.Text = "Manager";
            }
            else
            {
                cbStatusUpdate.Text = "Employee";
            }
            tbPassword.Text = UserController.UserUpdate.Password;
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            foreach(User human in users)
            {
                if (human.Name.Equals(UserController.UserUpdate.Name))
                {
                    human.Name = tbUseNameUpdate.Text;
                    
                    if(cbStatusUpdate.SelectedItem == "Manager")
                    {
                        human.IsManager = true;
                    }
                    else if(cbStatusUpdate.SelectedItem == "Employee")
                    {
                        human.IsManager= false;
                    }
                    
                    if(tbNewPassword.Text != "")
                    {
                        human.Password = tbNewPassword.Text;
                    }
                }
            }
            var userData = new UserData
            {
                Users = users
            };

            string fileName = "..\\..\\..\\Json\\User.json";
            string jsonString = JsonSerializer.Serialize(userData);
            File.WriteAllText(fileName, jsonString);

            MessageBox.Show("Update success !");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var form = new ManageUserPage();
            this.Hide();
            form.ShowDialog();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
