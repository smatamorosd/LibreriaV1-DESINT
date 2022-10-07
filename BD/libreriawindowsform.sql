-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 15-03-2017 a las 14:14:15
-- Versión del servidor: 5.7.14
-- Versión de PHP: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `libreriawindowsform`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tcliente`
--

CREATE TABLE `tcliente` (
  `idCliente` SMALLINT NOT NULL AUTO_INCREMENT,
  `CodCliente` varchar(50)  NOT NULL,
  `Nombre` varchar(50)  NOT NULL,
  `Apellidos` varchar(50)  NOT NULL,
  `DNI` varchar(50)  NOT NULL,
  `Direccion` varchar(100)  NOT NULL,
  `Email` varchar(100)  NOT NULL,
  `Borrado` varchar(1)  NOT NULL,

  CONSTRAINT PK_CodCliente PRIMARY KEY(idCliente, CodCliente)

) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;

--
-- Volcado de datos para la tabla `tcliente`
--

INSERT INTO `tcliente` (`CodCliente`, `Nombre`, `Apellidos`, `DNI`, `Direccion`, `Email`, `Borrado`) VALUES
('cod001', 'Javi', 'Díaz', '45562345L', 'Calle falsa nº2', 'javi@email.com', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tfactura`
--

CREATE TABLE `tfactura` (
  `idFactura` SMALLINT AUTO_INCREMENT NOT NULL,
  `Cliente` varchar(50)  NOT NULL,
  `FechaFactura` varchar(50)  NOT NULL,
  `Borrado` varchar(1)  NOT NULL,

  CONSTRAINT PK_idFactura PRIMARY KEY(idFactura)


) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;

--
-- Volcado de datos para la tabla `tfactura`
--

INSERT INTO `tfactura` (`idFactura`, `Cliente`, `FechaFactura`, `Borrado`) VALUES
('1', 'Javi Díaz', '16/02/2017', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tlibro`
--

CREATE TABLE `tlibro` (
  `idLibro` SMALLINT AUTO_INCREMENT NOT NULL,
  `Autor` varchar(50)  NOT NULL,
  `Titulo` varchar(50)  NOT NULL,
  `Tema` varchar(50)  NOT NULL,
  `Paginas` varchar(50)  NOT NULL,
  `Precio` varchar(50)  NOT NULL,
  `Formatouno` varchar(50)  NOT NULL,
  `Formatodos` varchar(50)  NOT NULL,
  `Formatotres` varchar(50)  NOT NULL,
  `Estado` varchar(50)  NOT NULL,
  `Borrado` varchar(1)  NOT NULL,

  CONSTRAINT PK_idLibro PRIMARY KEY(idLibro)


) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;

--
-- Volcado de datos para la tabla `tlibro`
--

INSERT INTO `tlibro` (`idLibro`, `Autor`, `Titulo`, `Tema`, `Paginas`, `Precio`, `Formatouno`, `Formatodos`, `Formatotres`, `Estado`, `Borrado`) VALUES
('1', 'Ceballos', 'Java a Fondo', 'Informática', '203', '35,5', 'N/A', 'Rústica', 'N/A', 'novedad', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tlineafactura`
--

CREATE TABLE `tlineafactura` (
  `idFactura` SMALLINT AUTO_INCREMENT NOT NULL,
  `Libro` varchar(50)  NOT NULL,
  `Cantidad` varchar(50)  NOT NULL,
  `Total` varchar(50)  NOT NULL,

  CONSTRAINT PK_idFactura_Libro PRIMARY KEY(idFactura, Libro)


) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;

--
-- Volcado de datos para la tabla `tlineafactura`
--

INSERT INTO `tlineafactura` (`idFactura`, `Libro`, `Cantidad`, `Total`) VALUES
('1', 'Java a Fondo', '4', '142,0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ttema`
--

CREATE TABLE `ttema` (
  `tema` varchar(30)  NOT NULL,
  `Borrado` tinyint(1) NOT NULL DEFAULT '0',

  CONSTRAINT PK_Tema PRIMARY KEY(tema),
  CONSTRAINT UQ_Tema UNIQUE(tema)


) ENGINE=InnoDB DEFAULT CHARSET=utf8 ;

--
-- Volcado de datos para la tabla `ttema`
--

INSERT INTO `ttema` (`tema`, `Borrado`) VALUES
('Acción', 0),
('Aventuras', 0),
('Biografía', 0),
('Ciencia', 0),
('Ciencia Ficción', 0),
('Cine', 0),
('Economía', 0),
('Gastronomía', 0),
('Historia', 0),
('Informática', 0),
('Medicina', 0),
('Misterio', 0),
('Naturaleza', 0),
('Policíaco', 0),
('Política', 0),
('Romántica', 0),
('Teatro', 0),
('Terror', 0);

--
-- Índices para tablas volcadas
--

-- Indices de la tabla `tfactura`
--


--
-- Indices de la tabla `tlibro`
--

--
-- Indices de la tabla `tlineafactura`
--

--
-- Indices de la tabla `ttema`
--


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
