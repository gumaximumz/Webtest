using NavTECH.Web.Models;
using Services.Models;
using Services.Repositories;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _productService;
        private ProductTypeService _productTypeService;
        private SupplierService _supplierService;
        private static IUnitOfWork _unitOfWork;

        static ProductController()
        {
            _unitOfWork = new UnitOfWork();
        }

        public ProductController()
        {
            _productService = new ProductService(_unitOfWork);
            _productTypeService = new ProductTypeService(_unitOfWork);
            _supplierService = new SupplierService(_unitOfWork);
        }
        public ActionResult Product()
        {
            GetProductTypeDropDown();
            // GetProductType();
            
            GetSupplierDropDown();
            //GetSupplier();
            return View();
        }
        #region DropDown 
        //DropDown ProductType
        public void GetProductTypeDropDown()
        {
            var list = new List<SelectListItem>();
            var model = _productTypeService.Get();


            foreach (var pt in model)
            {
                var selectList = new SelectListItem();
                selectList.Value = pt.Id.ToString();
                selectList.Text = pt.Name;
                list.Add(selectList);
            }
            list.Insert(0, new SelectListItem() { Value = "0", Text = "ผลิตภัณฑ์ทั้งหมด" });
            ViewBag.ProductTypeDropDown = list;
            //var slectList = new SelectList(_productTypeService.Get(), "id", "name");
            //ViewBag.ProductTypeSelectList = slectList;
        }

        public void GetSupplierDropDown()
        {
            var list = new List<SelectListItem>();
            var model = _supplierService.Get();

            foreach (var sp in model)
            {
                var selectList = new SelectListItem();
                selectList.Value = sp.Id.ToString();
                selectList.Text = sp.Name;
                list.Add(selectList);
            }
            
            list.Insert(0, new SelectListItem() { Value = "0", Text = "ทั้งหมด" });
            ViewBag.SupplierDropDown = list;
            //var slectlist = new SelectList(_supplierService.Get(), "id", "name");
            //ViewBag.SupplierSelectList = slectlist;
            
        }
        #endregion
    }
}