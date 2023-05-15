### Proyecto Sistema de cines "Cines FLAGG"
Creadores:
F- Franco Ouro
L- Lucas Marenco
A- Alejandro Solodujin
G- Gaston Mansilla
G- German Pardo

Proyecto:
Generamos un proyecto de un sistema de cines. Nuestro cine se maneja por motivos de seguridad y exclusividad en base solamente a clientes que se registran.
Dentro del sistema el usuario podra regitrarse o loguearse a nuestro sistema, para poder hacer consultas de las funciones que se proyectan en las distintas salas.
El usuario podrá ver la cartelera disponible (funciones) y seleccionar una funcion a la cual desea comprar. Tambien podrá poner la cantidad de entradas.
Asi mismo los administradores del sistema podran manejar el ABM de los Usuarios, Peliculas, Salas y Funciones, que se visualizan al cliente, asi tambien 
como operar en la cartelera como un usuario comun.
El usuario para comprar una entrada primero debe cargar saldo. Para ello en la cartelera disponibilizamos un boton de $500 que le carga $500 a su crédito.
Solamente podra comprar entradas si dispone del credito necesaria y si la sala tiene la disponibilidad en base a la cantidad que el usuario quiere comprar.

Tipos de Usuarios:
* Administrador: Al loguearse podra ingresar y maipular al ABM de Usuarios, Peliculas, Salas y Funciones. Ademas podrá ver la cartelera.
* Cliente: Podra ver cartelera y comprar tickets para funcion seleccionada.
NOTA: AL crear un usuario nuevo siempre se registra desbloqueado (en la base de datos bloqueado = 0 por default). Solo el administrador al modificar puede bloquearlo (en la base de datos bloqueado = 1).

Formularios del admin:
* Login (inicio)
* Cartelera 
* ABM de Usuarios
* ABM de Peliculas
* ABM de Salas
* ABM de Funciones

Formularios del usuario comun:
* Cartelera (busqueda y compra) - Los filtros estan en construccion
* Actualizar mis datos (en construccion)

COMPRA-> Se admite entre 1 y 10 boletos por compra.

Proceso de compra con usuario cliente:
1- El usuario se debe loguear (o registrar si no tiene usuario) por su MAIL y su contraseña.
2- EL sistema lo redirige a la CARTELERA. Alli podra buscar todas las funciones o filtrar por sala, pelicula y costo (o combinacion de ellas). Para elegir la entrada a comprar debe hacer doble clic sobre el grid en la funcion deseada y luego en la parte superior derecha colocar la cantidad y apretar COMPRAR.
Tambien podrá presionar el botón BUSQUEDA AVANZADA para poder buscar de una manera diferente donde pueda ver por salas, las funciones que existen o por Pelicula las funciones que se proyectan en distintas salas de dicha pelicula.
El usuario podrá comprar desde dicha ventana de igual forma que la cartelera.
3- Para comprar el usuario requiere de crédito. Para ello el usuario debe dirigirse al boton MODIFICAR USUARIO. 
Deberá presionar el boton MOSTRAR DATOS para que se carguen los datos de la base de datos. Dentro de aqui el usuario podra modificar sus datos personales por un lado y apretar ACTUALIZAR DATOS, o tambien cargar un monto de crédito y presionar CARGAR SALDO.
4- Dentro de esta ventana tambien existe el boton VER MIS FUNCIONES, el cual le muestra al usaurio todas las funciones que él compro en la historia. Para ello presiona en VER FUNCIONES y se carga en la tabla.
5- Si desea puede devolver entradas. Solamente se permite devolucion de entradas de una fecha anterior a la del dia actual. Simplemente hace doble clic en la funcion a devolver ei indica la cantidad.
La cantidad debe ser igual o menor a la cantidad comprada anteriormente.
Si la cantidad es MENOR, se actualiza la cantidad comprada en la base de datos (Tabla intermedia Usuario_Funcion).
Si la cantidad es IGUAL, se realiza una delete a la base de datos en dicho registro.
Al devolver se le reintegra crédito al cliente en base al costo de la funcion * cantidad seleccionada en devolución.