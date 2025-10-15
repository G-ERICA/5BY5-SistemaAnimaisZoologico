# POO - Sistema de Animais no Zoológico

Contexto: Você foi contratado para desenvolver um sistema simples de cadastro de animais em um zoológico. O sistema deve representar diferentes tipos de animais, cada um com comportamentos específicos, mas todos compartilhando características em comum.

🎯Requisitos:

**Classe base (Herança):**  
Crie uma classe Animal com:  
Atributos privados: nome (String) e idade (int).

Métodos públicos:  
getNome() e getIdade() (encapsulamento).  
emitirSom() (método que será sobrescrito).  
toString() para exibir informações.

**Classes derivadas (Herança + Polimorfismo):**  
Crie subclasses de Animal, como:
Cachorro - Gato - Leao

Cada uma deve sobrescrever o método emitirSom() com comportamento próprio.  
Exemplo: cachorro → "Au Au", gato → "Miau", leão → "Rugido".

💊Encapsulamento:  
Mantenha os atributos da classe Animal privados.  
Use getters/setters para manipular os valores.

🔗Polimorfismo em ação:  
Crie uma vetor e adicione objetos de diferentes tipos (Cachorro, Gato, Leao).

Percorra a lista e invoque emitirSom() para cada elemento.
