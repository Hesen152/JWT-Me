using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdd = "Product ugurlu sekilde elave olundu";
        public static string ProductDeleted = "Product ugurlu sekilde silindi";

        public static string ProductUpdated = "Product ugurlu sekilde elave guncellendi";

        public static string CategoryAdd = "Category ugurlua elave olundu";
        public static string CategoryDeleted = "Category ugurlu sekilde silindi";
        public static string CategoryUpdate = "Category ugurlu sekilde guncellendi";

        public static string UserNotFound = "istifadeci Tapilabilmedi";
        public static string PasswordError = "Password yalnisdir";
        public static string SuccessFullLogin = "Sisteme giris ugurludur";

        public static string UserAlreadyExists = "Bu istifadeci onsuzda movcudddur atam";

        public static string UserRegistered = "istifadeci ugurla regitirasiyadan kecirildi";
        public static string AccessTokenCreated = "AccessToken ugurla yaradildi ";
    }
}
