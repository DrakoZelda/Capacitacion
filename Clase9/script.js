//AJAX = XMLHttpRequest = XHR
//Asincronico == No bloqueante

//Bucle de eventos / Event Loop

//setTimeout(()=>{},MS)
//setInterval(()=>{},MS)

/*
http://latentflip.com/loupe
https://www.youtube.com/watch?v=8aGhZQkoFbQ
https://www.youtube.com/watch?v=cCOL7MC4Pl0

setTimeout(function(){
    console.log("1")
},5000)

setTimeout(function(){
    console.log("2")
},1000)

setTimeout(function(){
    console.log("3")
},3000)

console.log(4)

*/

let xhr = new XMLHttpRequest

xhr.addEventListener("readystatechange",()=>{
    console.log(`Nuevo estado : ${xhr.readyState}`)

    if(xhr.readyState == 4 && xhr.status == 200){
        let p = document.createElement("p")
        p.innerText = xhr.response
        document.body.appendChild(p)
    }

})



xhr.open("get","archivo1.html")
xhr.send()

xhr.open("get", "archivo2.html")
xhr.send()



/**
 * 0 - Objeto inicializado / Pedido abortado
 * 1 - Objeto configurado
 * 2 - Headers fueron enviados y recibidos
 * 3 - Descargando informacion
 * 4 - Pedido finalizado
 *
 *
 * GET - POST - PUT - PATCH - DELETE
 *
 *
 * REQUEST HTTP
 *
 * METODO       URL             HTTP
 * GET          /index.html     http/1.1
 *
 * Host : google.com
 * Headers :
 *  Accept : html,xml, xhtml,text/plain
 *  Origin : protocolo://dominio.tld
 *  Referer : protocolo://dominio.tld/path
 *
 *
 *
 * RESPONSE
 *
 * HTTP         CODIGO        MENSAJE
 * http/1.1     200           OK
 * Body : elarchivo.html
 * Content-Type : text/html
 * Content-Length : 20
 * Server : Win32 , Apache 5.4 , PHP 7.0
 *
 *
 * CORS : Cross-Origin Resource Sharing
 *
 *
 *
 * 400 Bad Request
 * 401 Unauthorized
 * 403 Forbidden
 * 405 Method Not Allowed
 * 418 I´m a Teapot
 *
 * 500 Internal Server Error
 *
 *
 * https://http.cat/
 */
