# Generala simulación.

## **Sobre mí**
### Mi nombre es Kevin Veliz y este trabajo fue un desafío con pro y contras a lo largo de su implementanción. No se me fue fácil, pero aprendí demasiado.

---

## **Resumen**
### La aplicación es una implementación del juego la generala. Comienza la app con una login en donde se puede iniciar sesión en caso de tener una cuenta creada o caso contrario la opción de poder generar una. Una vez dentro tendrá las opciones para generar salas, crear jugadores y ver las estadisticas obtenidas.


## **Justificación técnica**

### **Delegados.**

Utilice delegados para poder generar eventos.

```` C#
public delegate void ActualizarDadosEventHandler(List<int> dados);

public  delegate void ActualizarCategoriasEventHandler(Jugador jugador);
````

Su implementación se debe a que encapsulan la firma de los métodos que puede ser invocados por el evento, permiten la flexibilidad y la suscripción y desuscripción de múltiples métodos.

```` C#
public event ActualizarDadosEventHandler ActualizarDados;
````




