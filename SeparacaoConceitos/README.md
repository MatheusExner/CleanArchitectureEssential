# Separations of Concerns - SoC - Separação dos conceitos
Não deve misturar conceitos e/ou responsabilidades diferentes dentro do design ou do código de um projeto.

A violação deste princípio causa codigo duplicado com mais de uma responsbilidade, violando princípios do SOLID da Responsabilidade única e o princípio DRY - Dont repeat yourself.

Ex: 
- Separar interface front e back.
- Separar código de acesso a dados do código da apresentação dos dados.
- Seprar o projeto em diferentes módulos/camadas com responsabilidades distintas.
- Criar componentes/classes/funções que realizam apenas uma única tarefa com eficiência.

Conceitos/responsabilidades:
- reduzir acoplamento.
- aumentar a coesão.

Vantagens:
- Facilita manutenção.
- Melhor reutilização do código.
- Melhor clareza do código.
- Melhora na testabilidade.
- Permite uma evolução mais rápida do projeto.