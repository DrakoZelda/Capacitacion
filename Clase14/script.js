let arr = [1,2,3,4,5,6]

//Array.filter((e)=>{}) => Array de igual o menor longitud

arr.filter(e=>e%2==0)


//Regex = Son patrons de busqueda en un string

//Lorem ipsum dolor sit amet, consectetur adipisicing elit. Fuga nemo placeat tenetur quis vero porro esse assumenda velit vitae non, eveniet ducimus in quam possimus, quod magni aspernatur earum, rem aliquid similique! Dignissimos blanditiis deleniti a laboriosam sit placeat consequuntur itaque voluptatibus, cumque ratione repudiandae autem laborum possimus voluptas ullam neque ut. Dolore rem maiores suscipit libero deserunt ratione modi culpa ut hic sint placeat veritatis voluptatem aspernatur, magni dignissimos totam a incidunt pariatur qui. Culpa esse laboriosam distinctio dolorum! Adipisci, suscipit iste fugit voluptas, necessitatibus dolore veniam vel quasi corrupti sit distinctio officiis molestias odit at alias doloremque molestiae.

let regex = /\w/

regex.test("horacio") //Boolean 

/**
 * Literales : a-z 0-9
 * 
 * 
 * Especiales : 
 * 
 *      - Grupos
 *          \w : (word) 
 *          \W : !(word)
 *          \d : (digit) 
 *          \D : !(digit)
 *          \s : (space)
 *          \S : !(space)
 *          [XY] [a-f0-9A-F]
 *          .  : TODO         
 * 
 *      - Cantidad
 *          * : 0 - infinito
 *          + : 1 - infinito 
 *          {3} : 
 *          {M,N} : M es el minimo y N maximo
 *          
 * 
 *      - Posicion : 
 * 
 *          $ : El fin de un string 
 * 
 *          ^ : El comienzo de un string
 * 
 *          \b : (boundry) El limite de una palabra 
 * 
 */

//https://regexr.com/
//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_Expressions

let nombre = "xX_hor4c!oOoO0_Xx"

//String.length => Number - La longitud del string 
//String.trim() => String 
//String.trim{Right|Left}() => String
//{String|Array}.indexOf(X) => Number | -1
//{String|Array}.includes(X) => Boolean 
//String.to{Lower|Upper}Case() => String 

for(let i = 0; i<nombre.length ; i++){
    let letra = nombre[i]
    let codigo = letra.charCodeAt()

    if(codigo>96 && codigo<123){
        console.log("Es una letra")
    }else{
        console.log("Es otra cosa")
    }
}


/**
 * POST
 */

let xhr = new XMLHttpRequest
xhr.open("post","servidor.php")

//FormData => Recolecta info de un formulario ó agrega info customizada
//let form = document.querySelector("form")
//let data = new FormData(form)

let data = new FormData
data.append("nombre","horacio")
data.append("persona",JSON.stringify({nombre:"Carlos",ocupacion:"carnicero"}))
//xhr.setRequestHeader("content-type","application/json")
//xhr.setRequestHeader("content-type","application/x-www-form-urlencoded")
//xhr.send(JSON.stringify({nombre:"Horacio"}))
//xhr.send("nombre=horacio&edad=30")
xhr.send(data)

let input = document.querySelector("input")

let chips = []

input.addEventListener("change",e=>{
    chips.push(e.target.value+"x")
    let div = document.createElement("div")
    let close = document.createElement("button")
    close.className = "close"
    close.innerText = "x"
    div.className = "chip"
    div.innerText = e.target.value
    div.appendChild(close)
    document.body.appendChild(div)
    input.value = ""

    div.addEventListener("click",e=>{
        let i = chips.indexOf(e.target.innerText)
        chips.splice(i,1)
        e.target.parentNode.removeChild(e.target)
    })
})

/* input.addEventListener("input",e=>{
    console.log("input")
})

input.addEventListener("keyup",e=>{
    console.log("keyup")
}) */

    





