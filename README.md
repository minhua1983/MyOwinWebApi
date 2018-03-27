# OWIN下selfhost的webapi实例
这是一个OWIN下selfhost的webapi实例，以WebApi为Application，自定义了几个中间件做拦截，以形成管道的概念。通过学习OWIN规范，从而熟悉asp.net core中基础。

## 运行环境
* .net framework 4.5.2

## 项目依赖
* Owin，Owin原始程序集，提供了UseWebApi方法，以便使得WebApi可以作为Application
* Microsoft.Owin，微软封装的Owin程序集
* Microsoft.Owin.Hosting，用于使用WebApp类，当前Console程序就是Host
* Microsoft.Owin.Host.HttpListener，作为Server

## 目录说明
* MyController，用于存放所有继承自System.Web.Http.ApiController的自定义Controller类，自定义Controller类必须以Controller为类名后缀。
* MyMiddleware，用于自定义中间件，以便做拦截，多个中间件可以形成管道结构。
