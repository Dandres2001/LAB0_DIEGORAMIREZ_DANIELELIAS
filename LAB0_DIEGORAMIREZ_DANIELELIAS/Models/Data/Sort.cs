using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB0_DIEGORAMIREZ_DANIELELIAS.Models.Data
{
    public sealed class BubbleSort
    {
        private readonly static BubbleSort _instance = new BubbleSort();
        public void BubbleSortByName(List<Client> list) 
        {
            Client temp;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count-1; j++)
                {
                    if (list[j].Name.CompareTo(list[j + 1].Name) > 0)
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        public void BubbleSortByLastName(List<Client> list)
        {
            Client temp;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count-1; j++)
                {
                    if (list[j].LastName.CompareTo(list[j + 1].LastName) > 0)
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        public static BubbleSort Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
