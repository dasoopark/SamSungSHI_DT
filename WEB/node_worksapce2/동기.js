//동기.js
/* 함수가 일을 시작해서 마칠때까지 대기를 한다 */
let fs = require("fs");
//nodejs가 제공하는 파일관련 라이브러리
//readFileSynce-동기함수라 함수가 종료할때 읽은 파일의 내용을 반환한다
//비동기 모드의 경우 콜백함수가 매개변수로 전달된다.
//콜백함수는 시스템이 호출한다.
//그래서 매개변수가 정해져있다.
let txt = fs.readFileSync("test.txt", "utf-8", (error, data) => {
    if(error)
    {
        console.log("file not open");
        return;
    }
    console.log(data); //파일 읽은 내용
});
console.log(txt);
console.log("완료");