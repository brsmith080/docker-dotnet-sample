using Microsoft.AspNetCore.Mvc;

public class HelloController : Controller
{
	public ActionResult Say()
	{
		return this.Content("Hello");
	}
}