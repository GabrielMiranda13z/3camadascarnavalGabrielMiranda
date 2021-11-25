CREATE DATABASE IF NOT EXISTS `3camadas` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `3camadas`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `carnaval`
--

DROP TABLE IF EXISTS `carnaval`;
CREATE TABLE IF NOT EXISTS `carnaval` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nomedobloco` varchar(45) NOT NULL,
  `quantpessoas` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `login`
--

INSERT INTO `login` (`id`, `nome`, `senha`) VALUES
(1, 'teste', 'teste');