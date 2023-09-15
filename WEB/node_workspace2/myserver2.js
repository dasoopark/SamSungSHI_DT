let http = require("http");
let url = require("url");
let fs = require("fs");
let ejs = require("ejs");

//npm install ejs : html  문서와  json 데이터를 결합해서 출력한다 
//npm install url-search-params 
//npm WARN deprecated url-search-params@1.1.0: now available as @ungap/url-search-params
//npm install @ungap/url-search-params 

//라우팅 => 클라이언트로부터 다양한 요청을 받는다. 
//이 요청에 대한 처리를 하자. 
//get방식처리와 post방식처리 

let server = http.createServer( (req, res)=>{

    if(req.method=="GET") //브라우저에서 보낼수있음 
    {
        //http://127.0.0.1:4000/경로 
        //console.log( req );//request가 가져오는 모든 정보
        console.log( req.url );

        let pathName = url.parse( req.url) .pathname;
        if(pathName == "/userinfo")
        {
            let query = url.parse(req.url, true).query; 
            console.log( query );

            //파일을 읽자 
            fs.readFile("./html/userinfo.html", "utf-8", (error, data)=>{
                if(error)
                {
                    res.writeHead(500, {"Content-Type":"text/html;charset=utf-8"});
                    res.end( "not found" );
                    return;
                }
                res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
                res.end( ejs.render(data, {"name":query.name, 
                                            "age":query.age, 
                                            "phone":query.phone}) );
            });
        }
        else 
        {
            res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
            res.end("<h1>Get방식 처리</h1>");
        }
    }
    else  //POST방식 
    {
        let pathName = url.parse( req.url) .pathname;
        console.log( pathName);
        if(pathName == "/logon")
        {
            
            //1.데이터를 모두 수신한다. 파일도 전송하고 그러므로 
            //2.post방식에서는 많은 양의 데이터를 전송한다. 
            let body="";
            req.on('data', (data)=>{
                body+=data;
            });

            req.on('end', ()=>{
                params = new URLSearchParams(body);
                console.log( params.get("userid"));
                res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
                res.end(`<h1> ${params.get("userid")}  ${params.get("password")}</h1`); 
                //post맨
            })
        }
        else 
        {
            res.writeHead(200, {"Content-Type":"text/html;charset=utf-8"});
            res.end("<h1>POST방식 처리</h1>"); //post맨
        }
    }
});
//createServer 도 비동기 함수이다. 반환값은 완성된 서버에 대한 참조이다 

server.listen( 4000, ()=>{
    console.log( "server start http://127.0.0.1:4000");
});