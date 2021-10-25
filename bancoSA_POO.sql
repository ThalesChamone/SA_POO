-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema sa_02_oop
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema sa_02_oop
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sa_02_oop` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `sa_02_oop` ;

-- -----------------------------------------------------
-- Table `sa_02_oop`.`convenio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sa_02_oop`.`convenio` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `NomeFantasia` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `CNPJ` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `NomeEmpresa` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Email` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `NomeContato` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `HomePage` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Telefone` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sa_02_oop`.`especialidade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sa_02_oop`.`especialidade` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `NomeEspecialidade` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sa_02_oop`.`medico`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sa_02_oop`.`medico` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Nome` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Rua` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Numero` INT NOT NULL,
  `Bairro` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Complemento` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `CEP` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Email` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Telefone` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `EspecialidadeId` INT NULL DEFAULT NULL,
  `CPF` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_Medico_EspecialidadeId` (`EspecialidadeId` ASC) VISIBLE,
  CONSTRAINT `FK_Medico_Especialidade_EspecialidadeId`
    FOREIGN KEY (`EspecialidadeId`)
    REFERENCES `sa_02_oop`.`especialidade` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sa_02_oop`.`procedimentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sa_02_oop`.`procedimentos` (
  `Codigo` INT NOT NULL AUTO_INCREMENT,
  `Data` DATETIME(6) NOT NULL,
  `NomeProcedimento` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Valor` DOUBLE NOT NULL,
  `Genero` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Excecao` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sa_02_oop`.`paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sa_02_oop`.`paciente` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Nome` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Rua` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Numero` INT NOT NULL,
  `Bairro` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Complemento` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `CEP` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Email` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `Telefone` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `ConvenioId` INT NULL DEFAULT NULL,
  `ProcedimentoCodigo` INT NULL DEFAULT NULL,
  `CPF` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_Paciente_ConvenioId` (`ConvenioId` ASC) VISIBLE,
  INDEX `IX_Paciente_ProcedimentoCodigo` (`ProcedimentoCodigo` ASC) VISIBLE,
  CONSTRAINT `FK_Paciente_Convenio_ConvenioId`
    FOREIGN KEY (`ConvenioId`)
    REFERENCES `sa_02_oop`.`convenio` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_Paciente_Procedimentos_ProcedimentoCodigo`
    FOREIGN KEY (`ProcedimentoCodigo`)
    REFERENCES `sa_02_oop`.`procedimentos` (`Codigo`)
    ON DELETE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
