<p align="center">
<a href="https://nevergate.com.co/"><img src="https://nevergate.com.co/otros/portafolio/images/logo.png" width="200"></a>
</p>


# 🚩 Objetivo

Este proyecto esta desarrollado C# utilizando CodeFirst y Sql Server; con el fin de demostrar habilidades en el manejo del framework, y para practicar y mejorar los conocimientos aprendidos con ayuda de 
la documentacion oficial; para ello se planteo un ejercicio con el fin de darle solución desde el BackEnd.

Tambien existe una misma verision del api desarrollada en php Laravel 8. Asi que si tambien se esta interesad@ en revisar la otra version, puede hacerlo desde este enlace:

🍂 **[Version Php Laravel 8](https://github.com/Wilmilcard/PhpLaravel_Game-Store)** 🍂

- **[Web del desarrollador](https://nevergate.com.co/)**
- **[Link de la documentación (hay mucho mas de donde saque información)](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application)**

# 📄 Descripción del proyecto

## ✔ Reto

Usted ha sido contratado para gestionar todo el proceso básico de venta de una tienda de video juegos, por lo que el dueño tiene la necesidad clara de:
- Almacenar la información básica de los clientes para poder conocer quien tiene alquilado un juego y poder reclamarlo cuando se venza el periodo de alquiler
- Poder definir el precio de los alquileres que cambian periódicamente por título de juego
- Conocer el cliente más frecuente
- Conocer el título de juego más rentado
- Permitir registrar todos los alquileres hechos y generar prueba de compra
- Poder consultar las ventas del día
- Poder consultar por director de Juego
- Poder consultar por protagonista del juego
- Poder consultar por productor y&o marca del juego
- Poder saber cual juego es el menos rentado por rangos de edad de 10 años en 10 años
- Tener registrado de cada titulo, nombre, año, protagonistas, director, productor y tecnología (Xbox, PlayStation, Nintendo,PC,…)
- El dueño quiere exponer un servicio web para que cualquier cliente consulte su balance, fecha de entraga  y títulos alquilados

## ❌ Supuestos y restricciones

- No se necesita el manejo de usuarios, login y autenticacion
- Es importante poder ver el proceso de actualizaciones y uso del repositorio GIT a medida que desarrolla el mini proyecto
- Puede adicionar componentes que necesite para lograr el objetivo, solo que debe documentar la razón de usarlo y en maximiza su uso.

# 🔥 Ejecucion de proyecto

Para que el proyecto funcione correctamente se debe de tener instalado:

- IDE de desarrollo (Visual Studio 2019)
- SQL Server
- Postman

Una vez se tengan las herramientas instaladas:

1. Clonar el repositorio
2. Crear en Sql Server una base de datos llamada "GameStore"
    - 💡 Si desea cambiarle el nombre es tan facil como ir al proyecto GameStore.API y en el `appsetting.json` cambiar la propiedad **Initial Catalog = Nombre_Base_Datos** 
    en la cadena de conexion.
3. Abrir la consola de "Administrador de paquetes" y en el proyecto donde se ejecutara la consola ponerlo en GameStore.Domain. Ejecutar el comando `update-database`; 
esto creara las tablas y las llenara con el *sedder*
4. Luego ejecutar el proyecto con **IIS Express**.
5. Ya estara corriendo la aplicacion desde en endpoint de swagger en la ruta estandar https://localhost:44392/swagger/index.html

Esta API puede ir mejorando y cambiando, pero mientras tanto esta es una muestra de lo que puede hacer 🛴
    
