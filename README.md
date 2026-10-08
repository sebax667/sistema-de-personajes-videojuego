# Sistema de Combate: Personajes en C#

Este proyecto es una implementación de un sistema de personajes de videojuego utilizando los principios fundamentales de la **Programación Orientada a Objetos (POO)** en C#. 

## Características Principales
El sistema demuestra el manejo de estructuras complejas mediante:
- **Clases Abstractas:** Definición de una plantilla base `Personaje`.
- **Herencia y Polimorfismo:** Implementación de clases derivadas (`Guerrero`, `Mago`, `Arquero`) con comportamientos específicos.
- **Interfaces:** Uso de `ICurable` e `IDefendible` para añadir habilidades selectivas a ciertos personajes.
- **Encapsulamiento:** Protección de datos críticos (Vida, Nivel) mediante propiedades con lógica de validación.

## Estructura del Código
- **`Personaje` (Base):** Define los atributos comunes y el método abstracto `Atacar()`.
- **`Guerrero`:** Implementa `IDefendible` y ataque físico.
- **`Mago`:** Implementa `ICurable` y ataque mágico.
- **`Arquero`:** Gestiona un recurso limitado (flechas) para atacar.

## Requisitos de Ejecución
- .NET SDK (6.0 o superior recomendado).
- Un IDE como Visual Studio, Visual Studio Code o JetBrains Rider.

## Cómo ejecutar
1. Clona este repositorio.
2. Abre la terminal en la carpeta del proyecto.
3. Ejecuta el comando: `dotnet run`
   
## Lo que he aprendido
Este ejercicio me ha permitido comprender:
- Cómo el polimorfismo permite tratar diferentes objetos como una sola referencia base.
- La importancia de las interfaces para extender las capacidades de las clases sin romper la jerarquía de herencia.
- Cómo proteger la integridad de los datos usando propiedades con validaciones.
