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
        [AllowCrossSiteJson]
        [HttpGet]
        public List<TiengAnh_TiengViet> getAll()
        {
            List<TiengAnh_TiengViet> wordList = new List<TiengAnh_TiengViet>();
            var words = db.TiengAnh_TiengViets.ToList();
            return words;
        }
        [AllowCrossSiteJson]
        [HttpGet]
        public TiengAnh_TiengViet getByID(int id)
        {
            TiengAnh_TiengViet word = db.TiengAnh_TiengViets.SingleOrDefault(n => n.id == id);
            return word;
        }
        [AllowCrossSiteJson]
        [HttpGet]
        public TiengAnh_TiengViet getByEnglish(string tiengAnh)
        {
            TiengAnh_TiengViet word = db.TiengAnh_TiengViets.SingleOrDefault(n => n.TiengAnh == tiengAnh);
            return word;
        }
        [AllowCrossSiteJson]
        [HttpPost]
        public bool addWord(DateTime ngayThem, string tiengAnh, string tiengViet, string thongTinThem, string loaiTu)
        {
            try
            {
                TiengAnh_TiengViet word = new TiengAnh_TiengViet();
                word.NgayThem = ngayThem;
                word.TiengAnh = tiengAnh;
                word.TiengViet = tiengViet;
                word.ThongTinThem = thongTinThem;
                word.LoaiTu = loaiTu;
                db.TiengAnh_TiengViets.InsertOnSubmit(word);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [AllowCrossSiteJson]
        [HttpPut]
        public bool updateWord(int id, DateTime ngayThem, string tiengAnh, string tiengViet, string thongTinThem, string loaiTu)
        {
            try
            {
                TiengAnh_TiengViet word = db.TiengAnh_TiengViets.SingleOrDefault(n => n.id == id);
                word.NgayThem = ngayThem;
                word.TiengAnh = tiengAnh;
                word.TiengViet = tiengViet;
                word.ThongTinThem = thongTinThem;
                word.LoaiTu = loaiTu;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [AllowCrossSiteJson]
        [HttpDelete]
        public bool deleteWord(int id)
        {
            try
            {
                TiengAnh_TiengViet word = db.TiengAnh_TiengViets.SingleOrDefault(n => n.id == id);
                db.TiengAnh_TiengViets.DeleteOnSubmit(word);
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
