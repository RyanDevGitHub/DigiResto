
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
    public partial class ManageUserPage : Form
    {
        private List<User>? users;

        public ManageUserPage()
        {
            InitializeComponent();
            LoadAccount();
        }

        void LoadAccount()
        {
            List<User>? userList = UserController.Instance.LoadUserList();
            users = userList;

            
            foreach (User user in userList)
            {
                cbShowAccount.Items.Add(user.Name);
            }
        }
     
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User newUser =new User();
            newUser.Name = tbNewUser.Text;
            if(cbStatusNewUser.SelectedItem == "Manager")
            {
                newUser.Password = tbPassword.Text;
                newUser.IsManager = true;
                newUser.IsAdmin = false;
                newUser.ManageBy = null;
            }
            else if(cbStatusNewUser.SelectedItem == "Employee")
            {
                newUser.Password = tbPassword.Text;
                newUser.IsManager = false;
                newUser.IsAdmin = false;
                newUser.ManageBy = null;
            }
            users.Add(newUser);

            var userData = new UserData
            {
                Users = users
            };

            string fileName = "..\\..\\..\\Json\\User.json";
            string jsonString = JsonSerializer.Serialize(userData);
            File.WriteAllText(fileName, jsonString);

            cbShowAccount.Items.Add(tbNewUser.Text);

            MessageBox.Show("Add new user success !");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<User>? userList = UserController.Instance.LoadUserList();
            users = userList;
            bool isFound = false;

            foreach(User elm in users)
            {
                if(!isFound && elm.Name.Equals(cbShowAccount.SelectedItem))
                {
                    isFound = true;
                    UserController.UserUpdate = elm;
                }
            }
            
            var f = new UpdateUserPage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<User>? userList = UserController.Instance.LoadUserList();
            users = userList;

            if (users == null)
            {
                return;
            }

            User? removeElement = null;
            foreach (User elm in users)
            {
                if (elm.Name != null && cbShowAccount.SelectedItem.ToString() == elm.Name.ToString())
                {
                    removeElement = elm;
                }
            }

            users.Remove(removeElement);

            var userData = new UserData
            {
                Users = users
            };

            string fileName = "..\\..\\..\\Json\\User.json";
            string jsonString = JsonSerializer.Serialize(userData);
            File.WriteAllText(fileName, jsonString);

            cbShowAccount.Items.Remove(cbShowAccount.SelectedItem);

            MessageBox.Show("Delete success !");
        }
    }
}
