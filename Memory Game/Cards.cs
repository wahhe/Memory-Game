using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Game
{
    public class Cards
    {   
        public string value;
        public int cardTurned;
        public Image front, back;
        
        

        public Cards(string _value, Image _front, Image _back)
        {
            value = _value;
            front = _front;
            back = _back;
            
        }      
        

    }
}
