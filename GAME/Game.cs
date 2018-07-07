using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GAME
{
    public class Game
    {
        //以数组来记录调换后图片的顺序 record[i]=i时为拼好
        //初始顺序 共6张图
        public int[] record = new int[6] { 4, 2, 3, 0, 1 ,5 };

        //记录要修改的是哪两个图片框
        public int first = -1;
        public int second = -1;

        public void Turn(int click)
        {//排列顺序
            if (first == -1)
            {
                first = click;
            }
            else if (second == -1)
            {
                second = click;
            }

            if (first >= 0 && second >= 0)
            {
                int i;
                i = record[first];
                record[first] = record[second];
                record[second] = i;
                first = -1;
                second = -1;
            }
        }

        public bool Win()
        {//判断是否拼好
            int j = 0;
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == i)
                {
                    j++;
                }
            }

            if (j == record.Length)
            {
                return true;
            }
            else
                return false;
        }
    }
}
