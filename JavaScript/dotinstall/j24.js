var e = document.getElementById("msg");
e.textContent= "hello!";
e.style.color="red";
e.className='myStyle';


document.getElementById('add').addEventListener('click',function(){

  var greet = document.createElement('p'),
      text = document.createTextNode('hello world');

      document.body.appendChild(greet).appendChild(text);


});
