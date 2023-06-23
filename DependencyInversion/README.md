# Dependency Inversion (DI)
A direção da dependÊncia em uma aplicação deverá ser na direção da abstração e não nos detalhes da implementação.

Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de uma abstração.

Abstrações não devem depender de detalhes, detalhes devem depender de abstrações.

Módulos de alto nível: classes da camada de negócio, que encapsulam lógica complexa.
Módulos de baixo nível: classes da camada de infraestrutura, que implementa operações básicas, como acesso a dados, disco, protocolos de rede, etc..
Abstrações: interfaces ou classes abstratas que não possuem implementação.
*classes da camada de negócio, não deve depender das classes da camada de infra, mas ambas devem depender de interfaces ou classes abstratas.* 
<b>*não confundiar inversão da dependencia com injeção da dependencia*<b>

Implementação nas classes RecuperarSenha e interface IDataBaseConnection.

- Princípio da inversão da dependência (DIP)
- Injeção da dependência(DI)
- Inversão de controle (IoC)
- Container IoC - Container de injeção de dependência.
