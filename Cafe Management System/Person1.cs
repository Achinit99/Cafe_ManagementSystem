using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Person1 : Form
    {
        public int Espresso { get; private set; }

        public Person1()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("button1 was clicked", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            menu frm = new menu();
            this.Hide();
            frm.Show();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;

            if (cmb_coffee.Text == "")
            {
                if (cmb_milkshakes.Text == "")
                {
                    if (cmb_desserts.Text == "")
                    {
                        if (cmb_hotdrinks.Text == "")
                        {
                            if (cmb_icedrinks.Text == "")
                            {
                                MessageBox.Show("Ade thmauseta pissuda .Item 1k select karapiya");
                            }
                            else
                            {
                                item_1.Text = cmb_icedrinks.Text;
                                qty_1.Text = cmb_No_icedrinks.Text;
                                price_5.Text = cmb_ice_p.Text;

                                item_2.Text = "";
                                item_3.Text = "";
                                item_4.Text = "";
                                item_5.Text = "";

                                qty_2.Text = "";
                                qty_3.Text = "";
                                qty_4.Text = "";
                                qty_5.Text = "";

                                price_2.Text = "";
                                price_3.Text = "";
                                price_4.Text = "";
                                price_5.Text = "";

                            }
                        }
                        else
                        {
                            // buying a hotdrinks, no desserts, no Milkshake, no coffe

                            item_1.Text = cmb_hotdrinks.Text;
                            item_2.Text = "";
                            item_3.Text = "";
                            item_4.Text = "";
                            item_5.Text = "";

                            qty_1.Text = cmb_No_hotdrinks.Text;
                            qty_2.Text = "";
                            qty_3.Text = "";
                            qty_4.Text = "";
                            qty_5.Text = "";

                            price_1.Text = cmb_hot_p.Text;
                            price_2.Text = "";
                            price_3.Text = "";
                            price_4.Text = "";
                            price_5.Text = "";


                            // hot , cool
                            if (cmb_icedrinks.Text != "")
                            {
                                item_2.Text = cmb_icedrinks.Text;
                                item_3.Text = "";
                                item_4.Text = "";
                                item_5.Text = "";

                                qty_2.Text = cmb_No_icedrinks.Text;
                                qty_3.Text = "";
                                qty_4.Text = "";
                                qty_5.Text = "";

                                price_1.Text = cmb_ice_p.Text;
                                price_2.Text = "";
                                price_3.Text = "";
                                price_4.Text = "";
                                price_5.Text = "";

                            }

      
                        }
                    }
                    else
                    {
                        // buying a desserts, no Milkshake, no coffe

                        item_1.Text = cmb_desserts.Text;
                        item_2.Text = "";
                        item_3.Text = "";
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_1.Text = cmb_No_desserts.Text;
                        qty_2.Text = "";
                        qty_3.Text = "";
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_1.Text = cmb_desert_p.Text;
                        price_2.Text = "";
                        price_3.Text = "";
                        price_4.Text = "";
                        price_5.Text = "";


                        // desert ,hot & cool
                        if (cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                        {
                            item_2.Text = cmb_hotdrinks.Text;
                            item_3.Text = cmb_icedrinks.Text;
                            item_4.Text = "";
                            item_5.Text = "";

                            qty_2.Text = cmb_No_hotdrinks.Text;
                            qty_3.Text = cmb_No_icedrinks.Text;
                            qty_4.Text = "";
                            qty_5.Text = "";

                            price_2.Text = cmb_hot_p.Text;
                            price_3.Text = cmb_ice_p.Text;
                            price_4.Text = "";
                            price_5.Text = "";



                        }


                        // desert ,no hot & cool
                        else if (cmb_hotdrinks.Text == "" && cmb_icedrinks.Text != "")
                        {


                            item_2.Text = cmb_icedrinks.Text;
                            item_3.Text = "";
                            item_4.Text = "";
                            item_5.Text = "";

                            qty_2.Text = cmb_No_icedrinks.Text;
                            qty_3.Text = "";
                            qty_4.Text = "";
                            qty_5.Text = "";

                            price_2.Text = cmb_ice_p.Text;
                            price_3.Text = "";
                            price_4.Text = "";
                            price_5.Text = "";

                        }


                        // desert ,hot & no cool
                        else if (cmb_hotdrinks.Text != "" && cmb_icedrinks.Text == "")
                        {
                            item_2.Text = cmb_hotdrinks.Text;
                            item_3.Text = "";
                            item_4.Text = "";
                            item_5.Text = "";

                            qty_2.Text = cmb_No_hotdrinks.Text;
                            qty_3.Text = "";
                            qty_4.Text = "";
                            qty_5.Text = "";

                            price_2.Text = cmb_hot_p.Text;
                            price_3.Text = "";
                            price_4.Text = "";
                            price_5.Text = "";
                        }


                        // desert ,hot & cool
                        else if (cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                        {
                            item_2.Text = cmb_hotdrinks.Text;
                            item_3.Text = cmb_icedrinks.Text;
                            item_4.Text = "";
                            item_5.Text = "";

                            qty_2.Text = cmb_No_hotdrinks.Text;
                            qty_3.Text = cmb_No_icedrinks.Text;
                            qty_4.Text = "";
                            qty_5.Text = "";

                            price_2.Text = cmb_hot_p.Text;
                            price_3.Text = cmb_ice_p.Text;
                            price_4.Text = "";
                            price_5.Text = "";
                        }

                    }
                }
                else
                {

                    // buying a Milkshake no coffe

                    item_1.Text = cmb_milkshakes.Text;
                    item_2.Text = "";
                    item_3.Text = "";
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_1.Text = cmb_No_milkshakes.Text;
                    qty_2.Text = "";
                    qty_3.Text = "";
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_1.Text = cmb_milk_p.Text;
                    price_2.Text = "";
                    price_3.Text = "";
                    price_4.Text = "";
                    price_5.Text = "";



                    // milkshake , desert,hot & cool
                    if ( cmb_desserts.Text != "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                    {
                        item_2.Text = cmb_desserts.Text;
                        item_3.Text = cmb_hotdrinks.Text;
                        item_4.Text = cmb_icedrinks.Text;
                        item_5.Text = "";

                        qty_2.Text = cmb_No_desserts.Text;
                        qty_3.Text = cmb_No_hotdrinks.Text;
                        qty_4.Text = cmb_No_icedrinks.Text;
                        qty_5.Text = "";

                        price_2.Text = cmb_desert_p.Text;
                        price_3.Text = cmb_hot_p.Text;
                        price_4.Text = cmb_ice_p.Text;
                        price_5.Text = "";

                    }


                    // milkshake , no desert,hot & cool
                    else if (cmb_desserts.Text == "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                    {

                        item_2.Text = cmb_hotdrinks.Text;
                        item_3.Text = cmb_icedrinks.Text;
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_hotdrinks.Text;
                        qty_3.Text = cmb_No_icedrinks.Text;
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_hot_p.Text;
                        price_3.Text = cmb_ice_p.Text;
                        price_4.Text = "";
                        price_5.Text = "";



                    }
                    // milkshake ,no desert,no hot & cool
                    else if (cmb_desserts.Text == "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text != "")
                    {


                        item_2.Text = cmb_icedrinks.Text;
                        item_3.Text = "";
                        item_4.Text = "";
                        item_5.Text = "";


                        qty_2.Text = cmb_No_icedrinks.Text;
                        qty_3.Text = "";
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_ice_p.Text;
                        price_3.Text = "";
                        price_4.Text = "";
                        price_5.Text = "";

                    }



                    // milkshake , no desert,hot & cool
                    else if (cmb_desserts.Text == "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                    {
                        item_2.Text = cmb_hotdrinks.Text;
                        item_3.Text = cmb_icedrinks.Text;
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_hotdrinks.Text;
                        qty_3.Text = cmb_No_icedrinks.Text;
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_hot_p.Text;
                        price_3.Text = cmb_ice_p.Text;
                        price_4.Text = "";
                        price_5.Text = "";
                    }


                    // milkshake , desert,no hot & no cool
                    else if (cmb_desserts.Text != "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text == "")
                    {
                        item_2.Text = cmb_desserts.Text;
                        item_3.Text = "";
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_desserts.Text;
                        qty_3.Text = "";
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_desert_p.Text;
                        price_3.Text = "";
                        price_4.Text = "";
                        price_5.Text = "";
                    }


                    // milkshake ,desert,hot & no cool
                    else if (cmb_desserts.Text != "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text == "")
                    {
                        item_2.Text = cmb_desserts.Text;
                        item_3.Text = cmb_hotdrinks.Text;
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_desserts.Text;
                        qty_3.Text = cmb_No_hotdrinks.Text;
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_desert_p.Text;
                        price_3.Text = cmb_hot_p.Text;
                        price_4.Text = "";
                        price_5.Text = "";
                    }


                    // milkshake , no desert,no hot & cool
                    else if (cmb_desserts.Text == "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text != "")
                    {
                        item_2.Text = cmb_icedrinks.Text;
                        item_3.Text = ""; 
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_icedrinks.Text;
                        qty_3.Text = "";
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_ice_p.Text;
                        price_3.Text = "";
                        price_4.Text = "";
                        price_5.Text = "";
                    }


                    // milkshake ,no desert,hot & no cool
                    else if (cmb_desserts.Text == "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text == "")
                    {
                        item_2.Text = cmb_hotdrinks.Text;
                        item_3.Text = "";
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_hotdrinks.Text;
                        qty_3.Text = "";
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_hot_p.Text;
                        price_3.Text = "";
                        price_4.Text = "";
                        price_5.Text = "";
                    }


                    // milkshake ,desert,no hot & cool
                    else if (cmb_desserts.Text != "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text != "")
                    {
                        item_2.Text = cmb_desserts.Text;
                        item_3.Text = cmb_icedrinks.Text;
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_desserts.Text;
                        qty_3.Text = cmb_No_icedrinks.Text;
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_desert_p.Text;
                        price_3.Text = cmb_ice_p.Text;
                        price_4.Text = "";
                        price_5.Text = "";
                    }


                    // milkshake ,desert,hot & no cool
                    else if (cmb_desserts.Text != "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text == "")
                    {
                        item_2.Text = cmb_desserts.Text;
                        item_3.Text = cmb_hotdrinks.Text;
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_desserts.Text;
                        qty_3.Text = cmb_No_hotdrinks.Text;
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_desert_p.Text;
                        price_3.Text = cmb_hot_p.Text;
                        price_4.Text = "";
                        price_5.Text = "";
                    }


                    // milkshake ,no desert,hot & cool
                    else if (cmb_desserts.Text == "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                    {
                        item_2.Text = cmb_hotdrinks.Text;
                        item_3.Text = cmb_icedrinks.Text;
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_hotdrinks.Text;
                        qty_3.Text = cmb_No_icedrinks.Text;
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_hot_p.Text;
                        price_3.Text = cmb_ice_p.Text;
                        price_4.Text = "";
                        price_5.Text = "";
                    }


                    // milkshake ,desert,no hot & cool
                    else if (cmb_desserts.Text != "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text != "")
                    {
                        item_2.Text = cmb_desserts.Text;
                        item_3.Text = cmb_icedrinks.Text;
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_desserts.Text;
                        qty_3.Text = cmb_No_icedrinks.Text;
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_desert_p.Text;
                        price_3.Text = cmb_ice_p.Text;
                        price_4.Text = "";
                        price_5.Text = "";
                    }
                    

                    // milkshake ,no desert,hot & cool
                    else if (cmb_desserts.Text == "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                    {
                        item_2.Text = cmb_hotdrinks.Text;
                        item_3.Text = cmb_icedrinks.Text;
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_hotdrinks.Text;
                        qty_3.Text = cmb_No_icedrinks.Text;
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_hot_p.Text;
                        price_3.Text = cmb_ice_p.Text;
                        price_4.Text = "";
                        price_5.Text = "";
                    }
                }

            }
            else
            {
                // buying a coffee

                item_1.Text = cmb_coffee.Text;
                item_2.Text = "";
                item_3.Text = "";
                item_4.Text = "";
                item_5.Text = "";

                qty_1.Text = cmb_No_coffee.Text;
                qty_2.Text = "";
                qty_3.Text = "";
                qty_4.Text = "";
                qty_5.Text = "";

                price_1.Text = cmb_coffee_p.Text;
                price_2.Text = "";
                price_3.Text = "";
                price_4.Text = "";
                price_5.Text = "";

                //buying all

                if (cmb_milkshakes.Text != "" && cmb_desserts.Text != "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                {
                    item_2.Text = cmb_milkshakes.Text;
                    item_3.Text = cmb_desserts.Text;
                    item_4.Text = cmb_hotdrinks.Text;
                    item_5.Text = cmb_icedrinks.Text;

                    qty_2.Text = cmb_No_milkshakes.Text;
                    qty_3.Text = cmb_No_desserts.Text;
                    qty_4.Text = cmb_No_hotdrinks.Text;
                    qty_5.Text = cmb_No_icedrinks.Text;

                    price_2.Text = cmb_milk_p.Text;
                    price_3.Text = cmb_desert_p.Text;
                    price_4.Text = cmb_hot_p.Text;
                    price_5.Text = cmb_ice_p.Text;
                }



                // coffe , no milkshake , desert,hot & cool
                else if (cmb_milkshakes.Text == "" && cmb_desserts.Text != "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                {
                    item_2.Text = cmb_desserts.Text;
                    item_3.Text = cmb_hotdrinks.Text;
                    item_4.Text = cmb_icedrinks.Text;
                    item_5.Text = "";

                    qty_2.Text = cmb_No_desserts.Text;
                    qty_3.Text = cmb_No_hotdrinks.Text;
                    qty_4.Text = cmb_No_icedrinks.Text;
                    qty_5.Text = "";

                    price_2.Text = cmb_desert_p.Text;
                    price_3.Text = cmb_hot_p.Text;
                    price_4.Text = cmb_ice_p.Text;
                    price_5.Text = "";

                }
                                              
                
                    // coffe , no milkshake ,no desert,hot & cool
                  else if(cmb_milkshakes.Text =="" && cmb_desserts.Text =="" && cmb_hotdrinks.Text !=""  && cmb_icedrinks.Text!="")
                  {
                      
                        item_2.Text = cmb_hotdrinks.Text;
                        item_3.Text = cmb_icedrinks.Text;
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_hotdrinks.Text;
                        qty_3.Text = cmb_No_icedrinks.Text;
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_hot_p.Text;
                        price_3.Text = cmb_ice_p.Text;
                        price_4.Text = "";
                        price_5.Text = "";

                }
                    // coffe , no milkshake ,no desert,no hot & cool
                    else if (cmb_milkshakes.Text == "" && cmb_desserts.Text == "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text != "")
                    {
                       
                       
                        item_2.Text = cmb_icedrinks.Text;
                        item_3.Text = "";
                        item_4.Text = "";
                        item_5.Text = "";

                        qty_2.Text = cmb_No_icedrinks.Text;
                        qty_3.Text = "";
                        qty_4.Text = "";
                        qty_5.Text = "";

                        price_2.Text = cmb_ice_p.Text;
                        price_3.Text = "";
                        price_4.Text = "";
                        price_5.Text = "";

                }

                // coffe , milkshake ,no desert,no hot & no cool
                else if (cmb_milkshakes.Text != "" && cmb_desserts.Text == "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text == "")
                {
                    item_2.Text = cmb_milkshakes.Text;
                    item_3.Text = "";
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_2.Text = cmb_No_milkshakes.Text;
                    qty_3.Text = "";
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_2.Text = cmb_milk_p.Text;
                    price_3.Text = "";
                    price_4.Text = "";
                    price_5.Text = "";
                }


                // coffe , no milkshake ,desert,no hot & no cool
                else if (cmb_milkshakes.Text == "" && cmb_desserts.Text != "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text == "")
                {
                    item_2.Text = cmb_desserts.Text;
                    item_3.Text = "";
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_2.Text = cmb_No_desserts.Text;
                    qty_3.Text = "";
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_2.Text = cmb_desert_p.Text;
                    price_3.Text = "";
                    price_4.Text = "";
                    price_5.Text = "";
                }


                // coffe , no milkshake ,no desert,hot & cool
                else if (cmb_milkshakes.Text == "" && cmb_desserts.Text == "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                {
                    item_2.Text = cmb_hotdrinks.Text;
                    item_3.Text = cmb_icedrinks.Text;
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_2.Text = cmb_No_hotdrinks.Text;
                    qty_3.Text = cmb_No_icedrinks.Text;
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_2.Text = cmb_hot_p.Text;
                    price_3.Text = cmb_ice_p.Text;
                    price_4.Text = "";
                    price_5.Text = "";
                }


                // coffe , milkshake ,desert,no hot & no cool
                else if (cmb_milkshakes.Text != "" && cmb_desserts.Text != "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text == "")
                {
                    item_2.Text = cmb_milkshakes.Text;
                    item_3.Text = cmb_desserts.Text;
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_2.Text = cmb_No_milkshakes.Text;
                    qty_3.Text = cmb_No_desserts.Text;
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_2.Text = cmb_milk_p.Text;
                    price_3.Text = cmb_desert_p.Text;
                    price_4.Text = "";
                    price_5.Text = "";
                }


                // coffe , no milkshake ,desert,hot & no cool
                else if (cmb_milkshakes.Text == "" && cmb_desserts.Text != "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text == "")
                {
                    item_2.Text = cmb_desserts.Text;
                    item_3.Text = cmb_hotdrinks.Text;
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_2.Text = cmb_No_desserts.Text;
                    qty_3.Text = cmb_No_hotdrinks.Text;
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_2.Text = cmb_desert_p.Text;
                    price_3.Text = cmb_hot_p.Text;
                    price_4.Text = "";
                    price_5.Text = "";
                }


                // coffe ,milkshake ,no desert,no hot & cool
                else if (cmb_milkshakes.Text != "" && cmb_desserts.Text == "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text != "")
                {
                    item_2.Text = cmb_milkshakes.Text;
                    item_3.Text = cmb_icedrinks.Text;
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_2.Text = cmb_No_milkshakes.Text;
                    qty_3.Text = cmb_No_icedrinks.Text;
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_2.Text = cmb_milk_p.Text;
                    price_3.Text = cmb_ice_p.Text;
                    price_4.Text = "";
                    price_5.Text = "";
                }


                // coffe ,milkshake ,no desert,hot & no cool
                else if (cmb_milkshakes.Text != "" && cmb_desserts.Text == "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text == "")
                {
                    item_2.Text = cmb_milkshakes.Text;
                    item_3.Text = cmb_hotdrinks.Text;
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_2.Text = cmb_No_milkshakes.Text;
                    qty_3.Text = cmb_No_hotdrinks.Text;
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_2.Text = cmb_milk_p.Text;
                    price_3.Text = cmb_hot_p.Text;
                    price_4.Text = "";
                    price_5.Text = "";
                }


                // coffe , no milkshake ,desert,no hot & cool
                else if (cmb_milkshakes.Text == "" && cmb_desserts.Text != "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text != "")
                {
                    item_2.Text = cmb_desserts.Text;
                    item_3.Text = cmb_icedrinks.Text;
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_2.Text = cmb_No_desserts.Text;
                    qty_3.Text = cmb_No_icedrinks.Text;
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_2.Text = cmb_desert_p.Text;
                    price_3.Text = cmb_ice_p.Text;
                    price_4.Text = "";
                    price_5.Text = "";
                }


                // coffe ,milkshake ,desert,hot & no cool
                else if (cmb_milkshakes.Text != "" && cmb_desserts.Text != "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text == "")
                {
                    item_2.Text = cmb_milkshakes.Text;
                    item_3.Text = cmb_desserts.Text;
                    item_4.Text = cmb_hotdrinks.Text;
                    item_5.Text = "";

                    qty_2.Text = cmb_No_milkshakes.Text;
                    qty_3.Text = cmb_No_desserts.Text;
                    qty_4.Text = cmb_No_hotdrinks.Text;
                    qty_5.Text = "";

                    price_2.Text = cmb_milk_p.Text;
                    price_3.Text = cmb_desert_p.Text;
                    price_4.Text = cmb_hot_p.Text;
                    price_5.Text = "";
                }


                // coffe ,milkshake ,no desert,hot & cool
                else if (cmb_milkshakes.Text != "" && cmb_desserts.Text == "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text != "")
                {
                    item_2.Text = cmb_milkshakes.Text;
                    item_3.Text = cmb_hotdrinks.Text;
                    item_4.Text = cmb_icedrinks.Text;
                    item_5.Text = "";

                    qty_2.Text = cmb_No_milkshakes.Text;
                    qty_3.Text = cmb_No_hotdrinks.Text;
                    qty_4.Text = cmb_No_icedrinks.Text;
                    qty_5.Text = "";

                    price_2.Text = cmb_milk_p.Text;
                    price_3.Text = cmb_hot_p.Text;
                    price_4.Text = cmb_ice_p.Text;
                    price_5.Text = "";
                }


                // coffe ,milkshake ,desert,no hot & cool
                else if (cmb_milkshakes.Text != "" && cmb_desserts.Text != "" && cmb_hotdrinks.Text == "" && cmb_icedrinks.Text != "")
                {
                    item_2.Text = cmb_milkshakes.Text;
                    item_3.Text = cmb_desserts.Text;
                    item_4.Text = cmb_icedrinks.Text;
                    item_5.Text = "";

                    qty_2.Text = cmb_No_milkshakes.Text;
                    qty_3.Text = cmb_No_desserts.Text;
                    qty_4.Text = cmb_No_icedrinks.Text;
                    qty_5.Text = "";

                    price_2.Text = cmb_milk_p.Text;
                    price_3.Text = cmb_desert_p.Text;
                    price_4.Text = cmb_ice_p.Text;
                    price_5.Text = "";
                }


                // coffe ,no milkshake ,no desert,hot & no cool
                else if (cmb_milkshakes.Text == "" && cmb_desserts.Text == "" && cmb_hotdrinks.Text != "" && cmb_icedrinks.Text == "")
                {
                    item_2.Text = cmb_hotdrinks.Text;
                    item_3.Text = "";
                    item_4.Text = "";
                    item_5.Text = "";

                    qty_2.Text = cmb_No_hotdrinks.Text;
                    qty_3.Text = "";
                    qty_4.Text = "";
                    qty_5.Text = "";

                    price_2.Text = cmb_hot_p.Text;
                    price_3.Text = "";
                    price_4.Text = "";
                    price_5.Text = "";
                }
                calTotal();
            }
        }

        private void Person1_Load(object sender, EventArgs e)
        {

            load_coffee();
            load_desert();
            load_milkshake();
            load_hotdrink();
            load_icedrink();



        }
        public void load_coffee()
        {
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter da = new SqlDataAdapter("select * from coffee", cs);

            DataTable dt = new DataTable();


            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_coffee.Items.Add(dt.Rows[i]["item_name"]);
               cmb_coffee_p.Items.Add(dt.Rows[i]["item_price"]);

            }
        }
        public void load_desert()
        {
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter da = new SqlDataAdapter("select * from desert", cs);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_desserts.Items.Add(dt.Rows[i]["item_name"]);
                cmb_desert_p.Items.Add(dt.Rows[i]["item_price"]);

            }
        }
        public void load_milkshake()
        {
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter da = new SqlDataAdapter("select * from milkshake", cs);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_milkshakes.Items.Add(dt.Rows[i]["item_name"]);
                cmb_milk_p.Items.Add(dt.Rows[i]["item_price"]);

            }
        }
        public void load_hotdrink()
        {
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter da = new SqlDataAdapter("select * from hotdrink", cs);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_hotdrinks.Items.Add(dt.Rows[i]["item_name"]);
                cmb_hot_p.Items.Add(dt.Rows[i]["item_price"]);

            }
        }
        public void load_icedrink()
        {
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter da = new SqlDataAdapter("select * from icedrink", cs);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_icedrinks.Items.Add(dt.Rows[i]["item_name"]);
                cmb_ice_p.Items.Add(dt.Rows[i]["item_price"]);

            }
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            cmb_coffee.Text = string.Empty;
            cmb_milkshakes.Text = string.Empty;
            cmb_desserts.Text = string.Empty;
            cmb_hotdrinks.Text = string.Empty;
            cmb_icedrinks.Text = string.Empty;

            cmb_No_coffee.Text = string.Empty;
            cmb_No_milkshakes.Text = string.Empty;
            cmb_No_desserts.Text = string.Empty;
            cmb_No_hotdrinks.Text = string.Empty;
            cmb_No_icedrinks.Text = string.Empty;

            cmb_coffee_p.Text = string.Empty;
            cmb_milk_p.Text = string.Empty;
            cmb_desert_p.Text = string.Empty;
            cmb_hot_p.Text = string.Empty;
            cmb_ice_p.Text = string.Empty;

            item_1.Text = string.Empty;
            item_2.Text = string.Empty;
            item_3.Text = string.Empty;
            item_4.Text = string.Empty;
            item_5.Text = string.Empty;

            qty_1.Text = string.Empty;
            qty_2.Text = string.Empty;
            qty_3.Text = string.Empty;
            qty_4.Text = string.Empty;
            qty_5.Text = string.Empty;

            price_1.Text = string.Empty;
            price_2.Text = string.Empty;
            price_3.Text = string.Empty;
            price_4.Text = string.Empty;
            price_5.Text = string.Empty;


            MessageBox.Show("Oder Cleared", "Cleare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            PayBill frm = new PayBill();
            this.Hide();
            frm.Show();
        }

        private void lbl_dessert_Click(object sender, EventArgs e)
        {

        }

        private void cmb_coffee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();

            string sqlQry = "select* from coffee where item_name ='" + cmb_coffee.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlQry, connection);

            SqlDataReader rdr = cmd.ExecuteReader();

            fndataLoad();

            rdr.Close();
            connection.Close();
        }
        public void fndataLoad()
        {
            //string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wONd3r\Documents\cw2.mdf;Integrated Security=True;Connect Timeout=30";
            //SqlDataAdapter da = new SqlDataAdapter("Select * from Salary", connectionstring);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Salary");
            //dataGridView1.DataSource = ds.Tables["Salary"].DefaultView;

        }

        private void cmb_coffee_p_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();

            string sqlQry = "select* from coffee where item_name ='" + cmb_coffee.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlQry, connection);

            SqlDataReader rdr = cmd.ExecuteReader();

            fndataLoad();

            while (rdr.Read())
            {
                cmb_coffee.Text = rdr.GetString(1);
                // cmb_ice_p.Text = rdr.GetString(2);
            }
        }

        private void cmb_milkshakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();

            string sqlQry = "select* from milkshake where item_name ='" + cmb_milkshakes.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlQry, connection);

            SqlDataReader rdr = cmd.ExecuteReader();

            fndataLoad();

            while (rdr.Read())
            {
                cmb_milkshakes.Text = rdr.GetString(1);
                // cmb_ice_p.Text = rdr.GetString(2);
            }

        }

        private void cmb_desserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();

            string sqlQry = "select* from desert where item_name ='" + cmb_desserts.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlQry, connection);

            SqlDataReader rdr = cmd.ExecuteReader();

            fndataLoad();

            while (rdr.Read())
            {
                cmb_desserts.Text = rdr.GetString(1);
                // cmb_ice_p.Text = rdr.GetString(2);
            }


        }

        private void cmb_hotdrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();

            string sqlQry = "select* from hotdrink where item_name ='" + cmb_hotdrinks.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlQry, connection);

            SqlDataReader rdr = cmd.ExecuteReader();

            fndataLoad();

            while (rdr.Read())
            {
                cmb_hotdrinks.Text = rdr.GetString(1);
                // cmb_ice_p.Text = rdr.GetString(2);
            }


        }

        private void cmb_icedrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();

            string sqlQry = "select* from icedrink where item_name ='" + cmb_icedrinks.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlQry, connection);

            SqlDataReader rdr = cmd.ExecuteReader();

            fndataLoad();

            while (rdr.Read())
            {
                cmb_icedrinks.Text = rdr.GetString(1);
               // cmb_ice_p.Text = rdr.GetString(2);
            }
        }
            public void calTotal()
        {
            int total;

            if (cmb_No_coffee.Text == "0" || cmb_No_coffee.Text == "")
            {

                int coffee;

                coffee = Convert.ToInt32(cmb_No_coffee.Text);
                coffee = 0;
                total = Convert.ToInt32(cmb_No_coffee.Text) * Convert.ToInt32(cmb_coffee_p.Text) + Convert.ToInt32(cmb_desert_p.Text) * Convert.ToInt32(cmb_No_desserts.Text) + Convert.ToInt32(cmb_milk_p.Text) * Convert.ToInt32(cmb_No_milkshakes.Text) + Convert.ToInt32(cmb_hot_p.Text) * Convert.ToInt32(cmb_No_hotdrinks.Text) + Convert.ToInt32(cmb_ice_p.Text) * Convert.ToInt32(cmb_No_icedrinks.Text);

                lbl_total.Text = total.ToString();
            }
            else

                total = Convert.ToInt32(price_1.Text) * Convert.ToInt32(qty_1.Text) + Convert.ToInt32(price_2.Text) * Convert.ToInt32(qty_2.Text);
                //+ Convert.ToInt32(price_3.Text) * Convert.ToInt32(qty_3.Text) + Convert.ToInt32(price_4.Text) * Convert.ToInt32(qty_4.Text) + Convert.ToInt32(price_5.Text) * Convert.ToInt32(qty_5.Text);

                lbl_total.Text = total.ToString();
            


        }


    }

}
