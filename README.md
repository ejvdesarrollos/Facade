# Facade
Patrón de comportamiento

El objetivo de la fachada es exponer simplemente una acción visible al cliente. Es por es que todas las clases creadas responden a un namespace llamado "XXXXXXX".
La clase que hacce de Fachada implementa internamente atributos privados llamando a esas clases que forman parte de subsistemas. EL método de fachada expuesto es el llamado principal,
pero internamente hay ejecuciones complejas de diferentes clases. De ahí la "fachada".
