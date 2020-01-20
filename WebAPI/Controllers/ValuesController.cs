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
        // GET api/values
        //[Route("api/{controller}/{id}")]
        [Route("api/Values")]
        public IEnumerable<Word> Get()
        {
            return temp;
        }

        // GET api/values/word
        [Route("api/Values/{value}")]
        public IEnumerable<Word> Get(string value)
        {
            return temp.Where(word => word.word == value);
        }

        // POST api/values
        [Route("api/Values/POST/{id}")]
        public void Post(string inputWord, string meaning)
        {
            Word add = new Word();
            add.word = inputWord;
            add.meanings = meaning;
            temp.Add(add);
        }

        // PUT api/values/5
        [Route("api/Values/PUT/{id}")]
        public void Put(string inputWord, string meaning, string value)
        {
            var edit = temp.Where(word => word.word == value).FirstOrDefault();
            int indexOfWord = temp.IndexOf(edit);

            if (edit.word != inputWord)
                edit.word = inputWord;
            if (edit.meanings != meaning)
                edit.meanings = meaning;
            temp.RemoveAt(indexOfWord);
            temp.Insert(indexOfWord, edit);
        }

        // DELETE api/values/5
        [Route("api/Values/Delete/{id}")]
        public void Delete(string inputWord)
        {
            temp.Remove(temp.Where(word => word.word == inputWord).FirstOrDefault());
        }

    }
}
