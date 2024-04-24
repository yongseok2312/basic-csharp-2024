using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBookRentalShopAp.Helper
{
    public class Common
    {
        // 정적으로 만드는 공통 연결문자열
        public static readonly string  connString = "Data Source=localhost;" +
                                          "Initial Catalog=BookRentalShop2024;" +
                                          "Persist Security Info=True;" +
                                          "User ID=sa;Encrypt=False;" +
                                          "Password=mssql_p@ss";

        // 회원 선택 팝업에서 대출화면으로 넘길데이터 정적 변수

        public static string SelMemberIdx {  get; set; }

        public static string SelMemberName { get; set; }

        public static string SelBookIdx { get; set; }

        public static string SelBookName { get; set; }
        public static string LoginId { get; set; }


        // MD5 해시 알고리즘 암호화
        public static string GetMd5Hash(MD5 md5hash, string input)
    {
        // 입력문자열을 byte배열로 변환한 뒤 MD5 해시 처리
        byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            builder.Append(data[i].ToString("X2")); // 16진수 문자로 각 글자를 전부 변환
        }

        return builder.ToString();
    }

        
    }

    


}
