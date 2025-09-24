Este proyecto muestra dos principios SOLID:

SRP - Responsabilidad Única
Cada clase tiene una sola función:
- "Player Input": detecta teclas.
- "CombatController": coordina el combate.
- "UchigatanaAttack" y "ShieldDefense": ejecutan acciones específicas.

DIP - Inversión de Dependencias
El controlador "CombatController" usa interfaces "IAttackAction", "IDefenseAction" en vez de clases concretas. Esto permite cambiar la lógica sin modificar el controlador.

Cómo probar
Presioná "A" para atacar y "D" para defender.
