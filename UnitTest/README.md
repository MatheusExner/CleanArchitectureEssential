# Teste de unidade
Testar pequenas partes do software como métodos, funcoes, ou qualquer classe que trate com uma funcionalidade da aplicão
- Responsabilidade do dev.

- Não escrever testes de unidade no mesmo projeto.
- Escrever casos para pequena unidade
- não escrever casos que dependam de outros testes
- Deve ser independente de recursos externos (BD, integracoes)

Plataformas:
- MSTest
- NUnit
- xUnit

<b>xUnit</b>
Fact: métodos sem parametros
Theory: métodos com parametros
Skip: desativar um teste e indicar o motivo
Trait: organizar testes em grupos e criar categorias

<b>Princípio AAA (Arrange, Act and Asert)</b>
Arrange: preparar tudo para o teste
Act: método que estamos testando é executado
Assert: Parte final do teste em que comparamos o que esperamos que aconteça com o resultado real da execução do método de teste.

Nomes dos métodos devem ser os mais descritivos possíveis.
ex: Soma_DoisNumerosInteiros_RetornaNumeroInteiro