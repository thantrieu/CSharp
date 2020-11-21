using System;

namespace ExercisesVersion1
{
    class ATMApplicationV1
    {
        static void Main(string[] args)
        {
            long ballance = default; // số dư
            long amount = default; // số tiền cần giao dịch
            int choice = default;
            string password = "123456";
            bool isLogin = false;

            while (true)
            {
                Console.WriteLine("=====> MENU <=====");
                Console.WriteLine("1. Dang nhap vao TK");
                Console.WriteLine("2. Rut tien");
                Console.WriteLine("3. Nap tien");
                Console.WriteLine("4. Kiem tra so du");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Xin moi ban chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Cam on ban da su dung dich vu cua chung toi");
                        return;

                    case 1:
                        if (isLogin)
                        {
                            Console.WriteLine("Ban da dang nhap thanh cong!");
                        }
                        else
                        {
                            Console.WriteLine("Nhap mat khau cua ban: ");
                            var pass = Console.ReadLine();
                            if (pass.CompareTo(password) == 0)
                            {
                                isLogin = true;
                                Console.WriteLine("Ban da dang nhap thanh cong!");
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
                            Console.WriteLine("===============================");
                            bool isWithdrawable = true;
                            int option = default;
                            Console.WriteLine("1. 100k");
                            Console.WriteLine("2. 200k");
                            Console.WriteLine("3. 500k");
                            Console.WriteLine("4. 1000k");
                            Console.WriteLine("5. 2000k");
                            Console.WriteLine("6. So khac");
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
                                    Console.WriteLine("Nhap so tien can rut: ");
                                    amount = int.Parse(Console.ReadLine());
                                    if (amount % 10 != 0)
                                    {
                                        Console.WriteLine("Nhap so tien can rut la boi so cua 10");
                                        amount = 0;
                                        isWithdrawable = false; // khong rut tien duoc
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Sai tuy chon, vui long chon lai!");
                                    break;
                            }
                            if (ballance > amount && isWithdrawable)
                            {
                                ballance -= amount;
                                Console.WriteLine($"Ban da rut {amount}d");
                                Console.WriteLine($"So tien trong TK hien tai la {ballance}d");
                            }
                            else
                            {
                                Console.WriteLine("So du cua ban khong du");
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
                            Console.WriteLine("Nhap so tien can nap vao tai khoan: ");
                            amount = int.Parse(Console.ReadLine());
                            if (amount > 0)
                            {
                                ballance += amount;
                                Console.WriteLine("Nap tien vao TK thanh cong!");
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
                            Console.WriteLine($"==> So du trong TK cua ban la: {ballance}d <==");
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de thuc hien giao dich nay");
                        }
                        break;

                    default:
                        Console.WriteLine("Nhap sai chuc nang, vui long chon lai!");
                        break;
                }
                Console.WriteLine("================================");
            }
        }
    }
}
