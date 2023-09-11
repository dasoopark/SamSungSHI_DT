//route1.js
let fs = require("fs");
let ejs = require("ejs");

function test1(req,res)
{
    fs.readFile("./html/board/board_list.html","utf-8",(error, data)=>{
        if(error){
            res.writeHead(500, {"Content-Type":"text/html;charset=utf-8"});
            res.end("file not found");
            return;
        }
        res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
        res.end(ejs.render(data, {"dan":5} ));
        //랜더링한다.
    });
    
}

//ejs연동1.js 파일에서 이 파일을 써야 한다.
//exports.test1 = test1; //함수를 외부로 내보내야 다른 파일에서 사용이 가능하다.
exports.test1 = test1;