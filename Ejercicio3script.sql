-- MySQL Script generated by MySQL Workbench
-- Fri Mar 18 19:09:58 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Ejercicio3.1
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Ejercicio3.1
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Ejercicio3.1` DEFAULT CHARACTER SET utf8 ;
USE `Ejercicio3.1` ;

-- -----------------------------------------------------
-- Table `Ejercicio3.1`.`Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ejercicio3.1`.`Usuarios` (
  `User` VARCHAR(20) NOT NULL,
  `Pass` VARCHAR(25) NOT NULL,
  `Nombre` VARCHAR(50) NULL,
  PRIMARY KEY (`User`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
