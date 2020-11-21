using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesVersion1
{
    class ATMApplicationV1
    {
        static void Main()
        {
            string password = "123456";
            long ballance = default;
            bool isLogin = false;
            long amount = default;
            int choice = default;

            while (true)
            {
                Console.WriteLine("=====> MENU <=====");
                Console.WriteLine("1. Dang nhap vao TK");
                Console.WriteLine("2. Rut tien");
                Console.WriteLine("3. Nap tien vao TK");
                Console.WriteLine("4. Kiem tra so du");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("Xin moi ban chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Cam on quy khach da su dung dich vu cua chung toi");
                        break;

                    case 1:
                        if (isLogin)
                        {
                            Console.WriteLine("Ban da dang nhap vao TK");
                        }
                        else
                        {
                            Console.WriteLine("Nhap mat khau cua ban: ");
                            var userPassword = Console.ReadLine();
                            if (userPassword.CompareTo(password) == 0)
                            {
                                isLogin = true;
                                Console.WriteLine("Ban da dang nhap thanh cong");
                            }
                            else
                            {
                                Console.WriteLine("Sai mat khau, vui long thu lai!");
                            }
                        }
                        break;

                    case 2:
                        if (isLogin)
                        {
                            bool isWithdrawable = true;
                            int option = default;
                            Console.WriteLine("Chon so tien can rut: ");
                            Console.WriteLine("1. 100k");
                            Console.WriteLine("2. 200k");
                            Console.WriteLine("3. 500k");
                            Console.WriteLine("4. 1000k");
                            Console.WriteLine("5. 2000k");
                            Console.WriteLine("6. Nhap mot so khac");
                            option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    amount = 100000;
                                    break;

                                case 2:
                                    amount = 200000;
                                    break;

                                case 3:
                                    amount = 500000;
                                    break;

                                case 4:
                                    amount = 1000000;
                                    break;

                                case 5:
                                    amount = 2000000;
                                    break;

                                case 6:
                                    Console.WriteLine("Nhap so tien can rut la boi so cua 10k:");
                                    amount = int.Parse(Console.ReadLine());
                                    if (amount % 10000 != 0)
                                    {
                                        Console.WriteLine("Vui nhap so tien la boi so cua 10k!");
                                        amount = 0;
                                        isWithdrawable = false;
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Sai tuy chon, vui long nhap lai!");
                                    break;
                            }
                            if (isWithdrawable)
                            {
                                if (ballance > amount)
                                {
                                    ballance -= amount;
                                    Console.WriteLine($"Ban da rut {amount}d");
                                    Console.WriteLine($"So tien trong TK hien tai la: {ballance}d");
                                }
                                else
                                {
                                    Console.WriteLine("So du cua ban khong du");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de thuc hien giao dich nay");
                        }
                        break;

                    case 3:
                        if (isLogin)
                        {
                            Console.WriteLine("Nhap so tien muon nap vao TK: ");
                            amount = long.Parse(Console.ReadLine());
                            if (amount > 0)
                            {
                                ballance += amount;
                                amount = 0;
                                Console.WriteLine("Nap tien vao TK thanh cong!");
                            }
                            else
                            {
                                Console.WriteLine("So tien can nap khong hop le, vui long kiem tra lai!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de thuc hien giao dich nay");
                        }
                        break;

                    case 4:
                        if (isLogin)
                        {
                            Console.WriteLine($"So tien trong TK cua ban hien tai la: {ballance}d");
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de thuc hien giao dich nay");
                        }
                        break;

                    default:
                        Console.WriteLine("Sai chuc nang, vui long chon lai!");
                        break;
                }
            }
        }
    }
}


// Ctrl K Ctrl D