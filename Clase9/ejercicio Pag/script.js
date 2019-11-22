let menu_button = document.getElementById('menu-button')
let nav = document.querySelector("nav")
let links = []
for(i=0; i < nav.children.length; i++){
  links.push(nav.children[i])
}
let main = document.querySelector("main")

menu_button.addEventListener("click", e => {
  nav.classList.toggle("abierto")
})

links.forEach(link => {
  link.addEventListener("click", e => {
    e.preventDefault()
    getLink(e.target.href)
  })
})

function getLink(archivo){
  let xhr = new XMLHttpRequest
  xhr.open("GET", archivo)
  xhr.addEventListener("readystatechange", () =>{
    if(xhr.readyState == 4 && xhr.status == 200){
        main.innerHTML = xhr.response
    }
  })
  xhr.send()
  nav.classList.remove("abierto")
}

//JSON.parse() -- cuando pidamos un request a mvc, nos devuelve el request en string. investigar q formato es el request devuelto por los controladores
