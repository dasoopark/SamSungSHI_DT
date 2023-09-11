const http = require("http");//require 외부모듈을 불러온다 
const hostname = "127.0.0.1";
const port = 4000;
let url = require('url'); //url 모듈을 내부로 불러온다

const server = http.createServer( (req, res)=>{
    //console.log( req.url );
    let path = url.parse( req.url, true).pathname;
    console.log( path );
    
    {
        res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
        res.end('<h1>Hello world !!!<h1>');
    }
})

server.listen(port, hostname, ()=>{
    console.log(`http://${hostname}:${port}` )
});

//node 서버1.js
//http://127.0.0.1:4000/test
//http://127.0.0.1:4000/test1 
//http://127.0.0.1:4000/add?x=4&y=6

