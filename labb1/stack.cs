using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb1
{
    // Стек
    class stack
    {
        //счетчик
        public UInt64 N=1;
        //ссылка на вверхнюю ячейку
        public Cell current = null;
        public stack()
        {
            //инициализация стека(создается дно стека)
            current = new Cell();
            N+=5;
        }
        // Добавление элемента в стек
        public void Push(int value)
        {
            //создается новая ячейка
            current = new Cell(value, current);
            N += 5;
        }
        //Извлечение элемента
        public int Pop()
        {
            //сохраняем значение верхней ячейки
            int temp = this.current.Value;
            N++;
            // Временная переменная для хранение предыдущей ячейки
            Cell previous = this.current.Prev;
            N++;
            // Меняем действующую ячейку на ячейку под ней
            this.current = previous;
            N+=2;
            // передаем значение бывшей верхней ячейки
            return temp;
        }
        //метод для получения значения определенной ячейки без её удаления(на основе базовых метдов АТД)
        public int GetS(int pos=1)
        {
            // временный стек
            stack b = new stack();
            N+=5;
            N++;
            // переменная, в которую мы положим значение
            int num;
            N += 2;
            // перекладываем элементы из нашего стека во временный до нужного элеиента
            for (int i = 1; i < pos; i++)
            {
                N += 3;
                b.Push(this.Pop());
            }
            N++;
            // сохраняем значение
            num = current.Value;
            N += 2;
            // возвращаем все обратно
            for (int i = 1; i < pos; i++)
            {
                N += 3;
                this.Push(b.Pop());
            }
            N++;
            // Передаем значение
            return num;
        }
        // вычисление размера стека с помощью базовых методов АТД
        public int Size()
        {
            N++;
            // переменная, показывающая размер
            int c = 0;
            N += 5;
            // временная ячейка
            Cell buf = current;
            N++;
            // пока не дойдем до дна переходить к предыдущей ячейке
            while (buf.Value!=0)
            {
                N++;
                c++;
                N++;
                buf = buf.Prev;
                N++;
            }
            N++;
            // Передаем значение
            return c;
        }
        // Меняет положение указанных элементов на основе базовых методов АТД 
        public void Swap(int pa , int pb)
        {
            N++;
            // если позиция первого переданного элемента больше второго, то меняем их местами
            if(pa>pb)
            {
                N++;
                int tt = pa;
                N++;
                pa = pb;
                N++;
                pb = tt;
            }
            N+=2;
            //Получаем значение первого переданного элемента
            int va = GetS(pa);
            N+=2;
            //Получаем значение второго переданного элемента
            int vb = GetS(pb);
            N++;
            //Создаем временный стек
            stack t = new stack();
            N += 2;
            //Перекладываем значение стека, пока не дойдем до второго переданного элемента
            for (int i = 1; i < pb; i++)
            {
                N++;
                // если мы встретели первый переданный элемент, то присваеваем ему значение второго
                if(i==pa)
                {
                    N++;
                    current.Value = vb;
                }
                N += 3;
                t.Push(this.Pop());
            }
            N++;
            //присваеваем второму переданному элементу значение первого
            current.Value = va;
            N += 2;
            // собираем стек обратно
            for (int i = 1; i < pb; i++)
            {
                N += 3;
                this.Push(t.Pop());
            }
            N += t.N;
        }

    }
}
