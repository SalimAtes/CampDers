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
        public void Add(key nkey, value nvalue)
        {
            key[] tempKey = keys;
            value[] tempValue = values;

            keys = new key[keys.Length + 1];
            values = new value[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];

            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = nkey;
            values[values.Length - 1] = nvalue;
        }
        public void Read()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + "  " + values[i]);
            }
            
        }
    }
}
