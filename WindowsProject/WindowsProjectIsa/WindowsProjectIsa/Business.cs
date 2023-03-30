using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProjectIsa
{
    class Business
    {
        //variabelen voor tegels te controleren
        private int _v1;
        public int V1
        {
            get { return _v1; }
            set { _v1 = value; }
        }

        private int _v2;
        public int V2
        {
            get { return _v2; }
            set { _v2 = value; }
        }

        private int _v3;
        public int V3
        {
            get { return _v3; }
            set { _v3 = value; }
        }

        private int _v4;
        public int V4
        {
            get { return _v4; }
            set { _v4 = value; }
        }

        private int _v5;
        public int V5
        {
            get { return _v5; }
            set { _v5 = value; }
        }

        private int _v6;
        public int V6
        {
            get { return _v6; }
            set { _v6 = value; }
        }

        private int _v7;
        public int V7
        {
            get { return _v7; }
            set { _v7 = value; }
        }

        private int _v8;
        public int V8
        {
            get { return _v8; }
            set { _v8 = value; }
        }

        private int _v9;
        public int V9
        {
            get { return _v9; }
            set { _v9 = value; }
        }

        private int _v10;
        public int V10
        {
            get { return _v10; }
            set { _v10 = value; Generator(); }
        }

        //variabele voor tweemaal knop
        private int _tweemaal;
        public int tweemaal
        {
            get { return _tweemaal; }
            set { _tweemaal = value; }
        }

        //variabele voor de korting
        private int _korting=2;
        public int Korting
        {
            get { return _korting; }
            set { _korting = value; }
        }

        public void Generator()
        {
            Random rnd = new Random();

            _v1 = rnd.Next(1, 3);
            if (_v1 == 1)
            {
                _v2 = 2;
            }
            else
            {
                _v2 = 1;
            }

            _v3 = rnd.Next(1, 3);
            if (_v3 == 1)
            {
                _v4 = 2;
            }
            else
            {
                _v4 = 1;
            }

            _v5 = rnd.Next(1, 3);
            if (_v5 == 1)
            {
                _v6 = 2;
            }
            else
            {
                _v6 = 1;
            }

            _v7 = rnd.Next(1, 3);
            if (_v7 == 1)
            {
                _v8 = 2;
            }
            else
            {
                _v8 = 1;
            }

            _v9 = rnd.Next(1, 3);
            if (_v9 == 1)
            {
                _v10 = 2;
            }
            else
            {
                _v10 = 1;
            }

            _tweemaal = rnd.Next(1, 3);
        }
    }
}
