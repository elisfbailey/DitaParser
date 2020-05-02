using System;
using System.Collections.Generic;

namespace DitaParser
{
    public class TestClass
    {
        public string MyProperty { get; set; }
        public string OtherProperty { get; set; }

        public TestClass() { }

        public TestClass(string propertyOne, string propertyTwo)
        {
            this.MyProperty = propertyOne;
            this.OtherProperty = propertyTwo;
        }

        public string CombineProperties()
        {
            string combine = this.MyProperty + " " + this.OtherProperty;
            return combine;
        }

    }
    public class ElinorClass
    {
        // Gets/sets the InputProperty
        public string InputProperty { get; set; }

        // Creates a new list
        public List<string> inputList = new List<string>();


        // Initialises new instance of ListClass with one input variable
        public ElinorClass(string input)
        {
            this.InputProperty = input;
        }

        // Adds InputProperty to the created list
        public string CreateList(string InputProperty)
        {
            string create = inputList.Add(this.InputProperty);
            return create;

        }

        // returns each entry in the list with a comma separator
        public string SeparateList()
        {
            foreach (string item in inputList)
            {
                string formatted = this.InputProperty + ", ";
                return formatted;
            }
        }
    }
}

