using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        public readonly static List<Word> temp = Word.AddWords();

        [HttpGet]
        public IEnumerable<Word> Get()
        {
            return temp;
        }

        [HttpGet]
        public IEnumerable<Word> Get(string value)
        {
            return temp.Where(word => word.word == value);
        }

        [HttpPost]
        public string Post(string inputWord, string meaning)
        {
            Word add = new Word();
            add.word = inputWord;
            add.meanings = meaning;
            temp.Add(add);

            return "Done!";
        }

        [HttpPut]
        public string Put(string inputWord, string meaning, string value)
        {
            var edit = temp.Where(word => word.word == value).FirstOrDefault();
            if (edit != null)
            {
                int indexOfWord = temp.IndexOf(edit);

                if (edit.word != inputWord)
                    edit.word = inputWord;
                if (edit.meanings != meaning)
                    edit.meanings = meaning;
                temp.RemoveAt(indexOfWord);
                temp.Insert(indexOfWord, edit);

                return "Done!";
            }
            else
                return "Word Not Found 404";
        }

        [HttpDelete]
        public string Delete(string inputWord)
        {
            temp.Remove(temp.Where(word => word.word == inputWord).FirstOrDefault());

            return "Done!";
        }
    }
}
