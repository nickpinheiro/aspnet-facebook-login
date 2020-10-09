# Facebook Login with ASP.NET Core (MVC and Razor Pages)

[![Actions Status](https://github.com/nickpinheiro/aspnet-facebook-login/workflows/.NET%20Core/badge.svg)](https://github.com/nickpinheiro/aspnet-facebook-login/actions)

Facebook Login with ASP.NET Core is an open-source and cross-platform framework for building modern cloud based internet connected applications which are integrated with Facebook.  You can develop and run your ASP.NET Core apps cross-platform on Windows, Mac and Linux.

In this repository I have provided sample projects for implementing 'Facebook Login' using both ASP.NET Core MVC and Razor Pages.  

## Features
- Integrate Facebook Login and Graph API into your web app
- Retrieve the user's public profile information
- Redirect the user back to your website using the Redirect Url
- Display the Facebook Id, Email Address, First Name, Last Name, Full Name of the Facebook user

## Preview Image
![Facebook Login with ASP.NET Core](https://www.iamnickpinheiro.com/data/admin/2020/10/facebook-login-aspnet-core-flow.png "Facebook Login with ASP.NET Core")

## Create the app in Facebook
In order to configure your web app to support 'Login with Facebook' you must create a Facebook App in the Facebook Developer Portal
https://developers.facebook.com

- Navigate to the Facebook Developers app page and Log In. If you don't already have a Facebook account, use the Create New Account link on the login page to create one. Once you have a Facebook account, follow the instructions to register as a Facebook Developer.
- From the My Apps menu select Create App to create a new App ID.
- From the 'How are you using your app' popup, select the last option 'For Everything Else'
- Enter an 'App Display Name' (don't worry you can change it later) and click 'Create App ID'
- On the new App card, select Add a Product. On the Facebook Login card, click Set Up
- The Quickstart wizard launches with Choose a Platform as the first page. Bypass the wizard for now by clicking the FaceBook Login Settings link in the menu on the lower left
- You are presented with the Client OAuth Settings page
- Enter your development URI with /user appended into the Valid OAuth Redirect URIs field (for example: https://localhost:44319/user). The Facebook authentication configured these tempaltes will automatically handle requests at /user route to implement the OAuth flow.

## Configuration
Populte the Facebook App Id, App Secret and Redirect Uri in the appsettings.json of each sample project.
- FacebookAppId
- FacebookAppSecret
- FacebookRedirectUri

## Live Demo Sites on Microsoft Azure 
ASP.NET Core MVC  
https://aspnet-facebook-web-mvc.azurewebsites.net

ASP.NET Core Razor Pages  
https://aspnet-facebook-web-razor.azurewebsites.net

## Subscribe for Updates
Subscribe for notifications, updates and new features:  
https://www.iamnickpinheiro.com/#subscribe

## Resources
Facebook Login with ASP.NET Core (MVC and Razor Pages)
https://www.iamnickpinheiro.com/blog/facebook-login-with-aspnet-core

## License
Facebook Login with ASP.NET Core (MVC & Razor Pages) is licensed under the MIT license. See the LICENSE file for more details.