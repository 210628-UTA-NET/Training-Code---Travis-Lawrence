using System;

namespace HouseFunction
{
    public class House
    {

        private string _color;
        private int _price;
        private string _name;

        //ctor for auto-constructor
        public House()
        {
            Console.WriteLine("House was constructed lolz.");
            _color = "Cyan";
            _price = 0;
            _name = "Nameless.";
        }

        //Old way
        public string getColor(){
            return _color;
        }
        public void setColor(string p_s){
            _color = p_s; //Use a p_ prefix to show a variable is a parameter
        }

        //New way
        //Value is default variable to get naming field
        //Use prop for fast cheaty hacks
        public int Price{
            get{
                return _price;
            }
            set{
                _price = value;
            }
        }
        public string Name { get; set; }
    }
}