using Advanced_Auditing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advanced_Auditing.Controllers
{
    [Authorize]
    public class AuditController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Audit]
        public ActionResult LevelZero()
        {
            return Content("Level 0 Audit Executed");
        }

        public ActionResult LevelOne()
        {
            return View();
        }

        [HttpPost]
        [Audit(AuditingLevel = 1)]
        public ActionResult LevelOne(SimpleViewModel model)
        {
            return Content("Level 1 (Simple) Audit Executed");
        }

        public ActionResult LevelTwo()
        {
            return View();
        }

        [HttpPost]
        [Audit(AuditingLevel = 2)]
        public ActionResult LevelTwo(IntermediateViewModel model)
        {
            return Content("Level 2 (Intermediate) Audit Executed");
        }

        public ActionResult LevelThree()
        {
            return View();
        }

        [HttpPost]
        [Audit(AuditingLevel = 2)]
        public ActionResult LevelThree(AdvancedViewModel model)
        {
            return Content("Level 2 (Advanced) Audit Executed");
        }

        public ActionResult AuditRecords()
        {
            var audits = new AuditingContext().AuditRecords.OrderBy(a => a.TimeAccessed);
            return View(audits);
        }
    }


}
