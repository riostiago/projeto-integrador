-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 01-Out-2021 às 04:52
-- Versão do servidor: 10.4.20-MariaDB
-- versão do PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `lojahow3`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `form_cadastro_cliente`
--

CREATE TABLE `form_cadastro_cliente` (
  `Tipo_Pessoa` varchar(20) DEFAULT NULL,
  `Cod_Cliente` tinyint(4) NOT NULL,
  `CPF` tinytext NOT NULL,
  `CNPJ` tinytext DEFAULT NULL,
  `Nome` varchar(30) NOT NULL,
  `Sobrenome` varchar(30) DEFAULT NULL,
  `Sexo` varchar(10) DEFAULT NULL,
  `Data_Nasc` tinytext DEFAULT NULL,
  `EMAIL` tinytext DEFAULT NULL,
  `Rua` varchar(30) DEFAULT NULL,
  `Num` int(11) DEFAULT NULL,
  `CEP` tinytext DEFAULT NULL,
  `Complemento` varchar(20) DEFAULT NULL,
  `Bairro` varchar(30) DEFAULT NULL,
  `Cidade` varchar(30) DEFAULT NULL,
  `Estado` varchar(20) DEFAULT NULL,
  `Limite_cred` double DEFAULT NULL,
  `Informacoes` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `form_cadastro_cliente`
--
ALTER TABLE `form_cadastro_cliente`
  ADD PRIMARY KEY (`Cod_Cliente`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `form_cadastro_cliente`
--
ALTER TABLE `form_cadastro_cliente`
  MODIFY `Cod_Cliente` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
