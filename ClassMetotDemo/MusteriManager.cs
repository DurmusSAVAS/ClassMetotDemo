﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri ismi: " + musteri.Adınız+" "+ "Müşteri soyadı:" + musteri.Soyadınız+" "+"müşteri Id:"+musteri.MusteriId+" "+"müşteri yaşı: "+musteri.Yaşınız);
               


        }
       
    }
}
