# Autowired.Core

#### Description
Make the default DI container  inject fields and properties easily . (based on .netstandard2.0)

#### Installation


```
PM> Install-Package Autowired.Core
```


#### Instructions

 1. Service with [AppService]Attribute
    ```
    [AppService]
    public class MyService
    {
        //functions
    }
    ```

 2. Setup.ConfigureServices 
    ```
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        //注册应用服务
        services.AddAppServices();
    }
    ```
 3. use it
    ```
    public class HomeController : Controller
    {
        [Autowired]
        MyUserService myUserService;

        public HomeController(AutowiredService autowiredService)
        {
            autowiredService.Autowired(this);
        }
    }
    ```
