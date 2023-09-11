/*
프로젝트 내의 다른 파일들에서 이 파일내의 함수를 사용하고자 할때 
함부로 사용을 못한다. 이 파일내에서 exports  키워드를 통해 함수나 클래스 등을 외부로 
노출시켜야 한다 
*/

function add(x, y)
{
    return x+y; 
}

function sigma(limit=10)
{
    let i, s=0;
    for(i=1; i<=limit; i++)
        s+=i;

        return s;
}

function isEven(a){
    return a%2==0; 
}

//외부로 노출시키기 - json구조ㅓ
exports.add = add;  
exports.sigma = sigma;
exports.isEven = isEven;

//exports["외부로내보낼함수명"]  = 함수주소(함수이름만); 
//exports."외부로내보낼함수명" = 함수주소(함수이름만); 
