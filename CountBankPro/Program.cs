//Criar um construtor para a classe Titular, que inicialize todas suas propriedades
//Criar um construtor para a classe Conta, que inicialize todas suas propriedades
//Instanciar uma Conta e exibir suas informações na tela, utilizando construtores


Titular teste = new Titular("Filipe Bernard", "362.222.233-44", "Rua endereço exemplo 1");
teste.ExibirFixaTitular();
Conta ContaTeste = new Conta(teste, 9999, 123456789, 50, 99);
ContaTeste.TesteDeVoid();


Titular teste2 = new Titular("Diogo Ramos", "362.625.408-90", "Rua endereço exemplo 2");
teste2.ExibirFixaTitular();
Conta ContaTeste2 = new Conta(teste2, 4444, 987654321, 35, 85);
ContaTeste2.TesteDeVoid();

