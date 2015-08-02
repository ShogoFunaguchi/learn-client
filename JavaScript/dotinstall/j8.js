var signal = "yellow";
var signal2 = "yellow"

switch(signal){
  case "red":
    console.log("stop!");
    break;
  case "green":
    console.log("go!");
    break;
  case "yellow":
    console.log("watch out!");
    break;
  default:
    console.log("stop!");
    break;
}
switch(signal2){

  case "green":
    console.log("go!");
    break;
  case "yellow":
  case "red":
    console.log("stop!");
    break;

  default:
    console.log("stop!");
    break;
}
