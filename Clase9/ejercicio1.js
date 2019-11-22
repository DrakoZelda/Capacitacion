let btns = document.querySelectorAll(".button")
let main = document.querySelector("main")

btns.forEach(button => {
  button.addEventListener("click", (e) => {
    getArchivo(`${e.target.dataset.sarasa}.html`)
  })
})

function getArchivo(archivo){
  let xhr = new XMLHttpRequest
  xhr.open("GET", archivo)
  xhr.addEventListener("readystatechange", () => {
    if(xhr.readyState == 4 && xhr.status == 200){
        main.innerHTML = xhr.response
    }
  })
  xhr.send()
}

/*
  DESTRUCTURING
  let arr = [1,2,3]

  let uno = [0]
  let dos = [1]
  let tres = [3]
  --mucho codigo

  let [uno,dos,tres] = [1,2,3]

*/
