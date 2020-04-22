class smartphone {
  constructor() {
    this.item = 30;
  }
  sell(count) {
    if (this.item < count) {
      throw new Error("you can not sell more than current");
    }
    this.item -= count;
  }
}
let iPhone = new smartphone();
try {
  iPhone.sell(31);
} catch (error) {
  console.log(error.message);
}
class laptop {
  constructor() {
    this.item = 30;
  }
  sell(price) {
    if (price < 45) {
      throw new Error("you dont have enough money to buy laptop");
    }
  }
}
let HP = new laptop();
try {
  HP.sell(44);
} catch (error) {
  console.log(error.message);
}

let button = document.querySelector("#hi");
button.addEventListener("click", function () {
  console.log("test");
  hi();
});

function getSmartphone(hiSmartphone) {
  let smartphone;
  switch (hiSmartphone) {
    case 1:
      smartphone = "Iphone";
      break;
    case 2:
      smartphone = "Xiaomi";
      break;
    case 3:
      smartphone = "Huawei";
      break;
    case 4:
      smartphone = "Google Pixel";
      break;

    default:
      smartphone = "there is no other smartphone option";
      break;
  }
  return smartphone;
}
console.log(getSmartphone(1));
function getDayNumber(getDay) {
  let day;
  switch (getDay) {
    case 1:
      day = "Monday";
      break;
    case 2:
      day = "Tuesday";
      break;
    case 3:
      day = "Wendsday";
      break;
    case 4:
      day = "Thursday";
      break;
    case 5:
      day = "Friday";
      break;
    case 6:
      day = "Saturday";
      break;
    case 7:
      day = "Sunday";
      break;
    default:
      day = "its invalid";
      break;
  }
  return day;
}
console.log(getDayNumber(8));

for (let i = 0; i < 10; i++) {
  console.log(i);
}
for (let i = 1; i < 5; i++) {
  console.log(i);
}
function hi() {
  console.log("hello jason");
}

class dog {
  constructor(name) {
    this.name = name;
  }
  static jumps() {
    return "dog is hyperactive";
  }
  run() {
    return "dog loves to skyrocket";
  }
}
let pitbul = new dog("spike");
console.log(dog.jumps());
console.log(pitbul.run());

class Fish {
  constructor(name) {
    this.name = name;
  }
  swims() {
    console.log("moves in water");
  }
  eats() {
    console.log("eats invertebrates");
  }
  breeds() {
    console.log("through mating");
  }
}
class Shark extends Fish {
  constructor() {
    super(name);
  }
  predator() {
    console.log("hunts down marine mammals");
  }
  diving() {
    console.log("dives deep into ocean");
  }
}
let shark = new Shark("King Shark");
shark.predator();
shark.eats();
let year = 12;
if (year >= 1 && year <= 12) {
  if (year >= 1 && year <= 3) {
    console.log("summer");
  } else if (year >= 4 && year <= 6) {
    console.log("autumn");
  } else if (year >= 7 && year <= 9) {
    console.log("winter");
  } else {
    console.log("spring");
  }
} else {
  console.log("there is no such year");
}
class GrenadeLauncher {
  constructor(name) {
    this.name = name;
    this.count = 30;
  }
  shoot(bullet) {
    if (this.count < bullet) {
      console.log("you do not have enough grenade");
    }else{
        this.count-=bullet;
        console.log("you have shoot some of grenades")
    }
    
  }
}
let Grenadelauncher=new GrenadeLauncher("RPG")
Grenadelauncher.shoot(30)
