﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{
    int puan;
    int enYuksekPuan;

    int altin;
    int enYusekAltin;

    bool puanTopla = true;

    [SerializeField]
    Text puanText = default;


    [SerializeField]
    Text altinText = default;

    [SerializeField]
    Text oyunBittiPuanText = default;


    [SerializeField]
    Text oyunBittiAltinText = default;

    // Start is called before the first frame update
    void Start()
    {
        altinText.text = " X " + altin;
    }

    // Update is called once per frame
    void Update()
    {
        if(puanTopla)
        {
            puan = (int)Camera.main.transform.position.y;
            puanText.text = "Puan: " + puan;
        }
    }

    public void AltinKazan()
    {
        FindObjectOfType<SesKontrol>().AltinSes();
        altin++;
        altinText.text = " X " + altin;
    }

    public void OyunBitti()
    {
        if(Secenekler.KolayDegerOku() == 1)
        {
            enYuksekPuan = Secenekler.KolayPuanDegerOku();
            enYusekAltin = Secenekler.KolayAltinDegerOku();
            if(puan > enYuksekPuan)
            {
                Secenekler.KolayPuanDegerAta(puan);
            }
            if(altin > enYusekAltin)
            {
                Secenekler.KolayAltinDegerAta(altin);
            }
        }

        if (Secenekler.OrtaDegerOku() == 1)
        {
            enYuksekPuan = Secenekler.OrtaPuanDegerOku();
            enYusekAltin = Secenekler.OrtaAltinDegerOku();
            if (puan > enYuksekPuan)
            {
                Secenekler.OrtaPuanDegerAta(puan);
            }
            if (altin > enYusekAltin)
            {
                Secenekler.OrtaAltinDegerAta(altin);
            }
        }

        if (Secenekler.ZorDegerOku() == 1)
        {
            enYuksekPuan = Secenekler.ZorPuanDegerOku();
            enYusekAltin = Secenekler.ZorAltinDegerOku();
            if (puan > enYuksekPuan)
            {
                Secenekler.ZorPuanDegerAta(puan);
            }
            if (altin > enYusekAltin)
            {
                Secenekler.ZorAltinDegerAta(altin);
            }
        }

        puanTopla = false;
        oyunBittiPuanText.text = "Puan: " + puan;
        oyunBittiAltinText.text = " X " + altin;
    }
}
