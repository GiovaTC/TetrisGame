# TetrisGame

![image](https://github.com/user-attachments/assets/8a44b307-053d-4e64-b058-48a153c1c594)






# Documentación del Juego de Tetris

## Descripción del Juego
Tetris es un juego de puzzle en el que el jugador debe mover y rotar piezas con forma de bloques (conocidas como "tetrominós") que caen desde la parte superior del área de juego hacia la parte inferior. El objetivo es organizar estas piezas para formar líneas horizontales completas, que se eliminan del tablero, otorgando puntos al jugador. El juego termina cuando las piezas se acumulan y alcanzan la parte superior del área de juego.

## Reglas del Juego

### Objetivo del Juego
El objetivo del juego es completar tantas líneas horizontales como sea posible para obtener la mayor cantidad de puntos antes de que las piezas se acumulen y no haya más espacio disponible en el tablero.

### Controles
- **Mover Izquierda/Derecha**: Permite mover la pieza actual hacia la izquierda o derecha en el área de juego.
- **Rotar**: Rota la pieza en sentido horario (90 grados) para intentar encajarla mejor en el espacio disponible.
- **Descenso Rápido**: Permite mover la pieza actual hacia abajo rápidamente para ubicarla en la posición deseada.
- **Descenso Automático**: Las piezas caen automáticamente a una velocidad que aumenta progresivamente a medida que se juega.

### Tetrominós
Las piezas del juego, llamadas tetrominós, vienen en 7 formas diferentes, cada una con un color distinto y una estructura específica:

- **I-Tetrominó**: Una línea recta de 4 bloques.
- **O-Tetrominó**: Una forma de cuadrado de 2x2 bloques.
- **T-Tetrominó**: Una forma de T compuesta por 4 bloques.
- **S-Tetrominó**: Una forma de zigzag inclinada a la derecha.
- **Z-Tetrominó**: Una forma de zigzag inclinada a la izquierda.
- **J-Tetrominó**: Una forma en L con un bloque adicional en la parte inferior derecha.
- **L-Tetrominó**: Una forma en L con un bloque adicional en la parte inferior izquierda.

### Formación y Eliminación de Líneas
- Cuando una línea horizontal se llena completamente con bloques, esa línea se elimina del tablero.
- Cada vez que se elimina una línea, el jugador obtiene puntos, y las líneas superiores se desplazan hacia abajo para ocupar el espacio vacío.
- Si se eliminan varias líneas a la vez (por ejemplo, al colocar un I-Tetrominó en posición vertical), el jugador obtiene más puntos.

### Puntuación
- **1 línea eliminada**: 100 puntos.
- **2 líneas eliminadas simultáneamente**: 300 puntos.
- **3 líneas eliminadas simultáneamente**: 500 puntos.
- **4 líneas eliminadas simultáneamente (Tetris)**: 800 puntos.

### Niveles y Dificultad
- El juego comienza en el **Nivel 1**, y la velocidad de caída de las piezas aumenta a medida que se completan líneas o pasa el tiempo.
- Cada vez que el jugador completa 10 líneas, se incrementa el nivel y la velocidad de caída.
- Los niveles más altos hacen que las piezas caigan más rápidamente, aumentando la dificultad del juego.

### Condiciones de Fin del Juego
- El juego termina cuando las piezas se acumulan hasta el punto en que una nueva pieza no puede entrar en el tablero.
- El puntaje final se muestra en la pantalla, y el jugador puede elegir reiniciar el juego para intentarlo de nuevo.

### Reglas Adicionales
- **Rotación de Piezas**: Las piezas pueden rotarse siempre y cuando no estén bloqueadas por el borde del área de juego o por otras piezas.
- **Colisiones**: Si una pieza toca otra pieza o el fondo del área de juego, se bloquea en su lugar y no se puede mover más.
- **Pausa**: El jugador puede pausar el juego si lo desea (esta característica depende de la implementación del juego).

### Estrategias Básicas
- **Mantén la parte inferior despejada**: Intenta mantener la parte inferior del tablero lo más despejada posible para evitar bloqueos.
- **Apunta a Tetris (4 líneas)**: Siempre que sea posible, prepara el tablero para eliminar 4 líneas simultáneamente con un I-Tetrominó para obtener la máxima cantidad de puntos.
- **Rota y ajusta**: Practica la rotación de las piezas para encontrar la mejor manera de ubicarlas en el tablero.

## Requisitos Técnicos
- **Área de Juego**: Un tablero rectangular con dimensiones estándar de 10 columnas y 20 filas.
- **Control de Piezas**: Las piezas deben ser controlables usando las teclas de dirección del teclado o botones específicos en la interfaz gráfica.

## Funcionalidades del Formulario Principal
El formulario principal del juego de Tetris debe incluir:

- **Panel de Juego**: Área donde las piezas caen y se colocan.
- **Botones de Control**: Botones para mover las piezas (izquierda, derecha, rotar y descender).
- **Etiqueta de Puntuación**: Indicador para mostrar la puntuación actual del jugador.
- **Botón de Inicio/Restablecimiento**: Para iniciar un nuevo juego o restablecer la partida actual.
- **Nivel de Dificultad**: Indicador del nivel actual para mostrar la dificultad del juego.

## Créditos y Autores
Este proyecto fue desarrollado como parte de un ejercicio de desarrollo de juegos con Windows Forms en .NET. Se inspira en el clásico juego Tetris, creado por Alekséi Pázhitnov en 1984.
