using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkinciHaftaOdevi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Odev(10, 20);
    }



    void Odev(int ilkSayi, int ikiniciSayi)
    {
        ArrayList ListeTam = new ArrayList();
        ArrayList Liste_2 = new ArrayList();
        ArrayList Liste_3 = new ArrayList();
        ArrayList Liste_4 = new ArrayList();
        ArrayList Liste_5 = new ArrayList();

        //Tam Liste:
        for (int i = ilkSayi; i <= ikiniciSayi; i++)
        {
            ListeTam.Add(i);
        }         
            
        
        foreach (int sayi in ListeTam)
        {
            //2 Kalanlar Listesi 
            int kalan = sayi % 2;

            if (kalan == 0) { Liste_2.Add(sayi); }

            //3 Kalanlar Listesi
            kalan = sayi % 3;
            if (kalan == 0) { Liste_3.Add(sayi); }

            //4 kalanlar Listesi
            kalan = sayi % 4;
            if (kalan == 0) { Liste_4.Add(sayi); }

            //5 Kalanlar Listesi
            kalan = sayi % 5;
            if (kalan == 0) { Liste_5.Add(sayi); }

        }

        // --- Liste Ýçi ---

        string ciktiListesiTam = " ";

        foreach(int eleman in ListeTam) 
        {
            ciktiListesiTam += " " + eleman + ",";
        }
        //--- Kalan 2 ---
        string ciktiListe_2 = " ";
        foreach (int eleman2 in Liste_2)
        {
            ciktiListe_2+=" " + eleman2 + ",";
        }

        // --- Kalan 3 ---

        string ciktiListe_3 = " ";
        foreach (int eleman3 in Liste_3)
        {
            ciktiListe_3 += " " + eleman3 + ",";
        }
        // --- Kalan 4 ---
        string ciktiListe_4 = " ";
        foreach (int eleman4 in Liste_4)
        {
            ciktiListe_4 += " " + eleman4 + ",";
        }
        // --- Kalan 5 ---
        string ciktiListe_5 = " ";
        foreach (int eleman5 in Liste_5)
        {
            ciktiListe_5 += " " + eleman5 + ",";
        }
        print(ciktiListesiTam);
        print(ciktiListe_2);
        print(ciktiListe_3);
        print(ciktiListe_4);
        print(ciktiListe_5);
    }


  
}

