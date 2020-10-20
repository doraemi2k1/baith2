using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithso2
{
    class Stack
    {
        private int top;
        private int[] s;
        public Stack()
        {
            top = -1;
            s = new int[20];
        }
        public Stack(int n)
        {
            top = -1;
            s = new int[n];

        }
        public bool Full()
        {
            return top == s.Length - 1;
        }
        public bool Empty()
        {
            return top == -1;
        }
        public void Push(int x)
        {
            if (Full()) Console.WriteLine("Stack day");
            else s[++top] = x;
        }
        public int Pop()
        {
            if (Empty()) throw new Exception("Stack rong");
            else
            {
                int x = s[top--];
                return x;
            }
        }
    }
    class Hexa
    {
        private int n;
        private Stack s;
        public void NHAP()
        {

            Console.Write("Nhap so nguyen n=");
            n = int.Parse(Console.ReadLine());

        }
        public void Chuyencoso()
        {
            s = new Stack();
            string st = "0123456789ABCDEF";
            while (n != 0)
            {
                s.Push((int)st[n % 16]);
                n = n / 16;
            }
            while (!s.Empty())
                Console.Write((char)s.Pop());

        }

    }

    class Program
    {
        static void Main1(string[] args)
        {

            Hexa t = new Hexa();
            t.NHAP();
            t.Chuyencoso();

            Console.ReadKey();



        }
    }
}

//BAI2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithso2
{
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = 0; ms = 1;
        }
        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public PS(PS t2)
        {
            this.ts = t2.ts;
            this.ms = t2.ms;
        }

        public PS Tong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms + t2.ts * this.ms;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS Hieu(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms - t2.ts * this.ms;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Nhan(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS CHIA(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            return t.Rutgon();
        }
        public static bool operator ==(PS t1, PS t2)
        {
            return t1.ts * t2.ms == t2.ts * t1.ms;
        }
        public static bool operator !=(PS t1, PS t2)
        {
            return t1.ts * t2.ms != t2.ts * t1.ms;
        }
        public int UCLN(int ts, int ms)
        {
            ts = Math.Abs(ts); ms = Math.Abs(ms);
            while (ts != ms)
            {
                if (ts > ms) ts = ts - ms;
                if (ts < ms) ms = ms - ts;
            }
            return ts;
        }
        public PS Rutgon()
        {
            int uc = UCLN(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }
        public void Hien()
        {
            if (ms == 1) Console.WriteLine("{0}", ts);
            else if (ts == 0) Console.WriteLine("{0}", 0);
            else Console.WriteLine("{0}/{1}", ts, ms);
        }
        public static bool operator >(PS t1, PS t2)
        {
            return t1.ts * t2.ms > t2.ts * t1.ms;
        }
        public static bool operator <(PS t1, PS t2)
        {
            return t1.ts * t2.ms < t2.ts * t1.ms;
        }



    }
    class APP
    {
        static void Main2()
        {
            PS t1 = new PS(4, 5);
            PS t2 = new PS(9, 10);
            Console.Write(" Tong 2 phan so la: ");
            PS t = t1.Tong(t2);
            t.Hien();
            Console.Write(" Hieu 2 phan so la: ");
            PS t3 = t1.Hieu(t2);
            t3.Hien();
            Console.Write(" Nhan 2 phan so bang: ");
            PS t4 = t1.Nhan(t2);
            t4.Hien();
            Console.Write(" chia 2 phan so bang: ");
            PS t5 = t1.CHIA(t2);
            t5.Hien();
            if (t1 == t2) Console.WriteLine("Hai phan so bang nhau");
            else Console.WriteLine("Hai phan so khong bang nhau");
            if (t1 > t2) Console.WriteLine("t1>t2");
            else Console.WriteLine("t1<=t2");
            Console.ReadKey();
        }
    }
}
//BAI3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithso2
{
    class Queue
    {
        private int dau, cuoi;
        private int[] q;
        public Queue()
        {
            dau = cuoi = 0;
            q = new int[20];
        }
        public Queue(int n)
        {
            dau = cuoi = 0;
            q = new int[n];

        }
        public bool isFull()
        {
            return cuoi >= q.Length - 1;
        }
        public bool isEmpty()
        {
            return dau == 0;
        }
        public void Push(int x)
        {
            if (isFull()) Console.WriteLine("Stack day");
            else
            {
                cuoi++;
                q[cuoi] = x;
            }
        }
        public int Pop()
        {
            if (isEmpty()) throw new Exception("Stack rong");
            else
            {
                int x = q[dau];
                dau--;
                return x;
            }
        }
    }
}
//BAI4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithso2
{
    class DATHUC
    {
        private int n;
        private int[] a;
        public DATHUC()
        {
            n = 0; a = new int[0];
        }
        public DATHUC(int n)
        {
            this.n = n;
            a = new int[n];
        }
        public void Nhap()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Hien()
        {
            for (int i = 0; i < n; i++)
                Console.Write("{0}\n", a[i]);
            Console.WriteLine();
        }
        public DATHUC Tong(DATHUC T2)
        {
            if (this.n == T2.n)
            {
                DATHUC t = new DATHUC(this.n);
                for (int i = 0; i < n; i++)

                    t.a[i] = this.a[i] + T2.a[i];
                return t;
            }
            else return null;
        }
        public DATHUC Hieu(DATHUC T2)
        {
            if (this.n == T2.n)
            {
                DATHUC t = new DATHUC(this.n);
                for (int i = 0; i < n; i++)

                    t.a[i] = this.a[i] - T2.a[i];
                return t;
            }
            else return null;
        }

    }
    class App2
    {
        static void Main3()
        {
            Console.WriteLine("Nhap thong tin da thuc thu 1");
            DATHUC t1 = new DATHUC(4); t1.Nhap();
            Console.WriteLine("Nhap thong tin da thuc thu 2");
            DATHUC t2 = new DATHUC(4); t2.Nhap();

            DATHUC t3 = t1.Tong(t2);
            if (t3 == null)
                Console.WriteLine("Hai da thuc co kich co khac nhau");
            else
            {
                Console.WriteLine("Tong hai da thuc");
                t3.Hien();
            }
            DATHUC t4 = t1.Hieu(t2);
            if (t4 == null)
                Console.WriteLine("Hai da thuc co kich co khac nhau");
            else
            {
                Console.WriteLine("Hieu hai da thuc");
                t4.Hien();
            }
            Console.ReadKey();
        }
    }
}
//BAI5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithso2
{
    class Data
    {
        private int day, month, year;
        public Data(DateTime dt)
        {
            day = dt.Day;
            month = dt.Month;
            year = dt.Year;
        }
        public void Hien()
        {
            Console.WriteLine("{0}/{1}/{2}", month, day, year);
        }
    }
    class App3
    {
        static void Main4()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Data t = new Data(currentTime);
            t.Hien();
            Console.ReadKey();
        }
    }
}

