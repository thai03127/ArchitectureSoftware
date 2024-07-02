using Microsoft.AspNetCore.Mvc;
using StoreManage.Models;
using StoreManage.Patterns.Commands;

namespace StoreManage.Controllers
{
    public class BenefitController : Controller
    {
        private List<Benefit> benefits = new List<Benefit>();
        private BenefitManagerCommand benefitManager = new BenefitManagerCommand();

        public BenefitController()
        {
            // Khởi tạo dữ liệu mẫu
            benefits.Add(new Benefit { benefitID = 1, benefitName = "Health Insurance" });
            benefits.Add(new Benefit { benefitID= 2, benefitName = "Dental Coverage" });
        }

        public ActionResult Index()
        {
            return View(benefits);
        }

        [HttpPost]
        public ActionResult AddBenefit(string benefitName)
        {
            // Thực hiện thêm Benefit mới
            int newBenefitID = benefits.Count + 1; // Tạm thời làm như vậy, thực tế cần xử lý logic phù hợp
            Benefit newBenefit = new Benefit { benefitID = newBenefitID, benefitName = benefitName };
            ICommand addCommand = new AddBenefitCommand(newBenefit, benefits);
            benefitManager.AddCommand(addCommand);
            benefitManager.ExecuteCommands();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveBenefit(int id)
        {
            // Xác định Benefit cần xóa
            Benefit selectedBenefit = benefits.Find(b => b.benefitID == id);
            if (selectedBenefit != null)
            {
                ICommand removeCommand = new RemoveBenefitCommand(selectedBenefit, benefits);
                benefitManager.AddCommand(removeCommand);
                benefitManager.ExecuteCommands();
            }

            return RedirectToAction("Index");
        }
    }
}
