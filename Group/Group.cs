using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    internal class Group
    {
        public Group(int num)
        {
            if (this._studentLimit >= 0 && this._studentLimit <= num)
                this._studentLimit = num;
        }
        private string _groupNo;
        private int _studentLimit;
        private string[] _name;
        private string[] _surname;
        public string GroupNo { get { return this._groupNo; } set { 
                this._groupNo = value; 
            } }
        public int StudentLimit { get { return this._studentLimit; } set { this._studentLimit = value; } }
        public string[] Name {get => this._name;
                set
            {
               this._name = value;
            }
        }
        public string[] Surname {   get { return this._surname; } set { this._surname = value; } }
        public void GetInfo()
        {
            for (int i = 0; i < Name.Length; i++)
            {
                Console.WriteLine($"GroupNo : {GroupNo} - Ad : {Name[i]} - Soyad : {Surname[i]}");
            }
        }
    }
}
