const http = require("http");
const hostname = "127.0.0.1";
const port ="4000";
const url = require("url");

const server = http.createServer( (req, res) =>{
   // console.log(req.url);
    let path = url.parse(req.url,true).pathname;
    console.log(path);
    if(path=="/test1")
    {
        res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
        res.end('<h1 style="color:red">This is my web server!<h1>');
    }
    else if(path=="/uesrname") //http://127.0.0.1:4000/username
    {
        res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
        res.end('<h1 style="color:red">da soo park web server!<h1>');
    }
    else if(path=="/add") //http://127.0.0.1:4000/add
    {
        let query = url.parse(req.url, true).query;
        //우리가 보낸 매개변수가 json 형태로 온다
        console.log(query);
        let x = parseInt(query.x);
        let y = parseInt(query.y);
        let result = `${x}+${y}=${x+y}`;
        res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
        res.end(`<h1 style="color:red">${result}<h1>`);
    }
    //http://127.0.0.1:4000/sigma?limit=10 합계:55
    else if(path=="/sigma")
    {
        let query = url.parse(req.url, true).query;
        let limit = parseInt(query.limit);
        let i, sum = 0;
        for(i=1;i<=limit;i++)
            sum+=i;
            res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
            res.end(`<h1 style="color:red">${sum}<h1>`);
    }
    else
    {
        res.writeHead(200, {'Content-Type':'text/html;charset=utf-8'});
        res.end('<h1>Hello World!!!<h1>');
    }
})

server.listen(port, hostname, ()=>{
    console.log(`http://${hostname}:${port}`)
});

//node 서버1.js
//http://127.0.0.1:4000/test
//http://127.0.0.1:4000/test1
//http://127.0.0.1:4000/add?x=4&y=8;