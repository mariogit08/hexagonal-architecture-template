# Onion Architecture .NET Template
This template help to create the main layers suggested by onion(hexagonal, clean) architecture with DDD mindset.

English

This template help to create the main layers suggested by onion(hexagonal, clean) architecture.
The template was created using Visual Studio SDK.

## Installing the template
You need download the project and put the zip file in C:\Users\<YourUser>\Documents\Visual Studio <yourVersion>\Templates\ProjectTemplates in your computer.

## Using the template
Once you put the project zip in the folder, start the visual studio and go to New Project, after this, you can see the option to select the template already enabled. See the image bellow.
  
### HACK

Unfortunately, due to a bug developing multi-project templates for Visual Studio, an extra folder is created when you generate the project, which will interfere with some NuGet packages.

You have to perform the following extra steps in order to get the project to build:

		1. Click on your Solution in Solution Explorer.
		2. Go to File > Save As
		3. Save the solution file in the extra folder.
		4. Delete the original solution file.
		5. Move all files in the extra folder into the parent folder.
		6. Delete the extra folder.

Português

Template que ajuda a criar as principais camadas(projetos) dentro de uma solução seguindo as camadas sugeridas pela arquitetura onion (hexagonal, clean) baseado-se nos princípios do DDD.
O template foi criado utilizando o Visual Studio SDK.

## Instalando o template
Você precisa baixar e colocar o zip desse projeto na pasta C:\Users\<YourUser>\Documents\Visual Studio <yourVersion>\Templates\ProjectTemplates no seu computador.  

## Utilizando o template  
Depois que o projeto for colocado na pasta ao iniciar o Visual Studio e clicar em New Project a opção para selecionar o template já estará disponível, como é possível visualizar na imagem a abaixo.

### HACK

Infelizmente, devido a um bug no desenvolvimento de templates multi-project através do Visual Studio SDK, um diretório extra é criado acima da pastas dos projetos da solution, que interfere nas referências aos pacotes Nuget.

Você tem que executar o seguintes passos após criar um projeto a partir do template para que ele funcione corretamente:

		1. Clicar no nó da solução dentro da visualização Solution Explorer
		2. Clicar em File > Save As
		3. Salvar a solução dentro do diretório criado onde estão os projetos.
		4. Deletar a o sln original
		5. Mover todos os arquivos do diretório para a pasta pai.
		6. Deleta o diretório extra.
