<p align="center" dir="auto">
    <a target="_blank" rel="noopener noreferrer nofollow" href="https://camo.githubusercontent.com/0a8394c0ebe79b04b29d7b9d84399d07ec746f8b761c8251b8c4789ab02b541c/68747470733a2f2f726561646d652d747970696e672d7376672e6865726f6b756170702e636f6d2f3f6c696e65733d48656c6c6f3b57656c636f6d652b746f2b6d792b70726f66696c65213b486176652b612b6c6f6f6b2b61726f756e642126666f6e743d46697261253230436f646526636f6c6f723d2532334436324637392663656e7465723d747275652677696474683d323830266865696768743d3530"><img src="https://camo.githubusercontent.com/0a8394c0ebe79b04b29d7b9d84399d07ec746f8b761c8251b8c4789ab02b541c/68747470733a2f2f726561646d652d747970696e672d7376672e6865726f6b756170702e636f6d2f3f6c696e65733d48656c6c6f3b57656c636f6d652b746f2b6d792b70726f66696c65213b486176652b612b6c6f6f6b2b61726f756e642126666f6e743d46697261253230436f646526636f6c6f723d2532334436324637392663656e7465723d747275652677696474683d323830266865696768743d3530" data-canonical-src="https://readme-typing-svg.herokuapp.com/?lines=Hello;Welcome+to+my+profile!;Have+a+look+around!&amp;font=Fira%20Code&amp;color=%23D62F79&amp;center=true&amp;width=280&amp;height=50" style="max-width: 100%;"></a>
</p>

# studyASPNET
ASP.NET Core 학습 리포지토리

- Languages <br/>
<img src="https://camo.githubusercontent.com/dd433625a6e00049c26f08143705ff9e32d5da44f503f1be133664b11e37e34b/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f432532332d3233393132303f7374796c653d666f722d7468652d6261646765266c6f676f3d632d7368617270266c6f676f436f6c6f723d7768697465" data-canonical-src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&amp;logo=c-sharp&amp;logoColor=white" style="max-width: 100%;"> <img alt="Html" src ="https://img.shields.io/badge/HTML-E34F26.svg?&style=for-the-badge&logo=HTML5&logoColor=white"/> <img alt="Css" src ="https://img.shields.io/badge/CSS-1572B6.svg?&style=for-the-badge&logo=CSS3&logoColor=white"/> <img alt="JavaScript" src ="https://img.shields.io/badge/JavaScriipt-F7DF1E.svg?&style=for-the-badge&logo=JavaScript&logoColor=olive"/>

- Using Tool <br/>
<img alt="VisualStudio" src ="https://img.shields.io/badge/VisualStudio-5C2D91.svg?&style=for-the-badge&logo=VisualStudio&logoColor=Magenta "/> <img alt="Microsoft SQL Server" src ="https://img.shields.io/badge/Microsoft SQL Server-CC2927.svg?&style=for-the-badge&logo=Microsoft SQL Server&logoColor=sirver"/>

- 그 외<br/>
  <img alt="Bootstrap" src ="https://img.shields.io/badge/Bootstrap-7952B3.svg?&style=for-the-badge&logo=Bootstrap&logoColor=violet"/>

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

- Function(event)
```
$(document).ready(function () {
   $('h1').click(function () {
            alert('클릭');
    });
});
```

## 4일차
1. 웹 기반기술 총 복습
   - 핀터레스트 스타일 프론트엔드 연습
   - [랜덤이미지추가](https://placeimg.com/)
   - [소스](https://github.com/roving324/studyASPNET/tree/main/Day04/FrontEndExec/Pages)
   
- 메인컨텐트 사이즈별 반응형 웹
```
#main-section {
    width: 920px;
    margin: 0 auto;
}

/* 세줄 */
@media (max-width: 919px) {
    #main-section {
      width: 690px
    }
}

/* 네줄 */
@media (min-width: 920px) and (max-width: 1149px) {
    #main-section {
      width: 920px
    }
}
```

- 이미지 클릭 확대 이벤트
```
// 같은 이미지 출력
            function showLightBox(obj) {

                var img_src = obj.getElementsByTagName('img')[0].src;
                // 라이트박스 보이게 하기
                $('#random-image').attr({
                    src: img_src
                });
                $('#darken-background').show();
                $('#darken-background').css('top', $(window).scrollTop());
                // 스크롤 금지
                $('body').css('overflow', 'hidden');
            }
```

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
![게시판페이징화면](https://github.com/roving324/studyASPNET/blob/main/Images/Index.PNG)
게시판페이징화면

## 8일차
1. ASP.NET Core
   - 회원가입 완료
   - 계정관리(회원가입,로그인)
   - 세션관리
   - [Freebootstrap](https://startbootstrap.com/themes)
   - [velog](https://velog.io/)
  
- 오류발생시 출력
```
foreach (var error in result.Errors)
{
	ModelState.AddModelError(string.Empty, error.Description);
}  
```

- 패스워드 정책 변경 설정
```
builder.Services.Configure<IdentityOptions>(
    opt =>
    {
        opt.Password.RequiredLength = 4;             // 최소 번호 개수
        opt.Password.RequireNonAlphanumeric = false; // 특수문자
        opt.Password.RequireDigit = false;           // 영문자
        opt.Password.RequireLowercase = false;       // 소문자
        opt.Password.RequireUppercase = false;       // 대문자
    }
);
```
2. 결과화면

![템플릿적용화면](https://github.com/roving324/studyASPNET/blob/main/Images/template.PNG)
템플릿적용화면

![회원가입화면](https://github.com/roving324/studyASPNET/blob/main/Images/register.png)<br/>
회원가입화면



## 9일차
1. ASP.NET Core
   - Bootstrap 템플릿 적용 1차 완료
   - 로그인 계정으로 글쓰기
   - 메인페이지 DB연동
   - [stackoverflow](https://stackoverflow.com/)
   
2. 개발화면
![메인페이지](https://github.com/roving324/studyASPNET/blob/main/Images/Day09.PNG)
메인페이지 DB연동

## 10일차
1. ASP.NET Core
   - 메인페이지 DB연동(관리자) 완료
   - 권한관리
   - 마무리
   - [최종 Code](https://github.com/roving324/studyASPNET/tree/main/Day10/BoardWebApp)
  
- 권한관리 설정
```
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminRolePolicy", policy => policy.RequireRole("Admin"));
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("EditRolePolicy", policy => policy.RequireRole("Edit Role"));
    options.AddPolicy("DeleteRolePolicy", policy => policy.RequireRole("Delete Role"));
});
```

2. 개발화면

![권한관리화면](https://github.com/roving324/studyASPNET/blob/main/Images/Roles.PNG)
권한관리화면

![메인관리화면](https://github.com/roving324/studyASPNET/blob/main/Images/Profile.PNG)
메인관리화면

