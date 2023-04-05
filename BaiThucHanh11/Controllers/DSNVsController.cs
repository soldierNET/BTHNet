using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiThucHanh11.Models;

namespace BaiThucHanh11.Controllers
{
    public class DSNVsController : Controller
    {
        private Model1 db = new Model1();

        // GET: DSNVs
        public ActionResult Index()
        {
            return View(db.DSNVs.ToList());
        }

        // GET: DSNVs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DSNV dSNV = db.DSNVs.Find(id);
            if (dSNV == null)
            {
                return HttpNotFound();
            }
            return View(dSNV);
        }

        // GET: DSNVs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DSNVs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,HoTen,NgaySinh,GioiTinh,MaPhong,MaChucVu,HeSoLuong")] DSNV dSNV)
        {
            if (ModelState.IsValid)
            {
                db.DSNVs.Add(dSNV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dSNV);
        }

        // GET: DSNVs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DSNV dSNV = db.DSNVs.Find(id);
            if (dSNV == null)
            {
                return HttpNotFound();
            }
            return View(dSNV);
        }

        // POST: DSNVs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,HoTen,NgaySinh,GioiTinh,MaPhong,MaChucVu,HeSoLuong")] DSNV dSNV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dSNV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dSNV);
        }

        // GET: DSNVs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DSNV dSNV = db.DSNVs.Find(id);
            if (dSNV == null)
            {
                return HttpNotFound();
            }
            return View(dSNV);
        }

        // POST: DSNVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DSNV dSNV = db.DSNVs.Find(id);
            db.DSNVs.Remove(dSNV);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
