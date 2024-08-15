# AR Pong

## Descripción General
Este proyecto comenzó como una iniciativa para explorar las capacidades de la realidad aumentada (AR) en el ámbito de los videojuegos clásicos. No hay un cliente específico; el proyecto es una exploración académica y de desarrollo personal. El objetivo es crear una experiencia inmersiva y accesible de Pong utilizando AR, donde los jugadores interactúan con el juego mediante tarjetas físicas.

## Características del Juego
- **Start Card:** Al detectar esta tarjeta, el juego entra en modo de inicio mostrando un menú interactivo en AR.
- **Modo de Inicio:** Se activa al escanear la "Start Card" y muestra opciones como "Iniciar Juego" en la pantalla.
- **Modo de Juego:** Una vez iniciado, el juego despliega la arena de Pong en AR, donde se puede jugar siguiendo las reglas clásicas del juego.

## Game Objective
El objetivo del juego es simple: los jugadores deben utilizar su tarjeta AR para controlar una paleta e intentar devolver la pelota. El éxito se logra al evitar que la pelota pase y marcar puntos. El fracaso ocurre si la pelota atraviesa por la zona de muerte.

## Theme, Setting, Visual Style
- **Theme:** Clásico con un toque moderno de AR.
- **Setting:** Una arena de juego virtual proyectada en un espacio real a través de AR.
- **Visual Style:** El estilo visual combina elementos clásicos del juego original Pong con gráficos modernos. Se busca evocar nostalgia mientras se ofrece una experiencia visual fresca y atractiva. Los efectos visuales y el sonido complementan esta estética, proporcionando una sensación de inmersión y simplicidad.

## Gameplay

### Scoring
El sistema de puntuación sigue las reglas clásicas de Pong. Los jugadores obtienen un punto cada vez que logran que la pelota atraviese el lado opuesto de la arena de juego. El juego puede configurarse para un número específico de puntos para determinar al ganador. La puntuación se muestra en pantalla en tiempo real durante el juego, y el marcador se restablece al final de cada partida.

### Player Mechanics
Los jugadores controlan una paleta virtual utilizando la tarjeta AR. La posición de la tarjeta en el espacio físico determina el movimiento de la paleta en la arena de juego virtual. El movimiento es fluido y responde inmediatamente a los movimientos de la tarjeta, permitiendo un control preciso.

### Object Mechanics
La pelota se mueve automáticamente en la arena, rebotando en las paredes y las paletas. Su velocidad puede aumentar con el tiempo para aumentar la dificultad. Si la pelota toca la zona de muerte de un jugador, el otro jugador obtiene un punto. Las paletas y la pelota tienen un estilo visual sencillo pero efectivo, con efectos que resaltan cada impacto y movimiento.

## Interaction Design
Los jugadores interactúan con el juego a través de tarjetas físicas que son escaneadas por la cámara del dispositivo móvil. Al mover la tarjeta, los jugadores controlan la paleta en la arena virtual. El juego reconoce los movimientos de la tarjeta y los traduce en acciones dentro del juego, proporcionando una experiencia de control directa y táctil.

## User Interface and Feedback
La interfaz de usuario incluye un marcador de puntos, indicadores visuales para el inicio y final de la partida, y notificaciones en pantalla que guían a los jugadores durante el juego. La pantalla de inicio ofrece opciones como "Iniciar Juego" y "Configuraciones". El feedback se proporciona mediante efectos visuales y sonoros que destacan las acciones importantes, como la puntuación de un punto o el final de la partida.

## Technical Details

### Engine
Se ha seleccionado Unity 2022.3.38f1 por su robustez y capacidad para desarrollar aplicaciones de realidad aumentada. Unity permite una fácil integración con el SDK de Vuforia, que se utiliza para la detección y el seguimiento de las tarjetas AR.

### SDK
**Vuforia SDK** está integrado en el proyecto para la detección de las tarjetas físicas y su interacción con el entorno virtual.
![Texto alternativo](https://github.com/Cristian171/3D-DOC/blob/main/Recursos/inicioG.png?raw=true)


### Platform Requirements
El juego está diseñado para dispositivos móviles Android equipados con una cámara que permita escanear las tarjetas físicas, proporcionando una experiencia AR fluida y accesible.
