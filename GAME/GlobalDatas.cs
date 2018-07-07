using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{//存储全局变量
    public enum Thing
    {//枚举  表示物品
        NONETHING,
        KNIFE,
        KEYTOKITCHEN,
        KEY,
        PICTURE,
    } 
 
    public class GlobalDatas
    {
        //Hand表示当前所拿物品
        public static Thing Hand = Thing.NONETHING;
        public static string password = "409108";  //密码设置 "09:10:48";

        //判断是否获得物品 以及物品状态
        public static bool IsPictureOpen = false;
        public static bool IsKeyKicthen = false;
        public static bool IsKinfe = false;
        public static bool IsKey = false;
        public static bool IsPassword = false;
        public static bool IsBedroom = false;

        //判断控件是否能切换
        public static bool ChangetoKitchen = false;
        public static bool ChangetoBedroom = false;
        public static bool ChangetoLivingroom = true;  
        //客厅为初始化时状态 故初始值为true
    }
}
