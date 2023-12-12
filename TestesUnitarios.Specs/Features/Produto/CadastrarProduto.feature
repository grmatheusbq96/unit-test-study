Funcionalidade: Cadastrar um produto
Eu como usuario do sistema
Preciso que seja possivel o cadastro de produtos
Para que eu possa melhorar o gerenciamento do meu estoque de produtos

Cenario: Cadastra um produto inexistente na base
Dado que ao receber um objeto de produto com os seus campos corretamente preenchidos
Quando a aplicacao invocar o metodo para cadastro de um produto
Entao a aplicacao deve retornar sucesso true com um objeto de retorno preenchido
