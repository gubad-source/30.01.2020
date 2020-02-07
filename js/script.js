/*alert("Hello world");
document.write("mars is the closest relative to the earth in our solar system")
var phrase;
phrase=(" "+"texting messeage");
document.write(phrase);
document.write(phrase.charAt(4));
document.write(phrase.indexOf("a"));
document.write(phrase.substring(2,4));
document.write(phrase.endsWith("age"));
document.write(phrase.includes("messeage"));
document.write(phrase.lastIndexOf("messeage"));
var movietitle=window.prompt("what kind of movie do you watch most");
var howoften=window.prompt("how do you rate"+ movietitle);
document.write("so you like"+movietitle+howoften+"times");
var num1=window.prompt("enter a number");
var num2=window.prompt("enter another number");
num1=parseFloat(num1);
num2=parseFloat(num2);
document.write(num1+num2);
var movies=["horror","comedy","historical"];
document.write(movies[0]);
function sayhi(){
    alert("we are one");
    
}
var movies=[
    {
        author:"lucas arts",
        name:"star wars",
        duration:2 
    },
    {
        author:"jj abrams",
        name:"star trek",
        duration:2 

    }
];

movies.forEach(function(movie)
{
    document.write(movie.author)
});
function bla(movie,duration){
    document.write(movie,duration);
}
bla("star wars","2 hours 10 minutes");

function acc(num1,num2){
    return num1+num2;
};
document.write(acc(4,5));
document.getElementById("header4").innerHTML=("string4")
function handleClick(element){
    element.innerHTML="Clicked"
};
var img= document.getElementById("image");
img.addEventListener("mouseover",function(){
    this.style="box-shadow 2px 2px 2px 2px"
    this.height="200"
});
img.addEventListener("mouseout",function(){
    this.style=""
    this.height="150"
});

var message=document.getElementById("message");
var textbox=document.getElementById("textbox");
var duyme=document.getElementById("duyme");
duyme.addEventListener("click",function(){
var newmessage=document.createElement("li");
message.appendChild(newmessage);
newmessage.innerHTML=textbox.value;
textbox.value="";
});
isBlack=false;
isTall=false;
if( isBlack && isTall ){
    document.write("youre tall black ghost");
} else if (!isBlack && !isTall){
    document.write("you are not tall black ghost")
}
else {
    document.write("youre either not black or not tall ghost");
};
function mouse(getmonth) {
    var month;
    switch (getmonth) {
    case 0:
     month="january"
            
    break;
            
     case 1:
     month="february"
                    
     break;
     default:
         month="this month is not valid"
    }
    return month;
}
document.write(mouse(2));
var person={
    name:"michael",
    age:23,
    lastname:"jackson",

};
document.write(person.name)
var movie={
    moviename:"star wars",
    duration:"2 hours",
    actors:[
        {
            name:"carrie fisher",
            age:78,
            country:"washington"
        },
        {
            name:"harrison ford",
            age:45,
            country:"new york"
        },

    ]
}
document.write(movie.actors[1].name);
var i=2;
while(i<23){
    document.write(i+"<br/>");
    i++;
}
var questions=[
    {
        prompt:"which is science fiction movie\n(a)star wars\n(b)freddy krueger\n(c)dumb and dumber 2",
        answer:"a"
    },
    {
        prompt:"which is horror movie\n(a)star wars\n(b)freddy krueger\n(c)dumb and dumber 2",
        answer:"b"

    }
]
var score=0;
for(var k=0;questions.length>k;k++){
var response=window.prompt(questions[k].prompt);
if(response==questions[k].answer){
    score++;
    alert("youre right")
}else{
    alert("youre wrong")
}
}
var numberGrid=[
    [1,2,3],
    [4,5,4],
    [23,45,0] 
];
for(var i=0;i<numberGrid.length;i++){
    for(var k=0;k<numberGrid[i].length;k++){
    document.write(numberGrid[i][k]);
}
document.write("<br>");
}

var friends=["josh","frank","merle"]
for(var i=0;i<friends.length;i++){
    document.write(friends[i]+"<br/>")
}*/



















/*var password="kamino";
var response;
var entryCount=0;
var entryLimit=3;
var error=false;
while(password=!response && !error){
    if(entryCount<entryLimit){
        response=window.prompt("enter password");
        entryCount++;
    } else{
        error=true;
    }
};
if(error){
    alert("you are out of choice");
}else{
    alert("youre right");
};


var textbox=document.getElementById("textbox");
var button=document.getElementById("btn");
button.addEventListener=(click,function(){
    localStorage.name=textbox.value;
});
document.write(localStorage.name);*/
