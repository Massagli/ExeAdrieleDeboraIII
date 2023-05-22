using System.Web.Mvc;

namespace ExeAdrieleDeboraIII.Areas.Veiculo
{
    public class VeiculoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Veiculo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Veiculo_default",
                "Veiculo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}