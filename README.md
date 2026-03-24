## Implementação Técnica e Desafios

###  Object Pooling Customizado
Para evitar o alto custo de memória do *Garbage Collector*, implementei um sistema de **Object Pool** utilizando **C# Generics**. 
- **Flexibilidade:** A classe `objectPool<T>` permite gerenciar qualquer tipo de classe ou GameObject.
- **Eficiência:** Utilizo `Queue<T>` para garantir que a reciclagem de objetos (como balas e zumbis) seja feita em tempo constante.

### Sistema de Mira (Trigonometria)
A rotação do jogador é calculada dinamicamente baseada na posição do mouse na tela.
- Utilização de `Mathf.Atan2` para converter coordenadas de mundo em ângulos.
- Manipulação de `Quaternion.AngleAxis` para garantir que a sprite permaneça perpendicular ao cursor sem distorções.

### Entrada de Dados (Input System)
O projeto utiliza o novo **Unity Input System**, permitindo um controle mais robusto:
- Uso de `InputActionReference` para desacoplar a lógica da arma dos botões físicos.
- Implementação de eventos (`performed` e `canceled`) para gerenciar o estado de disparo de forma reativa.
