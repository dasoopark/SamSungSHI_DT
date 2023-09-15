let http = require("http");
let url = require("url");
let fs = require("fs");
let ejs = require("ejs");

//라우팅 => 클라이언트로부터 다양한 요청을 받는다. 
//이 요청에 대한 처리를 하자. 
//get방식처리와 post방식처리 

let server = http.createServer( (req, res)=>{

    if(req.method=="GET") //브라우저에서 보낼수있음 
    {
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end("<h1>Get방식 처리</h1>");
    }
    else 
    {
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end("<h1>POST방식 처리</h1>"); //post맨
    }
});
//createServer 도 비동기 함수이다. 반환값은 완성된 서버에 대한 참조이다 

server.listen( 4000, ()=>{
    console.log( "server start http://127.0.0.1:4000");
});