# Darwin vs Zombies

Um joguinho de estratégia e sobrevivência que fiz no Unity para colocar em prática alguns conceitos mais avançados de C# e otimização.

## O que tem no código:

### 1. Sistema de Object Pool Genérico
Em vez de ficar criando e destruindo bala e zumbi toda hora (o que pesa muito no jogo), eu fiz um **Object Pool**.
- **Generics:** Usei `<T>` para a classe de pool aceitar qualquer coisa. Assim não precisei repetir código para bala e para zumbi.
- **Performance:** Os objetos voltam para uma fila (`Queue`) e são desativados, evitando que o jogo dê aquelas travadinhas de memória.

### 2. Mira com Matemática
Fiz a rotação da sprite seguir o mouse usando `Mathf.Atan2`. 
- Calculei o ângulo entre o player e o cursor para a mira ficar bem precisa e perpendicular.

### 3. Unity Input System
Saí do básico e usei o novo **Input System** da Unity.
- Controlei o tiro por eventos (`performed` e `canceled`), o que deixa o código muito mais limpo do que socar tudo dentro de um Update.

### 4. Interface (UI)
- Usei o padrão **Singleton** no `UIManager` para facilitar o acesso de qualquer lugar.
- Controle de menus via `CanvasGroup` para não ter que ficar ativando/desativando objetos de UI toda hora.

---

## Como rodar
1. Clona aí: `git clone https://github.com/seu-usuario/darwin-vs-zombies.git`
2. Abre no Unity (Usei a unity 6000.30).
3. Só dar Play!
1. Clona aí: `git clone https://github.com/seu-usuario/darwin-vs-zombies.git`
2. Abre no Unity (tô usando a 2022.3 ou superior).
3. Só dar Play!
