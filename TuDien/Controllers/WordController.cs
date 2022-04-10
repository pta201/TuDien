using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TuDien.Models;

namespace TuDien.Controllers
{
    public class WordController : ApiController
    {
        WordDataContext db = new WordDataContext();
        //Get all
        [HttpGet]
        public List<TiengAnh_TiengViet> getAll()
        {
            List<TiengAnh_TiengViet> wordList = new List<TiengAnh_TiengViet>();
            var words = db.TiengAnh_TiengViets.ToList();
            foreach(var word in words)
            {
                wordList.Add(new TiengAnh_TiengViet(word.NgayThem, word.TiengAnh, word.TiengViet, word.ThongTinThem, word.DoKho ));
            }
            return wordList;
        }
        [HttpGet]
        public TiengAnh_TiengViet getByID(int id)
        {
            TiengAnh_TiengViet word = db.TiengAnh_TiengViets.SingleOrDefault(n => n.id == id);
            return word;
        }
        [HttpPost]
        [HttpGet]
        public TiengAnh_TiengViet getByEnglish(string tiengAnh)
        {
            TiengAnh_TiengViet word = db.TiengAnh_TiengViets.SingleOrDefault(n => n.TiengAnh == tiengAnh);
            return word;
        }
        [HttpPost]
        public bool addWord(DateTime ngayThem, string tiengAnh, string tiengViet, string thongTinThem, string doKho)
        {
            try
            {
                TiengAnh_TiengViet word = new TiengAnh_TiengViet();
                word.NgayThem = ngayThem;
                word.TiengAnh = tiengAnh;
                word.TiengViet = tiengViet;
                word.ThongTinThem = thongTinThem;
                word.DoKho = doKho;
                db.TiengAnh_TiengViets.InsertOnSubmit(word);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpPut]
        public bool updateWord(int id, DateTime ngayThem, string tiengAnh, string tiengViet, string thongTinThem, string doKho)
        {
            try
            {
                TiengAnh_TiengViet word = db.TiengAnh_TiengViets.SingleOrDefault(n => n.id == id);
                word.NgayThem = ngayThem;
                word.TiengAnh = tiengAnh;
                word.TiengViet = tiengViet;
                word.ThongTinThem = thongTinThem;
                word.DoKho = doKho;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
