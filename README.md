💰 Sistema de Préstamos con Intereses por Día
Este proyecto es una aplicación de escritorio en C# desarrollada en Visual Studio Community, que permite gestionar préstamos de dinero, calculando intereses diarios y cuotas de pago. Se conecta a una base de datos MySQL para almacenar y recuperar la información de usuarios y préstamos.
🚀 Características Principales
•	- Registro de clientes
•	- Gestión de préstamos diarios con intereses
•	- Cálculo automático de cuotas e intereses
•	- Conexión a base de datos MySQL remota
•	- Interfaz gráfica construida con Windows Forms
•	- Arquitectura modular distribuida en múltiples formularios
🛠️ Tecnologías Utilizadas
•	- C# (.NET Framework)
•	- Windows Forms
•	- MySQL
•	- Visual Studio Community
•	- MySql.Data (conector)
📁 Estructura del Proyecto
•	- `Form1.cs` a `Form7.cs`: Diferentes ventanas del sistema (registro, préstamos, pagos, etc.)
•	- `conexionSQL.cs`: Clase para conectar con la base de datos MySQL
•	- `registrar.cs`, `validar.cs`, `sql.cs`: Clases auxiliares para lógica de negocio y base de datos
•	- `SqlDatabaseSetup.cs`: Script/configurador de base de datos
•	- `Program.cs`: Punto de entrada de la aplicación
⚙️ Instalación y Ejecución Local
Requisitos
•	- Visual Studio Community (recomendado 2022 o superior)
•	- .NET Framework (4.x)
•	- Servidor MySQL (local o remoto)
•	- Conector de MySQL para .NET (MySql.Data)
Pasos
1.	1. Clona el repositorio: git clone https://github.com/SamxGuapo/final_proyecto.git
2.	2. Abre el proyecto en Visual Studio.
3.	3. Configura tu cadena de conexión en `conexionSQL.cs`.
4.	4. Restaura los paquetes NuGet (Visual Studio lo hace automáticamente).
5.	5. Ejecuta la aplicación (F5 o botón Iniciar en Visual Studio).
🧪 Pruebas
El archivo `SqlServerUnitTest1.cs` contiene pruebas para verificar la conexión o funciones clave del sistema.
📌 Notas
•	- Asegúrate de que el servidor MySQL esté accesible y que los puertos estén habilitados si usas una base de datos remota.
•	- Puedes modificar la base de datos o cambiar a local si no deseas usar el servidor remoto.
📬 Contacto
Desarrollado por: SamxGuapo (https://github.com/SamxGuapo)
