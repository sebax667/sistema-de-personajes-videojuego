# ⚔️ Sistema de Combate: Personajes en C#

![C#](https://img.shields.io/badge/C%23-.NET%208.0%2B-blueviolet?style=for-the-badge&logo=c-sharp)
![POO](https://img.shields.io/badge/Paradigma-POO-blue?style=for-the-badge)
![License](https://img.shields.io/badge/Licencia-MIT-green?style=for-the-badge)

Un motor de simulación de combate orientado a objetos desarrollado en **C#**, diseñado para demostrar la implementación práctica de patrones de diseño, principios SOLID y pilares de la **Programación Orientada a Objetos (POO)**.

---

## 🚀 Características Principales

| Pilar POO | Implementación en el Proyecto |
| :--- | :--- |
| 🧬 **Herencia & Polimorfismo** | Clases especializadas (`Guerrero`, `Mago`, `Arquero`) que sobrescriben el comportamiento de ataque base. |
| 🛡️ **Abstracción & Interfaces** | Uso de `ICurable` e `IDefendible` para acoplamiento débil y capacidades modulares. |
| 🔒 **Encapsulamiento** | Validación rigurosa de atributos críticos (`Vida`, `Nivel`, `Mana`) mediante propiedades con getters/setters protegidos. |

---

## 🧬 Arquitectura del Sistema

```text
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
```

### 🎭 Clases y Roles

* 🗡️ **`Guerrero`**: Especialista en combate cuerpo a cuerpo. Implementa `IDefendible` para mitigar el daño entrante.
* 🔮 **`Mago`**: Usuario de magia elemental. Implementa `ICurable` para restaurar puntos de vida propios o de aliados usando Maná.
* 🏹 **`Arquero`**: Atacante a distancia. Gestiona un recurso limitado (*Flechas*) que condiciona la ejecución de sus ataques.

---

## 🎓 Aprendizajes Clave

Este ejercicio práctico permitió profundizar en los siguientes conceptos de arquitectura y diseño:

* 🔄 **Polimorfismo en acción:** Tratar diferentes subclases mediante una referencia base `Personaje`, lo que facilita iterar sobre colecciones heterogéneas sin acoplar el código a tipos concretos.
* 🔌 **Diseño modular con Interfaces:** Extensión de capacidades (`ICurable`, `IDefendible`) de forma flexible sin romper la jerarquía de herencia ni forzar herencia múltiple.
* 🛡️ **Invariantes y Encapsulamiento:** Protección de la integridad de los datos (`Vida`, `Nivel`, `Mana`) mediante propiedades C# con lógica interna de validación para evitar estados inconsistentes.

---

## 🛠️ Requisitos e Instalación

### Prerrequisitos
* **.NET SDK** 6.0 o superior (Recomendado .NET 8.0).
* Un IDE o editor compatible: **Visual Studio Code**, **Visual Studio**, o **JetBrains Rider**.

### Pasos para Ejecutar

1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/tu-usuario/nombre-del-repo.git
   cd nombre-del-repo
   ```

2. **Restaurar y compilar:**
   ```bash
   dotnet build
   ```

3. **Ejecutar la simulación:**
   ```bash
   dotnet run
   ```

---

## 💻 Ejemplo de Uso

```csharp
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
```

---

## 📝 Licencia

Este proyecto está bajo la Licencia **MIT**. Consulta el archivo `LICENSE` para más detalles.