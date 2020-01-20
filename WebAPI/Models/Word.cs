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
            Word _word = new Word();
            List<Word> words = new List<Word>();

            _word.word = "آراد";
            _word.meanings = "آریایی";
            words.Add(_word);
            _word = new Word();
            _word.word = "درود";
            _word.meanings = "سلام";
            words.Add(_word);

            return words;
        }
    }
}