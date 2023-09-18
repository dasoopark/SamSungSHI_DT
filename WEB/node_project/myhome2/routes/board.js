var express = require('express');
var router = express.Router();

//json 데이터로 작업하려 함 
boardList = [
    {id:1, title:"제목1", contents:"내용1", writer:"작성자1", wdate:"2023-09-18"},
    {id:2, title:"제목2", contents:"내용2", writer:"작성자2", wdate:"2023-09-18"},
    {id:3, title:"제목3", contents:"내용3", writer:"작성자3", wdate:"2023-09-18"},
    {id:4, title:"제목4", contents:"내용4", writer:"작성자4", wdate:"2023-09-18"},
    {id:5, title:"제목5", contents:"내용5", writer:"작성자5", wdate:"2023-09-18"},
];

/* GET home page. */
router.get('/', function(req, res, next) {
  res.redirect("/board/list")
});

// http://127.0.0.1:3000/board/list
router.get('/list', function(req, res, next) {
    res.render("board/board_list", {boardList:boardList}  );
});

// http://127.0.0.1:3000/board/view
router.get('/view/:id', function(req, res, next) {
    let id = parseInt(req.params.id); 
    res.render("board/board_view", {board:boardList[id-1]}  );
});

// http://127.0.0.1:3000/board/write
router.get('/write', function(req, res, next) {
    res.render("board/board_write", {boardList:boardList}  );
});

router.post('/save', function(req, res, next) {
    //파라미터를 받아서 추가 
    let title = req.body.title;
    let writer = req.body.writer;
    let contents = req.body.contents;
    
    board= {
        id:boardList.length+1,
        title:title,
        writer:writer,
        contents:contents,
        wdate:'2023-09-18'  
    }
    boardList.push(board);
    res.redirect("/board/list");
});


module.exports = router;
