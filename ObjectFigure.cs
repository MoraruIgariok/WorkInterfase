using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    internal class ObjectFigure
    {
        public decimal aria { get; set; }   
        public decimal perimeter { get; set; } 
        
        public string ResultValue() 
        {
            return "Aria este: " + aria + "\nPerimeter este: " + perimeter; 
        }   
       
    }
}
