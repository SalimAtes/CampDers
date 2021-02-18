using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<key,value>
    {
        key[] keys;
        value[] values;
        public MyDictionary()
        {
            keys = new key[0];
            values = new value[0];
        }
        public void Add(key nkey, value nvle)
        {
            key[] tempkey = keys;
            value[] tempvle = values;

            keys = new key[tempkey.Length + 1];
            values = new value[tempvle.Length + 1];

            for (int i = 0; i < tempkey.Length; i++)
            {
                keys[i] = tempkey[i];
               
            }
            for (int i = 0; i < tempvle.Length; i++)
            {
                values[i] = tempvle[i];
            }

            keys[keys.Length - 1] = nkey;
            values[values.Length - 1] = nvle;
        
        
        }
        public void Read()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i]+"   "+values[i]);
            }



        }
        
               
               
                    
                
               


         
        
        
    }
}
