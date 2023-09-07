var http = require("http") //nodejs 에서 http라는 라이브러리를 제공한다.
//이 라이브러리를 메모리로 가지고 와라 require 

// 서버를 만들고 클라이언트에서 연결요청이 오길 기다린다.
// 클라이언트가 요청을 하면서 데이터를 보내면 request가 그 정보를 전달하고
// 서버가 처리를 한 후 클라이언트에게 응답을 보내는데 이를 response 라고 한다
http.createServer ( (request, response)=>{
    response.writeHead(200, {'Content-Type':'text/html'});
    // 200 - 오류가 없다는 의미,  {'Cont~}~~ : 전송데이터가 html 형식임을 의미한다.
    response.end('<h1>Hello World!!!<h1>');
})
.listen(3000, ()=>{
   console.log("http://localhost:3000 server start"); 
}); //이 서버는 3000번 서버에서 기다린다는 의미임