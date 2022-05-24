Boa tarde,

Decidir deixar a parte das chamadas dos metodos dentro da propria Operação, acho que e responsabilidade da classe resolver o calculo e mostrar apenas o resultado
Outra possibilidade era fazer tambem todas as chamadas dos metodos fora da Operação dentro do Program, e mais de mais facil leitura porem expoe tudo que e feito.

As bibliotecas usadas foram de conversão de json tanto para serializar e desserializar, tambem a parte de DataAnotations encima das propriedades na camada de Aplication.

para executar o projeto são dois passos:
1 - adicionar um arquivo Cases.json na pasta inputJson dentro da pasta AppBank
2 - basta apenas executar o comando dotnet run dentro da pasta AppBank

OBS:
o objeto de entrada padrao usado foi do case1 + case2 podendo assim ser feita a leitura dos dos casos separadamente.
Ex: Case1 + Case2
[
  [
    {"operation":"buy", "unit-cost":10.00, "quantity": 10000},
    {"operation":"sell", "unit-cost":5.00, "quantity": 5000},
    {"operation":"sell", "unit-cost":20.00, "quantity": 3000}
  ],
  [
    {"operation":"buy", "unit-cost":10.00, "quantity": 10000},
    {"operation":"sell", "unit-cost":5.00, "quantity": 5000},
    {"operation":"sell", "unit-cost":20.00, "quantity": 3000}
  ]
]

Ex: Case1
[
  [
    {"operation":"buy", "unit-cost":10.00, "quantity": 10000},
    {"operation":"sell", "unit-cost":5.00, "quantity": 5000},
    {"operation":"sell", "unit-cost":20.00, "quantity": 3000}
  ]
]

Tentei fazer um projeto de facil entendimento e simples, porem ja tem toda uma estrutura para crescimento do app, a camada de Aplication e Domain.