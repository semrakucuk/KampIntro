using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMyDictionary
{
    class Dictionary<Keys, Values>
    {
        Keys[] _keys;
        Values[] _values;

        Keys[] _tempKeys;
        Values[] _tempValue;

        public Dictionary()
        {
            _keys = new Keys[0];
            _values = new Values[0];
        }

        public void Add(Keys key, Values value)
        {
            _tempKeys = _keys;
            _keys = new Keys[_keys.Length + 1];
            for (int i = 0; i <= _tempKeys.Length-1; i++)
            {
                _keys[i] = _tempKeys[i];
            }
            _keys[_keys.Length - 1] = key;


            _tempValue = _values;
            _values = new Values[_values.Length + 1]; 
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _values[i] = _tempValue[i];
            } 
            _values[_values.Length - 1] = value;

        }

        public int Count
        {
            get
            {
                return _keys.Length; 
            }
        }

        public Keys[] key
        {
            get { return _keys; }
        }

        public Values[] value
        {
            get { return _values; }
        }

    }
}
