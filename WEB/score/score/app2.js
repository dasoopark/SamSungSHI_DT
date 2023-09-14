/*
1. get, get방식 2, post - 값 어떻게 처리할거냐
*/ 
let express = require('express');
let app = new express();

//포스트방식으로 테이터 처리는 bodyparser 라는 미들웨어를 사용하다가 4 버전부터는 내장형을 바뀐다.
//모든 요청들이 이 미들웨어를 거쳐 가면서 req 객체에 body 라는 요소를 추가한다.
app.use(express.json());
app.use(express.urlencoded({extended:true}));

//use(url, (req,res)=>{}) 형태이다. 맨앞의 url이 생략될수도 있는데 생략시 모든 url 경로를 다 처러한다.
// 그래서 url이 없는 미들웨어의 경우에는 맨 마지막에 두어야한다.
//이걸 젤 먼저 두면 모든 url을 이 미들웨어가 모든 url에 대한 처리를 다 하기때문에
//다른 미들웨어가 처리를 못한다. 폭포수모형 그래서 꼭 젤 마지막에 url이 없는 미들웨어를 두어야한다.

//라우팅 특정 경로에 특정 미들웨어가 반응하는걸
// http://127.0.0.1:4000/a
//use -get 으로 보내도 , post로 보내도 된다.
app.use("/a", (req, res)=>{

    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end('<h1>aaaaaaaaaaaaaaaaaaaaaa</h1>');
});

// 정보를 보내는 방식 get 1방식일때  /add?x=5&y=7  ===>  get 2방식 /add/5/7
// http://127.0.0.1:4000/add1?x=5&y=7
app.get("/add1", (req, res)=>{
    console.log(req.query); //get1방식
    let x = parseInt(req.query.x);
    let y = parseInt(req.query.y);

    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end(`<h1>${x} + ${y} = ${x+y}</h1>`);
});

//현재 대세
// http://127.0.0.1:4000/add2/5/7
app.get("/add2/:x/:y", (req, res)=>{
    console.log( req.params ); //get2방식
    let x = parseInt(req.params.x);
    let y = parseInt(req.params.y);

    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end(`<h1>${x} + ${y} = ${x+y}</h1>`);
});



/*
post 처리를 담당한다. = postman 프로그램을 이용해서 한다.
app.use(express.json());
app.use(express.urlencoded({extended:true}));
*/
// http://127.0.0.1:4000/add3
app.post("/add3/:x/:y", (req, res)=>{
    console.log( req.body ); 
    let x = parseInt(req.body.x);
    let y = parseInt(req.body.y);

    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.write("<h1>dddd</h1>");
    res.end(`<h1>${x} + ${y} = ${x+y}</h1>`);
});

//문제1.           http://127.0.0.1:4000/dan/4  구구단 출력하기  
app.get("/dan/:dan", (req, res)=>{
    console.log( req.params ); 
    let dan = parseInt(req.params.dan);
    let result = "";
    for(let i=1; i<=9; i++)
    {
        result += `<h1>${dan} * ${i} = ${dan*i}</h1>`
    }

    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end(result);
});

//문제2.           http://127.0.0.1:4000/userinfo/Bread/34  이름 나이
//                               Bread 나이는 34이다.
app.get("/userinfo/:name/:age", (req, res)=>{
    console.log( req.params ); 
    let name = req.params.name;
    let age = req.params.age;
    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end(`<h3>${name}의 나이는 ${age} 입니다.</h3>`);
});

//문제3.           post방식
//                 http://127.0.0.1:4000/rect       width:10, height:5
//                 면적은 50이다. 
app.post("/rect", (req, res)=>{
    console.log( req.body ); 
    let width = parseInt(req.body.width);
    let height = parseInt(req.body.height);
    res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
    res.end(`<h3>면적은 ${width*height} 입니다.</h3>`);
});


app.use((req, res)=>{
    //미들웨어라고 부른다.
    //특별히 url을 지정하지 않았을 경우에 대한 처리를 한다.
    //보통은 오류를 처리하기 위해 사용한다.
    //사용자가 함부로 url을 입력하면 그렇게 하면 안된다라는 메시지를 뿌리기 위해 그리고 로그온 페이지나
    //홈페이지로 이동을 한다.
    res.writeHead(404, {'Content-Type':'text/html;charset=utf-8'});
    res.end('<h1>존재하지 않는 페이지입니다</h1>');
});

app.listen(4000, ()=>{
    console.log("Server start at http://127.0.0.1:4000");
})