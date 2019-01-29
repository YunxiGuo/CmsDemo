using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class ContentController : Controller
    {
        //private readonly TestModeOption _contentListOption;
        private readonly ContentListOption _contentListOption;

        public ContentController(IOptions<ContentListOption> option)
        {
            _contentListOption = option.Value;
        }

        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var contents = _contentListOption;
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content
            //    {
            //        Id = i,
            //        Title = $"{i}的标题",
            //        NeiRong = $"{i}的内容",
            //        Status = 1,
            //        Add_time = DateTime.Now.AddDays(-i)
            //    });
            //}
            return View(new ContentViewModel{ Contents = contents});
        }
    }
}