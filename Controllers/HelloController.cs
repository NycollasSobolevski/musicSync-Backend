[ApiController]
[Route("[controller]")]
[EnableCors("MainPolicy")]
public class HelloController 
{
    [HttpGet]
    public string Get()
    {
        return "Hello World!";
    }
}