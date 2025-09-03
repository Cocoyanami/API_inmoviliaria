#### API Inmobiliaria - Sistema de Gestión


##  Descripción
API RESTful para gestión inmobiliaria desarrollada en .NET 8. Permite administrar clientes, lotes, pagos y autenticación de usuarios.

##  Características
✅ Autenticación JWT

✅ CRUD completo de clientes

✅ Gestión de lotes y asignaciones

✅ Sistema de pagos integrado

✅ Documentación Swagger/OpenAPI

✅ CORS configurado

✅ Arquitectura en capas

✅ Inyección de dependencias



##  Tecnologías Utilizadas
✅ .NET 8.0

✅ ASP.NET Core Web API

✅ Swagger/OpenAPI

✅ CORS

✅ JWT (JSON Web Tokens)


##  Estructura del Proyecto
text
api_immobiliaria/

├── 📂 Controllers/   # Controladores API

├── 📂 Models/               # Modelos de datos

├── 📂 Services/             # Lógica de negocio

│   ├── 📂 Interfaces/       # Contratos de servicios

│   └── 📂 Implementations/  # Implementaciones

├── ⚙️ Program.cs            # Configuración principal

├── ⚙️ appsettings.json      # Configuraciones

└── 📄 README.md            # Este archivo



##  Instalación y Configuración
Prerrequisitos
.NET 8.0 SDK

Visual Studio 2022 o VS Code

Git

Pasos de instalación
Clonar el repositorio

bash
git clone https://github.com/tu-usuario/api_immobiliaria.git
cd api_immobiliaria
Restaurar dependencias

bash
dotnet restore
Ejecutar la aplicación

bash
dotnet run
Abrir en el navegador

text
https://localhost:7101/swagger


## Endpoints de la API

✅ Autenticación
Método	Endpoint	Descripción

POST	/api/auth/login	Iniciar sesión

✅ Clientes
Método	Endpoint	Descripción

GET	/api/clientes	Obtener todos los clientes

POST	/api/clientes	Crear nuevo cliente

✅ Lotes
Método	Endpoint	Descripción

GET	/api/lotes	Obtener todos los lotes

POST	/api/lotes/asignar	Asignar lote a cliente

✅ Pagos
Método	Endpoint	Descripción

POST	/api/pagos	Registrar pago

GET	/api/pagos/cliente/{id}	Obtener pagos por cliente


## Ejemplos de Uso


✅ 1. Autenticación
http

POST /api/auth/login

Content-Type: application/json


{

    "username": "admin",
    
    "password": "password"
    
}


✅ 2. Crear Cliente

http

POST /api/clientes

Content-Type: application/json


{

    "nombre": "María García",
    
    "email": "maria@email.com",
    
    "telefono": "555-1234",
    
    "direccion": "Av. Principal #456"
    
}


✅ 3. Asignar Lote

http

POST /api/lotes/asignar

Content-Type: application/json


{

    "clienteId": 1,
    
    "loteId": 1
    
}

✅ 4. Registrar Pago

http

POST /api/pagos

Content-Type: application/json


{
    "clienteId": 1,
    
    "monto": 5000.00,
    
    "metodoPago": "Transferencia",
    
    "referencia": "TRF-123456"
    
}



## Configuración
appsettings.json

json

{

  "Logging": {
  
  
    "LogLevel": {
    
      "Default": "Information",
      
      "Microsoft.AspNetCore": "Warning"
      
    }


    
  } ,
  
  

  
  "AllowedHosts": "*",
  

  
  "Jwt": {
  
  
    "Key": "TuClaveSecretaSuperSeguraAquí",
    
    "Issuer": "api_immobiliaria",
    
    "Audience": "clientes_inmobiliaria"

    
  }

  
}



## Testing
Pruebas con Swagger
Ejecuta la aplicación

Ve a https://localhost:7101/swagger

Explora y prueba todos los endpoints

Pruebas con curl
bash
# Obtener clientes
curl -X GET "https://localhost:7101/api/clientes"

# Crear cliente
curl -X POST "https://localhost:7101/api/clientes" \
-H "Content-Type: application/json" \
-d '{"nombre":"Test","email":"test@email.com","telefono":"12345678"}'


## Seguridad
Autenticación JWT
Validación de datos de entrada
Manejo seguro de errores
CORS configurado


## Despliegue
Despliegue local
bash
dotnet publish -c Release
Despliegue en producción
Configurar variables de entorno
Actualizar appsettings.Production.json
Configurar base de datos real
Configurar SSL



## Modelos de Datos

Cliente

csharp

public class Cliente

{

    public int Id { get; set; }
    
    public string Nombre { get; set; }
    
    public string Email { get; set; }
    
    public string Telefono { get; set; }
    
    public string Direccion { get; set; }
    
    public DateTime FechaRegistro { get; set; }
    
}


Lote

csharp

public class Lote

{
    public int Id { get; set; }
    
    public string NumeroLote { get; set; }
    
    public string Descripcion { get; set; }
    
    public decimal Precio { get; set; }
    
    public bool Disponible { get; set; }

    
}


## Soporte
Si tienes problemas o preguntas:
Revisa la documentación de Swagger
Abre un issue en GitHub
Contacta al equipo de desarrollo

## Contacto
 Email: angeldavidmc20001@gmail.com
