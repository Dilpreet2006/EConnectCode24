﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eConnect.DataAccess;
using eConnect.Model;
using eConnect.Logic;
using System.IO;
using System.Configuration;
namespace eConnect.Application.Controllers
{
    public class ManageWithdrawalRequestController : Controller
    {
        // GET: ManageWithdrawalRequest
        List<SelectListItem> Status = new List<SelectListItem>()
            {

                new SelectListItem { Text = "Select Status", Value = "" },
                new SelectListItem { Text = "Open", Value = "1" },
                 new SelectListItem { Text = "Close", Value = "2" },
               
            };
        List<SelectListItem> City = new List<SelectListItem>()
            {

                new SelectListItem { Text = "Select City", Value = "" },
            };
        RaiseRequestLogic raiseRequest = new RaiseRequestLogic();
        public ActionResult Index()
        {
            UserLogic objUserDetailLogic = new UserLogic();
            StatusLogic objStatusLogic = new StatusLogic();
            StateLogic objStateLogic = new StateLogic();
            CityLogic objCityLogic = new CityLogic();
            ViewBag.State = new SelectList(objStateLogic.GetAllStates(), "StateId", "Name");
            ViewBag.City = City;
            ViewBag.Status = Status;
           
            var tblWithdrawDetails = raiseRequest.GetManageWithdrawDetails();
            bool flag = Convert.ToBoolean(TempData["flag"]);
            if (flag == true)
            {
                tblWithdrawDetails = TempData["searchdataManage"] as List<sp_GetManageWithdrawalRequestDetails_Result>;
            }
            return View(tblWithdrawDetails.ToList());
        }
        public ActionResult IndexSearch(string Requestid, string CspName, string CspID, string State, string City,string Status,string Requesteddte)
        {
            int Reqid = 0,Cid=0,Sid=0, Cityid=0,Statusid=0;
            if (Requestid == "")
            {
                Reqid = 0;
            }
            else
            {
                Reqid = Convert.ToInt32(Requestid);
            }

            if (CspID == "")
            {
                Cid = 0;
            }
            else
            {
                Cid = Convert.ToInt32(CspID);
            }
            if (State == "")
            {
                Sid = 0;
            }
            else
            {
                Sid = Convert.ToInt32(State);
            }
            if (City == "")
            {
                Cityid = 0;
            }
            else
            {
                Cityid = Convert.ToInt32(City);
            }
            if (Status == "")
            {
                Statusid = 0;
            }
            else
            {
                Statusid = Convert.ToInt32(Status);
            }
            var tblManageWithdrawDetails = raiseRequest.GetManageWithdrawDetailsSearch(Reqid,CspName,Cid,Sid,Cityid,Statusid,Requesteddte);
            TempData["searchdataManage"] = tblManageWithdrawDetails.ToList();
            TempData["flag"] = true;
            return RedirectToAction("Index");
        }
         public JsonResult BindCity(long state_id)
        {
            CityLogic sl = new CityLogic();
            IList<SelectListItem> citylist = new List<SelectListItem>();
            var clist = sl.GetAllCitiesByStateID(state_id);
            foreach (var dr in clist)
            {
                citylist.Add(new SelectListItem { Text = dr.Name.ToString(), Value = dr.CityId.ToString().ToString() });
            }
            return Json(citylist, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int? id)
        {
           
            RaiseRequestLogic raiseRequestdetals = new RaiseRequestLogic();
            ManageWithdrawal objMWithdraw = raiseRequestdetals.GetManageWithdrawDetailByID((int)id);
           var Status = new[]
           {

                 new SelectListItem { Text = "Select Status", Value = "" },
                  new SelectListItem { Text = "Open", Value = "1" },
                 new SelectListItem { Text = "Close", Value = "2" },

            };
            var selectedStatus = Status.FirstOrDefault(d => d.Value == objMWithdraw.CurrentStatus.ToString());
            if (selectedStatus != null)
                selectedStatus.Selected = true;
            ViewBag.EditedStatus = Status;
            return View(objMWithdraw);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ManageWithdrawal objMWithdraw)
        {

                RaiseRequestLogic raiseRequestLogic = new RaiseRequestLogic();
                raiseRequestLogic.UpdateManageWithdrawDetail(objMWithdraw);
                TempData["Message"] = "Record submitted successfully";
                return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            RaiseRequestLogic raiseRequestdetals = new RaiseRequestLogic();
            ManageWithdrawal objMWithdraw = raiseRequestdetals.GetManageWithdrawDetailByID((int)id);
            var Status = new[]
            {

                 new SelectListItem { Text = "Select Status", Value = "" },
                  new SelectListItem { Text = "Open", Value = "1" },
                 new SelectListItem { Text = "Close", Value = "2" },

            };
            var selectedStatus = Status.FirstOrDefault(d => d.Value == objMWithdraw.CurrentStatus.ToString());
            if (selectedStatus != null)
                selectedStatus.Selected = true;
            ViewBag.EditedStatus = Status;
            return View(objMWithdraw);
        }
    }
}