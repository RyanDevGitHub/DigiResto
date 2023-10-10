
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
    public partial class ConnexionPage : Form
    {
        public ConnexionPage()
        {
            InitializeComponent();
            LoadAccount();
        }
        private List<User>? users;

        

        #region methods
        
        void LoadAccount()
        {
            List<User>? userList = UserController.Instance.LoadUserList();
            users = userList;

            foreach(User user in userList)
            {
                if(user.IsManager || user.IsAdmin)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = user.Name;
                    radioButton.Name = user.Name;

                    flpShowManager.Controls.Add(radioButton);
                }
                else
                {
                    //CheckBox cb = new CheckBox();
                    //cb.Text = user.Name;
                    //flpShowEmployer.Controls.Add(cb);

                    clbShowEmployee.Items.Add(user.Name);
                }


            }
        }
        #endregion
        #region events
        private void tbnDone_Click(object sender, EventArgs e)
        {
            //check Manage
            foreach (Control c in flpShowManager.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;

                    if (rd.Checked)
                    {
                        bool found = false;
                        //create a new manager for Login
                        foreach (User elm in users!)
                        {
                            if (elm.Name == rd.Name && !found)
                            {
                                UserController.UserLogin = elm;
                                found = true;
                            }
                        }

                        //check employees in checklistbox
                        foreach(string itemChecked in clbShowEmployee.CheckedItems)
                        {
                            foreach(User elm in users)
                            {
                                if(elm.Name == itemChecked)
                                {
                                    elm.ManageBy = rd.Name;

                                }
                                //else
                                //{
                                //    elm.ManageBy = null;
                                //}
                            }
                            
                        }
                        var userData = new UserData
                        {
                            Users = users
                        };

                        string fileName = "..\\..\\..\\Json\\User.json";
                        string jsonString = JsonSerializer.Serialize(userData);
                        File.WriteAllText(fileName, jsonString);

                        var l = new LoginPage();
                        this.Hide();
                        l.ShowDialog();
                        //this.Show();
                    }
                }
            }
        }


        private void Manager_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void flpShowManager_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
