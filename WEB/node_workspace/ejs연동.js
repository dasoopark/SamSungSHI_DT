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
    //html 파일을 불러와서 , 자바스크립트 데이터와 결합해서 새로운 파일을 만들어서 보낸다;
    //비동기모드의 함수일 경우 함수의 마지막 파라미터는 함수이다. 
    //일이 완료되고 나서 시스템이 호출해줄 함수의 주소 또는 함수자체를 전달해줘야 한다 
    //전달하는 함수의 매개변수는 시스템이 결정해놨음 그래서 따라야 한다  
    fs.readFile("./html/index.html", "utf8", function(error, data){
        //error - 파일 읽다가 실패시 에러가 전달된다. 
        //data - 읽은 파일의 내용 

        let resultData = ejs.render(data, {"title":"ejs엔진을 사용해보자"});
        // render (파일데이터, JSON객체);

        res.writeHead(200, {'Content_Type':'text/html;charset=utf8'});
        res.end( resultData );
    } )
    
})

server.listen(port, hostname, ()=>{
    console.log(`http://${hostname}:${port}` )
});

//node 서버1.js
//http://127.0.0.1:4000/test
//http://127.0.0.1:4000/test1 
//http://127.0.0.1:4000/add?x=4&y=6

