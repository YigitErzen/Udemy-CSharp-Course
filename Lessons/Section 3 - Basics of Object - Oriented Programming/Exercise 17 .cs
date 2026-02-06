using System;

namespace Coding.Exercise
{
    public class Dog
    {
        private string _name;
        private string _breed;
        private int _weight;
        
        public Dog(string name, string breed, int weight){
            _name = name;
            _breed = breed;
            _weight = weight;
        }

        public Dog(string name, int weight){
            _name = name;
            _breed = "mixed-breed";
            _weight = weight;
        }

        public string Describe()
        {
            string size;

            if(this._weight < 5)
            size = "tiny";
            else if(this._weight >= 5 && this._weight < 30)
            size = "medium";
            else
            size = "large";

            return $"This dog is named {this._name}, it's a {this._breed} and weighs {this._weight} kilograms, so it's a {size} dog";
        }
        
    }
}
