let form = document.querySelector("form")
let usuarios = [];
//Comportamiento predeterminados
//Event object
// form.addEventListener("submit", (e)=>{
//   e.preventDefault()
//   console.log(e.target[0].value)
//   console.log(e.target[1].value)
//   console.log(e.target[2].value)
// })

//Array.push(X) => :void - agrega x al Array
//Array.splice(x,y) => Array - Borra tantos elementos como haya entre la posicion  x e y, y devuelve todo lo que corto

// Cada vez que se intente enviar un formulario se tiene que :
//   1) Crear un objeto con la info que escribio el usuario
//   2) Pusheamos el objeto al array de usuarios
//   3) Creamos un <div> que contenga solo el nombre lo agregamos al body
//   4) Cada vez que se haga click en un div se tiene que:
//     1) identificar que usuario es
//     2) borrarlo del Array
//     3) borrarlo de la pantalla

form.addEventListener("submit", (e)=>{
  e.preventDefault()
  usuario = new Object()
  usuario.nombre = e.target[0].value
  usuario.apellido = e.target[1].value
  usuario.dni = e.target[2].value
  e.target.reset()
  usuarios[usuario.nombre] = usuario
  divUsuario = crearDivUsuario(usuario.nombre, (usuarios.length - 1))
  divUsuario.addEventListener("click", (e)=>{
    document.body.removeChild(e.target)
    let indice = e.target.innerText
    delete usuarios[indice]
  })
  document.body.appendChild(divUsuario)
})

function crearDivUsuario(nombre){
  let divNombre = document.createElement("div")
  divNombre.innerText  = nombre
  return divNombre
}
