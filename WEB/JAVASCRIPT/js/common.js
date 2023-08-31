// common.js

function goClick() {
    //h태그를 접근해야 한다.
    var h1 = document.getElementsByTagName("h1");
    h1[0].style.color = "#f00";
    // - 이 변수에 못쓴다.
    h1[0].style.backgroundColor = "#ff0";
    h1[0].innerHTML = "모던<span style=color:'#0000FF'>스크</span>립트";
    h1[0].innerText = "모던<span style=color:'#0000FF'>스크</span>립트";
    //value- input 태그류 그 밖에는 innerHTML사용한다.
}