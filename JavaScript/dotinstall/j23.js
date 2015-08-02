var e = document.getElementById("msg");
e.textContent= "hello!";
e.style.color="red";
e.className='myStyle';

var greet = document.createElement('p'),
    text = document.createTextNode('hello world');

    document.body.appendChild(greet).appendChild(text);
