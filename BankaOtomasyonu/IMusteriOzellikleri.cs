using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    interface IMusteriOzellikleri
    {
        //müşteri sınıfının sahip olacağı metotları burada kodlanır.
        void YeniHesapAc(int EkBakiye);
        //hesap açılırken ek bakiyesi de bu metoda parametre olarak gönderilmeli
        //hangi hesabı sileceğimizi bilmemiz için bir hesap numarası olmalı parametre olarak gelen
        void HesabıSil(int hesapNo);

        //müşteri hesaba para yatırabilmeli, hangi hesaba yatıracağını bilmeli ne kadar yatıracağını da bilmeli
        void HesabaParaYatir(Hesap buHesaba, decimal paraMiktari);
        void HesaptanParaCek(Hesap buHesaptan, decimal paraMiktari);


        
    }
}
