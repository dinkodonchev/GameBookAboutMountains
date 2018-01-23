using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBookTheGreatMountainHike.Constants.Pages
{
    class Page
    {

        private int number;
        

        public Page(int number)
        {
            this.Number = number;

        }

        public int Number { 
            get
            {
                return number;
            }
             
            
            set 
            {
                number = value;
            }
        
        }

        public void WritePageContent() 
        {
            //int[] arrPages = new int[300];
            //ToDo - Implement logic, which takes  
            string pageText = "";
            switch (number) 
            {
                case 2:
                    pageText = "Hello Shepherd";
                    break;
                case 3:
                    pageText = "Hello Hunter";
                    break;
                case 4:
                    pageText = "Hello Mountaineer";
                    break;
                case 5:
                    pageText = "Hello Explorer";
                    break;
                case 6:
                    pageText = "Page 6";
                    break;
                case 7:
                    pageText = "Amazing - you have picked 'A'!";
                    break;
                case 8:
                    pageText = "Amazing - you have picked 'B'!";
                    break;
                case 9:
                    pageText = "Amazing - you have picked 'C'!";
                    break;
                case 10:
                    pageText = "Amazing - you have picked 'D'!";
                    break;
                case 11:
                    pageText = "Page 6";
                    break;
                case 12:
                    pageText = "Page 6";
                    break;
                case 13:
                    pageText = "Page 6";
                    break;
                case 14:
                    pageText = "Page 6";
                    break;
                case 15:
                    pageText = "Page 6";
                    break;
                default:
                    pageText = "";
                    break;
            }
            Console.WriteLine(pageText);
        }

    }
}
