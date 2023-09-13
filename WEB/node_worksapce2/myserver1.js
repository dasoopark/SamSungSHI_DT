//다른언어는 별도의 
/*
WebServer - html 문서나 css, image, js 등을 미리 만들어놓고 
            클라이언트가 요청하면 서버에서 찾아서 클라이언트에게 
            보내는 일을 한다.(아파치, ngnix) 
WAS(Web Application Server) - jsp를 예로 들면  html  안에 
            자바 코드가 들어감, 자바코드를 번역해서 새로운 html을 
            만들어서 클라이언트로 전송한다 

노드는 별도의 WebServer 나 WAS가 없다. 우리가 만든다. 
http 라는 모듈을 제공하고 이 모듈을 이용해 웹서버를 만들 수 있다 
*/

let http = require("http");
let url = require("url");

//1.서버를 생성한다.  
let server = http.createServer( (req, res)=>{
    //서버는 클라이언트부터의 요청을 처리하여 새로운 결과를 클라이언트로 전송해야 한다. 
    //req - request : 클라이언트로부터의 모든 요청을 받아들이는 객체이다. 
    //res - response : 클라이언트에게 응답을 보낼때 사용하는 객체이다. 
    //서버에 연결 요청이 오면 이 함수가 호출된다. 

    res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
    //통신 상태에 대한 정보와 서버가 보낼 정보의 타입에 대한 부분을 먼저 보낸다. 
    //200 은 통신이 제대로 완료했음을 의미한다. 
    //Content-Type : 보내는 정보가 어떤 형태인지 json인지 html인지 text 또는 엑셀인지 .... 
    res.end("<h1>Nodejs</h1>");
});
//createServer 도 비동기 함수이다. 반환값은 완성된 서버에 대한 참조이다 

//서버가 대기중인 상태로 들어간다. 
server.listen( 4000, ()=>{
    console.log( "server start http://127.0.0.1:4000");
});