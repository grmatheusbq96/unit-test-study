Funcionalidade: Cadastrar um produto
	Eu como usuario do sistema
	Preciso que seja possivel o cadastro de produtos
	Para que eu possa melhorar o gerenciamento do meu estoque de produtos

Cenario: Cadastrar um produto inexistente na base
	Dado que ao receber um objeto de produto com os seus campos corretamente preenchidos
	Quando a aplicacao invocar o metodo para cadastro de um produto
	Entao a aplicacao deve retornar sucesso true com um objeto de retorno preenchido

Cenario: Cadastrar um produto ja existente na base
	Dado que ao receber um objeto de produto que ja foi cadastrado na base
	Quando a aplicacao invocar o metodo para cadastro
	Entao a aplicacao deve retornar sucesso false com um objeto nulo