let fs = require("fs");

//readFile - 비동기, 반환값을 사용할 수 없다.
//일이 안끝나도 무조건 리턴된다. 
//비동기 모드의 경우 콜백함수가 매개변수로 전달된다. 
//콜백함수는 시스템이 호출한다. 
//그래서 매개변수가 정해져 있다 
fs.readFile("test.txt", "utf-8", (error, data)=>{
    if(error) //예외처리 
    {
        console.log("file not open");
        return;
    }
    console.log( data ); //파일 읽은 내용 
});

console.log( "완료" );
