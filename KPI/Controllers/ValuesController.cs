using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KPI.Models;

namespace KPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        KPIKIETHONGContext data;
        public ValuesController(KPIKIETHONGContext context)
        {


            data = context;

        }
        #region[Chi nhanh]
        // GET api/values
        [HttpGet]
        public IEnumerable<Tblchinhanh> Get()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tblchinhanh;
            } return null;
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "GetChiNhanh")]
        public ActionResult Get(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblchinhanh.SingleOrDefault(p => p.Idchinhanh == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Tblchinhanh value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tblchinhanh.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetChiNhanh", new { id = value.Idchinhanh }, value);
            }
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Tblchinhanh value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Idchinhanh != id)
                {
                    return BadRequest();
                }

                var item = data.Tblchinhanh.FirstOrDefault(t => t.Idchinhanh == id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Machinhanh = value.Machinhanh;
                item.Tenchinhanh = value.Tenchinhanh;
                item.Tragnthaicn = value.Tragnthaicn;
                data.Tblchinhanh.Update(item);
                data.SaveChanges();
                return new OkResult();
            }
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblchinhanh.FirstOrDefault(t => t.Idchinhanh == id);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tblchinhanh.Remove(item);
                data.SaveChanges();
                return new OkResult();
            }
            return BadRequest();
        }
        #endregion
        #region[Nhom tieu chi]
        // GET api/values
        [HttpGet("NhomTieuChi")]
        public IEnumerable<Tblnhomtieuchi> NhomTieuChi()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tblnhomtieuchi;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("NhomTieuChi/{id}", Name = "GetNhomTieuChi")]
        public ActionResult NhomTieuChi(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblnhomtieuchi.SingleOrDefault(p => p.Idnhomtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost("NhomTieuChi")]
        public IActionResult Post([FromBody]Tblnhomtieuchi value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tblnhomtieuchi.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetNhomTieuChi", new { id = value.Idnhomtieuchi }, value);
            }
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("NhomTieuChi/{id}")]
        public ActionResult Put(int id, [FromBody]Tblnhomtieuchi value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Idnhomtieuchi != id)
                {
                    return BadRequest();
                }

                var item = data.Tblnhomtieuchi.FirstOrDefault(t => t.Idnhomtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Tennhomtieuchi = value.Tennhomtieuchi;

                item.Trangthaintc = value.Trangthaintc;
                data.Tblnhomtieuchi.Update(item);
                data.SaveChanges();
                return new OkResult();
            } return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("NhomTieuChi/{id}")]
        public ActionResult DeleteNhomTieuChi(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblnhomtieuchi.FirstOrDefault(t => t.Idnhomtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tblnhomtieuchi.Remove(item);
                data.SaveChanges();
                return new OkResult();
            }return BadRequest();
        }
        #endregion
        #region[tonkholoi]
        // GET api/values
        [HttpGet("TonKhoLoi")]
        public IEnumerable<Tbltonkholoi> TonKhoLoi()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tbltonkholoi;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("TonKhoLoi/{id}", Name = "GetTonKhoLoi")]
        public ActionResult TonKhoLoi(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbltonkholoi.SingleOrDefault(p => p.Idtonkholoi == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("TonKhoLoiByTC/{id}", Name = "GetTonKhoLoiByTC")]
        public ActionResult TonKhoLoiByTC(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbltonkholoi.Where(p => p.Idtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            } return NotFound();
        }
        // POST api/values
        [HttpPost("TonKhoLoi")]
        public IActionResult Post([FromBody]Tbltonkholoi value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tbltonkholoi.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetTonKhoLoi", new { id = value.Idtonkholoi }, value);
            } return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("TonKhoLoi/{id}")]
        public ActionResult Put(int id, [FromBody]Tbltonkholoi value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Idtonkholoi != id)
                {
                    return BadRequest();
                }

                var item = data.Tbltonkholoi.FirstOrDefault(t => t.Idtonkholoi == id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Idtieuchi = value.Idtieuchi;
                item.Daxuly = value.Daxuly;
                item.Decen = value.Decen;
                item.Ngaychamdiem = value.Ngaychamdiem;
                data.Tbltonkholoi.Update(item);
                data.SaveChanges();
                return new OkResult();
            } return BadRequest();
        }
        [HttpPut("XacNhanOKTonKhoLoi/{id}")]
        public ActionResult XacNhanOKTonKhoLoi(int id, [FromBody]Tbltonkholoi value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Idtonkholoi != id)
                {
                    return BadRequest();
                }

                var item = data.Tbltonkholoi.FirstOrDefault(t => t.Idtonkholoi == id);
                if (item == null)
                {
                    return NotFound();
                }
                if (!item.Decen.Value)
                {
                    item.Daxuly = true;
                    item.Decen = true;

                    data.Tbltonkholoi.Update(item);
                    data.SaveChanges();
                    return new OkResult();
                }
                return BadRequest();
            }
            return BadRequest();
        }
        // DELETE api/values/5
        [HttpDelete("TonKhoLoi/{id}")]
        public ActionResult DeleteTonKhoLoi(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbltonkholoi.FirstOrDefault(t => t.Idtonkholoi == id);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tbltonkholoi.Remove(item);
                data.SaveChanges();
                return new OkResult();
            } return BadRequest();
        }
        #endregion
        #region[Loai Tieu Chi]
        // GET api/values
        [HttpGet("LoaiTieuChi")]
        public IEnumerable<Tblloaitieuchi> LoaiTieuChi()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tblloaitieuchi;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("LoaiTieuChi/{id}", Name = "GetLoaiTieuChi")]
        public ActionResult LoaiTieuChi(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblloaitieuchi.SingleOrDefault(p => p.Idloaitc == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            } return NotFound();
        }

        // POST api/values
        [HttpPost("LoaiTieuChi")]
        public IActionResult Post([FromBody]Tblloaitieuchi value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tblloaitieuchi.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetLoaiTieuChi", new { id = value.Idloaitc }, value);
            } return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("LoaiTieuChi/{id}")]
        public ActionResult Put(int id, [FromBody]Tblloaitieuchi value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Idloaitc != id)
                {
                    return BadRequest();
                }

                var item = data.Tblloaitieuchi.FirstOrDefault(t => t.Idloaitc == id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Tenloaitc = value.Tenloaitc;

                item.Trangthaitc = value.Trangthaitc;
                data.Tblloaitieuchi.Update(item);
                data.SaveChanges();
                return new OkResult();
            }
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("LoaiTieuChi/{id}")]
        public ActionResult DeleteLoaiTieuChi(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblloaitieuchi.FirstOrDefault(t => t.Idloaitc == id);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tblloaitieuchi.Remove(item);
                data.SaveChanges();
                return new OkResult();
            } return BadRequest();
        }
        #endregion
        #region[Tieu Chi]
        // GET api/values
        [HttpGet("TieuChi")]
        public IEnumerable<Tbltieuchi> TieuChi()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tbltieuchi;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("TieuChi/{id}", Name = "GetTieuChi")]
        public ActionResult TieuChi(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbltieuchi.SingleOrDefault(p => p.Idtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("TieuChiByChiNhanh/{id}", Name = "GetByChiNhanh")]
        public ActionResult TieuChiByChiNhanh(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbltieuchi.Where(p => p.Idchinhanh.Equals(id));
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("TieuChiByNhom/{id}", Name = "GetByNhom")]
        public ActionResult TieuChiByNhom(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbltieuchi.Where(p => p.Idnhomtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("TieuChiByLoai/{id}", Name = "GetByLoai")]
        public ActionResult TieuChiByLoai(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbltieuchi.SingleOrDefault(p => p.Idloaitc == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        // POST api/values
        [HttpPost("TieuChi")]
        public IActionResult Post([FromBody]Tbltieuchi value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tbltieuchi.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetTieuChi", new { id = value.Idtieuchi }, value);
            }
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("TieuChi/{id}")]
        public ActionResult Put(int id, [FromBody]Tbltieuchi value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Idtieuchi != id)
                {
                    return BadRequest();
                }

                var item = data.Tbltieuchi.FirstOrDefault(t => t.Idtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Matieuchi = value.Matieuchi;
                item.Tentieuchi = value.Tentieuchi;
                item.Idchinhanh = value.Idchinhanh;
                item.Idnhomtieuchi = value.Idnhomtieuchi;

                item.Trangthaitc = value.Trangthaitc;
                item.Diemtieuchi = value.Diemtieuchi;
                item.Idloaitc = value.Idloaitc;
                data.Tbltieuchi.Update(item);
                data.SaveChanges();
                return new OkResult();
            }
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("TieuChi/{id}")]
        public ActionResult DeleteTieuChi(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbltieuchi.FirstOrDefault(t => t.Idtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tbltieuchi.Remove(item);
                data.SaveChanges();
                return new OkResult();
            }
            return BadRequest();
        }
        #endregion
        #region[Nhom tieu chi]
        // GET api/values
        [HttpGet("DapAn")]
        public IEnumerable<Tbldapan> DapAn()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tbldapan;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("DapAn/{id}", Name = "GetDapAn")]
        public ActionResult DapAn(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbldapan.SingleOrDefault(p => p.Iddapan == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("DapAnByTC/{id}", Name = "GetDapAnByTc")]
        public ActionResult DapAnByTc(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbldapan.Where(p => p.Idtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            } return NotFound();
        }
        // POST api/values
        [HttpPost("DapAn")]
        public IActionResult Post([FromBody]Tbldapan value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tbldapan.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetDapAn", new { id = value.Iddapan }, value);
            }
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("DapAn/{id}")]
        public ActionResult Put(int id, [FromBody]Tbldapan value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Iddapan != id)
                {
                    return BadRequest();
                }

                var item = data.Tbldapan.FirstOrDefault(t => t.Iddapan == id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Idtieuchi = value.Idtieuchi;
                item.Tendapan = value.Tendapan;
                item.Diemdapan = value.Diemdapan;
                item.Trangthaidapan = value.Trangthaidapan;
                data.Tbldapan.Update(item);
                data.SaveChanges();
                return new OkResult();
            }
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("DapAn/{id}")]
        public ActionResult DeleteDapAn(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbldapan.FirstOrDefault(t => t.Iddapan == id);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tbldapan.Remove(item);
                data.SaveChanges();
                return new OkResult();
            } return BadRequest();
        }
        #endregion
        #region[Danh Gia]
        // GET api/values
        [HttpGet("DanhGia")]
        public IEnumerable<Tbldanhgia> DanhGia()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tbldanhgia;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("DanhGia/{id}", Name = "GetDanhGia")]
        public ActionResult DanhGia(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbldanhgia.SingleOrDefault(p => p.Iddanhgia == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }return NotFound();
        }
        [HttpGet("DanhGiaByTC/{id}", Name = "GetByTC")]
        public ActionResult DanhGiaByTC(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbldanhgia.Where(p => p.Idtieuchi == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("DanhGiaByDA/{id}", Name = "GetByDA")]
        public ActionResult DanhGiaByDA(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbldanhgia.Where(p => p.Iddapan == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("DanhGiaByUser/{id}", Name = "GetByUser")]
        public ActionResult DanhGiaByUser(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbldanhgia.Where(p => p.Iduser == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        // POST api/values
        [HttpPost("DanhGia")]
        public IActionResult Post([FromBody]Tbldanhgia value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tbldanhgia.Add(value);
                data.SaveChanges();

               
                return CreatedAtRoute("GetDanhGia", new { id = value.Iddanhgia }, value);
            }
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("DanhGia/{id}")]
        public ActionResult Put(int id, [FromBody]Tbldanhgia value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Iddanhgia != id)
                {
                    return BadRequest();
                }

                var item = data.Tbldanhgia.FirstOrDefault(t => t.Iddanhgia == id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Idtieuchi = value.Idtieuchi;
                item.Iddapan = value.Iddapan;
                item.Diemdanhgia = value.Diemdanhgia;
                item.Ngaydanhgia = value.Ngaydanhgia;
                item.Iduser = value.Iduser;
                item.Ghichu = value.Ghichu;
                item.Noidungdanhgia = value.Noidungdanhgia;
                item.Trangthaidanhgia = value.Trangthaidanhgia;
                data.Tbldanhgia.Update(item);
                data.SaveChanges();
                if (!value.Trangthaidanhgia.Value)
                {
                    data.Tbltonkholoi.Add(new Tbltonkholoi()
                    {
                        Daxuly = false,
                        Decen = false,
                        Idtieuchi = value.Idtieuchi,
                        Ngaychamdiem = value.Ngaydanhgia
                    });
                    data.SaveChanges();
                }
                return new OkResult();
            }
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("DanhGia/{id}")]
        public ActionResult DeleteDanhGia(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tbldanhgia.FirstOrDefault(t => t.Iddanhgia == id);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tbldanhgia.Remove(item);
                data.SaveChanges();
                return new OkResult();
            }
            return BadRequest();
        }
        #endregion
        #region[Nhan Vien]
        // GET api/values
        [HttpGet("NhanVien")]
        public IEnumerable<Tblnhanvien> NhanVien()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tblnhanvien;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("NhanVien/{id}", Name = "GetNhanVien")]
        public ActionResult NhanVien(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblnhanvien.SingleOrDefault(p => p.Iduser == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("NhanVienByCN/{id}", Name = "GetByCN")]
        public ActionResult NhanVienByCN(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblnhanvien.Where(p => p.Idchinhanh == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("Login/{username}/{pass}")]
        public ActionResult Login(string username,string pass)
        {
            var a = HttpContext.Request.Headers["token"].ToList();
            if (a.Count > 0)
            {
                if (a.FirstOrDefault() == "loginkpikiethong")
                {
                    var item = data.Tblnhanvien.FirstOrDefault(p => Hashing.MD5Hash(p.Username) == Hashing.MD5Hash(username) && Hashing.MD5Hash(pass)==p.Password);
                    if (item == null)
                    {
                        return NotFound();
                    }
                    return new ObjectResult(new SessionUser() {
                        Iduser =item.Iduser, Tennhanvien=item.Tennhanvien, Username=item.Username, Email=item.Email, Sodienthoai=item.Sodienthoai,
                         Isadmin=item.Isadmin, Idchinhanh=item.Idchinhanh, Tolken=item.Tolken
                    });
                }
            }
            return NotFound();
            
        }
        // POST api/values
        [HttpPost("NhanVien")]
        public IActionResult Post([FromBody]Tblnhanvien value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
            {
                return BadRequest();
            }
                var item = value;
                item.Password =Hashing.MD5Hash(value.Password);
                item.Tolken = Hashing.ComputeHash(item.Password);
            data.Tblnhanvien.Add(item);
            data.SaveChanges();

            return CreatedAtRoute("GetNhanVien", new { id = value.Iduser }, value);
            }
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("NhanVien/{id}")]
        public ActionResult Put(int id, [FromBody]Tblnhanvien value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Iduser != id)
            {
                return BadRequest();
            }

            var item = data.Tblnhanvien.FirstOrDefault(t => t.Iduser == id);
            if (item == null)
            {
                return NotFound();
            }

            item.Tennhanvien = value.Tennhanvien;
            item.Username = value.Username;
            item.Password = Hashing.MD5Hash(value.Password);
            item.Tolken = Hashing.MD5Hash(item.Password);
            item.Email = value.Email;
            item.Sodienthoai = value.Sodienthoai;
            item.Secrect = value.Secrect;
            item.Keychung = value.Keychung;
            item.Keyrieng = value.Keyrieng;
            item.Khoa = value.Khoa;
            item.Giatrixacthuc = value.Giatrixacthuc;
            item.Isadmin = value.Isadmin;
            item.Idchinhanh = value.Idchinhanh;
            data.Tblnhanvien.Update(item);
            data.SaveChanges();
            return new OkResult();
            }
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("NhanVien/{id}")]
        public ActionResult DeleteNhanVien(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblnhanvien.FirstOrDefault(t => t.Iduser == id);
            if (item == null)
            {
                return NotFound();
            }

            data.Tblnhanvien.Remove(item);
            data.SaveChanges();
            return new OkResult();
            }
            return BadRequest();
        }
        #endregion
        #region[Controller]
        // GET api/values
        [HttpGet("Controller")]
        public IEnumerable<Tblcontroller> Controller()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tblcontroller;
            }return null;
        }

        // GET api/values/5
        [HttpGet("Controller/{id}", Name = "GetController")]
        public ActionResult Controller(string id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblcontroller.SingleOrDefault(p => p.Idcontroller == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            } return NotFound();
        }
       
     
       
        // POST api/values
        [HttpPost("Controller")]
        public IActionResult Post([FromBody]Tblcontroller value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tblcontroller.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetController", new { id = value.Idcontroller }, value);
            }
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("Controller/{id}")]
        public ActionResult Put(string id, [FromBody]Tblcontroller value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Idcontroller != id)
                {
                    return BadRequest();
                }

                var item = data.Tblcontroller.FirstOrDefault(t => t.Idcontroller == id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Chucnang = value.Chucnang;

                data.Tblcontroller.Update(item);
                data.SaveChanges();
                return new OkResult();
            } return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("Controller/{id}")]
        public ActionResult DeleteController(string id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblcontroller.FirstOrDefault(t => t.Idcontroller == id);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tblcontroller.Remove(item);
                data.SaveChanges();
                return new OkResult();
            }return BadRequest();
        }
        #endregion
        #region[Quyen Controller]
        // GET api/values
        [HttpGet("QuyenController")]
        public IEnumerable<Tblquyencontroller> QuyenController()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tblquyencontroller;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("QuyenController/{id}", Name = "GetQuyenController")]
        public ActionResult QuyenController(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblquyencontroller.SingleOrDefault(p => p.Idquyen == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }return NotFound();
        }
        [HttpGet("QuyenControllerByIdControl/{id}", Name = "GetByIDControl")]
        public ActionResult QuyenControllerByIdControl(string id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblquyencontroller.Where(p => p.Idcontroller == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }return NotFound();
        }
       
      
        // POST api/values
        [HttpPost("QuyenController")]
        public IActionResult Post([FromBody]Tblquyencontroller value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tblquyencontroller.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetQuyenController", new { id = value.Idquyen }, value);
            } return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("QuyenController/{id}")]
        public ActionResult Put(int id, [FromBody]Tblquyencontroller value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null || value.Idquyen != id)
                {
                    return BadRequest();
                }

                var item = data.Tblquyencontroller.FirstOrDefault(t => t.Idquyen == id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Tenquyen = value.Tenquyen;
                item.Motaquyen = value.Motaquyen;
                item.Idcontroller = value.Idcontroller;

                data.Tblquyencontroller.Update(item);
                data.SaveChanges();
                return new OkResult();
            } return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("QuyenController/{id}")]
        public ActionResult DeleteQuyenController(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblquyencontroller.FirstOrDefault(t => t.Idquyen == id);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tblquyencontroller.Remove(item);
                data.SaveChanges();
                return new OkResult();
            }
            return BadRequest();
        }
        #endregion
        #region[Quyen User]
        // GET api/values
        [HttpGet("QuyenUser")]
        public IEnumerable<Tblquyenuser> QuyenUser()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tblquyenuser;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("QuyenUser/{id}", Name = "GetQuyenUser")]
        public ActionResult QuyenUser(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblquyenuser.Where(p => p.Idquyen == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("QuyenUserByUser/{id}", Name = "GetQuyenByUser")]
        public ActionResult QuyenUserByUser(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblquyenuser.Where(p => p.Iduser == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        
       
        // POST api/values
        [HttpPost("QuyenUser")]
        public IActionResult Post([FromBody]Tblquyenuser value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tblquyenuser.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetQuyenUser", new { id = value.Iduser }, value);
            }
            return BadRequest();
        }

        //// PUT api/values/5
        //[HttpPut("QuyenUser")]
        //public ActionResult Put([FromBody]Tblquyenuser value)
        //{
        //    if (value == null)
        //    {
        //        return BadRequest();
        //    }

        //    var item = data.Tblquyenuser.FirstOrDefault(t => t.Iduser == value.Iduser && t.Idquyen==value.Idquyen);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }
        //    data.Tblquyenuser.Update(item);
        //    data.SaveChanges();

        //    data.Tblquyenuser.Add(item);
        //    data.SaveChanges();
        //    return new OkResult();
        //}

        // DELETE api/values/5
        [HttpDelete("QuyenUser/{Idquyen}/{Iduser}")]
        public ActionResult DeleteQuyenUser(int Idquyen,int Iduser)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblquyenuser.FirstOrDefault(t => t.Idquyen == Idquyen && t.Iduser == Iduser);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tblquyenuser.Remove(item);
                data.SaveChanges();
                return new OkResult();
            }
            return BadRequest();
        }
        #endregion
        #region[Quan ly Chi Nhanh]
        // GET api/values
        [HttpGet("QuanLyChiNhanh")]
        public IEnumerable<Tblquanlychinhanh> QuanLyChiNhanh()
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                return data.Tblquanlychinhanh;
            }
            return null;
        }

        // GET api/values/5
        [HttpGet("QuanLyChiNhanh/{id}", Name = "GetQuanLyChiNhanh")]
        public ActionResult QuanLyChiNhanh(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblquanlychinhanh.Where(p => p.Iduser == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
            return NotFound();
        }
        [HttpGet("QuanLyChiNhanhByIDCN/{id}", Name = "GetByIDCN")]
        public ActionResult QuanLyChiNhanhByIDCN(int id)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblquanlychinhanh.Where(p => p.Idchinhanh == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
                return NotFound();
        }
       
        // POST api/values
        [HttpPost("QuanLyChiNhanh")]
        public IActionResult Post([FromBody]Tblquanlychinhanh value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                data.Tblquanlychinhanh.Add(value);
                data.SaveChanges();

                return CreatedAtRoute("GetByIDCN", new { id = value.Idchinhanh }, value);
            } return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("QuanLyChiNhanh")]
        public ActionResult Put([FromBody]Tblquanlychinhanh value)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                if (value == null)
                {
                    return BadRequest();
                }

                var item = data.Tblquanlychinhanh.FirstOrDefault(t => t.Idchinhanh == value.Idchinhanh && t.Iduser == value.Iduser);
                if (item == null)
                {
                    return NotFound();
                }

                item.Trangthaiquanly = value.Trangthaiquanly;


                data.Tblquanlychinhanh.Update(item);
                data.SaveChanges();
                return new OkResult();
            } return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("QuanLyChiNhanh/{Idchinhanh}/{Iduser}")]
        public ActionResult DeleteQuanLyChiNhanh(int Idchinhanh,int Iduser)
        {
            var b = HttpContext.Request.Headers["token"].ToList().FirstOrDefault();
            if (!string.IsNullOrEmpty(b))
            {
                var item = data.Tblquanlychinhanh.FirstOrDefault(t => t.Idchinhanh == Idchinhanh && t.Iduser == Iduser);
                if (item == null)
                {
                    return NotFound();
                }

                data.Tblquanlychinhanh.Remove(item);
                data.SaveChanges();
                return new OkResult();
            } return BadRequest();
        }
        #endregion
    }
}
