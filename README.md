# Proyecto Sistema de cines "Cines FLAGG"
## Creadores:
F- Franco Ouro
L- Lucas Marenco
A- Alejandro Solodujin
G- Gaston Mansilla
G- German Pardo

***Proyecto Realizado:***
Sistema de cines (administración con ABM, tipificacion de usuario admin/cliente, busqueda y compra/devolucion de entradas de funciones)

------------------------------------------------------------------------------------------------------------------------------------------------------
***TIPIFICACIÓN***

Tipos de Usuarios:
* Administrador: Al loguearse podra ingresar y maipular al ABM de Usuarios, Peliculas, Salas y Funciones. Ademas podrá ver la cartelera.
* Cliente: Podra ver cartelera y comprar tickets para funcion seleccionada.
NOTA: AL crear un usuario nuevo siempre se registra desbloqueado (en la base de datos bloqueado = 0 por default). Solo el administrador al modificar puede bloquearlo (en la base de datos bloqueado = 1).

------------------------------------------------------------------------------------------------------------------------------------------------------
***FORMULARIOS POR TIPO DE USUARIO***

Formularios del admin:
* Login/Registro (inicio): Permite registrarse o loguearse. Es el inicio de la aplicación ya que es obligatorio estar registrado.
* Cartelera: Es el formulario que permite buscar las funciones existentes para la compra (funciones con fecha de HOY o superior). 
* ABM de Usuarios: Alta Baja y Modificacion de usuarios (solamente administrador)
* ABM de Peliculas: Alta Baja y Modificacion de peliculas (solamente administrador)
* ABM de Salas: Alta Baja y Modificacion de salas (solamente administrador)
* ABM de Funciones:Alta Baja y Modificacion de funciones (solamente administrador)
* Busqueda avanzada (para buscar por sala o por pelicula las funciones existentes y comprar). Permitimos al admin la compra.
* Actualizar mis datos (Muestra datos del usuario, admite actualizar, y permite carga de credito. Tambien Acceso a Mis Funciones.)
* Mis funciones (Visualiza las funciones compradas por el usuario y permite devolver entrada si la funcion es del dia de HOY o posterior)

Formularios del cliente:
* Cartelera (busqueda y compra. Solo se visualizan funciones con fecha IGUAL o MAYOR a la del dia ACTUAL)
* Busqueda avanzada (para buscar por sala o por pelicula las funciones existentes y comprar)
* Actualizar mis datos (Muestra datos del usuario, admite actualizar, y permite carga de credito. Tambien Acceso a Mis Funciones.)
* Mis funciones (Visualiza las funciones compradas por el usuario y permite devolver entrada si la funcion es del dia de HOY o posterior)

------------------------------------------------------------------------------------------------------------------------------------------------------
***TRANSACCIONES***

Carga de Crédito:
1- El usuario dentro de la ventana de CARTELERA deberá dirigirse a sus datos mediante el boton "MODIFICAR USUARIO".
2- Dentro de la ventana de sus datos presionará "MOSTRAR DATOS" para que traiga los datos cargados en sistema y el credito que posee actualmente.
3- Para cargar credito debe completar un monto en el campo "Monto a Cargar". El monto debe ser numerico, y mayor a 0. No puede estar vacio.
4- Luego de indicar el monto debe presionar el boton "Cargar Credito" para que se le acredite el saldo en su cuenta y se actualice la informacion (la cual actualiza en la base de datos y posteriormente el objeto y la lista usuarios).

Proceso de compra de entradas:
1- El usuario se debe loguear (o registrar si no tiene usuario) por su MAIL y su contraseña.
2- EL sistema lo redirige a la CARTELERA. Alli podra buscar todas las funciones o filtrar por sala, pelicula y costo (o combinacion de ellas). Para elegir la entrada a comprar debe hacer doble clic sobre el grid en la funcion deseada y luego en la parte superior derecha colocar la cantidad y apretar COMPRAR.
Tambien podrá presionar el botón BUSQUEDA AVANZADA para poder buscar de una manera diferente donde pueda ver por salas, las funciones que existen o por Pelicula las funciones que se proyectan en distintas salas de dicha pelicula.
El usuario podrá comprar desde dicha ventana de igual forma que la cartelera.
NOTA: Solo se admite comprar de 1 a 10 entradas por usuario por compra (si el usuario quiere comprar 20 por ejemplo debe comprar 2 veces 10, esto por un tema de seguridad en la transaccion monetaria).
NOTA 2: Para comprar entradas el usuario tiene que tener crédito previamente cargado y la sala debe tener cantidad disponible que solicita el usuario.
3- La compra se almacena en la lista de usuarios, funciones y usuariofuncion para consultas posteriores, luego de haberse registrado correctamente en la base de datos.
4- Pueden darse 2 casos:
a) El usuario compro nuevamente una entrada de una funcion que ya habia comprado: En ese caso se le resta el monto * cantidad de su crédito, y se hace una actualizacion a Usuario_Funcion por la cantidad comprada, tanto en la BD como en las listas.
b) El usuario compro una funcion nueva que no habia comprado anteriormente: En ese caso se le resta el monto * cantidad de su credito y se hace un insert o creacion en Usuario_Funcion y un Add en las listas correspondientes.

Visualizacion de compras:
1- Para ver las funciones compradas el usuario debe estar posicionado en la ventana de sus datos (donde los visualiza y actualiza y donde carga credito).
2- Dentro debera presionar el boton "MIS FUNCIONES" el cual lo redirigirá al formulario de sus funciones.
3- Dentro de esta ventana tambien existe el boton VER MIS FUNCIONES, el cual le muestra al usaurio todas las funciones que él compro en la historia. Para ello presiona en VER FUNCIONES y se carga en la tabla.

Proceso de devolución de entradas:
1- Si desea puede devolver entradas. Solamente se permite devolucion de entradas de una fecha igual o posterior a la del dia actual. 
2- Para hacerlo debe estar en la ventana de MIS FUNCIONES y visualizar las funciones que compró presionando VER FUNCIONES.
3- Simplemente debe hacer doble clic en la funcion a devolver ei indica la cantidad en el campo Cantidad a Devolver.
4- La cantidad debe ser igual o menor a la cantidad comprada anteriormente.
Si la cantidad es MENOR, se actualiza la cantidad comprada en la base de datos (Tabla intermedia Usuario_Funcion).
Si la cantidad es IGUAL, se realiza una delete a la base de datos en dicho registro.
5- Al devolver se le reintegra crédito al cliente en base al costo de la funcion * cantidad seleccionada en devolución. Asi mismo se actualizan las listas correspondientes.


//