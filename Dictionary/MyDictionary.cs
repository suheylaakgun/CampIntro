using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        //*****add*****

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            // check if the array contains key
            bool containsKey = keys.Contains(key);
            if (containsKey)
            {
                string msg = key + " nolu key eklenemez. Zaten tanımlı!";
                Exception ex = new Exception(msg);
                throw ex;
            }
            else
            {
                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }
        }

            public int Length
            {
                get { return keys.Length; }

            }

            public TKey[] Keys
            {
                get { return keys; }
            }

            public TValue[] Values
            {
                get { return values; }
            }
    }

        //**********
    }

