//route1.js 

let ejs = require('ejs');
let url = require('url');
let fs = require('fs');
let URLParams = require('@ungap/url-search-params');

function index(req, res)
{
    //index.html 파일을 읽어서 전송한다. 
    fs.readFile("./html/index.html", "utf-8", (error, data)=>{
        if( error)
        {
            callError(req, res); //에러처리 전담 함수 
            return; 
        }

        let result = ejs.render(data); //html 파일과 json 데이터를 합쳐서 새로운 html을 만들어야 한다
        //현재는 데이터 없음 
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end( result );

    });
}

function callError(req, res){  /////////////////////////////////
    res.writeHead(500, {"Content-Type":"text/html;charset=utf-8"});
    res.end( "<h1>file not found</h1>" );
}

function flower(req, res)
{
    fs.readFile("./html/flower1.html", "utf-8", (error, data)=>{
        if(error)
        {
            callError(req,res);
            return;
        }

        let result = ejs.render(data);
        res.writeHead(500, {"Content-Type":"text/html;charset=utf-8"});
        res.end( result );
    })
}

//데이터가  json  형태로 있어야 한다 
scoreList =[
    {"id":1, "name":"홍길동", "kor":100, "eng":100, "mat":100},
    {"id":2, "name":"임꺽정", "kor":100, "eng":90, "mat":80},
    {"id":3, "name":"장길산", "kor":80, "eng":80, "mat":100},
    {"id":4, "name":"강감찬", "kor":70, "eng":90, "mat":90},
    {"id":5, "name":"을지문덕", "kor":90, "eng":80, "mat":70}
];

function score_list(req, res)
{
    fs.readFile("./html/score/score_list.html", "utf-8", (error, data)=>{
        if(error)
        {
            callError(req,res);
            return;
        }

        let result = ejs.render(data, {"scoreList":scoreList} );
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end( result );
    })
}

function score_view(req, res)
{
    fs.readFile("./html/score/score_view.html", "utf-8", (error, data)=>{
        if(error)
        {
            callError(req,res);
            return;
        }

        let result = ejs.render(data);
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end( result );
    })
}

function score_write(req, res)
{
    fs.readFile("./html/score/score_write.html", "utf-8", (error, data)=>{
        if(error)
        {
            callError(req,res);
            return;
        }

        let result = ejs.render(data);
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end( result );
    })
}


exports.score_list = score_list;
exports.score_view= score_view;
exports.score_write = score_write;

exports.flower = flower;
exports.index = index;
exports.callError = callError;  /////////////////////////////