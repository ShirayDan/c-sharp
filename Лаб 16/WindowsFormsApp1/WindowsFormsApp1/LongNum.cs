using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class LongNum
    {
        private int left;
        private int right;

        public LongNum(int left, int right)
        {
            this.left = left;
            this.right = right;
        }
        public LongNum(int left)
        {
            this.left = left;
            this.right = 0;
        }

        public LongNum()
        {

        }
        public int getNumLeft()
        {
            return this.left;
        }
        public int getNumRight()
        {
            return this.right;
        }
        public void  setNumLeft( int left)
        {
             this.left = left;
        }
        public void setNumRight(int right)
        {
             this.right = right;
        }
        public void addNums( LongNum num2)
        {
            int right = this.right + num2.getNumRight();
            int left = 0;
            if (right > 255)
            {
                left = 1;
                right -= 256;

            }
            left += this.left + num2.getNumLeft() ;
            this.setNumRight(right);
            this.setNumLeft(left);
        }
        public void minusNums(LongNum num2)
        {
            int right = this.right - num2.getNumRight();
            int left = this.left - num2.getNumLeft();
            if (right < -255)
            {
                left -= 1;
                right += 256;

            }
            this.setNumRight(right);
            this.setNumLeft(left);
        }
        public void mulNums(LongNum num2)
        {
            int right = this.right * num2.getNumRight();
            int left = 0;
            while (right > 255)
            {
                left += 1;
                right -= 255;
            }
            left += this.left * num2.getNumLeft();
            this.setNumRight(right);
            this.setNumLeft(left);
        }
        public int divideNums(LongNum num2)
        {

            int left = this.left / num2.getNumLeft();
            int right = (this.left % num2.getNumLeft() + this.right) / num2.getNumRight();
            //int rest = (this.left % num2.getNumLeft() + this.right) % num2.getNumRight();
            int rest = (this.left % num2.getNumLeft());
            this.setNumRight(right);
            this.setNumLeft(left);
            return rest;
        }
        public string compare(LongNum num2)
        {
            if (this.left == num2.getNumLeft() && this.right == num2.getNumRight())
            {
                return "Equal";
            }
            else if (this.left > num2.getNumLeft() || this.right > num2.getNumRight())
            {
                return "More";
            }
            else
            {
                return "Less";
            }
        }
        public bool compareMore(LongNum num2)
        {
            if (this.left >= num2.getNumLeft() && this.right >= num2.getNumRight())
            {
                return true;
            }
            return false;
        }
        public bool equal(LongNum num2)
        {
            return this.left == num2.getNumLeft() && this.right == num2.getNumRight() 
                ? true 
                : false;
        }
    }


}
