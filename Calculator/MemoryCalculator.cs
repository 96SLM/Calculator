using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MemoryCalculator : Calculator
    {
        //parameters
        bool memory;// to emable memory button later
       //bool hasNum;//checks if an item is stored 

        public decimal newStored; //gets recent vale for memory
        public decimal numStored { get; set; } //contains value from newStore
        
        //Methods
        public void StoreMem(decimal numStored)
        {
            //newStored = Convert.ToDecimal(displayString); //display string gives error
            this.numStored = newStored;
            ActiveMem();
            //hasNum = true;
        }

        public void AddToMem()
        {
            if (memory == true) 
            {
                numStored += newStored;
            }
            else
            {
                numStored = numStored;
                //hasNum = true;
            }
        }

        public void ClearMem()
        {
            numStored = 0;
            memory = false; 
           //hasNum = false;
        }

        public decimal RecallMem()
        {
            return numStored;
        }

        public void ActiveMem () => memory = true;

    }
}
