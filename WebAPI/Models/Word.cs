using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Word
    {
        public string word { get; set; }
        public string meanings { get; set; }

        public static List<Word> AddWords()
        {
            List<Word> words = new List<Word>();

            Word _word = new Word();
            _word.word = "آراد";
            _word.meanings =
                "فرشته ی موکل بر دین و تدبیر امور و مصالحی که به روز آراد متعلق است، نام روز بیست و پنجم ماه شمسی، (در پهلوی) آرای، آراینده - آراج، نام روز بیست و پنجم از هر ماه شمسی در ایران قدیم که در این روز نو پوشیدن را مبارک و سفر را شوم می دانند";
            words.Add(_word);

            _word = new Word();
            _word.word = "کوروش";
            _word.meanings = 
                "نام سه تن از پادشاهان هخامنشی، کورش کبیر از مقتدر ترین پادشاهان ایران که تخت جمشید را بنا نهاد";
            words.Add(_word);

            return words;
        }
    }
}