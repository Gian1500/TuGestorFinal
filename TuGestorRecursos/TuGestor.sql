/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 8.0.21 : Database - tugestor
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`tugestor` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `tugestor`;

/*Table structure for table `clientes` */

DROP TABLE IF EXISTS `clientes`;

CREATE TABLE `clientes` (
  `Nombre y Apellido` varchar(50) DEFAULT NULL,
  `Dni` varchar(12) NOT NULL,
  `Direccion` varchar(100) DEFAULT NULL,
  `Departamento` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `clientes` */

insert  into `clientes`(`Nombre y Apellido`,`Dni`,`Direccion`,`Departamento`,`Telefono`) values ('Patri','20220598','Uspallata','Las Heras','126859');

/*Table structure for table `envios` */

DROP TABLE IF EXISTS `envios`;

CREATE TABLE `envios` (
  `Total` double DEFAULT NULL,
  `Fecha de Entrega` varchar(200) DEFAULT NULL,
  `Envio` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Departamento` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `envios` */

insert  into `envios`(`Total`,`Fecha de Entrega`,`Envio`,`Departamento`) values (10,'11/11/2020 22:20:44','Envio a domicilio',''),(10,'12/11/2020 22:23:36','Retiro en local','Capital'),(10,'12/11/2020 22:29:22','Envio a domicilio','San Rafael'),(10,'12/11/2020 23:30:17','Retiro en local','Capital'),(10,'12/11/2020 23:33:18','Envio a domicilio','Capital'),(10,'19/11/2020 16:50:20','Envio a domicilio','Las Heras'),(10,'13/11/2020 16:51:41','Retiro en local','');

/*Table structure for table `inventario` */

DROP TABLE IF EXISTS `inventario`;

CREATE TABLE `inventario` (
  `Codigo` bigint NOT NULL DEFAULT '0',
  `Nombre` varchar(250) DEFAULT NULL,
  `Stock` int DEFAULT '0',
  `Precio Costo` double DEFAULT '0',
  `Precio Venta` double DEFAULT '0',
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `inventario` */

insert  into `inventario`(`Codigo`,`Nombre`,`Stock`,`Precio Costo`,`Precio Venta`) values (351,'Papa',7,10000,10),(456,'Tomate',0,20,20);

/*Table structure for table `usuarios` */

DROP TABLE IF EXISTS `usuarios`;

CREATE TABLE `usuarios` (
  `Usuario` varchar(25) DEFAULT NULL,
  `Contraseña` varchar(25) NOT NULL,
  PRIMARY KEY (`Contraseña`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `usuarios` */

insert  into `usuarios`(`Usuario`,`Contraseña`) values ('','');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
