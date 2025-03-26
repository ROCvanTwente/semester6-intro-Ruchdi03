using Microsoft.AspNetCore.Mvc;
using Semester6_DiceCode4.Utilities;

namespace Semester6_DiceCode4.Controllers
{
    public class ASPEC_01Controller : Controller
    {
        private const string ViewPath = "~/Views/Semester6_Views/ASPEC_01/Index.cshtml";

        public IActionResult Index()
        {
            return View(ViewPath);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EncryptText(string text, int key)
        {
            try
            {
                if (string.IsNullOrEmpty(text))
                {
                    ModelState.AddModelError("text", "Voer tekst in");
                    return View(ViewPath);
                }

                var encryptedText = ASPEC_01_Encryption.Encrypt(text, key);
                return Json(new { success = true, result = encryptedText });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DecryptText(string encryptedText, int key)
        {
            try
            {
                if (string.IsNullOrEmpty(encryptedText))
                {
                    ModelState.AddModelError("encryptedText", "Voer versleutelde tekst in");
                    return View(ViewPath);
                }

                var decryptedText = ASPEC_01_Encryption.Decrypt(encryptedText, key);
                return Json(new { success = true, result = decryptedText });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }
    }
}