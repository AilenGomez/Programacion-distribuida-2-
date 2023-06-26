# Template

## :computer: Tecnologías

- .NET v6.0
- AutoMapper v11.0.1
- MediatR v10.0.1
- FluentValidation 10.4.0
- EntityFrameworkCore v6.0.4
- Swashbuckle v6.3.1

## :open_book: Modo de uso

1. Clonar el repositorio
2. Eliminar la carpeta `.git`
3. Renombrar el archivo `Template.API.sln` y ponerle el nombre del nuevo proyecto
4. Hacer un reemplazo masivo de `Template.API` a el nombre del nuevo proyecto
5. Reemplazar el `Connectionstring` en el `appsettings.json`
6. Listo! Ya podes construir tu Microservicio/API

### :zap: Ejecución

#### Local
- En Visual Studio: presionar el botón "Play" (:arrow_forward:). Asegurarse de tener Web.UI como proyecto de inicio.
- En Consola: dotnet run --project=src\WebUI

#### Docker
Para crear la imagen correr el siguiente comando:
```
docker build -t [nombre-de-la-imagen] .
```

Para ejecutarlo con docker se debe correr el siguiente comando:
```
docker run -d -p [external-port]:[internal-port]
 -e "SERVER=host.docker.internal"
 -e "PORT=5432"
 -e "DATABASE=Tenants"
 -e "USERID=postgres" 
 -e "PASSWORDDB=vecfleet2022"
 -e "DOTNET_ENVIRONMENT=[environment]"
 --name [nombre-del-container] [nombre-de-la-imagen]
```

- `DOTNET_ENVIRONMENT` se refiere al entorno en el que va a correr la aplicaciín. Dependerá de cada proyecto los valores que puedan establecerse en esta variable.