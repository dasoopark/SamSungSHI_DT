//app1.js 

let express = require('express');
//express 프레임워크 안에 http 모듈이 다 들어가 있고 http 직접 사용안하고 express 모듈로 작업을 한다 

//1. express객체를 생성한다 
let app = express();

//http://127.0.0.1:4000/a 
app.get("/a", (req, res)=>{
    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end( '<h1>A</h1>');
})

//http://127.0.0.1:4000/b 
app.get("/b", (req, res)=>{
    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end( '<h1>B</h1>');
})

//http://127.0.0.1:4000/add?x=4&y=5 
app.get("/add", (req, res)=>{
    console.log( req.query );//get방식으로 받을때 
    let x = parseInt(req.query.x);
    let y = parseInt(req.query.y);

    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end( `<h1>${x} + ${y} = ${x+y}</h1>`);
});

//get, post, use(get 이나 post 둘다) - 라우터 역할을 한다 
app.use( (req, res)=>{
    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end( '<h1>Express</h1>');
});

app.listen(4000, ()=>{
    console.log("http://127.0.0.1:4000 server start");
}); 

//node app1.js 
