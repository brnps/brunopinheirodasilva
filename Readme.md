# Projeto API

API para gerenciamento de patrimônios e marcas.
Sem utilização de frameworks.

<b>Instruções:</b>

<br>1 - Executar os arquivos de criação de tabela <b>(Create.sql)</b> e inserir dados iniciais <b>(Insert.sql)</b></br>
<br>2 - rodar o projeto a partir do arquivo <b>BrunoPinheiroDaSilva.sln</b>.</br>

<b> Patrimonio </b>
Link: https://patrimoniomarca.azurewebsites.net/api/patrimonio
Endpoints:
        ◦ GET patrimonios - Obter todos os patrimônios 
        ◦ GET patrimonios/{id} - Obter um patrimônio por ID 
        ◦ POST patrimonios - Inserir um novo patrimônio 
        ◦ PUT patrimonios/{id} - Alterar os dados de um patrimônio 
        ◦ DELETE patrimonios/{id} - Excluir um patrimônio 

<b> Marca </b>
Link: https://patrimoniomarca.azurewebsites.net/api/marca
Link para obter patrimonios de uma marca: https://patrimoniomarca.azurewebsites.net/api/marca/<b>{ID da marca}</b>/patrimonios

Endpoints:
        ◦ GET marcas - Obter todas as marcas 
        ◦ GET marcas/{id} - Obter uma marca por ID 
        ◦ GET marcas/{id}/patrimônios – Obter todos os patrimônios de uma marca 
        ◦ POST marcas - Inserir uma nova marca 
        ◦ PUT marca/{id} - Alterar os dados de uma marca 
        ◦ DELETE marca/{id} - Excluir uma marca 


<b>Ferramentas utilizadas: </b>

- Plataforma .NET Framework
- ASP.NET MVC
- MSSQL Server
