var user = {
  email: "gooodsun1@gmail.com",
  score: 80 ,
  greet: function(name){
    console.log("hello," + name  + ",from," + this.email)
  }
};
console.log(user["email"]);
console.log(user.email);

user.score = 100;
console.log(user.score);
user.greet("Tom");
