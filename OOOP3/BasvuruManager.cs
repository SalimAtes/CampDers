﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            krediManager.Hesapla();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}