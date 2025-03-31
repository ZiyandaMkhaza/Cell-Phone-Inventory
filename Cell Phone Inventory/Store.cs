using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //refer to Line 22. Line 6 contains the definition of information relating to the listbox, and it essentially allows for the integration of data between the classes

namespace Cell_Phone_Inventory
{
    internal class Store //this class models the storeroom of the store
    {
        public List<CellPhone> phoneList= new List<CellPhone>(); //any object of the CellPhone class will be stored in the list. THIS IS A MEMBER OF A CLASS AND NOT THE DECLARATION
        
        public void AddPhone(CellPhone phone) //a void "void" constructor does not return any value, it will be assisting in pass on values when the "show" object is clicked by the user.
        { 
            phoneList.Add(phone); 
        }
        public void RemovePhone(CellPhone phone) //it is easier to add and remove objects using lists than arrays. It would need us to first ensure that the array is full before editing the array
        {
            phoneList.Remove(phone); //lists provide us with a lot of functionality
        }
        public void ToListBox(ListBox listBox) //this is to assist in passing values onto the listbox. The parameterised object can be used in other classes.
        {
            listBox.Items.Clear();
            listBox.Items.Add($"Brand: \tModel: \tPrice: \t"); //This is the heading, and it does not have an element or index value.
            foreach (CellPhone phone in phoneList) //foreach loops work best with lists. This loop will reiterate each content of a list. It will address data that has been included in  phoneList
            {
                listBox.Items.Add(phone.ToString()); //this will show the brand, model and price on one line in the listbox.
                //this is the usage of the get-set declarations
            }

            
          
        }

    } 
}
