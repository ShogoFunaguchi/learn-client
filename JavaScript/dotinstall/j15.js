var i = 0;

function show(){
  console.log(i++);
  var tid = setTimeout(function(){
    show();
  },1000);
 if(i > 3){
   clearTimeout(tid);
 }
}

show();
