let http = require("http");
let url = require("url");
let fs = require("fs");
let ejs = require("ejs");

let route = require("./route1");//외부모듈을 불러온다 


//라우팅 => 클라이언트로부터 다양한 요청을 받는다. 
//이 요청에 대한 처리를 하자. 
//get방식처리와 post방식처리 

let server = http.createServer( (req, res)=>{

    if(req.method=="GET") //브라우저에서 보낼수있음 
    {
        //euc-kr 또는 ksc-5601 : 옛날거 -,한글하고 영어만 지원
        //utf-8 : 모든 문자 시스템을 지원
        //특히 다국어 서비스를 제공할때 utf-8로 하자 
        let pathName = url.parse(req.url).pathname;
        if(pathName == "/test1")
        {
            route.test1(req, res); 
        }
        else if(pathName =="/test2")
        {
            route.test2(req, res); 
        }
        else if(pathName =="/board/list")
        {
            route.board_list(req, res); 
        }
        else if(pathName =="/board/write")  // url => 함수명은 관계없음 
        {
            route.board_write(req, res); 
        }
        else
        {
            res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
            res.end("<h1>My Home</h1>");
        }
    }
    else  //POST방식
    {
        let pathName = url.parse(req.url).pathname;
        if(pathName == "/board/save")
        {
            route.board_save(req, res);
            
        }
        else 
        {
            res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
            res.end("<h1>POST방식 처리</h1>"); //post맨
        }
    }
});
//createServer 도 비동기 함수이다. 반환값은 완성된 서버에 대한 참조이다 

server.listen( 4000, ()=>{
    console.log( "server start http://127.0.0.1:4000");
});