# studyASPNET
ASP.NET Core 학습 리포지토리
- 개발 Tool <br/>
<img alt="Html" src ="https://img.shields.io/badge/HTML-E34F26.svg?&style=for-the-badge&logo=HTML5&logoColor=white"/> <img alt="Css" src ="https://img.shields.io/badge/CSS3-1572B6.svg?&style=for-the-badge&logo=CSS3&logoColor=white"/> <img alt="JavaScript" src ="https://img.shields.io/badge/JavaScriipt-F7DF1E.svg?&style=for-the-badge&logo=JavaScript&logoColor=olive"/> <img alt="VisualStudio" src ="https://img.shields.io/badge/VisualStudio-5C2D91.svg?&style=for-the-badge&logo=VisualStudio&logoColor=Magenta "/> <img alt="Microsoft SQL Server" src ="https://img.shields.io/badge/Microsoft SQL Server-CC2927.svg?&style=for-the-badge&logo=Microsoft SQL Server&logoColor=sirver"/> <img alt="Bootstrap" src ="https://img.shields.io/badge/Bootstrap-7952B3.svg?&style=for-the-badge&logo=Bootstrap&logoColor=violet"/>

## 1일차
1. Git/Github Desktop 설정
2. Visual Studio(IDE) 개발환경 설정
3. 웹 기반기술
   - HTML 5, CSS 3, javascript (ECMAScript 6) 전체개요
  
## 2일차
1. 웹 기반기술
   - HTML 기본태그
   - CSS 전반 학습
   
## 3일차
1. 웹 기반기술
   - 반응형 웹 (Responsive Web)
   - Javascript 문법
   - Dom (Document Object Model)
   - [jQuery](https://code.jquery.com)
   
## 4일차
1. 웹 기반기술 총 복습
   - 핀터레스트 스타일 프론트엔드 연습
   - [랜덤이미지추가](https://placeimg.com/)
   - [소스](https://github.com/roving324/studyASPNET/tree/main/Day04/FrontEndExec/Pages)
2. 결과화면

![메인화면](https://github.com/roving324/studyASPNET/blob/main/Images/html_screen01.png)
메인화면

![라이트박스화면](https://github.com/roving324/studyASPNET/blob/main/Images/html_screen02.png)
라이트박스화면<br/>


## 5일차
1. ASP.NET Core
   - 기본개요
   - 기본프로젝트
   - 게시판 만들기 프로젝트 생성
   - NuGet 패키지 설치
     - Microsoft.EntityFrameworkCore
     - Microsoft.EntityFrameworkCore.SqlServer
     - Microsoft.EntityFrameworkCore.Tools
     - Microsoft.VisualStudio.Web.CodeGeneration.Design
   
## 6일차
1. ASP.NET Core
   - 게시판 만들기 시작
   - 게시판 리스트
   - 게시판 글 생성
   - [trumbowyg](https://getbootstrap.com)
   
## 7일차
1. ASP.NET Core
   - 게시판 추가기능
   - 페이징 기능
   - 게시판 완성
   - 회원가입 진행 중
   - [Toastr](https://github.com/CodeSeven/toastr)
   
2. 결과화면
![게시판페이징화면](https://github.com/roving324/studyASPNET/blob/main/Images/asp.net_screen01.png)
게시판페이징화면

## 8일차
1. ASP.NET Core
   - 회원가입 완료
   - 계정관리(회원가입,로그인)
   - 세션관리
   - [Freebootstrap](https://startbootstrap.com/themes)
   - [velog](https://velog.io/)
  
2. 결과화면

![회원가입화면](https://github.com/roving324/studyASPNET/blob/main/Images/register.png)<br/>
회원가입화면

![템플릿적용화면](https://github.com/roving324/studyASPNET/blob/main/Images/template.PNG)
템플릿적용화면

## 9일차
1. ASP.NET Core
   - Bootstrap 템플릿 적용 1차 완료
   - 로그인 계정으로 글쓰기
   - 메인페이지 DB연동
   - [stackoverflow](https://stackoverflow.com/)
   
2. 개발화면
![메인페이지](https://github.com/roving324/studyASPNET/blob/main/Images/Day09.PNG)
메인페이지

## 10일차
1. ASP.NET Core
   - 메인페이지 DB연동(관리자) 완료
   - 권한관리
   - 마무리
   
2. 개발화면


<pre>
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminRolePolicy", policy => policy.RequireRole("Admin"));
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("EditRolePolicy", policy => policy.RequireRole("Edit Role"));
    options.AddPolicy("DeleteRolePolicy", policy => policy.RequireRole("Delete Role"));
});
</pre>