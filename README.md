⚔️ KIMETSU ARCHIVE — Registro de Cazadores y Demonios
Aplicación web temática de Demon Slayer: Kimetsu no Yaiba desarrollada en ASP.NET Core MVC. Permite registrar, visualizar y consultar el detalle de personajes del universo Kimetsu, clasificándolos entre Cazadores y Demonios.

🖼️ Capturas de pantalla
Página de Inicio
<img width="1917" height="1078" alt="Inicio" src="https://github.com/user-attachments/assets/176e56f2-fab6-4cc8-82cb-711a2f3e789b" />
Registro de Personajes
<img width="1917" height="1078" alt="Catalogo1" src="https://github.com/user-attachments/assets/0165b243-3443-4189-bead-3fe6a47393f0" />
<img width="1918" height="1078" alt="Catalogo2" src="https://github.com/user-attachments/assets/78bfaeac-adc8-4f20-9f4c-9d1eed2abb24" />
Detalle de Personaje
<img width="1912" height="1062" alt="Detalle1" src="https://github.com/user-attachments/assets/77c6df44-926e-4947-9b61-0776ea7a637a" />
<img width="532" height="667" alt="Detalle2" src="https://github.com/user-attachments/assets/7bbc8200-7e05-49d4-a0be-c43ecae733f8" />
Inscribir Nuevo Guerrero
<img width="532" height="667" alt="Detalle2" src="https://github.com/user-attachments/assets/7bbc8200-7e05-49d4-a0be-c43ecae733f8" />
<img width="1917" height="1078" alt="Formulario2" src="https://github.com/user-attachments/assets/d996628b-3db9-4b1f-9315-4a5634171791" />

🛠️ Tecnologías utilizadas
TecnologíaUsoC#Lenguaje principalASP.NET CoreFramework webMVCPatrón de arquitecturaRazor Views (.cshtml)Vistas del lado del servidorBootstrap 5Estilos y diseño responsivoHTML / CSSMaquetación y estilos personalizadosGit + GitHubControl de versiones

✨ Funcionalidades

Página de inicio con fondo animado y video en loop
Catálogo visual de personajes con imagen, nombre, rango y habilidad
Clasificación por tipo: Cazador o Demonio
Vista de detalle individual por personaje
Formulario para inscribir nuevos guerreros al registro
Imagen por defecto asignada automáticamente al registrar un personaje


⚙️ Cómo ejecutar el proyecto

Clona el repositorio:

bash   git clone https://github.com/elbarto120/ArqSoft-S01-Gael.git

Abre el proyecto en Visual Studio.
Presiona F5 o ejecuta:

bash   dotnet run

Abre tu navegador en https://localhost:<puerto>.


📁 Estructura del proyecto
Catalogo2/
├── Controllers/        # Lógica de cada vista
├── Models/             # Clases del dominio (Personaje)
├── Views/              # Vistas Razor (.cshtml)
│   ├── Catalogo/
│   └── Shared/
├── wwwroot/            # Archivos estáticos
│   ├── Imagenes/personajes/
│   ├── videos/
│   └── css/
├── .gitignore
└── Catalogo2.csproj

👤 Autor
Gael — Proyecto desarrollado para el curso de Arquitectura de Software.
