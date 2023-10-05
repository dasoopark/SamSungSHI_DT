var express = require('express');
var router = express.Router();
let db = require('./commonDB');
let util = require('./commonUtil');

/* GET home page. */
//board/list -> 이 url을 처리 안하고 있다 
//board  => board/list/1 로 전환한다 
router.get('/', function(req, res, next) {
  res.redirect("/board/list/1");
});

router.get('/list/:pg', async function(req, res, next) {
    let pg = parseInt(req.params.pg) ?? 1;
    let searchGb = req.query.searcGb?? "";
    let searchText = req.query.searchText?? "";

    console.log( searchGb);
    console.log(searchText);

    condition ="";
    if(searchGb=="1")
        condition = " and title like '%" + searchText + "%' ";
    else if(searchGb=="2")
        condition = " and contents like '%" + searchText + "%' ";
    else if(searchGb=="3")
        condition = " and contents like '%" + searchText + "%' or "+ " and title like '%"+ searchText+"%' ";
    

    console.log( pg ); //확인용 
    let start = (pg-1)*10;  //글 시작위치 

    let sql;
    //데이터 전체 건수 가져오기 

    sql = `
            select count(*) as cnt 
            from tb_board 
            where delyn='N' ${condition}
    `;

    let totalCnt = await db.loadDB(sql);
    console.log(totalCnt[0].cnt );

    sql =  `select id, title, writer, contents, date_format(wdate,'%Y-%m-%d') wdate, hit 
            from tb_board 
            where delyn='N' ${condition}
            order by id desc 
            limit ? , 10   
        `;
               
    //limit (?-1)*10 , 10    :원하는 만큼만 데이터를 가져온다,  한 페이지당 10개를 가져온다 
    //limit 시작위치(offset), 개수  
    // (pg-1)*10 ~ 10개만 

    let boardList = await db.loadDB(sql, [start]);
    let paging = util.getPageInfo( pg, totalCnt[0].cnt);

    res.render( "board/board_list", {boardList:boardList, paging:paging});
});
  
router.get('/write', (req,res,next)=>{
  let board={title:"", writer:"", contents:""};
  res.render("board/board_write",{board:board, mode:"insert", id:""});
});

router.post('/save', async (req,res,next)=>{
  let title = req.body.title;
  let writer = req.body.writer;
  let contents = req.body.contents;
  let id = req.body.id;
  let mode  = req.body.mode;

  let sql
  if( mode=="insert")
  {
    sql =`insert into tb_board(title, writer, contents, wdate, hit)
            values(?,?,?,now(), 0)
  `;
    await db.saveDB(sql, [title, writer, contents]);
  }
  else
  {
    sql =`update tb_board set title=? , writer=?, contents=?
          where id=?
  `;
    await db.saveDB(sql, [title, writer, contents, id]);
  }
 
  //res.redirect("/board/list/1");
  //ajax통신시 json 데이터 전송
  res.send({result:"success"});
});


router.get('/view/:id', async (req,res,next)=>{
  let id=req.params.id; 
  let sql = `update tb_board set hit=hit+1  where id=?`;
  await db.saveDB(sql, [id]);
  
  sql = `
            select id, title, writer, contents, 
            date_format(wdate,'%Y-%m-%d') wdate,  hit 
            from tb_board 
            where id=?
  `;

  let board = await db.loadDB(sql, [id]);
  //반환값이 배열형태이다. 첫번째것만 보내야 한다 
  console.log( board );
  res.render("board/board_view", {board:board[0]});
});


router.get('/modify', async (req,res,next)=>{
  let id=req.query.id;
  let sql = `
            select id, title, writer, contents, 
            date_format(wdate,'%Y-%m-%d') wdate,  hit 
            from tb_board 
            where id=?
  `;

  let board = await db.loadDB(sql, [id]);
  //반환값이 배열형태이다. 첫번째것만 보내야 한다 
  console.log( board );
  res.render("board/board_write", {board:board[0], mode:"modify", id:id});
});

router.get('/delete', async (req,res,next)=>{
  let id=req.query.id;
  let sql = `
           update tb_board  set delyn='Y'
            where id=?
  `;
  console.log(id, sql );
  console.log(req.body.id );
  await db.saveDB(sql, [id]);
  res.send({"result":"success"});
});

module.exports = router;
