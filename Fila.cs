using System;

namespace Paint
{

    public class Fila
	{
        private object[] elements;
        private int front, rear, tamanho,count;

        public Fila(int tamanho)
        {
            this.tamanho = tamanho;
            elements = new object[tamanho];
            rear = front = 0 ;
            count = 0;
        }

        
        public void Insert(object x)
        {
            if (FilaCheia())
                throw new Exception("Fila Cheia!");
            if (rear == tamanho - 1)
                rear = 0;
            else
                rear++;
            elements[rear] = x;
            count++;
        }


        public object Remove()
        {
            if (FilaVazia())
                throw new Exception("Fila vazia!");
            if (front == tamanho - 1)
                front = 0;
            else
                front++;

            count--;
            return (elements[front]) ;

        }

        public bool FilaVazia()
        {
            if (count==0)
                return true;

            return false;
        }
        public bool FilaCheia()
        {
            if (count == tamanho)
                return true;

            return false;
        }

	}
}
