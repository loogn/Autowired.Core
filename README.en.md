# Autowired.Core

#### Description
基于.netstandard2.0实现的一个支持属性和字段注入的手脚架

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
