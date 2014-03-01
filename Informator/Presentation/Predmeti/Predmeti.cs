﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Informator.Presentation.Predmeti;

namespace Informator.Presentation.Predmeti
{
    public class Predmeti
    {
        public string[] lstPredmeti  { get; set; }
        public string Semestar { get; set; }
        public string NastavniProfesor { get; set; }
        public string Smer { get; set; }
       public string sadrzajCilj { get; set; }
       public string sadrzajPredmeta { get; set; }
       public string[] sadrzajPredmetaNiz { get; set; }
       
        public Predmeti()
        {
            sadrzajCilj = "Циљ предмета je оспособљавање студената да разумеју, примењују и управљају поступцима за заштиту података у обалсти рачунарства, комуникација и других пословних системима. Студенти треба да буду оспособљени да ураде анализу ризика, и да корисницима система образложе важност примене политике и прописаних поступака заштите.";
            sadrzajPredmeta = "Основе заштите података (историја, терминологија, дизајн, образложење потребе). Сигурносни механизми (криптографија, аутентикација, редундантност, откривање напада). Практична примена (актуелна практична решења, однос цена квалитет, стандарди).Политика примене (Дефинисање и контрола примене, превенција , ванредни догађаји у систему). Напади (активни , пасивни, злонамерни софтвер, онемогућавање рада, улога човека у систему). Подручја примене (управљање информацијама, мреже, интернет, одржавање система).Софтверска и хардверска решења за заштиту података (упоредна анализа).Употреба смарт картица и токена у процесу заштите података.Поступци заштите различитих облика података(пренос, чување и обрада). Практична настава: Анализа основних система за заштиту.Симетрични системи заштите.Асиметрични системи заштите. Сервиси за обезбеђење сигурности Хеш функције и дигитални потпис. Употреба смарт картица и токена у процесу заштите података.Примена хардверских решења за заштиту података.Примена софтверских решења за заштиту података.Криптографски стандарди Заштита преноса података у реалном времену";
            sadrzajPredmetaNiz = sadrzajPredmeta.Split('.');
            
        }

       
    }

    
}
