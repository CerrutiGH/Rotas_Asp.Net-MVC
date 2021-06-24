DROP DATABASE IF EXISTS db_Melhores_Noticias;
CREATE DATABASE IF NOT EXISTS db_Melhores_Noticias;
USE db_Melhores_Noticias;

CREATE TABLE IF NOT EXISTS tb_Noticias(
COD_NOTICIA INT PRIMARY KEY AUTO_INCREMENT,
TITULO_NOTICIA VARCHAR(100) NOT NULL,
DESCRICAO_NOTICIA VARCHAR(100) NOT NULL,
CATEGORIA_NOTICIA TEXT NOT NULL,
DATA_NOTICIA DATE NOT NULL
);

INSERT INTO tb_Noticias(TITULO_NOTICIA, DESCRICAO_NOTICIA, CATEGORIA_NOTICIA, DATA_NOTICIA)
VALUES("O time da escola ganha dos catados", "O time da escola vence por 10X2 de ime montado com os alunos sem time", "Esportes", str_to_date("01/01/0001", "%d/%m/%Y")),
("Ônibus da seleção masculina preso em blitz", "O ônibus da seleção masculina de queimada foi parado pela blitz", "Esportes", str_to_date("01/01/0001", "%d/%m/%Y")),
("Custo da Escola", "O custo das escolas aumentaram", "Escola", str_to_date("01/01/0001", "%d/%m/%Y")),
("Diario de um Nerd", "Diario de um Nerd é o novo livro mais comentado", "Escola", str_to_date("01/01/0001", "%d/%m/%Y"));

select * from tb_Noticias;
