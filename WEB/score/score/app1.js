//app1.js
//npm install express

let express = require('express');
//express 프레임워크 안에 http 모듈이 다 들어가 있고 http 직접 사용안하고 express 모듈로 작업을 한다.

//1. express 객체를 생성한다.
let app = express();

7                                                    
//http://127.0.0.1:4000/a 일때
app.get("/a", (req,res)=>{
    res.writeHead(200, {'Content=Type':'text/html;charset=utf-8'});
    res.end(' <h1>A</h1> ');
})

//http://127.0.0.1:4000/b 일 때
app.get("/b", (req,res)=>{
    res.writeHead(200, {'Content=Type':'text/html;charset=utf-8'});
    res.end(' <h1>B</h1> ');
})

//get, post, use(get이나 post 둘 다) - 라우터 역할을 한다.
app.use( (req, res)=>{
    res.writeHead(200, {'Content=Type':'text/html;charset=utf-8'});
    res.end(' <h1>Express</h1> ');
});

app.listen(4000, ()=>{

    console.log("http://127.0.0.1:4000 server start");
});

//node app1.js