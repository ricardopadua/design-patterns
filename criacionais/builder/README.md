## Builder Pattern

O Builder é um padrão de projeto criacional, que permite a construção de objetos complexos passo a passo. isso torna possível produzir produtos diferentes usando o mesmo processo de construção. 

O padrão Builder sugere que você extraia o código de construção do objeto para fora de sua própria classe e mova ele para objetos separados chamados builders. Esses construtores ainda se referem ao principal, passando alguns valores padrão para qualquer parâmetro omitido. “Builder” significa “construtor”, mas não usaremos essa palavra para evitar confusão com os construtores de classe.


## Quando usar?

Sempre que tivermos um objeto complexo de ser criado, que possui diversos atributos, ou que possui uma lógica de criação complicada, use o padrão Builder para se livrar de um construtor mostruoso.

Imagine um objeto complexo que necessite de uma inicialização passo a passo trabalhosa de muitos campos e objetos agrupados. esse código de inicialização fica geralmente enterrado dentro de um construtor com vários parâmetros ou espalhado por todo o código.