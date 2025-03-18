using System;

namespace MyStringNamespace
{
    public class MyString
    {
        char[] _myStr;
        public string String { get => new string(_myStr); }
        public MyString()
        {
            _myStr = default;
        }
        public MyString(string str)
        {
            _myStr = str.ToCharArray();
        }
        public MyString(char[] arr)
        {
            _myStr = arr;
        }
        public MyString(string[] arr)
        {
            _myStr = string.Join("", arr).ToCharArray();
        }
        public bool Compare(MyString str)
        {
            if (str._myStr.Length != _myStr.Length)
                return false;
            for (int i = 0; i < _myStr.Length; i++)
            {
                if (_myStr[i] != str._myStr[i])
                    return false;
            }
            return true;
        }
        public static bool operator ==(MyString str1, MyString str2)
        {
            if (str1 is null || str2 is null)
                return false;
            if (str1._myStr.Length != str2._myStr.Length)
                return false;
            for (int i = 0; i < str1._myStr.Length; i++)
            {
                if (str1._myStr[i] != str2._myStr[i])
                    return false;
            }
            return true;
        }
        public static bool operator !=(MyString str1, MyString str2)
        {
            if (str1 is null || str2 is null)
                return true;
            if (str1._myStr.Length != str2._myStr.Length)
                return true;
            for (int i = 0; i < str1._myStr.Length; i++)
            {
                if (str1._myStr[i] != str2._myStr[i])
                    return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj is MyString)
            {
                MyString str = (MyString)obj;
                if (new string(this._myStr) == new string(str._myStr))
                    return true;
            }
            return false;
        }
        new public static bool Equals(object obj1, object obj2)
        {
            if (obj1 is MyString && obj2 is MyString)
            {
                MyString str1 = (MyString)obj1;
                MyString str2 = (MyString)obj2;
                if (new string(str1._myStr) == new string(str2._myStr))
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return _myStr.GetHashCode();
        }
        public static string Join(char s, MyString[] strs)
        {
            string retstr = "";
            foreach (var str in strs)
            {
                if (str is null)
                    return "Null";
            }
            foreach (var str in strs)
            {
                retstr = (retstr + s + new string(str._myStr));
            }
            return retstr.Substring(1);
        }
        public bool EndsWith(string substr)
        {
            if (new string(this._myStr).EndsWith(substr))
                return true;
            return false;

        }
        public bool StartsWith(string substr)
        {
            if (new string(this._myStr).StartsWith(substr))
                return true;
            return false;
        }
        public char this[int index]
        {
            get => _myStr[index];
        }
        public static MyString operator +(MyString str1, MyString str2)
        {
            return new MyString(new string(str1._myStr) + new string(str2._myStr));
        }
        public static MyString operator +(MyString str1, string str2)
        {
            return new MyString(new string(str1._myStr) + str2);
        }
    }

}
