Funcionalidade: GoogleTest
	Teste simples para testar BDD + Selenium

@Google
Cenário: Entrar no Google, pesquisar "pipoca" e entrar no primeiro resultado
	Dado que tenho conexão com a Internet
	Então acessar o site do Google
	E pesquisar 
		| Valor  |
		| pipoca |
	E acessar o primeiro resultado