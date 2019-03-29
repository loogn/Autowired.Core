# Autowired.Core

#### 介绍
Make the default DI container  inject fields and properties easily . (based on .netstandard2.0)

#### 安装教程

```
PM> Install-Package Autowired.Core
```

#### 使用说明


 1. 编写服务类，并添加[AppService]特性  
    ```
    [AppService]
    public class MyService
    {
        //functions
    }
    ```

 2. 在Setup的ConfigureServices方法中注册应用服务
    ```
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        //注册应用服务
        services.AddAppServices();
    }
    ```
 3. 其他类中注入使用，比如Controller中
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
