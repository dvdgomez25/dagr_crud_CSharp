-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-11-2016 a las 08:44:14
-- Versión del servidor: 10.1.13-MariaDB
-- Versión de PHP: 5.6.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `deportes`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `equipo`
--

CREATE TABLE `equipo` (
  `id` int(3) NOT NULL,
  `codigo` varchar(8) NOT NULL,
  `nombre` varchar(15) NOT NULL,
  `deporte` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `equipo`
--

INSERT INTO `equipo` (`id`, `codigo`, `nombre`, `deporte`) VALUES
(1, 'rcm', 'Real Campello', 'baloncesto'),
(2, 'can', 'Canoa', 'natacion'),
(3, 'ssj', 'Sporting de San', 'futbol');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `jugador`
--

CREATE TABLE `jugador` (
  `id` int(3) DEFAULT NULL,
  `codigo` varchar(12) NOT NULL,
  `nombre` varchar(15) NOT NULL,
  `apellido1` varchar(15) NOT NULL,
  `apellido2` varchar(15) NOT NULL,
  `demarcacion` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `jugador`
--

INSERT INTO `jugador` (`id`, `codigo`, `nombre`, `apellido1`, `apellido2`, `demarcacion`) VALUES
(3, 'RLL', 'Raúl', 'López', 'López', 'Delantero'),
(2, 'JLO', 'Jordi', 'López', 'Osorio', 'nadador crawl'),
(1, 'CVM', 'Carlos', 'Vargas', 'Morales', 'Poste'),
(2, 'CRM', 'Camila', 'Rosero', 'Mora', 'E Libre'),
(3, 'FOM', 'Faryd', 'Ospina', 'Mondragon', 'Portero'),
(2, 'JRG', 'Josefina', 'Rosero', 'Gonzales', 'E Mariposa'),
(3, 'ADB', 'Alfonso', 'Duque', 'Borja', 'Defensa'),
(1, 'JTC', 'Juan', 'Torres', 'Cortes', 'Alero');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `equipo`
--
ALTER TABLE `equipo`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `jugador`
--
ALTER TABLE `jugador`
  ADD KEY `id` (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `equipo`
--
ALTER TABLE `equipo`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `jugador`
--
ALTER TABLE `jugador`
  ADD CONSTRAINT `jugador_ibfk_1` FOREIGN KEY (`id`) REFERENCES `equipo` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
