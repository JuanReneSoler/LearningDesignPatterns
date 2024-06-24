# LearningDesignPatterns

este repisitorio incluye ejemplos de los 23 patrones de dise~no de software incluidos en el libro de design patterns de Erich Gamma

estos se dividen en tres grandes grupos: patrones creacionales, patrones de estructura y patrones de comportamiento.

PATRONES CREACIONALES

_Abstract Factory_
Es un patron de dise~no creacional que resuelve el problema de crear familias enteras de objetos sin especificar sus clases concretas.

_Builder_
Es un patron de dise~no creacional que permite construir objetos complejos paso a paso.

_Factory Method_
Es un patron de dise~no creacional que proporciona una interfaz para crear objetos en una superclase, mientras permite a las subclases alterar el tipo de objetos que se crearan.

_Prototype_
Es un patron de dise~no creacional que nos permite copiar objetos existentes sin que el codigo dependa de sus clases.

_Singleton_
Es un patron de dise~no creacional que nos permite asegurarnos de que una clase tenga una unica instancia, a la vez que proporciona un punto de acceso global a dicha instancia.

PATRONES ESTRUCTURALES

_Adapter_
Es un patron de dise~no estructural que permite la colaboracion entre objetos con interfaces incompatibles.

_Bridge_

1. Es un patron de dise~no estructural que te permite dividir una clase grande, o un grupo de clases estrechamente relacionadas, en dos jerarquias separadas (abstraccion e implementacion) que pueden desarrollarse independientemente una de la otra.
2. Tambien llamado puente, desacopla una abstraccion de su implementacion de modoque los dos puedan ser modificados de forma independiente.

_Composite_
Es un patron de dise~no estructural que permite componer objetos en estructuras de arbol y trabajar con esas estructuras como si fuerasn objetos unicos e individuales.

_Decorator_

1. Es un patron de dise~no estructural que permite a~nadir funcionalidades a objetoscolocando estos objetos dentro de objetos encapsuladores especiales que contienenestas funciones.

2. Es un patron de dise~no estructural que permite a~nadir dinamicamente nuevos comportamientos a objetos colocandolos dentro de objetos especiales que los envuelven(Wrappers).

_Facade_

1. Es un patron de dise~no estructural que proporciona una interfaz simplicada(pero limitada) a una biblioteca, un framework o cualquier otro grupo complejo de clases.

_Flyweight_

1. ES un patron de dise~no estructural que te permite mantener mas objetos dentro de la cantidad disponible de RAM compartiendo las partes comunes del estado entre varios objetos en lugar de mantener toda la informacion en cada objeto.

2. Es un patron de dise~no estrutural que permite a los programas soportar grandes cantidades de objetos manteniendo un bajo uso de memoria.

_Proxy_

1. Es un patron de dise~no estructural que te permite proporcionar un sustituto o marcador de posicion para otro objeto. Un proxy controla el acceso al objeto original, permitiendote hacer algo antes o despues de que la solicitud llegue al objeto original.

2. Es un patron de dise~no estructural ue proporcional un objeto que actual como sustituto de un objeto de servicio real utilizado por un cliente. Un proxy recibe solicitudes del cliente, realiza parte del trabajo (control de acceso, alamacenamiento en cache, etc) y despues pasa la solicitud a un objeto de servicio.

PATRONES DE COMPORTAMIENTO

_Chain of Responsibility_
Es un patron de dise~no de comportamiento que te permite pasar solicitudes a lo largo de una cadena de manejadores. Al recibir una solicitud, cada manejador decide si la procesa o si la pasa al siguiente manejador de la cadena.

_Command_
Es un patron de dise~no de comportamiento que convierte una solicitud en un objeto independiente que contiene toda la informacion sobre la solicitud. Esta transformacion te permite parametrizar los metodos con diferentes solicitudes, retrasar o poner en cola la ejecucion de una solicitud y soportar operaciones que se pueden realizar.

_Interpreter_
Es un patron de dise~no de comportamiento el cual, dado un lenguaje define una representacion para su gramatica junto con un interprete del lenguaje.

_Iterator_
Es un patron de dise~no de comportamiento que te permite recorrer elementos de una coleccion sin exponer su representacion subyacente (lista, pila, arbol, etc).

_Mediator_
Es un patron de dise~no de comportamiento que te permite reducir las dependencias caoticas entre objetos. El patron restringe las comunicaciones directas entre los objetos, forzandolos a colaborar unicamente a travez de un objeto mediador.

_Memento_
Es un patron de dise~no de comportamiento que te permite guardar y restaurar el estado previo de un objeto sin revelar los detalles de su implementacion.

_Observer_
Es un patron de dise~no de comportamiento que te permite definir un mecanismo de suscripcion para notificar a varios objetos sobre cualquier evento que le suceda al objeto que estan observando.

_State_
Es un patron de dise~no de comportamiento que permite a un objeto alterar su comportamiento cuando su estado interno cambia. Parece como si el objeto cambiara su clase.

_Strategy_
Es un patron de dise~no de comportamiento que te permite definir una familia de algoritmos, colocar cada uno de ellos en una clase separada y hacer sus objetos intercambiables.

_Template Method_
Es un patron de dise~no de comportamiento que define el esqueleto de un algoritmo en la superclase pero permite que las subclases sobreescriban pasos del algoritmo sin cambiar su estructura.

_Visitor_
Es un patron de dise~no de comportamiento que te permite separar algoritmos de los objetos sobre los que operan.
