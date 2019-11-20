/*
  Notacion
*/
let arr = [1,2,3]
//console.table(arr)
arr["Lenght"] //3
i = 1
arr[i] //2
arr[50] = true

function foo(){
  let a = 1
  console.log("foo")
}

foo.sarasa = 1
//console.dir(foo) -- muestra al argumento como un objeto

/*BOM = Browser Object Model = Window = window
DOM = Document Object Model = Document = document

o solo llamando las propiedades, ya q el window no hace falta especificarlo
window.innerHeight
window.innerWidth

outerHeight o outerWidth cuenta todo, de punta a punta

screen.height
screen.width

location = URL --escrito asi, esto es igual q hacer lo de abajo
location.href = URL

history --trackea el uso de la pestaña, y tmb controla el back o forward (cambio entre paginas visitadas)

document.getElementById(id string)
document.getElementsByClass(class string)
docuemnt.getElementsByTagName(tagname string)
document.querySelector(selector string)
document.querySelectorAll(selector string)

*/

let item_uno = document.getElementById("item-1")
//console.dir(item_uno)

item_uno.classList.add("otracosa")
item_uno.classList.remove("item")
item_uno.classList.toggle("item")
item_uno.innerText = "<p>otra cosa </p>"
item_uno.innerHtml = "<p>otra cosa </p>"

let item = document.getElementsByClassName("item")
let otracosa = document.getElementsByClassName("otracosa")
//console.log(items)

let id = document.querySelector("#item-1") //query selector traeria el primer elemento si hubiera mas de item_uno
//let id = document.querySelectorAll("#item-1")

//Creacion de Nodos

let p = document.createElement("p")
p.innerText = "Lorem Ipsum"

//nodoTarget.appendChild(NuevoNodo)
//let body = document.querySelector("body")
//document.body.appendChild(p)

/*
  let li = document.querySelector("ul")
  //ul.insertBefore(li_nuevo, ul.children[0])
  ul.insertBefore(li_nuevo, ul.firstChild)

  ul.innerHtml = "" --deja vacio el contenido de ul

*/
console.clear()
function foo(){
  console.log("Foo!")
}

let bar = function(a){
  console.log(a)
}

//Event = Eventos : la ejecucion de una funcion(callback) como respuesta a una accion

let btn = document.querySelector("button")
//Nodo.addEventListener(evento String, callback function [, faseEvento boolean])
//btn.addEventListener("click", foo)

btn.addEventListener("click", function(){
  bar(1)
})

/*
  Fat Arrow Function / funcion flecha / funcion Lambda

  var a = function(){}
  var a = () => {}
  var a = function(item)
  var a = item => {}

  var a = function(item){return item * 2}
  var a = item => item *2

  var a = item => {
    if(item > 5){
      return item
    } else {
      return item * 2
    }
  }

  var a = item => item > 5 ? item : item * 2
*/

let usuarios = [
  {
    "id": 1,
    "name": "Leanne Graham",
    "username": "Bret",
    "email": "Sincere@april.biz",
    "address": {
      "street": "Kulas Light",
      "suite": "Apt. 556",
      "city": "Gwenborough",
      "zipcode": "92998-3874",
      "geo": {
        "lat": "-37.3159",
        "lng": "81.1496"
      }
    },
    "phone": "1-770-736-8031 x56442",
    "website": "hildegard.org",
    "company": {
      "name": "Romaguera-Crona",
      "catchPhrase": "Multi-layered client-server neural-net",
      "bs": "harness real-time e-markets"
    }
  },
  {
    "id": 2,
    "name": "Ervin Howell",
    "username": "Antonette",
    "email": "Shanna@melissa.tv",
    "address": {
      "street": "Victor Plains",
      "suite": "Suite 879",
      "city": "Wisokyburgh",
      "zipcode": "90566-7771",
      "geo": {
        "lat": "-43.9509",
        "lng": "-34.4618"
      }
    },
    "phone": "010-692-6593 x09125",
    "website": "anastasia.net",
    "company": {
      "name": "Deckow-Crist",
      "catchPhrase": "Proactive didactic contingency",
      "bs": "synergize scalable supply-chains"
    }
  },
  {
    "id": 3,
    "name": "Clementine Bauch",
    "username": "Samantha",
    "email": "Nathan@yesenia.net",
    "address": {
      "street": "Douglas Extension",
      "suite": "Suite 847",
      "city": "McKenziehaven",
      "zipcode": "59590-4157",
      "geo": {
        "lat": "-68.6102",
        "lng": "-47.0653"
      }
    },
    "phone": "1-463-123-4447",
    "website": "ramiro.info",
    "company": {
      "name": "Romaguera-Jacobson",
      "catchPhrase": "Face to face bifurcated interface",
      "bs": "e-enable strategic applications"
    }
  },
  {
    "id": 4,
    "name": "Patricia Lebsack",
    "username": "Karianne",
    "email": "Julianne.OConner@kory.org",
    "address": {
      "street": "Hoeger Mall",
      "suite": "Apt. 692",
      "city": "South Elvis",
      "zipcode": "53919-4257",
      "geo": {
        "lat": "29.4572",
        "lng": "-164.2990"
      }
    },
    "phone": "493-170-9623 x156",
    "website": "kale.biz",
    "company": {
      "name": "Robel-Corkery",
      "catchPhrase": "Multi-tiered zero tolerance productivity",
      "bs": "transition cutting-edge web services"
    }
  },
  {
    "id": 5,
    "name": "Chelsey Dietrich",
    "username": "Kamren",
    "email": "Lucio_Hettinger@annie.ca",
    "address": {
      "street": "Skiles Walks",
      "suite": "Suite 351",
      "city": "Roscoeview",
      "zipcode": "33263",
      "geo": {
        "lat": "-31.8129",
        "lng": "62.5342"
      }
    },
    "phone": "(254)954-1289",
    "website": "demarco.info",
    "company": {
      "name": "Keebler LLC",
      "catchPhrase": "User-centric fault-tolerant solution",
      "bs": "revolutionize end-to-end systems"
    }
  },
  {
    "id": 6,
    "name": "Mrs. Dennis Schulist",
    "username": "Leopoldo_Corkery",
    "email": "Karley_Dach@jasper.info",
    "address": {
      "street": "Norberto Crossing",
      "suite": "Apt. 950",
      "city": "South Christy",
      "zipcode": "23505-1337",
      "geo": {
        "lat": "-71.4197",
        "lng": "71.7478"
      }
    },
    "phone": "1-477-935-8478 x6430",
    "website": "ola.org",
    "company": {
      "name": "Considine-Lockman",
      "catchPhrase": "Synchronised bottom-line interface",
      "bs": "e-enable innovative applications"
    }
  },
  {
    "id": 7,
    "name": "Kurtis Weissnat",
    "username": "Elwyn.Skiles",
    "email": "Telly.Hoeger@billy.biz",
    "address": {
      "street": "Rex Trail",
      "suite": "Suite 280",
      "city": "Howemouth",
      "zipcode": "58804-1099",
      "geo": {
        "lat": "24.8918",
        "lng": "21.8984"
      }
    },
    "phone": "210.067.6132",
    "website": "elvis.io",
    "company": {
      "name": "Johns Group",
      "catchPhrase": "Configurable multimedia task-force",
      "bs": "generate enterprise e-tailers"
    }
  },
  {
    "id": 8,
    "name": "Nicholas Runolfsdottir V",
    "username": "Maxime_Nienow",
    "email": "Sherwood@rosamond.me",
    "address": {
      "street": "Ellsworth Summit",
      "suite": "Suite 729",
      "city": "Aliyaview",
      "zipcode": "45169",
      "geo": {
        "lat": "-14.3990",
        "lng": "-120.7677"
      }
    },
    "phone": "586.493.6943 x140",
    "website": "jacynthe.com",
    "company": {
      "name": "Abernathy Group",
      "catchPhrase": "Implemented secondary concept",
      "bs": "e-enable extensible e-tailers"
    }
  },
  {
    "id": 9,
    "name": "Glenna Reichert",
    "username": "Delphine",
    "email": "Chaim_McDermott@dana.io",
    "address": {
      "street": "Dayna Park",
      "suite": "Suite 449",
      "city": "Bartholomebury",
      "zipcode": "76495-3109",
      "geo": {
        "lat": "24.6463",
        "lng": "-168.8889"
      }
    },
    "phone": "(775)976-6794 x41206",
    "website": "conrad.com",
    "company": {
      "name": "Yost and Sons",
      "catchPhrase": "Switchable contextually-based project",
      "bs": "aggregate real-time technologies"
    }
  },
  {
    "id": 10,
    "name": "Clementina DuBuque",
    "username": "Moriah.Stanton",
    "email": "Rey.Padberg@karina.biz",
    "address": {
      "street": "Kattie Turnpike",
      "suite": "Suite 198",
      "city": "Lebsackbury",
      "zipcode": "31428-2261",
      "geo": {
        "lat": "-38.2386",
        "lng": "57.2232"
      }
    },
    "phone": "024-648-3804",
    "website": "ambrose.net",
    "company": {
      "name": "Hoeger LLC",
      "catchPhrase": "Centralized empowering task-force",
      "bs": "target end-to-end models"
    }
  }
]

console.table(usuarios)

/*
<div>
  <h2>Leanne Graham(name)</h2>
  <p>Multi-layered client-server neural-net(catchPhrase)
  </p>
  <a href="http://hildegard.org">ver mas...</a>

*/


//fragmento
let f = document.createDocumentFragment()
let s = document.createElement("section")
usuarios.forEach(element => {

  let div = document.createElement("div")
  let h2 = document.createElement("h2")
  let p = document.createElement("p")
  let a = document.createElement("a")
  div.classList.add("card")
  div.appendChild(h2)
  div.appendChild(p)
  div.appendChild(a)
  h2.innerText = `~${element.name}`
  p.innerText = `${element.company.catchPhrase}`
  a.href = `http://${element.website}`
  a.innerText = "ver mas..."
  //f.appendChild(div)
  s.appendChild(div)
})

document.body.appendChild(s)


/*
  Array.forEach() => :void
  Array.map() => Array de igual length
  Array.filter() => Array de igual o menor Lenght
  Array.find() =>
  Array.reduce() => Any
  Array.sort() => Array de igual length
*/
