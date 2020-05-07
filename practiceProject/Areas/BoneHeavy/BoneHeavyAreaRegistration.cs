using System.Web.Mvc;

namespace practiceProject.Areas.BoneHeavy
{
    public class BoneHeavyAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BoneHeavy";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BoneHeavy_default",
                "BoneHeavy/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}