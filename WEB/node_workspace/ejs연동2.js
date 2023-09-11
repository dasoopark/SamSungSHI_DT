const http = require("http");//require 외부모듈을 불러온다 
const hostname = "127.0.0.1";
const port = 4000;
let url = require('url'); //url 모듈을 내부로 불러온다
let ejs = require('ejs');  // 모듈을 내가 만들어서 같은 폴더에 있으면 ./모듈명 으로 시작 
                           //시스템이 제공하는 외부모듈은 폴더명 들어가면 안된다. 
                           //node_modules   폴더에서 찾는다 

let fs = require('fs'); //파일과 관련한 모듈이다 

const server = http.createServer( (req, res)=>{
    //console.log( req.url );
    let path = url.parse( req.url, true).pathname;
    console.log( path );

    if(path=="/")
    {
        fs.readFile("./html/index.html", "utf8", function(error, data){
            let resultData = ejs.render(data, {"title":"ejs엔진을 사용해보자"});
            res.writeHead(200, {'Content_Type':'text/html;charset=utf8'});
            res.end( resultData );
        })
    }
    else if(path=="/userinfo") //http://locahlost:4000/userinfo
    {
        fs.readFile("./html/userinfo.html", "utf8", function(error, data){
            let resultData = ejs.render(data, 
                    {
                        "username":"홍길동", 
                        "phone":"010-0000-0001",
                        "age":23,
                        "address":"거세시 장평동",
                        "fav":["자바", "nodejs", "c#", "unity"],
                        "friends":[
                            {"name":"박철수", "phone":"010-0000-0001"},
                            {"name":"김정숙", "phone":"010-0000-0002"},
                            {"name":"권미연", "phone":"010-0000-0003"},
                        ]
                    }
                );
            res.writeHead(200, {'Content_Type':'text/html;charset=utf8'});
            res.end( resultData );
        })
    }
    
})

server.listen(port, hostname, ()=>{
    console.log(`http://${hostname}:${port}` )
});

//node 서버1.js
//http://127.0.0.1:4000/test
//http://127.0.0.1:4000/test1 
//http://127.0.0.1:4000/add?x=4&y=6

