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
        public List<string> inputList = new List<string>();

        public ElinorClass(string input) {}

        // Adds InputProperty to the created list
        public void CreateList(string var1)
        {
            inputList.Add(var1);
        }

        // returns each entry in the list with a comma separator
        public string SeparateList()
        {
            string formatted = "";
            foreach (string item in inputList)
            {
                formatted = formatted + item + ", ";
                
            }
            formatted.Trim().Trim(',');
            return formatted;
            
        }
    }
}

