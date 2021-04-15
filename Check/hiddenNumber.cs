using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class hiddenNumber
    {
        public List<int> value { get; set; }
        /// <summary>
        /// длина загаданного слова
        /// </summary>
        /// <param name="thNumberOfCharactersInTheValue"></param>
        public hiddenNumber(int thNumberOfCharactersInTheValue)
        {
            var rnd = new Random();
            value.Add(rnd.Next(0, 10));
            
            do
            {
                bool Flag = false;
                var addItem = rnd.Next(0, 10);
                foreach (var item in value)
                {
                    if (item == addItem)
                    {
                        Flag = false;
                        break;
                    }
                    Flag = true;
                }

                if (Flag == true)
                {
                    value.Add(addItem);
                }
            }
            while (value.Count != thNumberOfCharactersInTheValue);
        }
    }
}
