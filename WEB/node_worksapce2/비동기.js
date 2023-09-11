let fs = require("fs");

//readFile - 비동기, 반환값을 사용할 수 없다.
//일이 안끝나도 무조건 리턴된다.
let txt = fs.readFile("test.txt","utf-8");
console.log(txt);
console.log("완료");