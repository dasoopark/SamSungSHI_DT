const http = require("http");//require 외부모듈을 불러온다 
const hostname = "127.0.0.1";
const port = 4000;
let url = require('url'); //url 모듈을 내부로 불러온다
let fs = require("fs");

const server = http.createServer( (req, res)=>{
    //console.log( req.url );
    let path = url.parse( req.url, true).pathname;
   
    
    {
        //readFileSync - 동기모드로 파일을 읽는다 
        let file = fs.readFileSync("./html/index.html", "utf-8");

        res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
        res.end(file); //파일 전송
    }
})

server.listen(port, hostname, ()=>{
    console.log(`http://${hostname}:${port}` )
});

//node 서버1.js
//http://127.0.0.1:4000/test
//http://127.0.0.1:4000/test1 
//http://127.0.0.1:4000/add?x=4&y=6

