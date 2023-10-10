
﻿using DigiResto.Controller;
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
    public partial class LoginPage : Form
    {

        private List<User>? users;


        public LoginPage()
        {
            InitializeComponent();
        }

        #region methods
        
        #endregion

        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txbPassWord.Text == UserController.UserLogin.Password)
            {
                //var p = new MainPage();
                UserController.Instance.SaveManage(UserController.UserLogin.Name);
                this.Hide();
                //p.ShowDialog();
                
            }
            else
            {
                //set ManageBy is null
                List<User>? userList = UserController.Instance.LoadUserList();
                users = userList;

                foreach (User elm in users)
                {
                    elm.ManageBy = null;
                }
                var userData = new UserData
                {
                    Users = users
                };

                string fileName = "..\\..\\..\\Json\\User.json";
                string jsonString = JsonSerializer.Serialize(userData);
                File.WriteAllText(fileName, jsonString);

                MessageBox.Show("Incorrect password !");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            List<User>? userList = UserController.Instance.LoadUserList();
            users = userList;

            foreach (User elm in users)
            {
                elm.ManageBy = null;
            }
            var userData = new UserData
            {
                Users = users
            };

            string fileName = "..\\..\\..\\Json\\User.json";
            string jsonString = JsonSerializer.Serialize(userData);
            File.WriteAllText(fileName, jsonString); 

            Application.Exit();
        }
        #endregion
    }
}
