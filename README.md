⚔️ Sistema de Combate: Personajes en C#
Un motor de simulación de combate orientado a objetos desarrollado en C#, diseñado para demostrar la implementación práctica de patrones de diseño, principios SOLID y pilares de la Programación Orientada a Objetos (POO).

🚀 Características Principales
Pilar POO	Implementación en el Proyecto
🧬 Herencia & Polimorfismo	Clases especializadas (Guerrero, Mago, Arquero) que sobrescriben el comportamiento de ataque base.
🛡️ Abstracción & Interfaces	Uso de ICurable e IDefendible para acoplamiento débil y capacidades modulares.
🔒 Encapsulamiento	Validación rigurosa de atributos críticos (Vida, Nivel, Mana) mediante propiedades con getters/setters protegidos.
🧬 Arquitectura del Sistema
Plaintext
                  +-----------------------+
                  |  «Abstract» Personaje |
                  +-----------------------+
                  | + Nombre: string      |
                  | + Vida: int           |
                  | + Nivel: int          |
                  +-----------------------+
                  | + Atacar(): void*     |
                  +-----------+-----------+
                              |
       +----------------------+----------------------+
       |                      |                      |
+------+-------+       +------+-------+       +------+-------+
|   Guerrero   |       |     Mago     |       |    Arquero   |
+--------------+       +--------------+       +--------------+
| [IDefendible]|       |  [ICurable]  |       | - Flechas    |
+--------------+       +--------------+       +--------------+
🎭 Clases y Roles
🗡️ Guerrero: Especialista en combate cuerpo a cuerpo. Implementa IDefendible para mitigar el daño entrante.

🔮 Mago: Usuario de magia elemental. Implementa ICurable para restaurar puntos de vida propios o de aliados usando Maná.

🏹 Arquero: Atacante a distancia. Gestiona un recurso limitado (Flechas) que condiciona la ejecución de sus ataques.

🛠️ Requisitos e Instalación
Prerrequisitos
.NET SDK 6.0 o superior (Recomendado .NET 8.0).

Un IDE o editor compatible: Visual Studio Code, Visual Studio, o JetBrains Rider.

Pasos para Ejecutar
Clonar el repositorio:

Bash
git clone https://github.com/tu-usuario/nombre-del-repo.git
cd nombre-del-repo
Restaurar y compilar:

Bash
dotnet build
Ejecutar la simulación:

Bash
dotnet run
💻 Ejemplo de Uso
C#
// Creación de instancias usando polimorfismo
List<Personaje> equipo = new List<Personaje>
{
    new Guerrero("Thorin", vida: 150),
    new Mago("Gandalf", vida: 80, mana: 100),
    new Arquero("Legolas", vida: 100, flechas: 15)
};

// Simulación de turno de ataque
foreach (var personaje in equipo)
{
    personaje.Atacar();
}
