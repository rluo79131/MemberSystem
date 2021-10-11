## 說明
- 採用 .NET 框架技術，來實作會員系統的應用。
- 串接Google、Facebook和Line平台，來實作第三方登入功能。

## 專案架構
- MS：SQL Server資料庫專案
- MS.Web：前台網站
- MS.Admin：後台網站

## MS.Web專案
- 使用 .NET Framework 框架技術。
- 採用 FormsAuthentication 作為授權驗證方案。
- 採用 Entity Framework 6 作為ORM方案。

## MS.Admin專案
- 使用 .NET Core 框架技術。
- 採用 CookieAuthentication 作為授權驗證方案。
- 採用 Entity Framework Core 作為ORM方案。

## Entity Framework 指令
- Entity Framework 6
1. enable-migrations
2. add-migration Init
3. pdate-database –Verbose
- Entity Framework Core
1. add-migration [migration]-Context [DbContext]
2. update-database -Context [DbContext]

## 參考
1. 授權驗證
- https://mileslin.github.io/2017/07/ASP-NET-表單驗證
- https://dotblogs.com.tw/shadow/2019/01/16/105615
2. Line登入
- https://developers.line.biz/console
- https://developers.line.biz/zh-hant/docs/line-login/integrate-line-login/#making-an-authorization-request
3. Facebook登入
- https://developers.facebook.com/apps
- https://developers.facebook.com/docs/graph-api/using-graph-api/
4. Google登入
- https://console.cloud.google.com/apis/dashboard
- https://www.oauth.com/oauth2-servers/signing-in-with-google/verifying-the-user-info
