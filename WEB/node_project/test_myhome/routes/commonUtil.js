//commonUtil.js 
//공통으로 사용하는 함수들을 이곳에 모아놓고 쓴다 

//pageNum -  현재페이지 
//totalCnt - 전체 데이터 개수 
//pageGroupSize - 한 그룹당 나타낼 페이지개수 
//10이니까 그룹은 1 2 3 4 5 6 7 8 9 10 이 되어야 한다 
// 1  11 21 31 41 
// 10 20 30 40 50 
//현재페이지가  34 
function getPageInfo(pageNum, totalCnt, pageGroupSize=10)
{
    //그룹시작위치, 그룹엔딩위치, 현재페이지, 전체페이지개수, 전체데이터개수등을 반환한다 

    //전체 데이터가 321 개일 경우  페이지는 32.10 이 된다. 그러나 실수는 사용불가하기때문에 
    //실제 페이지 개수는 33개가 되어야 한다.  올림 함수를 이용해 값 올림을 하여 33이 나오도록 한다 

    let totalPage = Math.ceil(totalCnt/10); //올림수 발생 
    //34/10 -> 3.4
    let pageGroupStart = Math.floor(pageNum/pageGroupSize)*pageGroupSize + 1;
    let pageGroupEnd = pageGroupStart + pageGroupSize;

    if( pageGroupEnd> totalPage)
    {
        pageGroupEnd = totalPage+1; 
    }

    console.log("현재페이지 : ", pageNum);
    console.log("전체페이지  ", totalPage  );
    console.log("그룹시작  ", pageGroupStart  );
    console.log("그룹종료  ", pageGroupEnd  );

    return {"pageNum":pageNum, pgStart:pageGroupStart, pgEnd: pageGroupEnd, pgTotal:totalPage, 
            "totalCnt":totalCnt};
    
}

getPageInfo(34, 100 );

exports.getPageInfo = getPageInfo;  //외부노출

