# Curso API DIO

## Projeto
<p>Trata-se de um projeto básico de API REST desenvolvido em C# com .NET core, ASP.NET core e EF core. É composto pelas classes <b>Produto</b> e <b>Categoria</b> e realiza o CRUD de ambas em um Banco de Dados <em>In Memory</em></p>

## Classe Categoria
<p>Classe que representa as categorias dos produtos cadastrados no sistema (Lacticínios, Limpeza, etc.).</p>
<p>Possui:</p> 
<ul>
<li>Id (Int)</li>
<li>Descrição (String)</li>
</ul>


## Classe Produto
<p>Classe que representa os produtos cadastrados no sistema.</p>
<p>Possui:</p>
<ul>
<li>Id (Int)</li>
<li>Descrição (String)</li>
<li>Id da Categoria (Int)</li>
</ul>
