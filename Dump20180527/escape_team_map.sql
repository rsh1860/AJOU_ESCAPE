-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: escape_team
-- ------------------------------------------------------
-- Server version	8.0.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `map`
--

DROP TABLE IF EXISTS `map`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `map` (
  `﻿BUILD_ID` text,
  `LOCATION` text,
  `FLOOR` int(11) DEFAULT NULL,
  `TYPE_ID` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `map`
--

LOCK TABLES `map` WRITE;
/*!40000 ALTER TABLE `map` DISABLE KEYS */;
INSERT INTO `map` VALUES ('PA10','PALDAL',10,'C1'),('PA9','PALDAL',9,'C1'),('PA8','PALDAL',8,'C1'),('PA7','PALDAL',7,'C1'),('PA6','PALDAL',6,'C1'),('PA5','PALDAL',5,'C1'),('PA4','PALDAL',4,'C1'),('PA3','PALDAL',3,'C1'),('PA2','PALDAL',2,'C1'),('PA1','PALDAL',1,'C1'),('SE3','SEONGHO',3,'M1'),('SE2','SEONGHO',2,'E1'),('SE1','SEONGHO',1,'E1'),('SA8','SANHAK',8,'G1'),('SA7','SANHAK',7,'G1'),('SA6','SANHAK',6,'G1'),('SA5','SANHAK',5,'G1'),('SA4','SANHAK',4,'G1'),('SA3','SANHAK',3,'G1'),('SA2','SANHAK',2,'G1'),('SA1','SANHAK',1,'G1'),('DA4','DASAN',4,'K1'),('DA3','DASAN',3,'K1'),('DA2','DASAN',2,'K1'),('DA1','DASAN',1,'K1'),('WO5','WONCHEON',5,'S1'),('WO4','WONCHEON',4,'S1'),('WO3','WONCHEON',3,'S1'),('WO2','WONCHEON',2,'S2'),('WO1','WONCHEON',1,'S2'),('YU4','YULGOK',4,'P1'),('YU3','YULGOK',3,'P1'),('YU2','YULGOK',2,'P1'),('YU1','YULGOK',1,'P1'),('SO8','SONGJAE',8,'D1'),('SO7','SONGJAE',7,'D1'),('SO6','SONGJAE',6,'D1'),('SO5','SONGJAE',5,'D1'),('SO4','SONGJAE',4,'D1'),('SO3','SONGJAE',3,'D1'),('SO2','SONGJAE',2,'D1'),('SO1','SONGJAE',1,'D1'),('JO0','JONGHAP',10,'E1'),('JO9','JONGHAP',9,'M1'),('JO8','JONGHAP',8,'M1'),('JO7','JONGHAP',7,'K1'),('JO6','JONGHAP',6,'P1'),('JO5','JONGHAP',5,'S1'),('JO4','JONGHAP',4,'S2'),('JO3','JONGHAP',3,'S3'),('JO2','JONGHAP',2,'S4'),('JO1','JONGHAP',1,'P1'),('EA5','EASTKWAN',5,'S3'),('EA4','EASTKWAN',4,'S3'),('EA3','EASTKWAN',3,'S3'),('EA2','EASTKWAN',2,'S3'),('EA1','EASTKWAN',1,'S3'),('WE5','WESTKWAN',5,'S4'),('WE4','WESTKWAN',4,'S4'),('WE3','WESTKWAN',3,'S4'),('WE2','WESTKWAN',2,'S4'),('WE1','WESTKWAN',1,'S4');
/*!40000 ALTER TABLE `map` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-05-27 16:05:07
