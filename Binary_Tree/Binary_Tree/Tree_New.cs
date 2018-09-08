using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Tree_New : Tree
    {
        Item L;
        /// <summary>
        /// конструктор
        /// </summary>
        public Tree_New() : base()
        {
            L = null;
        }

        /// <summary>
        /// удаление самой левой вершины k-того уровня
        /// </summary>
        /// <param name="k">уровень дерева</param>
        public bool Del_Son(int k)
        {
            L = root;
            if (k == 0)
                throw new Exception("Неверно введенный уровень!");
            for (int i = 0; i < k; i++)
            {
                if (L.lSon != null)
                    L = L.lSon;
                else
                    return false;
            }
            Delete(L.info);
            return true;
        }

        private bool Check(Queue<Item> queue)
        {
            foreach (var q in queue)
            {
                if (q != null)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (root == null)
                throw new Exception("Пустое дерево!");
            Queue<Item> queue = new Queue<Item>();
            string answer = "";
            int layer = 1, check_layer = 0, count = 0;
            int r = Console.WindowWidth;
            queue.Enqueue(root);
            while (Check(queue))
            {
                ++check_layer;
                if (queue.Peek() == null)
                {
                    queue.Enqueue(null);
                    queue.Enqueue(null);
                }
                else
                {
                    queue.Enqueue(queue.Peek().lSon);
                    queue.Enqueue(queue.Peek().rSon);
                }
                if (queue.Peek() != null)
                    answer += queue.Peek().info.ToString() + "     ";
                else
                    answer += "-   ";
                queue.Dequeue();
                if (layer == check_layer)
                {
                    layer *= 2;
                    check_layer = 0;
                    answer += Environment.NewLine;
                }
            }
            count = (layer / 4 + 1)*2;
            string buff = "";
            int ind = 0;
            if (count <= r / 2)
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    if (ind != -1)
                        for (int j = 0; j < count * 2; j++)
                            buff += " ";
                    if (i != answer.Length - 1 && answer[i] != '\n' && answer[i + 1] != '\r' ) 
                    {
                        ind = -1;
                        buff += answer[i];
                        if (answer[i + 1] == ' ' && count == 8)
                                buff += " ";
                    }
                    else
                    {
                        buff += Environment.NewLine;
                        ind = 0;
                        count--;
                    }
                }
            }
            return buff;
        }
    }
}
