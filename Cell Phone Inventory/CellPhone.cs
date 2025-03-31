using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Inventory //THIS IS THE SUPERCLASS
{
    class CellPhone //this class relates to the data under "enter cellphone data" in the design
    {
       private string _brand; //cannot be used outside the class as: obj.brand
       private string _model; //these variables have been encapsulated in this class. They have been retained within this class by the access modifier "private", to be accessed outside of this class, they need to be publicised by the get-set method.
       private double _price;

        public string brand    // when referring to these members, we use the newly assigned properties, such as "_brand" being now referred to as "brand" from now onwards to other classes.
        {
            get //this is a method
            {
                return _brand;
            }
            set //this is a method
            {
                _brand = value; // a value can be assigned for "brand" outside of this class. This can be done as: obj.brand = "newbrand"."newbrand" is the string that will be placed when referring the brand in this example
            }
        }
        public string model 
        {
            get { return _model;} //"get" is an accessor method
            set {_model = value;} //"set" is a mutator method
        }
        public double price 
        {
            get {return _price;}
            set {_price = value;}
        }

        public CellPhone() //Default constructor without any parameters. Constructors help in the instantiation of objects in other classes
        {
            _brand = "DefaultBrand"; //this is how an empty object will be approached // this is what can also be done to represent a default constructor: " ";
            _model = "DefaultModel";
            _price = 0;
        }
        public CellPhone( string newBrand, string newModel, double  newPrice) //this is a parameterised constructor or an overloaded constructor. We do this when we know what the values of our object will be
        {
            this._brand = newBrand;
            this ._model = newModel;
            this.price = newPrice;
        }

        public override string ToString() //this allows for (refer to line 28 in Store class), to remove the content after "$" to br able to directly write "phone.ToString" and produce the same output
        {
            return $"{brand}\t{model}\t" + price.ToString();
        }
    }
}
