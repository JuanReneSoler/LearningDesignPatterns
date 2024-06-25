# LearningDesignPatterns

Este repisitorio incluye ejemplos de los 23 patrones de diseño de software incluidos en el libro de design patterns
de Erich Gamma.

Estos se dividen en tres grandes grupos:

1- Patrones Creacionales,
2- Patrones de Estructura
3- Patrones de Comportamiento.

PATRONES CREACIONALES

1. _Abstract Factory_
   Es un patrón de diseño creacional que resuelve el problema de crear familias enteras de objetos sin especificar sus
   clases concretas.

2. Builder
   Es un patrón de diseños creacional que permite construir objetos complejos paso a paso.

3. _Factory Method_
   Es un patrón de diseño creacional que proporciona una interfaz para crear objetos en una superclase, mientras permite
   a las subclases alterar el tipo de objetos que se crearan.

4. _Prototype_
   Es un patrón de diseño creacional que nos permite copiar objetos existentes sin que el codigo dependa de sus clases.

5. _Singleton_
   Es un patrón de diseño creacional que nos permite asegurarnos de que una clase tenga una unica instancia, a la vez
   que proporciona un punto de acceso global a dicha instancia.

PATRONES ESTRUCTURALES

6. _Adapter_
   Es un patrón de diseño estructural que permite la colaboracion entre objetos con interfaces incompatibles.

7. _Bridge_

- Es un patrón de diseño estructural que te permite dividir una clase grande, o un grupo de clases estrechamente
  relacionadas, en dos jerarquias separadas (abstracción e implementación) que pueden desarrollarse independientemente
  una de la otra.
- Tambien llamado puente, desacopla una abstraccion de su implementacion de modo que los dos puedan ser modificados de
  forma independiente.

8. Composite
   Es un patrón de diseño estructural que permite componer objetos en estructuras de árbol y trabajar con esas estructuras
   como si fuerasn objetos unicos e individuales.

9. Decorator

- Es un patrón de diseño estructural que permite añadir funcionalidades a objetos colocando estos objetos dentro de
  objetos encapsuladores especiales que contienen estas funciones.

- Es un patrón de diseño estructural que permite añadir dinamicamente nuevos comportamientos a objetos colocandolos
  dentro de objetos especiales que los envuelven(Wrappers).

10. Facade
    Es un patrón de diseño estructural que proporciona una interfaz simplicada (pero limitada) a una biblioteca, un
    framework o cualquier otro grupo complejo de clases.

11. Flyweight

- Es un patrón de diseño estructural que te permite mantener mas objetos dentro de la cantidad disponible de RAM
  compartiendo las partes comunes del estado entre varios objetos en lugar de mantener toda la informacion en cada
  objeto.

- Es un patrón de diseño estrutural que permite a los programas soportar grandes cantidades de objetos manteniendo un
  bajo uso de memoria.

12. Proxy

- Es un patrón de diseño estructural que te permite proporcionar un sustituto o marcador de posicion para otro objeto.
  Un proxy controla el acceso al objeto original, permitiendote hacer algo antes o despues de que la solicitud llegue
  al objeto original.

- Es un patrón de diseño estructural que proporcional un objeto que actúa como sustituto de un objeto de servicio real
  utilizado por un cliente. Un proxy recibe solicitudes del cliente, realiza parte del trabajo (control de acceso,
  alamacenamiento en cache, etc) y despues pasa la solicitud a un objeto de servicio.

PATRONES DE COMPORTAMIENTO

13. Chain of Responsibility
    Es un patrón de diseño de comportamiento que te permite pasar solicitudes a lo largo de una cadena de manejadores.
    Al recibir una solicitud, cada manejador decide si la procesa o si la pasa al siguiente manejador de la cadena.

14. _Command_
    Es un patrón de diseño de comportamiento que convierte una solicitud en un objeto independiente que contiene toda
    la informacion sobre la solicitud. Esta transformacion te permite parametrizar los metodos con diferentes solicitudes,
    retrasar o poner en cola la ejecucion de una solicitud y soportar operaciones que se pueden realizar.

15. _Interpreter_
    Es un patrón de diseño de comportamiento el cual, dado un lenguaje define una representacion para su gramática
    junto con un interprete del lenguaje.

16. _Iterator_
    Es un patrón de diseño de comportamiento que te permite recorrer elementos de una coleccion sin exponer su
    representacion subyacente (lista, pila, arbol, etc).

17. _Mediator_
    Es un patrón de diseño de comportamiento que te permite reducir las dependencias caoticas entre objetos. El
    patrón restringe las comunicaciones directas entre los objetos, forzandolos a colaborar unicamente a travez de un
    objeto mediador.

18. _Memento_
    Es un patrón de diseño de comportamiento que te permite guardar y restaurar el estado previo de un objeto sin
    revelar los detalles de su implementacion.

19. Observer
    Es un patrón de diseño de comportamiento que te permite definir un mecanismo de suscripcion para notificar a varios
    objetos sobre cualquier evento que le suceda al objeto que estan observando.

20. State
    Es un patrón de diseño de comportamiento que permite a un objeto alterar su comportamiento cuando su estado interno
    cambia. Parece como si el objeto cambiara su clase.

21. Strategy
    Es un patrón de diseño de comportamiento que te permite definir una familia de algoritmos, colocar cada uno de
    ellos en una clase separada y hacer sus objetos intercambiables.

22. _Template Method_
    Es un patrón de diseño de comportamiento que define el esqueleto de un algoritmo en la superclase pero permite que
    las subclases sobreescriban pasos del algoritmo sin cambiar su estructura.

23. _Visitor_
    Es un patrón de diseño de comportamiento que te permite separar algoritmos de los objetos sobre los que operan.
