# Projeto API Patrimonio/Marca

<br>API para gerenciamento de patrimônios e marcas.
<br>Sem utilização de frameworks.

<h2>Instruções:</h2>

<br>1 - Executar os arquivos de criação de tabela <b>(Create.sql)</b> e inserir dados iniciais <b>(Insert.sql)</b></br>
<br>2 - rodar o projeto a partir do arquivo <b>BrunoPinheiroDaSilva.sln</b>.</br>

<h2> Patrimonio </h2>
<br>Link: https://patrimoniomarca.azurewebsites.net/api/patrimonio

<br>Endpoints:
        <br>◦ GET patrimonios - Obter todos os patrimônios 
        <br>◦ GET patrimonios/{id} - Obter um patrimônio por ID 
        <br>◦ POST patrimonios - Inserir um novo patrimônio 
        <br>◦ PUT patrimonios/{id} - Alterar os dados de um patrimônio 
        <br>◦ DELETE patrimonios/{id} - Excluir um patrimônio 

<h2> Marca </h2>
<br>Link: https://patrimoniomarca.azurewebsites.net/api/marca
<br>Link para obter patrimonios de uma marca: https://patrimoniomarca.azurewebsites.net/api/marca/<b>{ID da marca}</b>/patrimonios

<br>Endpoints:
        <br>◦ GET marcas - Obter todas as marcas 
        <br>◦ GET marcas/{id} - Obter uma marca por ID 
        <br>◦ GET marcas/{id}/patrimônios – Obter todos os patrimônios de uma marca 
        <br>◦ POST marcas - Inserir uma nova marca 
        <br>◦ PUT marca/{id} - Alterar os dados de uma marca 
        <br>◦ DELETE marca/{id} - Excluir uma marca 


<h2>Ferramentas utilizadas: </h2>

- Plataforma .NET Framework (C#)
- ASP.NET MVC (C#)
- MSSQL Server
