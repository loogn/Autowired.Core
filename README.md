# Autowired.Core

#### 介绍
Make the default DI container  inject fields and properties easily . (based on .netstandard2.0)

#### 安装教程

```
PM> Install-Package Autowired.Core
```

#### 一、基本使用说明

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
#### 二、生命周期
```
    [AppService(ServiceLifetime.Transient)]
    public class MyService
    {
        //functions
    }
```
#### 三、实现接口

服务代码：
```
    public interface IService{}

    [AppService]
    public class MyService:IService
    {
        //functions
    }
```

注入代码：

```
    [Autowired]
    IService myUserService; 
```

#### 四、实现多接口
```
    public interface IService1{}
    public interface IService2{}

    [AppService]
    public class MyService:IService1,IService2
    {
        //functions
    }
```
这个时候可以默认注入类型可以是IService1，即第一个接口类型,如果要注入的IService2，可以把IService2放在第一位，也可以如下声明：
```
    [AppService(typeof(IService2))]  //对应IService2
    [AppService]   //对应IService1
    public class MyService:IService1,IService2{
        //functions
    }
```

#### 五、一个接口多个实现
```
    public interface IService{}

    [AppService("ser1")]
    public class Service1:IService{
        //service1的实现
    }        
    [AppService("ser2")]
    public class Service2:IService{
        //service2的实现
    }
```
注入的时候，我们可以根据identifier指定具体哪个实现
```
    [Autowired("ser1")]
    IService service1; 

    [Autowired("ser2")]
    IService service2;
```
