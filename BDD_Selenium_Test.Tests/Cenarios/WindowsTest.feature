Funcionalidade: WindowsTest
	Teste básico para interação com janelas e programas do Windows 

@Windows
Cenário: Abrir notepad
	Dado estou num computador com Windows
	Quando for um horário múltiplo de 5
	Então abrir o notepad
	E Digitar
	| Valor                        |
	| FOR /L %%A IN (1,1,200) DO ( |
	|	ECHO %%A                   |
	| )                            |
	E salvar arquivo na área de trabalho
