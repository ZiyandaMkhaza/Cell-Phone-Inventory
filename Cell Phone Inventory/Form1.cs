using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory //THERE AN INTERDEPENDENCY BETWEEN ALL THESE CLASSES
{
    public partial class Form1 : Form //the interaction between the classes and the UI
    {
        Store myStore = new Store(); //this is the instantiation of a new object called "myStore". Tis will enable us to extract information in the Store class. This object has to be created on class-level
        public Form1()
        {
            InitializeComponent();
        }

       private void addPhoneButton_Click(object sender, EventArgs e)
       {
        //CellPhone myPhone = new CellPhone(); //this is the call to the default constructor to install default values. 
             
            //below are objects created using the defaul constructor
        //  myPhone.brand = brandTextBox.Text;
        //  myPhone.model = modelTextBox.Text;
        //  myPhone.price = Convert.ToDouble(priceTextBox.Text); //the text in the textbox should be converted to a double value

            CellPhone myPhone = new CellPhone(brandTextBox.Text, modelTextBox.Text, Convert.ToDouble(priceTextBox.Text)); //this is a call to the parameterised constructor
            myStore.AddPhone(myPhone); //this adds the phones in the Store class (storeroom) into the list of phones. This is the integration of two class under one class.

            brandTextBox.Clear(); //after each entry onto the listbox, the textboxes below will clear
            modelTextBox.Clear();
            priceTextBox.Clear();

            brandTextBox.Focus(); //after all the listboxes have been cleared any data, focus will be brought back to the Brand textbox in order for us to type the next one.
       }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        { //this will display all the phones entered.
            myStore.ToListBox(lsbDisplay);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lsbDisplay.SelectedIndex - 1;
            myStore.RemovePhone(myStore.phoneList[index]); //the data on a particular index off-by-one will be removed

            myStore.ToListBox(lsbDisplay); //this will remove the data instanteously by returning the listbox to normal 
        }
    }
}
