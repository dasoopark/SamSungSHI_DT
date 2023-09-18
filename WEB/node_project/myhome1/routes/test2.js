//test2.js  
var express = require('express');
var router = express.Router();

///http://127.0.0.1:3000/test2
router.get("/", (req, res)=>{
    //views/test2.ejs파일이 있어야 한다 
    res.render("test2" , {name:"홍길동", age:23, phone:"010-0000-0001"});
});

///http://127.0.0.1:3000/test2/add?x=5&y=7
router.get("/add", (req, res)=>{
    
    let x = parseInt(req.query.x); 
    let y = parseInt(req.query.y);

    //render - ejs파일이 필요하다
    res.render("add" , {x:x, y:y, result:x+y});
});


//모듈을 외부에서 사용할 수 있도록 한다 
module.exports = router;