let express = require("express");
let ejs = require("ejs");

let app = new express();  //이 객체가 서버임 

app.set('view engine', 'ejs');   // pug(jade) 사용이 어려움 ,   ejs를 많이 사용 

// post 방식으로 데이터를 전송받은 경우에 데이터 처리를 위한 미들웨어 연결 작업 
//이전에는  bodyparser 라는것을 사용했음 
app.use(express.json());
app.use(express.urlencoded({extended:true}));

/**********************************************
모든코드는   start 
***********************************************/

// /board/list
//서버 실행   nodemon app 
//http://127.0.0.1:4000/board/list
let commonDB = require("./commonDB");
app.use("/board/list", async (req, res)=>{
    //디비에서 데이터를 읽어서 보낸다.
    let sql = 
    `   select A.id, A.title, A.writer, A.contents, date_format(A.wdate, '%Y-%m-%d') wdate, hit 
        from tb_board as A
        where delyn = 'N'
    `;
    let param = []; //검색하거나 페이징 정보 주고자 할때 사용

    let boardList = await commonDB.loadDB(sql, param); 
    res.render("board/board_list", {"boardList":boardList}); //html 에 데이터를  json 객체로 전달한다 
})

app.use("/board/write", async (req, res)=>{
    res.render("board/board_write");
});


app.use("/board/save", async (req, res)=>{

    //1. 파라미터 가져오기  post 방식일때 body
    let title = req.body.title; 
    let writer = req.body.writer; 
    let contents = req.body.contents; 

    //2.디비에 저장하기 
    let sql = ` insert into tb_board( title, writer, contents, wdate, hit) 
     values(?, ?, ?, now(), 0) `;
    param = [title, writer, contents];
    await commonDB.saveDB(sql, param); 

    //3.페이지 이동하기  redirect 를 이용해서 이동해야 한다. 
    //html 페이지를 호출하는게 아니고 라우터 app.use("/board/list") 를 불러야 하는데 
    //내부적으로 처리해야할일들을 express  가 처리한다. 그래서 직접 부르면 안되고 
    //저장후에는 redirect함수를 이용해 이동해야 한다. 
    res.redirect("/board/list");
});


app.use("/board/view/:id", async (req, res)=>{
    //디비에서 데이터를 읽어서 보낸다.
    let id = req.params.id;   //query, params, body  
    let param = [id]; //검색하거나 페이징 정보 주고자 할때 사용

    //조회수 증가하기 
    let sql =     'update tb_board set hit=hit+1 where id=?';
    await commonDB.saveDB(sql, param); 

    sql = 
    `   select A.id, A.title, A.writer, A.contents, date_format(A.wdate, '%Y-%m-%d') wdate , hit
        from tb_board as A
        where delyn = 'N' and id=?
    `;

    let boardItem = await commonDB.loadDB(sql, param); //리턴값이 무조건 배열구조다 

    //console.log( boardItem );
    res.render("board/board_view", {"boardItem":boardItem[0]}); //html 에 데이터를  json 객체로 전달한다 
});


/**********************************************
모든코드는   end
***********************************************/

app.use((req, res)=>{
    res.writeHead(404, {'Content-Type':'text/html;charset=utf-8'});
   res.end('<h1>존재하지 않는 페이지입니다.</h1>');
});

app.listen(4000, ()=>{
   console.log("Server start at http://127.0.0.1:4000");
});
