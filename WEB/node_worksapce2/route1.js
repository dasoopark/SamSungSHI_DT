 //route1.js 
let fs = require("fs");
let ejs = require("ejs");
let URLParams = require("@ungap/url-search-params");

 function test1(req, res)
 {
    fs.readFile("./html/board/test1.html", "utf-8", (error, data)=>{
        if(error){
            res.writeHead(500, {"Content-Type":"text/html;charset=utf-8"});
            res.end("file not found");
            return;
        }
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end( ejs.render( data , {"dan":5 } ));
        //랜더링한다. 
    });
}

todos = [
    {"id":1, "todo":"공부"},
    {"id":2, "todo":"한려수도 관광"},
    {"id":3, "todo":"과제"},
    {"id":4, "todo":"맛집투어"}
];

function test2(req, res)
 {
    fs.readFile("./html/board/test2.html", "utf-8", (error, data)=>{
        if(error){
            res.writeHead(500, {"Content-Type":"text/html;charset=utf-8"});
            res.end("file not found");
            return;
        }
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end( ejs.render( data , {"todos":todos} ));
        //랜더링한다. 
    });
}

boards = [
    {"id":1, "title":"제목1", "contents":"내용1", "writer":"작성자1"},
    {"id":2, "title":"제목2", "contents":"내용2", "writer":"작성자2"},
    {"id":3, "title":"제목3", "contents":"내용3", "writer":"작성자3"},
    {"id":4, "title":"제목4", "contents":"내용4", "writer":"작성자4"},
    {"id":5, "title":"제목5", "contents":"내용5", "writer":"작성자5"},
];

function board_list(req, res)
{
    fs.readFile("./html/board/board_list.html", "utf-8", (error, data)=>{
        if(error){
            res.writeHead(500, {"Content-Type":"text/html;charset=utf-8"});
            res.end("file not found");
            return;
        }
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end( ejs.render( data , {"board_list":boards} ));
        //랜더링한다. 
    });
}

//페이지 이동만 한다 
function board_write(req, res)
{
    fs.readFile("./html/board/board_write.html", "utf-8", (error, data)=>{
        if(error){
            res.writeHead(500, {"Content-Type":"text/html;charset=utf-8"});
            res.end("file not found");
            return;
        }
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end( ejs.render( data  ));
        //랜더링한다. 
    });
}

function board_save(req, res)
{
    //post방식으로 데이터 보냈을때 데이터 수신 
    let body = "";
    req.on('data', (data)=>{
        body+=data;
    });

    //수신완료가 되면 수신될데이터를 파싱한다. 
    req.on('end', ()=>{
        params = new URLParams(body); //파싱작업 
        title=params.get("title");
        writer=params.get("writer");
        contents=params.get("contents");
        id = boards.length+1;  //id값 자동 부여 배열길이 +1
        boards.push( {"id":id, "title":title, "contents":contents, "writer":writer});
        //배열에 데이터 추가 

        //list 페이지로 강제로 이동해야 한다 
        //200 - 성공 302-페이지이동 404-페이지없음 405-권한없음 500-오류 ....
        res.writeHead(302, {"Location":"/board/list"});
        res.end();
    })
}



//ejs연동1.js 파일에서 이 파일을 써야 한다 
exports.test1 = test1;   //함수를 외부로 내보내야 다른 파일에서 사용이 가능하다 
exports.test2 = test2;
exports.board_list = board_list;
exports.board_write = board_write;
exports.board_save = board_save;