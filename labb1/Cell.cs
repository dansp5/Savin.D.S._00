using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb1
{
    // Ячейка стека
    class Cell
    {
        //Значение ячейки(у первого элемента 0)
        public int Value = 0;
        //ссылка на предыдущую ячеку(у первого элемента null)
        public Cell Prev = null;
        // при создании ячейки отправляются значение и ссылка 
        public Cell(int value=0, Cell prev=null)
        {
            Value = value;
            Prev = prev;
        }
    }
}
