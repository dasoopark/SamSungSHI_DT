const http = require("http");
const hostname = "127.0.0.1";
const port ="4000";
let url = require("url"); //url 모듈을 내부러 불러온다
let queryString = require("querystring");
// npm install @ungap/url-search-params 
let URLSearchParams = require("@ungap/url-search-params");

const server = http.createServer( (req, res) =>{
   // console.log(req.url);
    let path = url.parse(req.url,true).pathname;
    console.log(path);
    if(req.method=="POST")
    {
        req.on('data', (receiveData)=>{
            //let data = queryString.parse(receiveData.toString()); //옛날꺼
            let data = URLSearchParams.parse(receiveData.toString()); //최신꺼
            console.log(data);
            //{'x'=>4,} == express framework 쓰면 알아서 해준다.
            if(path=="/add")
            {
                let x = parseInt(data.get("x")); //신버전
                let y = parseInt(data.get("y")); //신버전
                res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
                res.end(`<h1>${x}+${y}=${x+y}<h1>`);
               
            }
            else
            {
                res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
                res.end('<h1>Hello World!!!<h1>');
            }
        })
    }
   
})

server.listen(port, hostname, ()=>{
    console.log(`http://${hostname}:${port}`)
});

//node 서버1.js
//http://127.0.0.1:4000/test
//http://127.0.0.1:4000/test1
//http://127.0.0.1:4000/add?x=4&y=8;

/*
node_modules 에는 nodejs 라이브러리가 설치되는 공간이다.

지역풀더 : 자기 프로젝트 내에서만 사용할때
npm install 라이브러리명
로 설치를 하면 package.json 이라는 파일에 설치된 라이브러리 정보가 자동으로 저장됨.
(예전에는 저장안됐음)
    npm install --save 라이브러리명 --save 옵션이 필요했었다.
지역풀더의 경우 삭제 후 package.json 파일이 있는 곳에서 
npm install 이라고 치면 다시 설치된다.

전역풀더 : 

모든 프로젝트가 사용가능한 라이브러리 설치공간
npm install -g 라이브러리명
*/