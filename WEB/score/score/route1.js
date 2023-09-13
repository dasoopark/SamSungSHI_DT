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

//npm install mysql2
let commonDB = require('./commonDB');/////////////////////

function score_list(req, res)
{
    fs.readFile("./html/score/score_list.html", "utf-8", async(error, data)=>{ /////////////////
        if(error)
        {
            callError(req,res);
            return;
        }

        let sql="select * from tb_score";/////////////////////////
        let scoreList = await commonDB.loadDB(sql, []);//////////////////////
        
        let result = ejs.render(data, {"scoreList":scoreList} );
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end( result );
    })
}



function score_view(req, res)
{
    fs.readFile("./html/score/score_view.html", "utf-8", async(error, data)=>{
        if(error)
        {
            callError(req,res);
            return;
        }
        //get방식으로 받는다 


        let id =  url.parse(req.url, true).query.id;
        let sql = "select * from tb_score where id=?";
        let param=[id];
        let item = await commonDB.loadDB(sql, param);
        let result = ejs.render(data, {board:item[0]});

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

function score_save(req, res)
{
    //입력한값 
    let body = "";
    req.on('data', (data)=>{
        console.log( data);
        body+=data; // 수신된 데이터를 모아서 
    });
   
    //수신완료시 
    req.on('end', async()=>{  ////////////////////////////////////////////////////////////
        //파싱작업 
        params = new URLParams(body);
        console.log(params); 

        //json객체로 전환 - 따로 함수가 없어서 직접 만들음 
        let sql = `insert into tb_score(name, kor, eng, mat,wdate)
        values(?,?,?,?,now())`;
        score = [params.get("name"), params.get("kor"), params.get("eng"), params.get("mat")];
        await commonDB.saveDB(sql, score);

        //직접 /save/list 를 호출할 수 없다. 내부적으로 별도의 처리가 
        //많이 이뤄진다. 그래서 페이지 자동이동으로 해결해야 한다 
        res.writeHead(302, {"Location":"/score/list"});
        res.end();
    });
}

exports.score_list = score_list;
exports.score_view= score_view;
exports.score_write = score_write;
exports.score_save = score_save;

exports.flower = flower;
exports.index = index;
exports.callError = callError;  /////////////////////////////