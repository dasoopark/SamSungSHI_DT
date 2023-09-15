//mysql동기.js
//npm install mysql2  -- mysql1 구조가 지나치게 콜백구조라 개선함 promise 를 사용 
let mysql = require('mysql2/promise');

//1.mysql  연결정보기반으로 객체 생성  
let pool = mysql.createPool({
    connectionLimit:10,    //연결이 안될경우 10초간 기다려봄 10초 넘으면 예외발생
    host:'localhost',      //디비 ip 
    user:'user01',         //디비 계정
    password:'1234',       //디비 계정 패스워드  
    database:'mydb',       //디비명     
    port:3306              //포트번호 
});

//param=[]저변수에 json으로 데이터를 받아오겠다 
//이 함수를 다시 만드는게 아니고 계속 사용하자 
async function saveDB(sql, param=[])
{
    //async (conn) => { return conn}   화살표함수 async  promise 타입의 객체를 반환한다 
    //함수앞에   async 가 있으면 이 함수는 Promise  객체를 반환한다 
    //await   는 Promise  객체가 작업을 완료할동안 대기하게 한다. 
    //await 를 포함하는 함수도 함수앞에  async  를 붙여야 한다 

    let conn = await pool.getConnection( async (conn) => { return conn} ); // 연결객체를 동기모드로 가져온다  

    await conn.query(sql, param );  //쿼리가 실행될때까지 기다려야 한다. 
    //? - 들어갈 값들을 별도로 전달이 가능하다. 
    //직접 값을 넣지 않고 ?, ?, ?,  등으로 대체될것을 알려준다 
    //파라미터는 json 형태로 전달하면 된다.  
    await conn.release();
}


//쿼리를 작성해서 디비에 넣는다. 
let sql = `
insert into tb_score(name, kor, eng, mat, wdate)
values(?,?,?,?, now())
`;

//saveDB( sql, ["new student", 100,100,100]); //데이터를 연달아서 배열로 전달해야 한다 

async function loadDB(sql)
{
    let conn = await pool.getConnection( async (conn) => { return conn} ); // 연결객체를 동기모드로 가져온다  
   
    let rows = await conn.query(sql );  //쿼리가 실행될때까지 기다려야 한다. 
    //console.log( rows );
    await conn.release();
    return rows;
}

async function output()
{
    sql = "select * from tb_score";
    let rows = await loadDB(sql);
    //console.log( rows[0]);
    for (row of rows[0]) 
    {
        console.log( row.id, row.name);
    }
    
}

output();

