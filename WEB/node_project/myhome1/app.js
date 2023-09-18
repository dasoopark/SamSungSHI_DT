var createError = require('http-errors'); //에러처리모듈
var express = require('express'); //express  모듈
var path = require('path'); // 파일업로드/다운로드시 필요, 경로 
var cookieParser = require('cookie-parser'); //쿠키저장 
var logger = require('morgan'); //로그 

var indexRouter = require('./routes/index');
var usersRouter = require('./routes/users');
var testRouter = require('./routes/test');  ////////////////////////
var test2Router = require('./routes/test2');  //test2 모듈을 사용하겠다. 


//////////// 사용자 추가 

var app = express(); // 서버생성

// view engine setup
app.set('views', path.join(__dirname, 'views')); //html 놓는 경로 
app.set('view engine', 'ejs'); //ejs 엔진을 사용한다 

//-----------------    미들웨어 : 전처리작업들 , 중간에 필요한 처리들 다하고 나온다 
app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));//public - css, js, image

app.use('/', indexRouter);
app.use('/users', usersRouter);
app.use("/test", testRouter);
app.use("/test2", test2Router); //url과 라우터를 연결한다. 


//////////// 사용자 추가

// catch 404 and forward to error handler
app.use(function(req, res, next) {
  next(createError(404));
});

// error handler
app.use(function(err, req, res, next) {
  // set locals, only providing error in development
  res.locals.message = err.message;
  res.locals.error = req.app.get('env') === 'development' ? err : {};

  // render the error page
  res.status(err.status || 500);
  res.render('error');
});

module.exports = app;
