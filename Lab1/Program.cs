#:property PublishAot=false

using System;

namespace Lab1
{
    class Cau1
    {
        public static void Run()
        {
            Console.Write("Nhập số: ");
            int n = int.Parse(Console.ReadLine());

            int tram = n / 100;
            int chuc = n / 10 % 10;
            int donvi = n % 10;

            Console.WriteLine(
                $"Số {n} có: {tram} trăm {chuc} chục {donvi} đơn vị"
            );
        }
    }

    class Cau2
    {
        public static void Run()
        {
            Console.Write("Nhap So: ");
            int n = int.Parse(Console.ReadLine());

            int tram = n / 100;
            int chuc = n / 10 % 10;
            int donvi = n % 10;

            int tong = tram * tram * tram
                       + chuc * chuc * chuc
                       + donvi * donvi * donvi;

            if (n == tong)
            {
                Console.WriteLine("La so Armstrong");
            }
            else
            {
                Console.WriteLine("Khong phai so Armstrong");
            }
        }
    }

    class Cau3
    {
        public static void Run()
        {
            double ketqua = 1;

            Console.Write("So nguyen x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("So nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            n = Math.Abs(n);

            for (int i = 0; i < n; i++)
            {
                ketqua *= x;
            }

            Console.WriteLine("Ket qua = " + ketqua);
        }
    }

    class Cau4
    {
        public static void Run()
        {
            double total = 0;

            Console.Write("So nguyen x: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                total += x * i;
            }

            Console.WriteLine("Ket qua = " + total);
        }
    }

    class Cau5
    {
        public static void Run()
        {
            Console.Write("Ban kinh hinh tron R: ");
            double r = double.Parse((Console.ReadLine()));

            double cvhinhtron = 2 * Math.PI * r;
            Console.WriteLine("Chu vi hinh tron la: " + cvhinhtron);
            double dientichhinhtron = Math.PI * r * r;
            Console.WriteLine("Dien tich hinh tron: " + dientichhinhtron);

            Console.Write("Canh tam giac A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Canh tam giac B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Canh tam giac C: ");
            double c = double.Parse(Console.ReadLine());

            double chuvitamgiac = a + b + c;
            ;
            double dientichtamgiac =
                Math.Sqrt(chuvitamgiac * (chuvitamgiac - a) * (chuvitamgiac - b) * (chuvitamgiac - c));

            Console.WriteLine("Chieu dai: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Chieu Rong: ");
            double w = double.Parse(Console.ReadLine());

            double chuvihinhchunhat = (h + w) * 2;
            Console.WriteLine("Chu vi hinh nhat la: " + chuvihinhchunhat);
            double dientichhinhchunhat = h * w;
            Console.WriteLine("Dien tich hinh chu nhat la: " + dientichhinhchunhat);

        }
    }

    class Cau6
    {
        public static void Run()
        {
            int[] array = new int[10]; // khai bao mang 10
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                array[i] = int.Parse(Console.ReadLine());
            }

// Tính tổng các phần tử trong mảng
            int total = 0; // tong phan tu 
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }

            Console.WriteLine(total);
// Đếm số phần tử chẵn/ lẻ trong mảng
            int count_chan = 0;
            int count_le = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count_chan++;
                }
                else
                {
                    count_le++;
                }
            }

            Console.WriteLine("So phan tu le:" + count_le);
            Console.WriteLine("So phan tu chan: " + count_chan);

            // Tìm phần tử lớn nhất/ nhỏ nhất trong mảng
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Phan tu lon nhat" + max);
            Console.WriteLine("Phan tu nho nhat " + min);

            // Sắp xếp mảng tăng dần

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Mang tang dan:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");

            }
            // Sắp xếp mảng giảm dần

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

                Console.WriteLine("Mang giam dan:");
                for (int u = 0; u < array.Length; u++)
                {
                    Console.WriteLine(array[u] + " ");

                }
            }

            //Tìm 1 phần tử trong mảng
            Console.WriteLine("So can tim trong mang:");
            int x = int.Parse(Console.ReadLine());
            Boolean found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    Console.WriteLine("Tim thay x tai vi tri: " + i);
                    found = true;
                    break;

                }
            }

            if (!found)
            {
                Console.WriteLine("Khong tim thay ");
            }

            //Đếm số lần xuất hiện của 1 phần tử trong mảng
            Console.WriteLine("nhap so a:");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a)
                {
                    count++;
                }
            }

            Console.WriteLine($"{a} xuat hien {count} lan");            //Kiểm tra mảng có là mảng tăng dần

            bool tang = true;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    tang = false;
                    break;
                }
            }

            Console.WriteLine(tang ? "Mảng tăng dần" : "Mảng không tăng dần");
        }
    }
//7.	Tính cước taxi: nhập vào chiều dài quãng đường (km). Tính số tiền phải trả theo qui luật sau:
    //  · KM đầu tiên: 10000
    // · 20 KM tiếp theo: 9500
    // · > 20KM, mỗi KM tiếp theo: 9000

    class Cau7
    {
        public static void Run()
        {
            Console.WriteLine("Chieu dai quang duong: ");
            int km = int.Parse(Console.ReadLine());
            double sotienphaitra = 0;
            if (km <= 1)
            {
                sotienphaitra = km * 10000;
            }
            else if (km <= 21)
            {
                sotienphaitra = 10000 + (km - 1) * 9500;
            }
            else
            {
                sotienphaitra = 10000 + 20 * 9500 + (km - 21) * 9000;

            }

            Console.WriteLine("So tien phai tra: " + sotienphaitra);


        }
    }

//8.	Viết chương trình giải phương trình bậc II Hướng đối tượng.
    class Cau8
    {
        public static void Run()
        {
            Console.WriteLine("So a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("So b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("So c: ");
            int c = int.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                Console.Write("Phuong trinh co 2 nghiem: ");
                double n1 = (-b + Math.Sqrt(delta)) / 2*a;
                double n2 = (b + Math.Sqrt(delta)) / 2*a;
                Console.Write(n1 + " va " + n2 + " ");
            }
            else if (delta < 0)
            {
                Console.Write("Vo nghiem");
            }
            else
            {
                Console.Write("Co nghiem kep:");
                double x1 = -b / (2*a);
            }
        }
    }

//9.	Viết chương trình chơi cờ caro bằng console
    class Cau9
    {
        static char[,] board = new char[3, 3];

        //tao ban co 3x3
        static void khoitao()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        //in ban co
        static void inbanco()
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        //dieukien win
        static bool checkWinner(char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                {
                    return true;
                }
            }

            if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player)
            {
                return true;

            }

            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                return true;
            }

            return false;

        }

        static bool dieukienhoa()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '-')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void Run()
        {
            khoitao();

            char player = 'X';

            while (true)
            {
                inbanco();

                Console.WriteLine($"Nguoi choi {player}");

                Console.Write("Nhap hang (0-2): ");
                int row = int.Parse(Console.ReadLine());

                Console.Write("Nhap cot (0-2): ");
                int col = int.Parse(Console.ReadLine());

                // Kiểm tra vị trí
                if (row < 0 || row > 2 || col < 0 || col > 2)
                {
                    Console.WriteLine("Vi tri khong hop le!");
                    continue;
                }

                // khong danh trung
                if (board[row, col] != '-')
                {
                    Console.WriteLine("O nay da duoc danh!");
                    continue;
                }

                board[row, col] = player;

                // Kiểm tra thắng
                if (checkWinner(player))
                {
                    inbanco();
                    Console.WriteLine($"Nguoi choi {player} thang!");
                    break;
                }

                // Kiểm tra hòa
                if (dieukienhoa())
                {
                    inbanco();
                    Console.WriteLine("Hoa!");
                    break;
                }

//Swap
    player = player == 'X' ? 'O' : 'X';
            }
        }
    }
//10.	Nhập vào một số long bất kỳ kiểm tra số này có phải là nguyên tố hay không. (Miller-Rabin)
    class Cau10
    {
        // Method kiểm tra số nguyên tố
        static bool IsPrime(long n)
        {
            if (n < 2)
                return false;

            if (n == 2 || n == 3)
                return true;

            if (n % 2 == 0)
                return false;

            for (long i = 3; i <= n / i; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public static void Run()
        {
            Console.Write("Nhap so long bat ky: ");
            long a = long.Parse(Console.ReadLine());

            if (IsPrime(a))
            {
                Console.WriteLine(a + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(a + " khong phai la so nguyen to");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CAU 1 =====");
            Cau1.Run();

            Console.WriteLine("\n===== CAU 2 =====");
            Cau2.Run();

            Console.WriteLine("\n===== CAU 3 =====");
            Cau3.Run();

            Console.WriteLine("\n===== CAU 4 =====");
            Cau4.Run();

            Console.WriteLine("\n===== CAU 5 =====");
            Cau5.Run();

            Console.WriteLine("\n===== CAU 6 =====");
            Cau6.Run();

            Console.WriteLine("\n===== CAU 7 =====");
            Cau7.Run();

            Console.WriteLine("\n===== CAU 8 =====");
            Cau8.Run();
            
            Console.WriteLine("\n===== CAU 9 =====");
            Cau9.Run();
            
            Console.WriteLine("\n===== CAU 10 =====");
Cau10.Run();
        }
    }
}