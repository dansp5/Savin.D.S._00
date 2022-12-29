using System;

namespace labb1
{
    class Program
    {   
        // пирамидальная сортировка
        static void Sort(stack st)
        {
            // создаем стек
            st.N++;
            // Получаем его размер
            int size = st.Size();
            st.N+=2;
            // Пирамидальная сортировка 
            for (int i = 0; i < size; i++)
            {
                st.N+=3;
                // откладываем элемент
                for (int j = size-i; j > 1; j--)
                {
                    st.N+=5;
                    // если сын больше родителя, то меняем местами
                    if (st.GetS(j)<st.GetS(j/2))
                    {
                        st.N+=3;
                        st.Swap(j, j / 2);
                    }
                    st.N++;

                }
                st.N+=3;
                st.Push(st.Pop());
            }
            Console.WriteLine("Количество операций: "+st.N);
        }
        static void Main(string[] args)
        {
            Int64 t =0 ;
            Random r = new Random();
            for (int j = 0; j <10 ; j++)
            {
                Console.WriteLine("Тест №"+(j+1)+"\n Количество элементов: "+(1000+j*200));
                stack a = new stack();
                for (int i = 0; i < 1000+j*200; i++)
                {
                    a.Push(r.Next(1,100));
                }
                a.N = 0;
                t=Environment.TickCount;
                Sort(a);
                t = Environment.TickCount - t;
                Console.WriteLine("Время выполнения: "+t);
            }
        }
    }
}
