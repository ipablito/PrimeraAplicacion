/*
SQLyog Enterprise v10.42 
MySQL - 5.5.15 : Database - mastertech_db1
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`mastertech_db1` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `mastertech_db1`;

/*Table structure for table `bodega` */

DROP TABLE IF EXISTS `bodega`;

CREATE TABLE `bodega` (
  `id_bodega` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_bodega` varchar(255) DEFAULT NULL,
  `direccion_bodega` varchar(255) DEFAULT NULL,
  `telefono_bodega` varchar(15) DEFAULT NULL,
  `telefono2_bodega` varchar(15) DEFAULT NULL,
  `estado_bodega` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_bodega`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `bodega` */

insert  into `bodega`(`id_bodega`,`descripcion_bodega`,`direccion_bodega`,`telefono_bodega`,`telefono2_bodega`,`estado_bodega`) values (1,'bodega1','ciudad1','1','1',1),(2,'fads','adfs','2','2',1),(3,'3','3','3','3',0),(4,'bodega3','bodega3','bodega3','bodega3',0),(5,'bodegaprueba','bodegaprueba','','',1);

/*Table structure for table `cliente` */

DROP TABLE IF EXISTS `cliente`;

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_cliente` varchar(255) DEFAULT NULL,
  `nit_cliente` varchar(15) DEFAULT NULL,
  `direccion_cliente` varchar(255) DEFAULT NULL,
  `telefono_cliente` varchar(15) DEFAULT NULL,
  `correo_cliente` varchar(150) DEFAULT NULL,
  `fecha_nacimiento_cliente` datetime DEFAULT NULL,
  `estado_cliente` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=205 DEFAULT CHARSET=utf8;

/*Data for the table `cliente` */

insert  into `cliente`(`id_cliente`,`nombre_cliente`,`nit_cliente`,`direccion_cliente`,`telefono_cliente`,`correo_cliente`,`fecha_nacimiento_cliente`,`estado_cliente`) values (185,'Dsad ','11111111-1',' ',' ',' ','2014-05-05 09:14:03',1),(186,'Fads ','22222222-2',' ',' ',' ','2014-05-05 09:14:14',1),(187,'Fdassd ','33333333-3',' ',' ',' ','2014-05-05 09:14:24',1),(188,'Sin Cliente','c/f',NULL,NULL,NULL,NULL,0),(189,'Kevin Coyoy','88888888-8','sin direccion','','','2014-05-07 00:00:00',1),(190,'Mario','1212','1212','1212','1212','2014-05-22 00:00:00',1),(191,'c12','1212','1212','1212','1212','2014-05-07 23:50:06',1),(192,'c34','c/f','','','','2014-05-07 23:52:21',0),(194,'c3232','3232','','','','2014-05-07 23:57:28',1),(195,'qw','c/f','','','','2014-05-08 00:01:06',0),(196,'qwe','c/f','','','','2014-05-08 00:02:32',0),(197,'Julio Ramirez ','1301177-4','','','','2014-05-12 00:00:00',1),(198,'kevin','123','123','','','1993-02-23 12:42:07',1),(199,'ultcli','c/f','','','','2014-05-16 10:07:12',1),(201,'c/f1','c/f','','','','2014-05-16 10:28:59',1),(202,'clientesinnit','cf','','','','2014-05-16 11:23:41',1),(203,'cfcfcf','c/f','','','','2014-05-16 11:26:54',1),(204,'clientenuevo','123456789','','','','2014-05-16 11:46:37',1);

/*Table structure for table `contacto` */

DROP TABLE IF EXISTS `contacto`;

CREATE TABLE `contacto` (
  `id_contacto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_contacto` varchar(255) DEFAULT NULL,
  `telefono_contacto` varchar(15) DEFAULT NULL,
  `direccion_contacto` varchar(255) DEFAULT NULL,
  `id_proveedor` int(11) DEFAULT NULL,
  `estado_contacto` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_contacto`),
  KEY `Relationship14` (`id_proveedor`),
  CONSTRAINT `Relationship14` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedor` (`id_proveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `contacto` */

insert  into `contacto`(`id_contacto`,`nombre_contacto`,`telefono_contacto`,`direccion_contacto`,`id_proveedor`,`estado_contacto`) values (1,'kevin','2143-4531',' ',93,1),(2,'FDSAFADS','123 ',' 123',90,1),(3,'c1','','',93,0),(4,'contacto2','','contacto2',92,1);

/*Table structure for table `detalle` */

DROP TABLE IF EXISTS `detalle`;

CREATE TABLE `detalle` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `id_encabezado` int(11) DEFAULT NULL,
  `precio_por_unidad_detalle` double DEFAULT NULL,
  `cantidad_de_producto_detalle` int(11) DEFAULT NULL,
  `total_detalle` double DEFAULT NULL,
  `id_bodega` int(11) DEFAULT NULL,
  `id_producto` int(11) DEFAULT NULL,
  `precio_costo` double DEFAULT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `Relationship5` (`id_encabezado`),
  KEY `Relationship45` (`id_bodega`),
  KEY `Relationship46` (`id_producto`),
  CONSTRAINT `Relationship45` FOREIGN KEY (`id_bodega`) REFERENCES `bodega` (`id_bodega`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship46` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship5` FOREIGN KEY (`id_encabezado`) REFERENCES `encabezado` (`id_encabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8;

/*Data for the table `detalle` */

insert  into `detalle`(`id_detalle`,`id_encabezado`,`precio_por_unidad_detalle`,`cantidad_de_producto_detalle`,`total_detalle`,`id_bodega`,`id_producto`,`precio_costo`) values (2,1,10,12,120,1,1,8),(8,6,100,4,400,1,1,8),(9,7,100,2,200,1,1,8),(10,8,100,12,1200,1,1,8),(11,9,100,4,400,1,1,8),(12,10,100,3,300,1,1,8),(13,10,100,10,1000,1,1,8),(14,11,100,3,300,1,1,8),(15,12,100,1,100,1,1,8),(16,13,100,1,100,1,1,8),(17,14,100,1,100,1,1,8),(18,15,100,1,100,1,1,8),(19,21,15,3,45,1,1,8),(20,21,15,3,45,1,1,8),(21,24,15,6,90,1,1,15),(22,23,10,10,100,1,1,10),(23,23,10,10,100,1,1,10),(24,23,10,10,100,1,1,10),(25,23,10,10,100,1,1,10),(26,23,10,10,100,1,1,10),(27,23,10,10,100,1,1,10),(28,23,10,10,100,1,1,10),(29,23,10,10,100,1,1,10),(30,23,10,10,100,1,1,10),(31,23,10,10,100,1,1,10),(32,23,10,10,100,1,1,10),(33,23,10,10,100,1,1,10),(34,23,10,10,100,1,1,10),(35,23,10,10,100,1,1,10),(36,25,11,12,132,1,1,10),(37,26,11,2,22,1,1,11),(38,27,10,1,10,1,1,10),(39,28,100,8,800,1,1,100),(40,29,10,2,20,2,1,10),(41,29,15,3,45,2,2,15),(42,30,11,1,11,1,1,10),(43,30,11,2,22,1,1,10),(44,30,11,3,33,1,1,10),(45,30,11,4,44,1,1,10),(46,31,11,9,99,1,1,10),(47,32,11,3,33,1,1,10),(48,33,13,600,7800,2,2,13),(49,33,12,500,6000,2,1,12),(50,34,14,1,14,2,1,12),(51,34,15,1,15,2,2,13),(52,35,13.2,1,13.2,2,1,12),(53,35,14.3,2,28.6,2,2,13),(54,36,14,1,14,2,1,12),(55,36,14,1,14,2,2,13),(56,37,15,13,195,1,1,15),(57,37,16,10,160,1,2,16),(58,38,17,3,51,1,1,17),(59,38,18,3,54,1,2,18),(60,39,80,100,8000,2,4,80),(61,40,160,60,9600,2,4,80),(62,41,18.7,42,785.4,1,1,17),(63,42,75,1,75,2,4,75),(64,43,100,3,300,1,5,100),(65,44,115,4,460,1,5,115),(66,45,10,100,1000,1,6,10),(67,46,150,10,1500,1,4,75),(68,46,126.5,10,1265,1,5,115),(69,46,20,19,380,1,6,10),(70,47,20,8,160,1,6,10),(71,47,150,6,900,1,4,75),(72,47,126.5,3,379.5,1,5,115),(73,48,150,10,1500,1,4,75),(74,48,126.5,5,632.5,1,5,115),(75,48,20,2,40,1,6,10),(76,48,150,2,300,1,4,75),(77,51,8,8,64,1,14,8),(78,52,115,3,345,2,5,115),(79,52,11,11,221,2,1,11),(80,52,11,11,221,2,1,11),(81,52,11,11,221,2,1,11),(82,52,11,11,221,2,2,11),(83,53,4,1,4,5,15,4),(84,53,5,1,5,5,14,5),(85,54,7,1,7,1,10,7),(86,54,10,1,10,1,7,10),(87,56,5,5,25,1,8,5),(88,59,5,1,5,1,9,5),(89,59,5,20,100,1,15,5),(90,60,10,13,130,1,7,10),(91,61,15,1,15,1,7,15),(92,62,18,1,18,1,7,15),(93,62,200,1,200,1,5,115),(94,63,15.3,4,61.2,1,7,15),(95,63,10,5,50,1,15,5),(96,64,5,1,5,5,8,5),(97,64,6,1,6,5,14,6),(98,64,5,1,5,5,16,5),(99,65,5.5,1,5.5,5,16,5),(100,65,5.5,1,5.5,5,8,5);

/*Table structure for table `empresa` */

DROP TABLE IF EXISTS `empresa`;

CREATE TABLE `empresa` (
  `nombre_empresa` varchar(255) NOT NULL,
  `slogan_empresa` varchar(255) DEFAULT NULL,
  `nit_empresa` varchar(50) DEFAULT NULL,
  `telefono_empresa` varchar(15) DEFAULT NULL,
  `direccion_empresa` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `empresa` */

/*Table structure for table `encabezado` */

DROP TABLE IF EXISTS `encabezado`;

CREATE TABLE `encabezado` (
  `id_encabezado` int(11) NOT NULL AUTO_INCREMENT,
  `id_usuario` int(11) DEFAULT NULL,
  `id_serie_documento` int(11) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_proveedor` int(11) DEFAULT NULL,
  `fecha_encabezado_sistema` timestamp NULL DEFAULT NULL,
  `fecha_encabezado_usuario` datetime DEFAULT NULL,
  `total_encabezado` double DEFAULT NULL,
  `no_documento` int(11) DEFAULT NULL,
  `docomento_referencia_proveedor` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_encabezado`),
  KEY `Relationship2` (`id_serie_documento`),
  KEY `Relationship4` (`id_cliente`),
  KEY `Relationship12` (`id_proveedor`),
  KEY `Relationship32` (`id_usuario`),
  CONSTRAINT `Relationship11` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedor` (`id_proveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship12` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedor` (`id_proveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship2` FOREIGN KEY (`id_serie_documento`) REFERENCES `serie_documento` (`id_serie_documento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship3` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship32` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship4` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8;

/*Data for the table `encabezado` */

insert  into `encabezado`(`id_encabezado`,`id_usuario`,`id_serie_documento`,`id_cliente`,`id_proveedor`,`fecha_encabezado_sistema`,`fecha_encabezado_usuario`,`total_encabezado`,`no_documento`,`docomento_referencia_proveedor`) values (1,1,1,188,98,'2014-05-07 22:38:27','2012-12-12 00:00:00',100,1,'asd'),(2,1,1,188,98,'2014-05-07 22:39:08','2012-12-12 00:00:00',100,2,'asd1'),(3,1,2,188,98,'2014-05-07 22:39:22','2012-12-12 00:00:00',100,1,'asd1'),(4,1,1,188,98,'2014-05-07 22:57:06','2014-05-07 00:00:00',100,3,'sin ref'),(5,1,1,189,98,'2014-05-07 23:45:16','2014-05-07 23:44:33',392,4,'Kevin Coyoy'),(6,1,1,188,98,'2014-05-07 23:48:02','2014-05-07 23:47:42',400,5,'mario'),(7,1,1,188,98,'2014-05-07 23:50:37','2014-05-07 23:50:06',200,6,'c12'),(8,1,1,188,98,'2014-05-07 23:52:36','2014-05-07 23:52:21',1200,7,'c34'),(9,1,1,188,98,'2014-05-07 23:55:17','2014-05-13 23:54:57',400,8,''),(10,1,1,189,98,'2014-05-07 23:56:12','2014-05-07 23:55:45',1300,9,'Kevin Coyoy'),(11,1,1,188,98,'2014-05-07 23:57:43','2014-05-07 23:57:28',300,10,'c3232'),(12,1,1,189,98,'2014-05-07 23:58:56','2014-05-07 23:58:34',100,11,'Kevin Coyoy'),(13,1,1,188,98,'2014-05-08 00:01:17','2014-05-08 00:01:06',100,12,'qw'),(14,1,1,188,98,'2014-05-08 00:02:45','2014-05-08 00:02:32',100,13,'qwe'),(15,1,1,188,98,'2014-05-08 00:05:44','2014-05-08 00:05:29',100,14,'mario coyoy'),(16,1,2,188,99,'2014-05-08 11:23:00','2012-12-12 00:00:00',150,2,'sin ref'),(17,1,2,188,91,'2014-05-08 11:24:02','2014-05-08 11:23:23',30,3,'referencianull'),(18,1,2,188,90,'2014-05-08 11:56:21','2014-05-08 11:55:58',60,4,''),(19,1,2,188,90,'2014-05-08 11:59:49','2014-05-08 11:59:28',42,5,''),(20,1,2,188,90,'2014-05-08 12:03:38','2014-05-08 12:02:44',15,6,'12'),(21,1,1,185,98,'2014-05-08 12:07:09','2014-05-08 12:06:40',90,15,'Dsad '),(22,1,2,188,90,'2014-05-08 12:07:25','2014-05-08 12:07:11',90,7,''),(23,1,2,188,90,'2014-05-08 12:08:44','2014-05-08 12:08:33',90,8,''),(24,1,2,188,90,'2014-05-08 12:15:49','2014-05-08 12:15:34',90,9,''),(25,1,1,185,98,'2014-05-08 12:25:51','2014-05-08 12:25:35',132,16,'Dsad '),(26,1,2,188,90,'2014-05-08 12:26:02','2014-05-08 12:25:52',22,10,''),(27,1,2,188,90,'2014-05-08 12:27:05','2014-05-08 12:26:48',10,11,''),(28,1,2,188,90,'2014-05-08 12:27:38','2014-05-08 12:27:19',800,12,''),(29,1,2,188,90,'2014-05-08 15:59:40','2014-05-08 15:59:01',65,13,''),(30,1,1,189,98,'2014-05-08 16:45:12','2014-05-08 16:44:20',110,17,'Kevin Coyoy'),(31,1,1,189,98,'2014-05-08 16:48:51','2014-05-08 16:48:38',99,18,'Kevin Coyoy'),(32,1,1,189,98,'2014-05-08 16:52:31','2014-05-08 16:52:19',33,19,'Kevin Coyoy'),(33,1,2,188,90,'2014-05-08 16:55:18','2014-05-08 16:54:27',13800,14,''),(34,1,1,185,98,'2014-05-08 16:55:44','2014-05-08 16:55:20',29,20,'Dsad '),(35,1,1,188,98,'2014-05-08 16:57:20','2014-05-08 16:56:58',41.8,21,''),(36,1,1,188,98,'2014-05-08 17:00:13','2014-05-08 16:59:58',28,22,''),(37,1,2,188,91,'2014-05-08 17:09:24','2014-05-08 17:08:38',355,15,'sin ref'),(38,1,2,188,100,'2014-05-08 17:22:10','2014-05-08 17:21:30',105,16,'proveedor recien ingresado'),(39,1,2,188,90,'2014-05-09 12:37:16','2014-05-09 12:36:31',8000,17,'PK1'),(40,1,1,188,98,'2014-05-09 12:37:57','2014-05-09 12:37:32',9600,23,''),(41,1,1,185,98,'2014-05-09 13:39:47','2014-05-09 13:39:30',785.4,24,'Dsad '),(42,1,2,188,91,'2014-05-09 15:25:32','2014-05-09 15:24:32',75,18,''),(43,1,2,188,90,'2014-05-09 15:49:32','2014-05-09 15:49:13',300,19,''),(44,1,2,188,91,'2014-05-09 15:49:58','2014-05-09 15:49:37',460,20,''),(45,1,2,188,90,'2014-05-12 09:34:18','2014-05-12 09:32:37',1000,21,''),(46,1,1,188,98,'2014-05-12 09:37:58','2014-05-12 09:34:47',3145,25,''),(47,1,1,197,98,'2014-05-12 09:45:54','2014-05-12 09:44:25',1439.5,26,'Julio'),(48,1,1,197,98,'2014-05-12 09:59:52','2014-05-12 09:49:59',2472.5,27,'julio'),(49,1,2,188,93,'2014-05-15 12:02:11','2014-05-15 12:00:54',0,22,''),(50,1,9,188,103,'2014-05-15 12:21:41','2014-05-15 12:21:29',0,1,''),(51,1,2,188,104,'2014-05-15 12:48:08','2014-05-15 12:47:01',164,23,'kk'),(52,1,9,188,105,'2014-05-15 12:53:16','2014-05-15 12:51:29',352,2,'bb'),(53,1,2,188,106,'2014-05-15 13:02:20','2014-05-15 13:01:33',9,24,''),(54,1,9,188,104,'2014-05-15 13:24:52','2014-05-14 13:23:54',17,3,''),(55,1,2,188,93,'2014-05-16 09:39:52','2014-05-16 09:39:19',24,25,''),(56,1,2,188,90,'2014-05-16 09:42:10','2014-05-16 09:41:43',10,26,''),(57,1,9,188,95,'2014-05-16 09:45:39','2014-05-16 09:45:25',0,4,''),(58,1,2,188,92,'2014-05-16 09:49:03','2014-05-16 09:48:42',4,27,''),(59,1,2,188,92,'2014-05-16 09:54:13','2014-05-16 09:53:44',105,28,''),(60,1,2,188,92,'2014-05-16 10:56:35','2014-05-16 10:56:11',130,29,''),(61,1,2,188,93,'2014-05-16 10:57:50','2014-05-16 10:57:34',15,30,''),(62,1,1,202,98,'2014-05-16 11:24:34','2014-05-16 11:23:41',218,28,''),(63,1,1,204,98,'2014-05-16 11:54:15','2014-05-16 11:53:29',111.2,29,''),(64,1,2,188,93,'2014-05-16 15:52:26','2014-05-16 15:50:44',16,31,''),(65,1,1,189,98,'2014-05-16 15:54:42','2014-05-16 15:53:21',11,30,'');

/*Table structure for table `estado_documento` */

DROP TABLE IF EXISTS `estado_documento`;

CREATE TABLE `estado_documento` (
  `id_estado_documento` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_estado_documento` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_estado_documento`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `estado_documento` */

insert  into `estado_documento`(`id_estado_documento`,`descripcion_estado_documento`) values (1,'Activo'),(2,'Inactivo');

/*Table structure for table `historial_precio_compra` */

DROP TABLE IF EXISTS `historial_precio_compra`;

CREATE TABLE `historial_precio_compra` (
  `id_historial_precio_compra` int(11) NOT NULL AUTO_INCREMENT,
  `id_detalle` int(11) DEFAULT NULL,
  `antiguo_precio_compra` double DEFAULT NULL,
  `antigua_precio_venta` double DEFAULT NULL,
  PRIMARY KEY (`id_historial_precio_compra`),
  KEY `Relationship40` (`id_detalle`),
  CONSTRAINT `Relationship40` FOREIGN KEY (`id_detalle`) REFERENCES `detalle` (`id_detalle`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8;

/*Data for the table `historial_precio_compra` */

insert  into `historial_precio_compra`(`id_historial_precio_compra`,`id_detalle`,`antiguo_precio_compra`,`antigua_precio_venta`) values (20,35,8,15),(21,37,10,11),(22,38,11,12.1),(23,39,10,11),(24,40,100,110),(25,41,7,15),(26,48,15,16.5),(27,49,10,11),(28,56,12,13.2),(29,57,13,14.3),(30,58,15,16.5),(31,59,16,17.6),(33,63,80,160),(34,64,0,0),(35,65,100,110),(36,66,0,0),(37,77,0,0),(38,78,115,126.5),(39,79,17,18.7),(40,80,11,12.1),(41,81,11,12.1),(42,82,18,19.8),(43,83,0,8),(44,84,8,8.8),(45,85,0,0),(46,86,0,15),(47,87,0,0),(48,88,0,0),(49,89,4,8),(50,90,10,10.2),(51,91,10,10.2),(52,96,5,5.5),(53,97,5,5.5),(54,98,0,0);

/*Table structure for table `ingreso` */

DROP TABLE IF EXISTS `ingreso`;

CREATE TABLE `ingreso` (
  `id_ingreso` int(11) NOT NULL AUTO_INCREMENT,
  `id_usuario` int(11) DEFAULT NULL,
  `fechahora_ingreso` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id_ingreso`),
  KEY `Relationship26` (`id_usuario`),
  CONSTRAINT `Relationship26` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=279 DEFAULT CHARSET=utf8;

/*Data for the table `ingreso` */

insert  into `ingreso`(`id_ingreso`,`id_usuario`,`fechahora_ingreso`) values (1,4,'2014-05-09 08:52:41'),(2,5,'2014-05-09 08:52:49'),(3,4,'2014-05-09 08:54:56'),(4,4,'2014-05-09 08:57:54'),(5,4,'2014-05-09 09:00:36'),(6,4,'2014-05-09 09:09:23'),(7,4,'2014-05-09 09:17:18'),(8,4,'2014-05-09 09:20:19'),(9,4,'2014-05-09 09:22:00'),(10,4,'2014-05-09 09:24:16'),(11,4,'2014-05-09 09:27:30'),(12,4,'2014-05-09 09:28:24'),(13,4,'2014-05-09 09:31:02'),(14,4,'2014-05-09 09:32:55'),(15,4,'2014-05-09 09:37:33'),(16,4,'2014-05-09 09:39:47'),(17,4,'2014-05-09 09:42:37'),(18,4,'2014-05-09 09:43:55'),(19,4,'2014-05-09 09:44:42'),(20,4,'2014-05-09 09:45:45'),(21,4,'2014-05-09 09:48:10'),(22,4,'2014-05-09 09:48:59'),(23,4,'2014-05-09 09:49:18'),(24,4,'2014-05-09 09:50:15'),(25,4,'2014-05-09 09:51:46'),(26,4,'2014-05-09 09:53:11'),(27,4,'2014-05-09 09:54:00'),(28,4,'2014-05-09 09:54:36'),(29,4,'2014-05-09 09:58:13'),(30,4,'2014-05-09 10:02:04'),(31,4,'2014-05-09 10:02:57'),(32,4,'2014-05-09 10:03:17'),(33,4,'2014-05-09 10:06:49'),(34,4,'2014-05-09 10:12:52'),(35,4,'2014-05-09 10:14:19'),(36,4,'2014-05-09 10:15:12'),(37,5,'2014-05-09 10:38:31'),(38,4,'2014-05-09 10:46:58'),(39,4,'2014-05-09 10:47:51'),(40,4,'2014-05-09 10:49:04'),(41,4,'2014-05-09 10:49:31'),(42,4,'2014-05-09 10:52:45'),(43,4,'2014-05-09 10:53:04'),(44,4,'2014-05-09 10:53:31'),(45,4,'2014-05-09 10:54:07'),(46,4,'2014-05-09 10:56:56'),(47,4,'2014-05-09 11:00:21'),(48,4,'2014-05-09 11:22:44'),(49,4,'2014-05-09 11:26:33'),(50,4,'2014-05-09 11:27:15'),(51,4,'2014-05-09 11:27:45'),(52,4,'2014-05-09 11:28:53'),(53,4,'2014-05-09 11:32:53'),(54,4,'2014-05-09 11:40:18'),(55,4,'2014-05-09 11:44:24'),(56,4,'2014-05-09 11:44:50'),(57,4,'2014-05-09 11:59:09'),(58,4,'2014-05-09 12:01:13'),(59,4,'2014-05-09 12:02:59'),(60,4,'2014-05-09 12:16:28'),(61,4,'2014-05-09 12:17:15'),(62,4,'2014-05-09 12:17:58'),(63,4,'2014-05-09 12:21:13'),(64,5,'2014-05-09 12:21:30'),(65,4,'2014-05-09 12:24:06'),(66,6,'2014-05-09 12:24:54'),(67,4,'2014-05-09 12:25:07'),(68,6,'2014-05-09 12:25:39'),(69,4,'2014-05-09 12:29:36'),(70,1,'2014-05-09 12:30:14'),(71,4,'2014-05-09 12:30:31'),(72,4,'2014-05-09 12:35:46'),(73,4,'2014-05-09 12:41:18'),(74,4,'2014-05-09 13:00:03'),(75,4,'2014-05-09 13:01:31'),(76,4,'2014-05-09 13:03:05'),(77,4,'2014-05-09 13:06:50'),(78,4,'2014-05-09 13:07:05'),(79,4,'2014-05-09 13:07:18'),(80,4,'2014-05-09 13:08:46'),(81,4,'2014-05-09 13:08:54'),(82,4,'2014-05-09 13:25:06'),(83,4,'2014-05-09 13:34:32'),(84,4,'2014-05-09 13:37:34'),(85,4,'2014-05-09 13:38:58'),(86,4,'2014-05-09 13:47:20'),(87,4,'2014-05-09 13:47:47'),(88,5,'2014-05-09 13:48:18'),(89,4,'2014-05-09 13:48:27'),(90,1,'2014-05-09 13:48:45'),(91,4,'2014-05-09 13:49:41'),(92,5,'2014-05-09 13:49:54'),(93,1,'2014-05-09 13:50:19'),(94,1,'2014-05-09 13:50:32'),(95,4,'2014-05-09 13:50:40'),(96,5,'2014-05-09 13:50:54'),(97,4,'2014-05-09 13:53:08'),(98,4,'2014-05-09 13:58:19'),(99,4,'2014-05-09 13:58:59'),(100,5,'2014-05-09 14:00:02'),(101,4,'2014-05-09 14:15:21'),(102,4,'2014-05-09 14:18:22'),(103,4,'2014-05-09 14:19:21'),(104,4,'2014-05-09 14:33:28'),(105,4,'2014-05-09 14:34:28'),(106,4,'2014-05-09 14:36:09'),(107,4,'2014-05-09 15:24:30'),(108,4,'2014-05-09 15:28:12'),(109,4,'2014-05-09 15:28:54'),(110,4,'2014-05-09 15:42:05'),(111,4,'2014-05-09 15:42:55'),(112,4,'2014-05-09 15:45:31'),(113,4,'2014-05-09 15:46:41'),(114,4,'2014-05-09 15:48:49'),(115,4,'2014-05-09 15:54:55'),(116,4,'2014-05-09 16:00:26'),(117,4,'2014-05-11 19:31:50'),(118,4,'2014-05-11 19:49:58'),(119,4,'2014-05-11 19:55:52'),(120,4,'2014-05-11 19:57:53'),(121,4,'2014-05-11 19:58:40'),(122,4,'2014-05-11 19:59:53'),(123,4,'2014-05-11 20:00:37'),(124,4,'2014-05-11 20:01:05'),(125,4,'2014-05-11 20:03:37'),(126,4,'2014-05-11 20:04:36'),(127,4,'2014-05-11 20:05:18'),(128,4,'2014-05-11 20:05:55'),(129,4,'2014-05-11 20:09:52'),(130,4,'2014-05-11 20:10:39'),(131,4,'2014-05-11 20:12:16'),(132,4,'2014-05-11 20:22:51'),(133,4,'2014-05-11 20:26:30'),(134,4,'2014-05-11 20:27:37'),(135,4,'2014-05-11 20:28:16'),(136,4,'2014-05-11 20:28:48'),(137,4,'2014-05-11 20:29:38'),(138,4,'2014-05-11 22:34:53'),(139,4,'2014-05-11 22:36:00'),(140,4,'2014-05-11 22:50:38'),(141,4,'2014-05-11 22:53:40'),(142,4,'2014-05-11 22:55:10'),(143,4,'2014-05-11 22:55:58'),(144,4,'2014-05-11 22:59:00'),(145,4,'2014-05-11 23:01:22'),(146,4,'2014-05-11 23:04:16'),(147,4,'2014-05-11 23:09:12'),(148,4,'2014-05-11 23:10:05'),(149,4,'2014-05-11 23:13:54'),(150,4,'2014-05-11 23:14:34'),(151,4,'2014-05-11 23:19:03'),(152,4,'2014-05-11 23:24:30'),(153,4,'2014-05-11 23:29:58'),(154,4,'2014-05-11 23:35:56'),(155,4,'2014-05-11 23:41:33'),(156,4,'2014-05-11 23:43:26'),(157,4,'2014-05-11 23:52:12'),(158,4,'2014-05-11 23:58:57'),(159,4,'2014-05-12 00:00:00'),(160,4,'2014-05-12 00:01:58'),(161,4,'2014-05-12 00:04:11'),(162,4,'2014-05-12 00:08:30'),(163,4,'2014-05-12 00:14:33'),(164,4,'2014-05-12 00:16:07'),(165,4,'2014-05-12 00:25:41'),(166,4,'2014-05-12 00:26:33'),(167,4,'2014-05-12 00:28:04'),(168,4,'2014-05-12 00:30:36'),(169,4,'2014-05-12 00:32:10'),(170,4,'2014-05-12 00:33:20'),(171,4,'2014-05-12 00:34:09'),(172,4,'2014-05-12 00:35:11'),(173,4,'2014-05-12 00:37:06'),(174,4,'2014-05-12 00:40:11'),(175,4,'2014-05-12 00:40:53'),(176,4,'2014-05-12 00:41:50'),(177,4,'2014-05-12 00:42:19'),(178,4,'2014-05-12 00:47:19'),(179,4,'2014-05-12 00:48:59'),(180,4,'2014-05-12 00:50:11'),(181,4,'2014-05-12 00:51:10'),(182,4,'2014-05-12 00:52:42'),(183,4,'2014-05-12 00:53:38'),(184,4,'2014-05-12 08:39:38'),(185,4,'2014-05-12 08:51:21'),(186,4,'2014-05-12 09:23:48'),(187,4,'2014-05-12 09:24:41'),(188,4,'2014-05-12 09:25:45'),(189,4,'2014-05-12 09:26:38'),(190,4,'2014-05-12 09:28:25'),(191,7,'2014-05-12 09:41:03'),(192,4,'2014-05-12 09:41:28'),(193,7,'2014-05-12 09:43:49'),(194,4,'2014-05-12 09:44:22'),(195,4,'2014-05-12 10:10:17'),(196,4,'2014-05-14 11:39:00'),(197,9,'2014-05-14 11:39:42'),(198,4,'2014-05-14 11:41:08'),(199,9,'2014-05-14 11:41:31'),(200,9,'2014-05-14 11:41:43'),(201,4,'2014-05-14 11:42:01'),(202,9,'2014-05-14 11:43:14'),(203,4,'2014-05-14 11:43:31'),(204,4,'2014-05-14 11:44:38'),(205,4,'2014-05-14 11:45:25'),(206,4,'2014-05-14 11:46:01'),(207,4,'2014-05-14 11:48:49'),(208,4,'2014-05-14 11:49:50'),(209,4,'2014-05-14 11:50:33'),(210,4,'2014-05-14 11:52:53'),(211,4,'2014-05-14 11:53:46'),(212,4,'2014-05-14 11:54:18'),(213,4,'2014-05-14 11:55:20'),(214,4,'2014-05-14 11:57:00'),(215,4,'2014-05-14 11:57:54'),(216,4,'2014-05-14 11:59:18'),(217,4,'2014-05-14 12:00:27'),(218,4,'2014-05-14 12:01:40'),(219,4,'2014-05-14 12:03:48'),(220,4,'2014-05-14 12:06:53'),(221,4,'2014-05-14 12:10:45'),(222,4,'2014-05-14 12:28:22'),(223,4,'2014-05-14 12:30:16'),(224,4,'2014-05-14 12:31:26'),(225,4,'2014-05-14 12:32:18'),(226,4,'2014-05-14 12:50:01'),(227,4,'2014-05-14 12:50:41'),(228,4,'2014-05-14 12:52:04'),(229,4,'2014-05-14 12:52:43'),(230,4,'2014-05-14 12:53:21'),(231,4,'2014-05-14 12:53:45'),(232,4,'2014-05-14 12:54:27'),(233,4,'2014-05-14 12:54:57'),(234,4,'2014-05-14 12:55:34'),(235,4,'2014-05-14 12:57:55'),(236,4,'2014-05-14 12:59:12'),(237,4,'2014-05-14 13:00:31'),(238,4,'2014-05-14 13:06:43'),(239,4,'2014-05-14 13:07:46'),(240,4,'2014-05-14 13:09:25'),(241,4,'2014-05-14 13:10:51'),(242,4,'2014-05-14 13:11:27'),(243,4,'2014-05-14 13:14:14'),(244,4,'2014-05-14 13:17:52'),(245,4,'2014-05-14 13:37:35'),(246,4,'2014-05-14 13:40:02'),(247,4,'2014-05-14 13:45:29'),(248,4,'2014-05-14 13:46:49'),(249,4,'2014-05-14 13:48:09'),(250,4,'2014-05-14 13:59:29'),(251,4,'2014-05-14 14:01:00'),(252,4,'2014-05-14 14:01:58'),(253,4,'2014-05-14 14:35:26'),(254,4,'2014-05-14 14:36:13'),(255,4,'2014-05-14 14:38:10'),(256,4,'2014-05-14 14:39:52'),(257,4,'2014-05-14 14:46:44'),(258,4,'2014-05-14 14:54:39'),(259,4,'2014-05-14 14:55:05'),(260,4,'2014-05-14 14:59:52'),(261,4,'2014-05-14 15:01:10'),(262,4,'2014-05-14 15:02:09'),(263,4,'2014-05-14 15:29:19'),(264,4,'2014-05-14 15:37:22'),(265,4,'2014-05-14 15:40:18'),(266,4,'2014-05-14 15:41:30'),(267,4,'2014-05-14 16:21:14'),(268,4,'2014-05-14 16:22:25'),(269,4,'2014-05-15 13:49:31'),(270,4,'2014-05-15 13:49:56'),(271,5,'2014-05-15 13:50:17'),(272,4,'2014-05-16 14:12:53'),(273,9,'2014-05-16 14:14:00'),(274,4,'2014-05-16 15:49:28'),(275,4,'2014-05-16 15:50:29'),(276,9,'2014-05-16 16:03:02'),(277,9,'2014-05-16 16:03:11'),(278,4,'2014-05-18 21:00:23');

/*Table structure for table `marca` */

DROP TABLE IF EXISTS `marca`;

CREATE TABLE `marca` (
  `id_marca` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_marca` varchar(100) DEFAULT NULL,
  `estado_marca` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `marca` */

insert  into `marca`(`id_marca`,`nombre_marca`,`estado_marca`) values (1,'Marca predeterminada',1),(2,'marca2',0),(3,'marca_3',1),(4,'marca_2',1);

/*Table structure for table `permiso` */

DROP TABLE IF EXISTS `permiso`;

CREATE TABLE `permiso` (
  `id_permiso` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_permiso` varchar(150) DEFAULT NULL,
  `descripcion_permiso_para_programador` varchar(150) DEFAULT NULL,
  `fecha_creacion_permiso` datetime DEFAULT NULL,
  `estado_permiso` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_permiso`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

/*Data for the table `permiso` */

insert  into `permiso`(`id_permiso`,`descripcion_permiso`,`descripcion_permiso_para_programador`,`fecha_creacion_permiso`,`estado_permiso`) values (1,'Sala de ventas','p_salaprincipal_ventas',NULL,1),(2,'Sala de compras','p_salaprincipal_compras',NULL,1),(3,'Reportes de la sala principal','p_salaprincipal_reportes',NULL,1),(4,'Mantenimiento de clientes','p_cliente_mantenimiento',NULL,1),(5,'Reportes de clientes','p_cliente_reportes',NULL,1),(6,'Mantenimiento de producto','p_producto_mantenimiento',NULL,1),(7,'Mantenimiento de marcas','p_producto_marca',NULL,1),(8,'Reportes de producto','p_producto_reportes',NULL,1),(9,'Mantenimiento de proveedores','p_proveedor_mantenimiento',NULL,1),(10,'Mantenimiento de contactos','p_proveedor_contacto',NULL,1),(11,'Reportes de proveedores','p_proveedor_reportes',NULL,1),(12,'Mantenimiento de bodegas','p_bodega_mantenimiento',NULL,1),(13,'Reportes de bodegas','p_bodega_reportes',NULL,1),(14,'Mantenimiento de series de documentos','p_documento_serie',NULL,1),(15,'Reportes de documentos','p_documento_reportes',NULL,1),(16,'Mantenimiento de usuarios','p_usuarios_mantenimiento',NULL,1);

/*Table structure for table `producto` */

DROP TABLE IF EXISTS `producto`;

CREATE TABLE `producto` (
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_producto` varchar(255) DEFAULT NULL,
  `codigo_producto` varchar(100) DEFAULT NULL,
  `porcentaje_producto` double DEFAULT NULL,
  `ultimo_precio_compra_producto` double DEFAULT NULL,
  `ultimo_precio_venta_producto` double DEFAULT NULL,
  `id_marca` int(11) DEFAULT NULL,
  `estado_producto` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `Relationship13` (`id_marca`),
  CONSTRAINT `Relationship13` FOREIGN KEY (`id_marca`) REFERENCES `marca` (`id_marca`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

/*Data for the table `producto` */

insert  into `producto`(`id_producto`,`descripcion_producto`,`codigo_producto`,`porcentaje_producto`,`ultimo_precio_compra_producto`,`ultimo_precio_venta_producto`,`id_marca`,`estado_producto`) values (1,'producto_1','p1',0.1,11,12.1,3,0),(2,'p_2','p2',0.1,11,12.1,4,1),(3,'p3','p3',0.1,10,11,1,0),(4,'PK1','PK1',1,75,150,3,1),(5,'pk2','pk2',0.1,115,126.5,1,1),(6,'pp12','pp1',1,10,20,3,1),(7,'producto1','producto1',0.02,15,15.3,1,1),(8,'pk7','pk7',0.1,5,5.5,1,1),(9,'producto8','producto8',0.1,5,5.5,1,1),(10,'prod9','prod9',0.1,7,7.7,1,1),(11,'prod91','prod91',0.1,0,0,1,1),(12,'por10','por10',0.1,0,0,1,1),(13,'dsa','sad',0.1,0,0,1,1),(14,'kk','kk',0.1,6,6.6,1,1),(15,'productoprueba','productoprueba',1,5,10,1,1),(16,'pppppppp','pppppppp',0.1,5,6,1,1);

/*Table structure for table `producto_bodega` */

DROP TABLE IF EXISTS `producto_bodega`;

CREATE TABLE `producto_bodega` (
  `id_producto_bodega` int(11) NOT NULL AUTO_INCREMENT,
  `existencia_minima_producto_bodega` int(11) DEFAULT NULL,
  `existencia_producto_bodega` int(11) DEFAULT NULL,
  `id_bodega` int(11) DEFAULT NULL,
  `id_producto` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_producto_bodega`),
  KEY `Relationship47` (`id_bodega`),
  KEY `Relationship48` (`id_producto`),
  CONSTRAINT `Relationship47` FOREIGN KEY (`id_bodega`) REFERENCES `bodega` (`id_bodega`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship48` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8;

/*Data for the table `producto_bodega` */

insert  into `producto_bodega`(`id_producto_bodega`,`existencia_minima_producto_bodega`,`existencia_producto_bodega`,`id_bodega`,`id_producto`) values (3,10,1,1,1),(10,0,13,1,2),(11,0,0,3,2),(14,0,41,2,4),(15,0,10,1,5),(16,0,28,1,4),(17,0,71,1,6),(18,0,11,2,1),(19,0,610,2,2),(20,0,1,5,15),(22,0,1,1,10),(24,0,5,1,8),(25,0,1,1,9),(26,0,15,1,15),(28,0,10,1,7),(29,0,0,5,8),(30,0,2,5,14),(31,0,0,5,16);

/*Table structure for table `proveedor` */

DROP TABLE IF EXISTS `proveedor`;

CREATE TABLE `proveedor` (
  `id_proveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nit_proveedor` varchar(15) DEFAULT NULL,
  `descripcion_proveedor` varchar(100) DEFAULT NULL,
  `telefono_proveedor` varchar(15) DEFAULT NULL,
  `telefono2_proveedor` varchar(15) DEFAULT NULL,
  `direccion_proveedor` varchar(255) DEFAULT NULL,
  `correo_proveedor` varchar(150) DEFAULT NULL,
  `estado_proveedor` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=107 DEFAULT CHARSET=utf8;

/*Data for the table `proveedor` */

insert  into `proveedor`(`id_proveedor`,`nit_proveedor`,`descripcion_proveedor`,`telefono_proveedor`,`telefono2_proveedor`,`direccion_proveedor`,`correo_proveedor`,`estado_proveedor`) values (90,'11111111-1','fadsfadsf ',' ',' ',' ',' ',1),(91,'22222222-2','2222222',' ',' ',' ',' ',1),(92,'33333333-3','fdsa22',' ',' ',' ',' ',1),(93,'44444444-4','proveedor1',' ',' ',' ',' ',1),(94,'55555555-5','dafads',' ',' ',' ',' ',1),(95,'99999999-9','fdafsdf','','','','',1),(96,'43242343-4','43223','','','','',1),(97,'66666666-6','666666','6666-6666','6666-6666','666666666666','666666666666',0),(98,'c/f','Sin Proveedor',NULL,NULL,NULL,NULL,0),(99,'77777777-7','proveedor7','77','77','77','77',1),(100,'12345678-9','nproveedor','','','','',1),(101,'111','111','111','','','',1),(102,'2','2','2','2','2','3',0),(103,'123','123','','','','',1),(104,'kk','kk','','','','',1),(105,'bb','bb','','','','',1),(106,'pp','Proveedorprueba','','','','',1);

/*Table structure for table `rol` */

DROP TABLE IF EXISTS `rol`;

CREATE TABLE `rol` (
  `id_rol` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_rol` varchar(25) DEFAULT NULL,
  `estado_rol` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_rol`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

/*Data for the table `rol` */

insert  into `rol`(`id_rol`,`nombre_rol`,`estado_rol`) values (8,'Administrador',1),(9,'Contador',1),(10,'Secretaria',1),(11,'pablito',0);

/*Table structure for table `rol_permiso` */

DROP TABLE IF EXISTS `rol_permiso`;

CREATE TABLE `rol_permiso` (
  `id_rol_permiso` int(11) NOT NULL AUTO_INCREMENT,
  `estado_rol_permiso` tinyint(1) DEFAULT NULL,
  `id_rol` int(11) DEFAULT NULL,
  `id_permiso` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_rol_permiso`),
  KEY `Relationship51` (`id_rol`),
  KEY `Relationship52` (`id_permiso`),
  CONSTRAINT `Relationship51` FOREIGN KEY (`id_rol`) REFERENCES `rol` (`id_rol`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship52` FOREIGN KEY (`id_permiso`) REFERENCES `permiso` (`id_permiso`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=140 DEFAULT CHARSET=utf8;

/*Data for the table `rol_permiso` */

insert  into `rol_permiso`(`id_rol_permiso`,`estado_rol_permiso`,`id_rol`,`id_permiso`) values (75,1,8,16),(76,1,8,15),(77,1,8,14),(78,1,8,13),(79,1,8,12),(80,1,8,11),(81,1,8,10),(82,1,8,9),(83,1,8,8),(84,1,8,7),(85,1,8,6),(86,1,8,5),(87,1,8,4),(88,1,8,3),(89,1,8,2),(90,1,8,1),(91,0,9,16),(92,0,9,15),(93,0,9,14),(94,0,9,13),(95,0,9,12),(96,0,9,11),(97,0,9,10),(98,0,9,9),(99,0,9,8),(100,0,9,7),(101,0,9,6),(102,0,9,5),(103,0,9,4),(104,1,9,3),(105,0,9,2),(106,0,9,1),(107,0,10,16),(108,0,10,15),(109,0,10,14),(110,0,10,13),(111,0,10,12),(112,0,10,11),(113,0,10,10),(114,0,10,9),(115,0,10,8),(116,0,10,7),(117,0,10,6),(118,0,10,5),(119,0,10,4),(120,0,10,3),(121,0,10,2),(122,0,10,1),(124,0,11,16),(125,0,11,15),(126,0,11,14),(127,0,11,13),(128,0,11,12),(129,0,11,11),(130,0,11,10),(131,0,11,9),(132,0,11,8),(133,0,11,7),(134,0,11,6),(135,0,11,5),(136,0,11,4),(137,0,11,3),(138,0,11,2),(139,1,11,1);

/*Table structure for table `serie_documento` */

DROP TABLE IF EXISTS `serie_documento`;

CREATE TABLE `serie_documento` (
  `id_serie_documento` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_serie_documento` varchar(50) DEFAULT NULL,
  `id_tipo_documento` int(11) DEFAULT NULL,
  `id_estado_documento` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_serie_documento`),
  KEY `Relationship42` (`id_estado_documento`),
  KEY `id_tipo_documento` (`id_tipo_documento`),
  CONSTRAINT `Relationship42` FOREIGN KEY (`id_estado_documento`) REFERENCES `estado_documento` (`id_estado_documento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `serie_documento_ibfk_1` FOREIGN KEY (`id_tipo_documento`) REFERENCES `tipo_documento` (`id_tipo_documento`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

/*Data for the table `serie_documento` */

insert  into `serie_documento`(`id_serie_documento`,`descripcion_serie_documento`,`id_tipo_documento`,`id_estado_documento`) values (1,'Serie A',1,1),(2,'Serie A',2,1),(8,'Serie B',1,1),(9,'Serie B',2,1),(10,'seriec123',1,2),(11,'se123',2,2);

/*Table structure for table `signo` */

DROP TABLE IF EXISTS `signo`;

CREATE TABLE `signo` (
  `id_signo` int(11) NOT NULL AUTO_INCREMENT,
  `signo` varchar(10) DEFAULT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_signo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `signo` */

insert  into `signo`(`id_signo`,`signo`,`descripcion`) values (1,'+','Agrega al inventario'),(2,'-','Elimina del inventario');

/*Table structure for table `tipo_documento` */

DROP TABLE IF EXISTS `tipo_documento`;

CREATE TABLE `tipo_documento` (
  `id_tipo_documento` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_tipo_documento` varchar(250) DEFAULT NULL,
  `signo_tipo_docuemtno` varchar(10) DEFAULT NULL,
  `estado_tipo_documento` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_documento`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `tipo_documento` */

insert  into `tipo_documento`(`id_tipo_documento`,`descripcion_tipo_documento`,`signo_tipo_docuemtno`,`estado_tipo_documento`) values (1,'Factura','-',1),(2,'Compra','+',1);

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_empleado` varchar(255) DEFAULT NULL,
  `telefono_empleado` varchar(15) DEFAULT NULL,
  `nombre_usuario` varchar(25) DEFAULT NULL,
  `pass_usuario` varchar(25) DEFAULT NULL,
  `fecha_creacion_usuario` datetime DEFAULT NULL,
  `estado_usuario` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

/*Data for the table `usuario` */

insert  into `usuario`(`id_usuario`,`nombre_empleado`,`telefono_empleado`,`nombre_usuario`,`pass_usuario`,`fecha_creacion_usuario`,`estado_usuario`) values (1,'f','f','f','f','2014-05-06 10:43:19',0),(2,'f1','f1','f1','f1','2014-05-06 10:43:31',1),(3,'e','','e','e','2014-05-06 10:43:38',0),(4,'kevin','','kcoyoy','kcoyoy','2014-05-06 10:50:29',1),(5,'juan',NULL,'jcoyoy','jcoyoy',NULL,1),(6,'kjpnombre','123','kjp','kjp','2014-05-09 12:24:22',1),(7,'Julio','','jramirez','jramirez','2014-05-12 09:40:08',1),(8,'Kevin','','Kevin','Kevin','2014-05-13 14:09:47',1),(9,'pablito','','pablito','pablito','2014-05-14 11:39:14',1);

/*Table structure for table `usuario_rol` */

DROP TABLE IF EXISTS `usuario_rol`;

CREATE TABLE `usuario_rol` (
  `id_usuario_rol` int(11) NOT NULL AUTO_INCREMENT,
  `estado_usurio_rol` tinyint(1) DEFAULT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `id_rol` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_usuario_rol`),
  KEY `Relationship49` (`id_usuario`),
  KEY `Relationship50` (`id_rol`),
  CONSTRAINT `Relationship49` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Relationship50` FOREIGN KEY (`id_rol`) REFERENCES `rol` (`id_rol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;

/*Data for the table `usuario_rol` */

insert  into `usuario_rol`(`id_usuario_rol`,`estado_usurio_rol`,`id_usuario`,`id_rol`) values (16,1,4,8),(21,1,7,9),(24,1,2,10),(25,1,2,9),(26,1,2,8),(31,1,5,9),(34,1,9,10);

/* Procedure structure for procedure `ActualizarCliente` */

/*!50003 DROP PROCEDURE IF EXISTS  `ActualizarCliente` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarCliente`(
n_id int,
n_no VARCHAR(255),
n_ni VARCHAR(15),
n_di VARCHAR(255),
n_te VARCHAR(15),
n_co VARCHAR(150),
n_fe DATETIME
)
BEGIN
	
update cliente set nombre_cliente=n_no,nit_cliente=n_ni,direccion_cliente=n_di,telefono_cliente=n_te,correo_cliente=n_co,fecha_nacimiento_cliente=n_fe
			where id_cliente=n_id;
END */$$
DELIMITER ;

/* Procedure structure for procedure `AsignarRolAUsuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `AsignarRolAUsuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `AsignarRolAUsuario`(
n_idus int,
n_idro int
)
BEGIN
insert into usuario_rol(estado_usurio_rol,id_usuario,id_rol)
values(1,n_idus,n_idro);
END */$$
DELIMITER ;

/* Procedure structure for procedure `CorteDeCaja` */

/*!50003 DROP PROCEDURE IF EXISTS  `CorteDeCaja` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `CorteDeCaja`(
)
BEGIN
SELECT        tipo_documento.descripcion_tipo_documento, serie_documento.descripcion_serie_documento, encabezado.total_encabezado, 
                         encabezado.no_documento
FROM            tipo_documento INNER JOIN
                         serie_documento ON tipo_documento.id_tipo_documento = serie_documento.id_tipo_documento INNER JOIN
                         encabezado ON serie_documento.id_serie_documento = encabezado.id_serie_documento
WHERE DATE(encabezado.fecha_encabezado_usuario)= DATE(CURRENT_TIMESTAMP());
END */$$
DELIMITER ;

/* Procedure structure for procedure `detallecompra` */

/*!50003 DROP PROCEDURE IF EXISTS  `detallecompra` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `detallecompra`(
n_iden INT(11),
n_preu DOUBLE,
n_cant INT(11),
n_totd DOUBLE,
n_idbo INT(11),
n_idpro int(11)
)
BEGIN
DECLARE ncan INT DEFAULT 0;
DECLARE a_pc DOUBLE DEFAULT 0;
DECLARE a_pv DOUBLE DEFAULT 0;
DECLARE por DOUBLE DEFAULT 0;
DECLARE node DOUBLE DEFAULT 0;
SELECT existencia_producto_bodega INTO ncan FROM producto_bodega WHERE id_bodega=n_idbo AND id_producto=n_idpro;
SELECT ultimo_precio_compra_producto INTO a_pc FROM producto WHERE id_producto=n_idpro;
SELECT ultimo_precio_venta_producto INTO a_pv FROM producto WHERE id_producto=n_idpro;
INSERT INTO detalle(id_encabezado,precio_por_unidad_detalle,cantidad_de_producto_detalle,total_detalle,id_bodega,id_producto,precio_costo)
VALUES(n_iden,n_preu,n_cant,n_totd,n_idbo,n_idpro,n_preu);
SELECT id_detalle INTO node FROM detalle ORDER BY id_detalle DESC LIMIT 1;
INSERT INTO historial_precio_compra(id_detalle,antiguo_precio_compra,antigua_precio_venta)
VALUES (node,a_pc,a_pv);
SELECT porcentaje_producto INTO por FROM producto WHERE id_producto=n_idpro;
SET por = por*n_preu;
SET por =por+n_preu;
UPDATE producto SET ultimo_precio_compra_producto=n_preu,ultimo_precio_venta_producto=por WHERE id_producto=n_idpro; 
SET ncan=ncan+n_cant;
delete from producto_bodega where id_bodega=n_idbo and id_producto=n_idpro;
insert into producto_bodega(existencia_minima_producto_bodega,existencia_producto_bodega,id_bodega,id_producto)
values(0,ncan,n_idbo,n_idpro);
END */$$
DELIMITER ;

/* Procedure structure for procedure `detallefactura` */

/*!50003 DROP PROCEDURE IF EXISTS  `detallefactura` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `detallefactura`(
n_iden INT(11),
n_preu DOUBLE,
n_cant INT(11),
n_totd DOUBLE,
n_idbo INT(11),
n_idpro int(11)
)
BEGIN
DECLARE preco DOUBLE DEFAULT 0;
DECLARE ncan INT DEFAULT 0;
SELECT ultimo_precio_compra_producto INTO preco FROM producto WHERE id_producto=n_idpro;
SELECT existencia_producto_bodega INTO ncan FROM producto_bodega WHERE id_bodega=n_idbo AND id_producto=n_idpro;
INSERT INTO detalle(id_encabezado,precio_por_unidad_detalle,cantidad_de_producto_detalle,total_detalle,id_bodega,id_producto,precio_costo)
VALUES(n_iden,n_preu,n_cant,n_totd,n_idbo,n_idpro,preco);
SET ncan=ncan-n_cant;
UPDATE producto_bodega SET existencia_producto_bodega=ncan WHERE id_bodega=n_idbo AND id_producto=n_idpro;
END */$$
DELIMITER ;

/* Procedure structure for procedure `EditarPermisoRol` */

/*!50003 DROP PROCEDURE IF EXISTS  `EditarPermisoRol` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarPermisoRol`(
idrol INT,
idper int,
val tinyint(1)
)
BEGIN
update rol_permiso set estado_rol_permiso=val WHERE id_rol=idrol AND id_permiso=idper;
END */$$
DELIMITER ;

/* Procedure structure for procedure `EliminarCliente` */

/*!50003 DROP PROCEDURE IF EXISTS  `EliminarCliente` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarCliente`(
n_id int
)
BEGIN
update cliente set estado_cliente=0 where id_cliente=n_id;
END */$$
DELIMITER ;

/* Procedure structure for procedure `EliminarRolesDeUsuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `EliminarRolesDeUsuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarRolesDeUsuario`(
n_idus INT
)
BEGIN
DELETE FROM usuario_rol WHERE id_usuario=n_idus;
END */$$
DELIMITER ;

/* Procedure structure for procedure `EncabezadoCompra` */

/*!50003 DROP PROCEDURE IF EXISTS  `EncabezadoCompra` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `EncabezadoCompra`(
n_idus INT (11),
n_idse INT (11),
n_idpro int(11),
n_fe DATETIME,
n_to DOUBLE,
n_ref VARCHAR(150),
OUT NoCompra INT
)
BEGIN
DECLARE idcli INT DEFAULT 0;
DECLARE nodoc INT DEFAULT 0;
SELECT id_cliente INTO idcli FROM cliente WHERE nombre_cliente="Sin Cliente";
SELECT no_documento INTO nodoc FROM encabezado WHERE id_serie_documento =n_idse ORDER BY id_encabezado DESC LIMIT 1;
SET nodoc=nodoc+1;
INSERT INTO encabezado(id_usuario,id_serie_documento,id_cliente,id_proveedor,fecha_encabezado_sistema,fecha_encabezado_usuario,total_encabezado,no_documento,docomento_referencia_proveedor)
VALUES(n_idus,n_idse,idcli,n_idpro,(SELECT CURRENT_TIMESTAMP()),n_fe,n_to,nodoc,n_ref);
SELECT id_encabezado INTO NoCompra FROM encabezado ORDER BY id_encabezado DESC LIMIT 1;
END */$$
DELIMITER ;

/* Procedure structure for procedure `EncabezadoFactura` */

/*!50003 DROP PROCEDURE IF EXISTS  `EncabezadoFactura` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `EncabezadoFactura`(
n_idus INT(11),
n_idse INT(11),
n_idcli int(11),
n_fe DATETIME,
n_to DOUBLE,
n_ref VARCHAR(150),
OUT NoFactura INT
)
BEGIN
DECLARE idpro INT DEFAULT 0;
DECLARE nodoc INT DEFAULT 0;
SELECT id_proveedor INTO idpro FROM proveedor WHERE descripcion_proveedor="Sin Proveedor";
SELECT no_documento INTO nodoc FROM encabezado WHERE id_serie_documento =n_idse ORDER BY id_encabezado DESC LIMIT 1;
SET nodoc=nodoc+1;
INSERT INTO encabezado(id_usuario,id_serie_documento,id_cliente,id_proveedor,fecha_encabezado_sistema,fecha_encabezado_usuario,total_encabezado,no_documento,docomento_referencia_proveedor)
VALUES(n_idus,n_idse,n_idcli,idpro,(SELECT CURRENT_TIMESTAMP()),n_fe,n_to,nodoc,n_ref);
SELECT id_encabezado INTO NoFactura FROM encabezado ORDER BY id_encabezado DESC LIMIT 1;
END */$$
DELIMITER ;

/* Procedure structure for procedure `HistorialIngreso` */

/*!50003 DROP PROCEDURE IF EXISTS  `HistorialIngreso` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `HistorialIngreso`(
n_nous varchar(25)
)
BEGIN
declare idus int default 0;
select id_usuario into idus from usuario WHERE nombre_usuario=n_nous;
insert into ingreso(id_usuario,fechahora_ingreso)
values(idus,(SELECT CURRENT_TIMESTAMP()));
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoBodega` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoBodega` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoBodega`(
n_de varchar(255),
n_di varchar(255),
n_te varchar(15),
n_te2 varchar(15),
out rsp int
)
BEGIN
	DECLARE cont INT DEFAULT 0;
	
			SELECT COUNT(*) INTO cont
			FROM bodega WHERE direccion_bodega=n_di;
	IF(cont =0) THEN
		insert into bodega(descripcion_bodega,direccion_bodega,telefono_bodega,telefono2_bodega,estado_bodega)
		values (n_de,n_di,n_te,n_te2,1);
		set rsp=1;
	else
		set rsp=0;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoCliente` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoCliente` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoCliente`(
n_no VARCHAR(255),
n_ni VARCHAR(15),
n_di VARCHAR(255),
n_te VARCHAR(15),
n_co VARCHAR(150),
n_fe DATETIME,
out rsp int
)
BEGIN
	declare vcounter int default 0;
	
	if(n_ni!="c/f") then
		SELECT COUNT(*) into vcounter
		FROM cliente WHERE nit_cliente=n_ni and estado_cliente=1;
	end if;
	
	IF(vcounter=0) then
			INSERT INTO cliente(nombre_cliente,nit_cliente,direccion_cliente,telefono_cliente,correo_cliente,fecha_nacimiento_cliente,estado_cliente)
			VALUES(n_no,n_ni,n_di,n_te,n_co,n_fe,1);
			set rsp =1;
	else
		set rsp=0;
	END IF;
	
	
	
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoCompra` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoCompra` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoCompra`(
n_idus int (11),
n_idse int (11),
n_nitpro varchar(15),
n_fe datetime,
n_to double,
n_ref varchar(150),
out nocom int
)
BEGIN
declare idcli int default 0;
declare idpro int default 0;
declare nodoc int default 0;
select id_cliente into idcli from cliente where nombre_cliente="Sin Cliente";
select id_proveedor into idpro from proveedor where nit_proveedor=n_nitpro;
SELECT no_documento INTO nodoc FROM encabezado WHERE id_serie_documento =n_idse ORDER BY id_encabezado DESC LIMIT 1;
SET nodoc=nodoc+1;
insert into encabezado(id_usuario,id_serie_documento,id_cliente,id_proveedor,fecha_encabezado_sistema,fecha_encabezado_usuario,total_encabezado,no_documento,docomento_referencia_proveedor)
values(n_idus,n_idse,idcli,idpro,(SELECT CURRENT_TIMESTAMP()),n_fe,n_to,nodoc,n_ref);
SELECT id_encabezado INTO nocom FROM encabezado ORDER BY id_encabezado DESC LIMIT 1;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoContacto` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoContacto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoContacto`(
n_no VARCHAR(255),
n_te VARCHAR(15),
n_di VARCHAR(255),
n_id_pr INT(11),
OUT rsp INT
)
BEGIN
INSERT INTO contacto (nombre_contacto,telefono_contacto,direccion_contacto,id_proveedor, estado_contacto)
VALUES(n_no,n_te,n_di,n_id_pr,1);
SET rsp=1;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoDetalleCompra` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoDetalleCompra` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoDetalleCompra`(
n_iden INT(11),
n_preu DOUBLE,
n_cant INT(11),
n_totd DOUBLE,
n_idbo INT(11),
n_codpro VARCHAR(100)
)
BEGIN
DECLARE idpro INT DEFAULT 0;
DECLARE ncan INT DEFAULT 0;
DECLARE a_pc DOUBLE DEFAULT 0;
DECLARE a_pv DOUBLE DEFAULT 0;
DECLARE por DOUBLE DEFAULT 0;
declare node double default 0;
SELECT id_producto INTO idpro FROM producto WHERE codigo_producto=n_codpro;
SELECT existencia_producto_bodega INTO ncan FROM producto_bodega WHERE id_bodega=n_idbo AND id_producto=idpro;
select ultimo_precio_compra_producto into a_pc from producto where id_producto=idpro;
select ultimo_precio_venta_producto into a_pv from producto where id_producto=idpro;
INSERT INTO detalle(id_encabezado,precio_por_unidad_detalle,cantidad_de_producto_detalle,total_detalle,id_bodega,id_producto,precio_costo)
VALUES(n_iden,n_preu,n_cant,n_totd,n_idbo,idpro,n_preu);
SELECT id_detalle INTO node FROM detalle ORDER BY id_detalle DESC LIMIT 1;
INSERT INTO historial_precio_compra(id_detalle,antiguo_precio_compra,antigua_precio_venta)
VALUES (node,a_pc,a_pv);
select porcentaje_producto into por from producto where id_producto=idpro;
set por = por*n_preu;
set por =por+n_preu;
update producto set ultimo_precio_compra_producto=n_preu,ultimo_precio_venta_producto=por WHERE id_producto=idpro; 
SET ncan=ncan+n_cant;
UPDATE producto_bodega SET existencia_producto_bodega=ncan WHERE id_bodega=n_idbo AND id_producto=idpro;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoDetalleFactura` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoDetalleFactura` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoDetalleFactura`(
n_iden INT(11),
n_preu DOUBLE,
n_cant INT(11),
n_totd DOUBLE,
n_idbo INT(11),
n_codpro VARCHAR(100)
)
BEGIN
DECLARE idpro INT DEFAULT 0;
DECLARE preco DOUBLE DEFAULT 0;
DECLARE ncan INT DEFAULT 0;
SELECT id_producto INTO idpro FROM producto WHERE codigo_producto=n_codpro;
SELECT ultimo_precio_compra_producto INTO preco FROM producto WHERE codigo_producto=n_codpro;
SELECT existencia_producto_bodega INTO ncan FROM producto_bodega WHERE id_bodega=n_idbo AND id_producto=idpro;
INSERT INTO detalle(id_encabezado,precio_por_unidad_detalle,cantidad_de_producto_detalle,total_detalle,id_bodega,id_producto,precio_costo)
VALUES(n_iden,n_preu,n_cant,n_totd,n_idbo,idpro,preco);
SET ncan=ncan-n_cant;
UPDATE producto_bodega SET existencia_producto_bodega=ncan where id_bodega=n_idbo AND id_producto=idpro;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoFactura` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoFactura` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoFactura`(
n_idus INT(11),
n_idse INT(11),
n_nicli VARCHAR(15),
n_fe DATETIME,
n_to DOUBLE,
n_ref VARCHAR(150),
OUT nofac INT
)
BEGIN
DECLARE idcli INT DEFAULT 0;
DECLARE idpro INT DEFAULT 0;
DECLARE nodoc INT DEFAULT 0;
	IF(n_nicli="c/f") THEN
		SELECT id_cliente INTO idcli FROM cliente WHERE nombre_cliente="Sin Cliente";
	ELSE
		SELECT id_cliente INTO idcli FROM cliente WHERE nit_cliente=n_nicli;
	END IF;
SELECT id_proveedor INTO idpro FROM proveedor WHERE descripcion_proveedor="Sin Proveedor";
SELECT no_documento INTO nodoc FROM encabezado WHERE id_serie_documento =n_idse ORDER BY id_encabezado DESC LIMIT 1;
SET nodoc=nodoc+1;
INSERT INTO encabezado(id_usuario,id_serie_documento,id_cliente,id_proveedor,fecha_encabezado_sistema,fecha_encabezado_usuario,total_encabezado,no_documento,docomento_referencia_proveedor)
VALUES(n_idus,n_idse,idcli,idpro,(SELECT CURRENT_TIMESTAMP()),n_fe,n_to,nodoc,n_ref);
SELECT id_encabezado INTo nofac FROM encabezado ORDER BY id_encabezado DESC LIMIT 1;
END */$$
DELIMITER ;

/* Procedure structure for procedure `ingresomarca` */

/*!50003 DROP PROCEDURE IF EXISTS  `ingresomarca` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `ingresomarca`(
n_no varchar(100),
out rsp int
)
BEGIN
	DECLARE cont INT DEFAULT 0;
	
	SELECT COUNT(*) INTO cont
			FROM marca WHERE nombre_marca=n_no;	
	
	IF(cont=0) THEN
		insert into marca (nombre_marca,estado_marca)
		values (n_no,1);
		set rsp =1;
	else
		set rsp=0;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoProducto` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoProducto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoProducto`(
n_de varchar(255),
n_co varchar(100),
n_pr double,
n_ima int(11),
out rsp int
)
BEGIN
	DECLARE cont INT DEFAULT 0;
	
	SELECT COUNT(*) INTO cont
			FROM producto WHERE codigo_producto=n_co;
	
	IF(cont=0) THEN
		INSERT INTO producto(descripcion_producto,codigo_producto,porcentaje_producto,ultimo_precio_compra_producto,ultimo_precio_venta_producto,id_marca,estado_producto)
		VALUES (n_de,n_co,n_pr,0,0,n_ima,1);
		set rsp=1;
	else
		set rsp=0;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoProductoEnBodega` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoProductoEnBodega` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoProductoEnBodega`(
n_ex INT,
n_idbod INT,
n_codpr varchar(100),
OUT rsp INT
)
BEGIN
DECLARE idpro INT DEFAULT 0;
DECLARE contadorproducto INT DEFAULT 0;
SELECT id_producto INTO idpro FROM producto WHERE codigo_producto =n_codpr;
SELECT COUNT(*) INTO contadorproducto FROM producto_bodega WHERE id_producto=idpro AND id_bodega=n_idbod;
IF(contadorproducto=0)THEN
	INSERT INTO producto_bodega (existencia_minima_producto_bodega,existencia_producto_bodega,id_bodega,id_producto)
	VALUES (0,n_ex,n_idbod,idpro);
	SET rsp=1;
ELSE
	SET rsp=0;
END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoProveedor` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoProveedor` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoProveedor`(
n_ni nvarchar(15),
n_de nvarchar(100),
n_te nvarchar(15),
n_te2 nvarchar(15),
n_di nvarchar(255),
n_co nvarchar(150),
out rsp int
)
BEGIN
	DECLARE vcounter INT DEFAULT 0;
	
	SELECT COUNT(*) INTO vcounter FROM proveedor  WHERE nit_proveedor=n_ni;
	IF(vcounter=0) THEN
		INSERT INTO proveedor(nit_proveedor,descripcion_proveedor,telefono_proveedor,telefono2_proveedor,direccion_proveedor,correo_proveedor,estado_proveedor)
		VALUES (n_ni,n_de,n_te,n_te2,n_di,n_co,1);
		SET rsp=1;
		
	else
	set rsp=0;
	
	END IF;
	
	
	
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoSerieDocumento` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoSerieDocumento` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoSerieDocumento`(
n_de varchar(50),
n_ti int(11),
out rsp int
)
BEGIN
	DECLARE cont INT DEFAULT 0;
	
			SELECT COUNT(*) INTO cont
			FROM serie_documento WHERE descripcion_serie_documento=n_de and id_tipo_documento=n_ti;
	IF(cont=0) THEN
		insert into serie_documento(descripcion_serie_documento,id_tipo_documento,id_estado_documento)
		values (n_de,n_ti,1);
		set rsp=1;
	else
		set rsp=0;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoTipoDocumento` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoTipoDocumento` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoTipoDocumento`(
n_de varchar(250),
n_si varchar(10),
out rsp int
)
BEGIN
	DECLARE cont INT DEFAULT 0;
	
	select count(*) into cont from tipo_documento where descripcion_tipo_documento=n_de;
	
	
	IF(cont=0) THEN
		insert into tipo_documento(descripcion_tipo_documento,signo_tipo_docuemtno,estado_tipo_documento)
		values (n_de,n_si,1);
		set rsp=1;
	else
		set rsp=0;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `IngresoUsuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `IngresoUsuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoUsuario`(
n_no varchar(255),
n_te varchar(15),
n_u varchar(25),
n_p varchar(25),
out rsp int
)
BEGIN
	DECLARE cont INT DEFAULT 0;
	
	SELECT COUNT(*) INTO cont
	FROM usuario WHERE nombre_usuario=n_u;
	
	IF(cont=0) THEN
		INSERT INTO usuario(nombre_empleado,telefono_empleado,nombre_usuario,pass_usuario,fecha_creacion_usuario,estado_usuario)
		values (n_no,n_te,n_u,n_p,(SELECT CURRENT_TIMESTAMP()),1);
		set rsp=1;
	else
		set rsp=0;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `NuevoRol` */

/*!50003 DROP PROCEDURE IF EXISTS  `NuevoRol` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoRol`(
n_rol varchar(25),
out rsp int
)
BEGIN
declare con int default 0;
declare rp int default 0;
declare idrol int default 0;
select count(*) into con from rol where nombre_rol=n_rol;
if(con=0) then
	insert into rol(nombre_rol,estado_rol)
	values (n_rol,1);
	
	SELECT id_rol into idrol FROM rol ORDER BY id_rol DESC LIMIT 1;
	
	select count(*) into rp from permiso;
	
	set rsp=1;
	while rp>0 do
		insert into rol_permiso(estado_rol_permiso,id_rol,id_permiso)
		values(0,idrol,rp);
		set rp=rp-1;
	end while;
else
	set rsp=0;
end if;
END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
