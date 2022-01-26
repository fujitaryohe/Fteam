﻿using CampApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rental()
        {
            return View();
        }

        public IActionResult Subscription()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubscCheck(SubscriptionModel model)
        {
            if (model != null)
            {
                ViewBag.name = model.name;
                ViewBag.furigana = model.furigana;
                ViewBag.gender = model.gender;
                ViewBag.birthday = model.birthday;
                ViewBag.ID = model.ID;
                ViewBag.rePassword = model.rePassword;
                ViewBag.HidePassword = string.Concat(Enumerable.Repeat("＊", ViewBag.rePassword.Length));
                ViewBag.addressNum = model.addressNum;
                ViewBag.address = model.address;
                ViewBag.phonenum = model.phonenum;
                ViewBag.mail = model.mail;

                try
                {
                    // 接続情報の作成 
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = "wizazure2021watanabetakuto.database.windows.net"; // 接続DBサーバー 
                    builder.UserID = "azureuser"; // 管理者ID 
                    builder.Password = "xsfE2484"; // 管理者パスワード 
                    builder.InitialCatalog = "wizazureclasswork2021watanabetakuto"; // DB名 

                    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))

                    {
                        Debug.WriteLine("\nQuery data example:");
                        Debug.WriteLine("=========================================\n");
                        // SQL文の作成 
                        StringBuilder sb = new StringBuilder();

                        //sb.Append("SELECT * ");
                        //sb.Append("FROM UserTable");
                        //String sql = sb.ToString();

                        string UserID = model.ID;
                        string Name = model.name;
                        string Furigana = model.furigana;
                        string Birthday = model.birthday;
                        string Password = model.rePassword;
                        string PosCode = model.addressNum;
                        string Address = model.address;
                        string PhoneNumber = model.phonenum;
                        string Mail = model.mail;
                        string Gender = model.gender;

                        string sql = "INSERT INTO UserTable VALUES("
                            + "'" + UserID + "',"
                            + "N'" + Name + "',"
                            + "N'" + Furigana + "',"
                            + "'" + Birthday + "',"
                            + "'" + Password + "',"
                            + "'" + PosCode + "',"
                            + "N'" + Address + "',"
                            + "'" + PhoneNumber + "',"
                            + "N'" + Mail + "',"
                            + "N'" + Gender + "'"
                            +
                            ")";

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            // 接続処理 
                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // データ表示 
                                    Debug.WriteLine(reader["Name"]); // 表示列名の指定やり方 
                                }
                            }
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.ToString());
                }
            }
            else
            {
                ViewBag.name = "No Name";
            }
            return View();
        }

        [HttpPost]
        public IActionResult SubscFinish()
        {
            return View();
        }

        public IActionResult E_Commerce()
        {
            return View();
        }

        public IActionResult Inquiry()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult Tent1()
        {
            return View();
        }

        public IActionResult Tent2()
        {
            return View();
        }

        public IActionResult Tent3()
        {
            return View();
        }

        public IActionResult Tent4()
        {
            return View();
        }

        public IActionResult Chair1()
        {
            return View();
        }

        public IActionResult Chair2()
        {
            return View();
        }

        public IActionResult Chair3()
        {
            return View();
        }

        public IActionResult Chair4()
        {
            return View();
        }

        public IActionResult Chair5()
        {
            return View();
        }

        public IActionResult Chair6()
        {
            return View();
        }

        public IActionResult Sherahu1()
        {
            return View();
        }

        public IActionResult Sherahu2()
        {
            return View();
        }

        public IActionResult Sherahu3()
        {
            return View();
        }

        public IActionResult Sherahu4()
        {
            return View();
        }

        public IActionResult Sherahu5()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InquiryCheck(InquiryModel model)
        {
            if (model != null)
            {
                ViewBag.name = model.name;
                ViewBag.furigana = model.furigana;
                ViewBag.gender = model.gender;
                ViewBag.mail = model.mail;
                ViewBag.tel = model.tel;
                ViewBag.inquiryGroup = model.inquiryGroup;
                ViewBag.message = model.message;
            }
            else
            {
                ViewBag.name = "No Name";
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult InquiryFinish(InquiryModel model)
        {
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}