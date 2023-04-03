﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneration
{
    public class RandomizeFourWordForPassword
    {
        private readonly List<string> PasswordFirstWord = new List<string>
        {
    "Диких",
    "Грязных",
    "Жестоких",
    "Маленьких",
    "Старых",
    "Варварских",
    "Интересных",
    "Одиноких",
    "Беспощадных",
    "Русских"
        };

        private readonly List<string> PasswordSecondWord = new List<string>
        {
    "Гризли",
    "Сусликов",
    "Коров",
    "Кротов",
    "Обезьян",
    "Ювелиров",
    "Макак",
    "Свиней",
    "Афиканцец",
    "Медведей"
        };

        private readonly List<string> PasswordThirdWord = new List<string>
        {
    "Съели",
    "Взяли",
    "Отобрали",
    "Забрали",
    "Подарили",
    "Купили",
    "Своровали",
    "Любили",
    "Усыновили",
    "Спрятали"
        };

        private readonly List<string> PasswordFourWord = new List<string>
        {
    "Зуб",
    "Морковь",
    "Яблоко",
    "Ребёнка",
    "Кольцо",
    "Суп",
    "Машину",
    "Человека",
    "Цепочку",
    "Бриллиант"
        };


        private readonly Random random = new Random();

        public virtual string GenerateWordsForPassword()
        {
            var index = random.Next(PasswordFirstWord.Count);
            var password = PasswordFirstWord[index];

            var index1 = random.Next(PasswordSecondWord.Count);
            var password1 = PasswordSecondWord[index1];

            var index2 = random.Next(PasswordThirdWord.Count);
            var password2 = PasswordThirdWord[index2];

            var index3 = random.Next(PasswordFourWord.Count);
            var password3 = PasswordFourWord[index3];

            var passwordResultWithoutFormatting = password + password1 + password2 + password3;
           

            return passwordResultWithoutFormatting;
        }


        


    }
}
