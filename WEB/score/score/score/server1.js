//1.필요한 모듈을 먼저 읽는다 
let http = require('http'); //웹서버만드는데 필요한 라이브러리 
let fs = require('fs'); //외부의 html 파일을 읽고 쓰는데 사용한다 
let ejs = require('ejs'); // html 문서와 json객체를 합쳐 새로운 html 문서를 만든다(랜더링)
let URLSearchParams = require('@ungap/url-search-params'); 
//POST 방식 전송때 실 데이터를 추출하는 라이브러리 => 16버전부터 이거 사용 
let url = require('url');  //url분석 라이브러리 

/*
브라우저(클라이언트 )  =====================================> 서버
                              request객체 
                       <===================================== 
                              response객체 

브라우저에서 정보는 GET, POST형태로 전송
                    GET ->  request객체의 url속성에 모든 정보가 있다. 
                    http://127.0.0.1:4000/userinfo?name=Tom&age=12   가 한문장으로 
                    서버에 전달된다. 여기서 
                    /userinfo  
                    name=Tom
                    age=12    등의 데이터를 추출하는것을 parsing이라고 한다 

                    /userinfo - pathname     url.parse(req.url).pathName  

                    url.parse(req.url).query
                    {"name":"tom"}
                    {"age":12}   형태로 데이터 전달을 받아야 한다 

                   
            POST형태로 전송(form태그있는 html 페이지 만들어서 post 로 전송)
             req.url-  header 정보(간단한거) - get방식은 이것만 간다 
             post 방식은 데이터를 따로 비동기로 보낸다. 
             post방식은 원칙이 데이터가 무제한으로 간다. 
             그러나 실제 이용시 무제한을 쓰면 데이터 전송동안 화면이 멈춰있는것처럼 보인다. 
             그래서 실제로는 20~30M 정도만, 많아야 50~100M 까지 
             돈주고 사거나 유투브에 올려놓고 링크만 가져오기도 한다 

             패스는 똑같다. ? 부터가 달라짐 
             http://127.0.0.1:4000/userinfo
              /userinfo - pathname     url.parse(req.url).pathName  

            //나머지 정보 
             let body="";
             req.on('data', (data)=>{
                body += data; //데이터 오는동안 틈틈이 계속 호출된다. 
             }); 

             //파싱을 한다.
             query = new URLSearchParams(body); 수신받은데이터를 파싱한다. 
             let name = query.get("name");
             {"name":name}
*/

let server = http.createServer( (req, res)=>{
    //createServer - http 통신을 담당할 객체를 만들고 객체 주소를 반환한다. 
    //매개변수인 (req, res)=>{ } 함수는 클라이언트가 접속해오면 이 함수가 호출된다. 
    //request객체, response개체인데 변수명은 내마음임 
    
    //클라이언트로부터 요청을 받아서 응답을 해야 한다 

    //서버와 클라이언트가 서로 정보를 주고 받는다. 
    //상태값 - 200, 500,404, 403, 302, ...... http프로토콜 
    //200 -성공, {"Content-Type":"text/html"}

    process( req, res );//모든 처리를 담당한다. 

    // res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"} );
    // res.end("<h1>success</h1>");
}); //서버가 만들어짐 , 아직 작동은 안함 

server.listen( 4000, ()=>{
    //4000 : 포트번호, 이 포트번호는 1~65537 쓸수있지만 1000이하는 알려진 포트번호 
    //협회에서 지정함   
    //80 - http, 21-telnet, 23-ftp, 22-ssh ....... 
    //3306- mysql, oracle-1521, mssql-1443  ...... 
    //하나의 포트는 한개만 연결할 수 있다. 
     //작동이 시작되면 두번째 매개변수 함수가 호출된다. 
     //프로세스가 계속 작동한다 
     console.log( "http://127.0.0.1:4000  server start "); 
});

let route = require("./route1");
function process(req, res)
{
    let pathname = url.parse(req.url, true).pathname; //get, post나 똑같다 
    
    if(pathname=="/")
    {
        //첫번째 페이지임 
        route.index(req, res); 
    }
    else if(pathname=="/flower")
    {
        //첫번째 페이지임 
        route.flower(req, res); 
    }
    else if(pathname=="/image") //별도의 작업을 필요로 한다. 
    {  // image 폴더에 http 형태로 접근할 수 있도록 별도의 처리를 해야 한다 
        //첫번째 페이지임 
        //route.flower(req, res); 
        //express framework - 처리해줌
    }
    else if(pathname=="/score/list")
    {
        //http://127.0.0.1:4000/score/list
        route.score_list(req, res); //함수 만들어야 함 
    }
    else if(pathname=="/score/view")
    {
        //http://127.0.0.1:4000/score/view
        route.score_view(req, res); //함수 만들어야 함 
    }
    else if(pathname=="/score/write")
    {
        //http://127.0.0.1:4000/score/write
        route.score_write(req, res); //함수 만들어야 함 
    }
    else if(pathname=="/score/save")
    {
        //http://127.0.0.1:4000/score/save
        route.score_save(req, res); //함수 만들어야 함 
    }

    else
    {
        res.writeHead(404, {"Content-Type":"text/html;charset=utf-8"} );
        res.end("해당 페이지가 존재하지 않습니다");
    }
}

//문제1.  html 파일을 하나 만들고 파일명은  flower1.html  
//        /flower  라고 경로를 치면 flower1.html 내용이 보이게 하기     

/*
 
  /weekpay/list 
 /weekpay/write 
 /weekpay/save

주급 
이름, 시간당급여, 근무시간 

홍길동  10000 40 40000
장길산  20000 20 40000

route2.js 파일에 몰아넣기 
weekpay_list();
weekpay_write();
weekpay_save();

weekpay/weekpay_list.html 
weekpay/weekpay_write.html 
weekpay/weekpay_view.html 
*/